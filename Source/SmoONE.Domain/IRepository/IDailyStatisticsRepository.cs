using SmoONE.DTOs;
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
    // 主要内容： 用户的历史的工作日的日统计数据的仓储接口,仅用于查询
    // ******************************************************************
    /// <summary>
    /// 用户的历史的工作日的日统计数据的仓储接口,仅用于查询
    /// </summary>
    public interface IDailyStatisticsRepository : IRepository<DailyStatistics>
    {
        /// <summary>
        /// 根据用户ID和日期返回该用户历史工作日中的某日的日统计数据
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="Date">日期</param>
        IQueryable<DailyStatistics> GetDSByUser(string UserID,DateTime Date);

        /// <summary>
        /// 根据用户ID和日期返回该用户历史工作日中的某段时间的日统计数据
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="StartDate">开始日期</param>
        /// <param name="EndDate">结束日期</param>
        IQueryable<DailyStatistics> GetDSByUserAndPeriod(string UserID, DateTime StartDate,DateTime EndDate);

        /// <summary>
        /// 得到某段时间内某类的用户名
        /// </summary>
        /// <param name="UserID">用户ID</param>
        List<string> GetNamesByTypeAndPeriod(DateTime StartDate, DateTime EndDate, StatisticsType Type);
    }
}
