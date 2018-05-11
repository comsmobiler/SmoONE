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
    /// 加班日志的仓储接口实现,仅用于查询
    /// </summary>
    public class OvertimeLogRepository : BaseRepository<OvertimeLog>, IOvertimeLogRepository
    {
        /// <summary>
        /// 仓储类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public OvertimeLogRepository(IDbContext dbContext)
            : base(dbContext)
        { }

        ///// <summary>
        ///// 根据用户ID返回该用户所有有加班日志的日期
        ///// </summary>
        ///// <param name="UserID">用户ID</param>
        //public IQueryable<DateTime> GetAllDayByUser(string UserID)
        //{
        //    return _entities.Where(x => x.OL_UserID == UserID).Select(x => x.OL_DateTime).Distinct();
        //}

        /// <summary>
        /// 根据用户ID和日期返回某天的加班日志对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="Date">日期</param>
        public IQueryable<OvertimeLog> GetByUserAndDate(string UserID, DateTime Date)
        {
            return _entities.Where(x => x.OL_UserID == UserID && x.OL_DateTime == Date);
        }


        ///// <summary>
        ///// 根据考勤模板ID和日期返回某天的加班人数
        ///// </summary>
        ///// <param name="ATID">考勤模板ID</param>
        ///// <param name="Date">日期</param>
        //int GetOLDayCount(string ATID, DateTime Date);

        /// <summary>
        /// 根据考勤模板ID和日期返回某天的加班人员详情
        /// </summary>
        /// <param name="ATID">考勤模板ID</param>
        /// <param name="Date">日期</param>
        public IQueryable<OvertimeLog> GetDayStatisticsDetail(string ATID, DateTime Date)
        {
            return _entities;
        }
    }
}
