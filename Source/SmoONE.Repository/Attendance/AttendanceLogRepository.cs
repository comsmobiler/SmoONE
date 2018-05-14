using SmoONE.Domain;
using SmoONE.Domain.IRepository;
using SmoONE.DTOs;
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
    // 主要内容： 考勤日志的仓储实现,仅用于查询
    // ******************************************************************
    /// <summary>
    /// 考勤日志的仓储实现,仅用于查询
    /// </summary>
    public class AttendanceLogRepository : BaseRepository<AttendanceLog>, IAttendanceLogRepository
    {
        /// <summary>
        /// 仓储类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public AttendanceLogRepository(IDbContext dbContext)
            : base(dbContext)
        { }

        /// <summary>
        /// 根据用户ID和日期返回某天的日志对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="Date">日期</param>
        public IQueryable<AttendanceLog> GetByUserAndDate(string UserID, DateTime Date)
        {
            DateTime Start = Date.Date;
            DateTime End = Date.AddDays(1).Date;
            return _entities.Where(x => x.AL_UserID == UserID && x.AL_Date >= Start && x.AL_Date < End);
        }

        /// <summary>
        /// 根据用户ID和日期,统计的时间返回某天的日志对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="Date">日期</param>
        /// <param name="Time">统计的时间</param>
        public IQueryable<AttendanceLog> GetByStatisticsTime(string UserID, DateTime Date, StatisticsTime Time)
        {
            string time = Time.ToString();
            DateTime Start = Date.Date;
            DateTime End = Date.AddDays(1).Date;
            return _entities.Where(x => x.AL_UserID == UserID && x.AL_Date>=Start&&x.AL_Date<End && x.AL_LogTimeType == time);
        }

        /// <summary>
        /// 根据用户ID和日期返回用户某天的考勤日志数量
        /// </summary>
        /// <param name="ATID">用户ID</param>
        /// <param name="Date">日期</param>
        public int GetDayCount(string UserID, DateTime Date)
        {
            DateTime Start = Date.Date;
            DateTime End = Date.AddDays(1).Date;
            return _entities.Where(x => x.AL_UserID == UserID && x.AL_Date >= Start && x.AL_Date < End).Count();
        }

        /// <summary>
        /// 根据用户ID和日期,统计的类型返回用户某天的考勤日志数量
        /// </summary>
        /// <param name="ATID">用户ID</param>
        /// <param name="Date">日期</param>
        /// <param name="Type">统计的类型</param>
        public int GetDayCountByType(string UserID, DateTime Date,StatisticsType Type)
        {
            string type=Type.ToString();
            DateTime Start = Date.Date;
            DateTime End = Date.AddDays(1).Date;
            return _entities.Where(x => x.AL_UserID == UserID && x.AL_Date >= Start && x.AL_Date <End && x.AL_Status == type).Count();
        }

        /// <summary>
        /// 根据用户ID和类型及时间段返回用户某段时间的日志对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="StartDate">开始时间</param>
        /// <param name="EndDate">结束时间</param>
        /// <param name="Types"></param>
        public IQueryable<AttendanceLog> GetByTypesAndPeriod(string UserID, DateTime StartDate, DateTime EndDate, string Types)
        {
            return _entities.Where(o => o.AL_Date >= StartDate && o.AL_Date < EndDate && Types.Contains(o.AL_Status) && o.AL_UserID == UserID);        
        }

        /// <summary>
        /// 根据用户ID和类型及时间段返回用户某段时间的日志数量
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="StartDate">开始时间</param>
        /// <param name="EndDate">结束时间</param>
        public int GetCountByPeriod(string UserID, DateTime StartDate, DateTime EndDate)
        {
            return _entities.Where(o => o.AL_Date >= StartDate && o.AL_Date < EndDate && o.AL_UserID == UserID).Count();
        }

        /// <summary>
        /// 根据类型及时间段返回某段时间内的用户
        /// </summary>
        /// <param name="StartDate">开始时间</param>
        /// <param name="EndDate">结束时间</param>
        /// <param name="Types"></param>
        public IQueryable<string> GetUsersByTypesAndPeriod(DateTime StartDate, DateTime EndDate, string Types)
        {
            return _entities.Where(o => o.AL_Date >= StartDate && o.AL_Date < EndDate && Types.Contains(o.AL_Status)).Select(o=>o.AL_UserID).Distinct();        
        }
    }
}
