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
    // 主要内容： 用户月统计信息的仓储实现,仅用于查询
    // ******************************************************************
    /// <summary>
    /// 用户月统计信息的仓储实现,仅用于查询
    /// </summary>
    public class MonthlyStatisticsRepository : BaseRepository<MonthlyStatistics>, IMonthlyStatisticsRepository
    {
        /// <summary>
        /// 仓储类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public MonthlyStatisticsRepository(IDbContext dbContext)
            : base(dbContext)
        { }

        /// <summary>
        /// 得到用户的月统计信息
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="Year">年份</param>
        /// <param name="Month">月份</param>
        public IQueryable<MonthlyStatistics> GetUserMonthlyStatistics(string UserID, int Year, int Month)
        {
            return _entities.Where(x => x.MS_UserID == UserID && x.MS_Year == Year && x.MS_Month == Month);
        }

        /// <summary>
        /// 得到用户的最新月统计信息
        /// </summary>
        /// <param name="UserID">用户ID</param>
        public MonthlyStatistics GetNewestUserMonthlyStatistics(string UserID)
        {
            return _entities.Where(x => x.MS_UserID == UserID).OrderByDescending(o=>o.MS_Year).ThenByDescending(o=>o.MS_Month).FirstOrDefault();;
        }
    }
}
