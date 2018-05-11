using SmoONE.Domain;
using SmoONE.Domain.IRepository;
using SmoONE.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmoONE.DTOs;

namespace SmoONE.Repository
{
    // ******************************************************************
    // 文件版本： SmoONE 1.1
    // Copyright  (c)  2016-2017 Smobiler 
    // 创建时间： 2017/2
    // 主要内容： 用户的历史的工作日的日统计数据的仓储实现,仅用于查询
    // ******************************************************************
    /// <summary>
    /// 用户的历史的工作日的日统计数据的仓储实现,仅用于查询
    /// </summary>
    public class DailyStatisticsRepository : BaseRepository<DailyStatistics>, IDailyStatisticsRepository
    {
        /// <summary>
        /// 仓储类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public DailyStatisticsRepository(IDbContext dbContext)
            : base(dbContext)
        { }


        /// <summary>
        /// 根据用户ID和日期返回该用户历史工作日中的某日的日统计数据
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="Date">日期</param>
        public IQueryable<DailyStatistics> GetDSByUser(string UserID, DateTime Date)
        {
            DateTime date = Date.Date;
            return _entities.Where(x => x.DS_UserID == UserID && x.DS_Date.CompareTo(date) == 0);
        }

        /// <summary>
        /// 根据用户ID和日期返回该用户历史工作日中的某段时间的日统计数据
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="StartDate">开始日期</param>
        /// <param name="EndDate">结束日期</param>
        public IQueryable<DailyStatistics> GetDSByUserAndPeriod(string UserID, DateTime StartDate, DateTime EndDate)
        {
            DateTime Start = StartDate.Date;
            DateTime End = EndDate.Date;
            return _entities.Where(x => x.DS_UserID == UserID && x.DS_Date >= Start && x.DS_Date < EndDate);
        }

        /// <summary>
        /// 得到用户最新的日统计数据
        /// </summary>
        /// <param name="UserID">用户ID</param>
        public DailyStatistics GetNewestByUser(string UserID)
        {
            return _entities.Where(x => x.DS_UserID == UserID).OrderByDescending(o => o.DS_Date).FirstOrDefault();
        }

        /// <summary>
        /// 得到用户最早的日统计数据
        /// </summary>
        /// <param name="UserID">用户ID</param>
        public DailyStatistics GetOldestByUser(string UserID)
        {
            return _entities.Where(x => x.DS_UserID == UserID).OrderBy(o => o.DS_Date).FirstOrDefault();
        }

        /// <summary>
        /// 得到某段时间内某类的用户名
        /// </summary>
        /// <param name="UserID">用户ID</param>
        public List<string> GetNamesByTypeAndPeriod(DateTime StartDate,DateTime EndDate,StatisticsType Type)
        {
            string type=Type.ToString();
            var q=_entities.Where(x=>x.DS_Date>=StartDate&&x.DS_Date<EndDate);
            switch(type)
            {
                case "准点":
                    break;
                case "迟到":
                    q=q.Where(x => x.DS_ComeLateCount > 0);
                    break;
                case "早退":
                     q=q.Where(x => x.DS_LeaveEarlyCount > 0);
                    break;
                case "未签到":
                case "未签退":
                    q=q.Where(x=>(x.DS_NoSignInCount>0||x.DS_NoSignOutCount>0)&&x.DS_IsAbsent==0);
                    break;
                case "旷工":
                    q=q.Where(x => x.DS_IsAbsent == 1);
                    break;
                default:
                    break;
            }
            return q.Select(o => o.DS_UserID).Distinct().ToList();
        }
    }
}
