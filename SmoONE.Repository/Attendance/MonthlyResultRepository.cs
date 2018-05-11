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
    // 主要内容： 月统计信息的仓储实现,仅用于查询
    // ******************************************************************
    /// <summary>
    /// 月统计信息的仓储实现,仅用于查询
    /// </summary>
    public class MonthlyResultRepository : BaseRepository<MonthlyResult>, IMonthlyResultRepository
    {
        /// <summary>
        /// 仓储类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public MonthlyResultRepository(IDbContext dbContext)
            : base(dbContext)
        { }

        /// <summary>
        /// 得到月统计信息
        /// </summary>
        /// <param name="Year">年份</param>
        /// <param name="Month">月份</param>
        public IQueryable<MonthlyResult> GetMonthlyResult(int Year, int Month)
        {
            return _entities.Where(x => x.MR_Year == Year && x.MR_Month == Month);
        }
    }
}
