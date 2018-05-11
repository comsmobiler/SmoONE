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
    // 主要内容： 考勤日志的仓储接口,仅用于查询
    // ******************************************************************
    /// <summary>
    /// 考勤日志的仓储接口,仅用于查询
    /// </summary>
    public interface IAttendanceLogRepository : IRepository<AttendanceLog>
    {

        /// <summary>
        /// 根据用户ID和日期返回某天的日志对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="Date">日期</param>
        IQueryable<AttendanceLog> GetByUserAndDate(string UserID, DateTime Date);

        /// <summary>
        /// 根据用户ID和日期,统计的时间返回某天的日志对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="Date">日期</param>
        /// <param name="Time">统计的时间</param>
        IQueryable<AttendanceLog> GetByStatisticsTime(string UserID, DateTime Date, StatisticsTime Time);

        /// <summary>
        /// 根据用户ID和日期返回用户某天的考勤日志数量
        /// </summary>
        /// <param name="ATID">用户ID</param>
        /// <param name="Date">日期</param>
        int GetDayCount(string UserID, DateTime Date);

        /// <summary>
        /// 根据用户ID和日期,统计的类型返回用户某天的考勤日志数量
        /// </summary>
        /// <param name="ATID">用户ID</param>
        /// <param name="Date">日期</param>
        /// <param name="Type">统计的类型</param>
        int GetDayCountByType(string UserID, DateTime Date, StatisticsType Type);

        /// <summary>
        /// 根据用户ID和类型及时间段返回用户某段时间的日志对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="StartDate">开始时间</param>
        /// <param name="EndDate">结束时间</param>
        /// <param name="Types"></param>
        IQueryable<AttendanceLog> GetByTypesAndPeriod(string UserID, DateTime StartDate,DateTime EndDate, string Types);

        /// <summary>
        /// 根据用户ID和类型及时间段返回用户某段时间的日志数量
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="StartDate">开始时间</param>
        /// <param name="EndDate">结束时间</param>
        int GetCountByPeriod(string UserID, DateTime StartDate, DateTime EndDate);

        /// <summary>
        /// 根据类型及时间段返回某段时间内的用户
        /// </summary>
        /// <param name="StartDate">开始时间</param>
        /// <param name="EndDate">结束时间</param>
        /// <param name="Types"></param>
        IQueryable<string> GetUsersByTypesAndPeriod(DateTime StartDate, DateTime EndDate, string Types);
    }
}
