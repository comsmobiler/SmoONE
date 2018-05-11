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
    // 主要内容： 考勤排班的仓储接口,仅用于查询
    // ******************************************************************
    /// <summary>
    /// 考勤排班的仓储接口,仅用于查询
    /// </summary>
    public interface IAttendanceSchedulingRepository : IRepository<AttendanceScheduling>
    {
        /// <summary>
        /// 根据用户ID和日期返回考勤排班对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="Date">日期</param>
        IQueryable<AttendanceScheduling> GetByUserIDAndDate(string UserID,DateTime Date);

        /// <summary>
        /// 根据考勤模板ID和日期返回考勤排班对象
        /// </summary>
        /// <param name="ATID">考勤模板ID</param>
        /// <param name="Date">日期</param>
        IQueryable<AttendanceScheduling> GetByATIDandDate(string ATID, DateTime Date);

        /// <summary>
        /// 根据用户ID和时间段返回考勤排班对象(上班的)
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="SatartDate">开始日期</param>
        /// <param name="EndDate">结束日期</param>
        IQueryable<AttendanceScheduling> GetByUserIDAndPeriod(string UserID, DateTime SatartDate,DateTime EndDate);

        /// <summary>
        /// 根据用户ID和时间段返回考勤日期(上班的)
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="SatartDate">开始日期</param>
        /// <param name="EndDate">结束日期</param>
        IQueryable<DateTime> GetDateByUserIDAndPeriod(string UserID, DateTime SatartDate, DateTime EndDate);

        /// <summary>
        /// 根据用户ID和时间段返回应考勤次数(上班的)
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="SatartDate">开始日期</param>
        /// <param name="EndDate">结束日期</param>
        int GetCountByUserIDAndPeriod(string UserID, DateTime SatartDate, DateTime EndDate);

        /// <summary>
        /// 根据考勤模板ID得到该考勤模板的最大日期
        /// </summary>
        /// <param name="ATID">考勤模板ID</param>
        DateTime? GetMaxDateByATID(string ATID);
    }
}
