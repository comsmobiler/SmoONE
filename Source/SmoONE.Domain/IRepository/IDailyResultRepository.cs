using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmoONE.Domain.IRepository
{
    /// <summary>
    /// 日统计数据的仓储接口,仅用于查询
    /// </summary>
    public interface IDailyResultRepository : IRepository<DailyResult>
    {
        /// <summary>
        /// 根据日期返回某日的日统计数据
        /// </summary>
        /// <param name="Date">日期</param>
        IQueryable<DailyResult> GetByDate(DateTime Date);
    }
}

