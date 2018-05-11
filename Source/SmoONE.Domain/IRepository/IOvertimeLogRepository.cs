using SmoONE.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmoONE.Domain.IRepository
{
    /// <summary>
    /// 加班日志的仓储接口,仅用于查询
    /// </summary>
    public interface IOvertimeLogRepository : IRepository<OvertimeLog>
    {
        ///// <summary>
        ///// 根据用户ID返回该用户所有有加班日志的日期
        ///// </summary>
        ///// <param name="UserID">用户ID</param>
        //IQueryable<DateTime> GetAllDayByUser(string UserID);

        /// <summary>
        /// 根据用户ID和日期返回某天的加班日志对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="Date">日期</param>
        IQueryable<OvertimeLog> GetByUserAndDate(string UserID, DateTime Date);


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
        IQueryable<OvertimeLog> GetDayStatisticsDetail(string ATID, DateTime Date);
    }
}
