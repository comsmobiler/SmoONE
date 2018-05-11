using SmoONE.Domain;
using SmoONE.Domain.IRepository;
using SmoONE.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SmoONE.Repository
{
    /// <summary>
    /// 日统计的仓储接口实现,仅用于查询
    /// </summary>
    public class DailyResultRepository: BaseRepository<DailyResult>, IDailyResultRepository
    {
        /// <summary>
        /// 仓储类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public DailyResultRepository(IDbContext dbContext)
            : base(dbContext)
        { }

        /// <summary>
        /// 根据日期返回某日的日统计数据
        /// </summary>
        /// <param name="Date">日期</param>
        public IQueryable<DailyResult> GetByDate(DateTime Date)
        { 
            DateTime date=Date.Date;
            return _entities.Where(x => x.DR_Date.CompareTo(date) == 0);
        }
    }
}
