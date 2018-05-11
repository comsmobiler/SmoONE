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
    // 主要内容： 月统计信息的仓储接口,仅用于查询
    // ******************************************************************
    /// <summary>
    /// 月统计信息的仓储接口,仅用于查询
    /// </summary>
    public interface IMonthlyResultRepository : IRepository<MonthlyResult>
    {
        /// <summary>
        /// 得到月统计信息
        /// </summary>
        /// <param name="Year">年份</param>
        /// <param name="Month">月份</param>
        IQueryable<MonthlyResult> GetMonthlyResult(int Year, int Month);
    }
}
