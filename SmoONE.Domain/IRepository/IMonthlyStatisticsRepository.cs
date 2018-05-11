using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmoONE.Domain.IRepository
{
    // ******************************************************************
    // 文件版本： SmoONE 1.1
    // Copyright  (c)  2016-2017 Smobiler 
    // 创建时间： 2017/2
    // 主要内容： 用户月统计信息的仓储接口,仅用于查询
    // ******************************************************************
    /// <summary>
    /// 用户月统计信息的仓储接口,仅用于查询
    /// </summary>
    public interface IMonthlyStatisticsRepository : IRepository<MonthlyStatistics>
    {
        /// <summary>
        /// 得到用户的月统计信息
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="Year">年份</param>
        /// <param name="Month">月份</param>
        IQueryable<MonthlyStatistics> GetUserMonthlyStatistics(string UserID,int Year,int Month);
    }
}
