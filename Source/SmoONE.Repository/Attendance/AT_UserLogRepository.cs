using SmoONE.Domain;
using SmoONE.Domain.IRepository;
using SmoONE.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmoONE.Repository
{
    // ******************************************************************
    // 文件版本： SmoONE 1.1
    // Copyright  (c)  2016-2017 Smobiler 
    // 创建时间： 2017/2
    // 主要内容： 用户模板变更日志的仓储实现,仅用于查询
    // ******************************************************************
    /// <summary>
    /// 用户模板变更日志的仓储实现,仅用于查询
    /// </summary>
    public class AT_UserLogRepository: BaseRepository<AT_UserLog>, IAT_UserLogRepository
    {
        /// <summary>
        /// 仓储类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public AT_UserLogRepository(IDbContext dbContext)
            : base(dbContext)
        { }

        /// <summary>
        /// 根据日期返回模板ID
        /// </summary>
        /// <param name="Date">日期</param>
        public IQueryable<string> GetATIDByDate(DateTime Date)
        {
            return _entities.Where(x => x.AT_UL_StartTime <= Date && x.AT_UL_EndTime >= Date && x.AT_UL_StartTime <= x.AT_UL_EndTime).Select(o => o.AT_UL_ATID).Distinct();
        }
          
        /// <summary>
        /// 得到用户某段时间内的模板变更日志
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="StartDate">开始时间</param>
        /// <param name="EndDate">结束时间</param>
        public IQueryable<AT_UserLog> GetByPeriod(string UserID, DateTime StartDate, DateTime EndDate)
        {
            return _entities.Where(x => x.AT_UL_UserID == UserID && x.AT_UL_StartTime < EndDate && x.AT_UL_EndTime > StartDate && x.AT_UL_StartTime < x.AT_UL_EndTime);
        }

        /// <summary>
        /// 得到某段时间内的所有用户
        /// </summary>
        /// <param name="StartDate">开始时间</param>
        /// <param name="EndDate">结束时间</param>
        public IQueryable<string> GetUserNameByPeriod(DateTime StartDate, DateTime EndDate)
        { 
            return _entities.Where(x => x.AT_UL_StartTime < EndDate && x.AT_UL_EndTime > StartDate && x.AT_UL_StartTime <= x.AT_UL_EndTime).Select(x => x.AT_UL_UserID).Distinct();
        }

        /// <summary>
        /// 得到某天的所有用户
        /// </summary>
        /// <param name="Date">开始时间</param>
        public IQueryable<string> GetUserNameByDate(DateTime Date)
        {
            return _entities.Where(x => x.AT_UL_StartTime <= Date && x.AT_UL_EndTime >=Date && x.AT_UL_StartTime <= x.AT_UL_EndTime).Select(x => x.AT_UL_UserID).Distinct();
        }

        /// <summary>
        /// 得到某段时间内的所有模板ID
        /// </summary>
        /// <param name="StartDate">开始时间</param>
        /// <param name="EndDate">结束时间</param>
        public IQueryable<string> GetATIDsByPeriod(DateTime StartDate, DateTime EndDate)
        {
            return _entities.Where(x => x.AT_UL_StartTime < EndDate && x.AT_UL_EndTime > StartDate && x.AT_UL_StartTime <= x.AT_UL_EndTime).Select(x => x.AT_UL_ATID).Distinct();
        }

        /// <summary>
        /// 得到用户最新的变更日志
        /// </summary>
        /// <param name="UserID">用户ID</param>
        public AT_UserLog GetNewestByUser(string UserID)
        {
            return _entities.Where(x => x.AT_UL_UserID == UserID).OrderByDescending(o=>o.AT_UL_ID).FirstOrDefault();
        }
    }
}
