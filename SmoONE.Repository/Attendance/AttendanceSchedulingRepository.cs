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
    // 主要内容： 考勤排班的仓储实现,仅用于查询
    // ******************************************************************
    /// <summary>
    /// 考勤排班的仓储实现,仅用于查询
    /// </summary>
    public class AttendanceSchedulingRepository: BaseRepository<AttendanceScheduling>, IAttendanceSchedulingRepository
    {
        /// <summary>
        /// 仓储类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public AttendanceSchedulingRepository(IDbContext dbContext)
            : base(dbContext)
        { }

        /// <summary>
        /// 根据用户ID和日期返回考勤排班对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="Date">日期</param>
        public IQueryable<AttendanceScheduling> GetByUserIDAndDate(string UserID, DateTime Date)
        {
            DateTime  date = Date.Date;
            return _entities.Where(x => x.AS_DateTime.CompareTo(date) == 0 && x.AS_Users.Contains(UserID));
        }

        /// <summary>
        /// 根据考勤模板ID和日期返回考勤排班对象
        /// </summary>
        /// <param name="ATID">考勤模板ID</param>
        /// <param name="Date">日期</param>
        public IQueryable<AttendanceScheduling> GetByATIDandDate(string ATID, DateTime Date)
        {
            DateTime date = Date.Date;
            return _entities.Where(x => x.AS_DateTime.CompareTo(Date) == 0 && x.AS_ATID == ATID);
        }

        /// <summary>
        /// 根据用户ID和时间段返回考勤排班对象(上班的)
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="SatartDate">开始日期</param>
        /// <param name="EndDate">结束日期</param>
        public IQueryable<AttendanceScheduling> GetByUserIDAndPeriod(string UserID, DateTime SatartDate, DateTime EndDate)
        {
            string Type=WorkOrRest.上班.ToString();
            return _entities.Where(x => x.AS_Users.Contains(UserID) && x.AS_DateTime >= SatartDate && x.AS_DateTime < EndDate&&x.AS_ASType==Type);
        }

        /// <summary>
        /// 根据用户ID和时间段返回考勤日期(上班的)
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="SatartDate">开始日期</param>
        /// <param name="EndDate">结束日期</param>
        public IQueryable<DateTime> GetDateByUserIDAndPeriod(string UserID, DateTime SatartDate, DateTime EndDate)
        {
            string Type = WorkOrRest.上班.ToString();
            return _entities.Where(x => x.AS_Users.Contains(UserID) && x.AS_DateTime >= SatartDate && x.AS_DateTime < EndDate && x.AS_ASType == Type).Select(o=>o.AS_DateTime);
        }

        /// <summary>
        /// 根据用户ID和时间段返回应考勤次数(上班的)
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="SatartDate">开始日期</param>
        /// <param name="EndDate">结束日期</param>
        public int GetCountByUserIDAndPeriod(string UserID, DateTime SatartDate, DateTime EndDate)
        {
            string Type = WorkOrRest.上班.ToString();
            return _entities.Where(x => x.AS_Users.Contains(UserID) && x.AS_DateTime >= SatartDate && x.AS_DateTime < EndDate && x.AS_ASType == Type).Sum(o=>o.AS_LogCount);
        }

        /// <summary>
        /// 根据考勤模板ID得到该考勤模板的最大日期
        /// </summary>
        /// <param name="ATID">考勤模板ID</param>
        public DateTime? GetMaxDateByATID(string ATID)
        {
            IQueryable<DateTime> Dates = _entities.Where(x => x.AS_ATID == ATID).Select(e => e.AS_DateTime);
            if (Dates.Count() > 0)
            {
                return Dates.Max();
            }
            else
            {
                return null;
            }
        }
    }
}
