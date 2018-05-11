using AutoMapper;
using SmoONE.CommLib;
using SmoONE.Domain;
using SmoONE.Domain.IRepository;
using SmoONE.DTOs;
using SmoONE.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Globalization;

namespace SmoONE.Application
{
    // ******************************************************************
    // 文件版本： SmoONE 1.1
    // Copyright  (c)  2016-2017 Smobiler 
    // 创建时间： 2017/2
    // 主要内容： 考勤的服务实现
    // ******************************************************************
    /// <summary>
    /// 考勤的服务实现
    /// </summary>
    public class AttendanceService:IAttendanceService
    {
        /// <summary>
        /// 工作单元的接口
        /// </summary>
        private IUnitOfWork _unitOfWork;

        /// <summary>
        /// 自定义日期的仓储类的接口
        /// </summary>
        private IAT_CustomDateRepository _AT_CustomDateRepository;

        /// <summary>
        /// 考勤日志的仓储类的接口
        /// </summary>
        private IAttendanceLogRepository _AttendanceLogRepository;

        /// <summary>
        /// 考勤模板的仓储类的接口
        /// </summary>
        private IAttendanceTemplateRepository _AttendanceTemplateRepository;

        /// <summary>
        /// 用户的仓储类的接口
        /// </summary>
        private IUserRepository _userRepository;

        /// <summary>
        /// 考勤排班的仓储接口
        /// </summary>
        private IAttendanceSchedulingRepository _attendanceSchedulingRepository;

        /// <summary>
        /// 用户月统计的仓储接口
        /// </summary>
        private IMonthlyStatisticsRepository _monthlyStatisticsRepository;

        /// <summary>
        /// 用户日统计的仓储接口
        /// </summary>
        private IDailyStatisticsRepository _dailyStatisticsRepository;

        /// <summary>
        /// 用户模板变更日志的仓储接口
        /// </summary>
        private IAT_UserLogRepository _AT_UserLogRepository;

        /// <summary>
        /// 月统计的仓储接口
        /// </summary>
        private IMonthlyResultRepository _monthlyResultRepository;

        /// <summary>
        /// 数据库上下文
        /// </summary>
        private SmoONEDbContext smoONEContext;

        /// <summary>
        /// 成本中心服务实现的构造函数
        /// </summary>
        public AttendanceService(IUnitOfWork unitOfWork,
            IAT_CustomDateRepository AT_CustomDateRepository,
            IAttendanceLogRepository AttendanceLogRepository,
            IAttendanceTemplateRepository AttendanceTemplateRepository,
            IUserRepository userRepository,
            IAttendanceSchedulingRepository attendanceSchedulingRepository,
            IMonthlyStatisticsRepository monthlyStatisticsRepository,
            IDailyStatisticsRepository dailyStatisticsRepository,
            IAT_UserLogRepository AT_UserLogRepository,
            IMonthlyResultRepository monthlyResultRepository,
            IDbContext dbContext)
        {
            _unitOfWork = unitOfWork;
            _AT_CustomDateRepository = AT_CustomDateRepository;
            _AttendanceLogRepository = AttendanceLogRepository;
            _AttendanceTemplateRepository = AttendanceTemplateRepository;
            _userRepository = userRepository;
            _attendanceSchedulingRepository = attendanceSchedulingRepository;
            _monthlyStatisticsRepository = monthlyStatisticsRepository;
            _dailyStatisticsRepository = dailyStatisticsRepository;
            _AT_UserLogRepository=AT_UserLogRepository;
            _monthlyResultRepository = monthlyResultRepository;
            smoONEContext = (SmoONEDbContext)dbContext;
        }

        #region 查询
        /// <summary>
        /// 根据考勤模板ID返回考勤模板对象
        /// </summary>
        /// <param name="ID">考勤模板ID</param>
        public ATDetailDto GetATByID(string ID)
        {
            AttendanceTemplate at = _AttendanceTemplateRepository.GetByID(ID).AsNoTracking().FirstOrDefault();
            if (at != null)
            {
                if (!string.IsNullOrEmpty(at.AT_Users))
                {
                    AttendanceScheduling a = _attendanceSchedulingRepository.GetByATIDandDate(at.AT_ID, DateTime.Now.Date).AsNoTracking().FirstOrDefault();
                    if (a != null)
                    {
                        //当天有排班记录
                    }
                    else
                    {
                        //当天没排班记录
                        //批量添加历史排班记录
                        AddHisAttendanceScheduling(at);
                    }
                }                
            }

            ATDetailDto ad = Mapper.Map<AttendanceTemplate, ATDetailDto>(at);
            return ad;
        }

        /// <summary>
        /// 返回所有考勤模板对象
        /// </summary>
        public List<ATDto> GetAll()
        {
            //List<AttendanceTemplate> at = _AttendanceTemplateRepository.GetAll().AsNoTracking().ToList();
            //List<ATDto> ad = Mapper.Map<List<AttendanceTemplate>, List<ATDto>>(at);
            //return ad;
            List<ATDto> ad = Mapper.Map<List<AttendanceTemplate>, List<ATDto>>(_AttendanceTemplateRepository.GetAll().AsNoTracking().ToList());
            return ad;
        }

        /// <summary>
        /// 得到用户当天的排班
        /// </summary>
        /// <param name="UserID">用户ID</param>
        public WorkTimeDto GetCurrantASByUser(string UserID)
        {
            WorkTimeDto wd = null;
            AttendanceScheduling a = _attendanceSchedulingRepository.GetByUserIDAndDate(UserID, DateTime.Now.Date).AsNoTracking().FirstOrDefault();
            if (a != null)
            {
                //当天有排班记录（可解决问题：得到当天被排除模板的人的排班）
                if (a.AS_Users.Contains(UserID))
                {
                    //当前用户非今天新加入模板的用户
                    wd = new WorkTimeDto();
                    wd.AT_AMEndTime = a.AS_AMEndTime;
                    wd.AT_AMStartTime = a.AS_AMStartTime;
                    wd.AT_ASType = a.AS_ASType;
                    wd.AT_EndTime = a.AS_EndTime;
                    wd.AT_PMEndTime = a.AS_PMEndTime;
                    wd.AT_PMStartTime = a.AS_PMStartTime;
                    wd.AT_StartTime = a.AS_StartTime;
                    wd.AT_CommutingType = a.AS_CommutingType;
                    wd.AT_Longitude = a.AS_Longitude;
                    wd.AT_Latitude = a.AS_Latitude;
                    wd.AT_Positions = a.AS_Positions;
                    wd.AT_AllowableDeviation = a.AS_AllowableDeviation;
                }
            }           
            return wd;
        }

        /// <summary>
        /// 得到模板某天的排班
        /// </summary>
        /// <param name="ATID">考勤模板ID</param>
        /// <param name="Date">天数</param>
        public WorkTimeDto GetASByATIDAndDate(string ATID,DateTime Date)
        {
            WorkTimeDto wd = null;           
            AttendanceTemplate at = _AttendanceTemplateRepository.GetByID(ATID).AsNoTracking().FirstOrDefault();
            if (at != null)
            {
                if (Date.Date > at.AT_CreateDate)
                {
                    if (Date.Date <= DateTime.Now.Date)
                    {
                        //历史的排班,直接从排班记录中查询
                        AttendanceScheduling a = _attendanceSchedulingRepository.GetByATIDandDate(at.AT_ID, Date.Date).AsNoTracking().FirstOrDefault();
                        if (a != null)
                        {
                            wd = new WorkTimeDto();
                            wd.AT_AMEndTime = a.AS_AMEndTime;
                            wd.AT_AMStartTime = a.AS_AMStartTime;
                            wd.AT_ASType = a.AS_ASType;
                            wd.AT_EndTime = a.AS_EndTime;
                            wd.AT_PMEndTime = a.AS_PMEndTime;
                            wd.AT_PMStartTime = a.AS_PMStartTime;
                            wd.AT_StartTime = a.AS_StartTime;
                            wd.AT_CommutingType = a.AS_CommutingType;
                        }
                    }
                    else
                    { 
                        //计算出未来的排班
                        AT_CustomDate ac = _AT_CustomDateRepository.GetByATIDandDate(ATID, Date.Date).AsNoTracking().FirstOrDefault();
                        if (ac != null)
                        {
                            //该模板当天存在自定义日期
                            wd = new WorkTimeDto();
                            wd.AT_AMEndTime = ac.AT_CD_AMEndTime;
                            wd.AT_AMStartTime = ac.AT_CD_AMStartTime;
                            wd.AT_ASType = ac.AT_CD_CDType;
                            wd.AT_EndTime = ac.AT_CD_EndTime;
                            wd.AT_PMEndTime = ac.AT_CD_PMEndTime;
                            wd.AT_PMStartTime = ac.AT_CD_PMStartTime;
                            wd.AT_StartTime = ac.AT_CD_StartTime;
                            wd.AT_CommutingType = ac.AT_CD_CommutingType;
                        }
                        else
                        { 
                            //该模板当天不存在自定义日期
                            Week temp = (Week)Date.DayOfWeek;
                            int temps = (int)temp;
                            //判断是否在上班时间中
                            if (at.AT_WeeklyWorkingDay.Contains(temps.ToString()))
                            {
                                wd = new WorkTimeDto();
                                if (at.AT_AMEndTime != null)
                                {
                                    wd.AT_AMEndTime = Date.Date.AddHours( at.AT_AMEndTime.Value.Hour).AddMinutes(at.AT_AMEndTime.Value.Minute);
                                }
                                if (at.AT_AMStartTime != null)
                                {
                                    wd.AT_AMStartTime =Date.Date.AddHours( at.AT_AMStartTime.Value.Hour).AddMinutes(at.AT_AMStartTime.Value.Minute);
                                }
                                wd.AT_ASType = WorkOrRest.上班.ToString();
                                if (at.AT_EndTime != null)
                                {
                                    wd.AT_EndTime =Date.Date.AddHours( at.AT_EndTime.Value.Hour).AddMinutes(at.AT_EndTime.Value.Minute);
                                }
                                if (at.AT_PMEndTime != null)
                                {
                                    wd.AT_PMEndTime = Date.Date.AddHours(at.AT_PMEndTime.Value.Hour).AddMinutes(at.AT_PMEndTime.Value.Minute);
                                }
                                if (at.AT_PMStartTime != null)
                                {
                                    wd.AT_PMStartTime =Date.Date.AddHours( at.AT_PMStartTime.Value.Hour).AddMinutes(at.AT_PMStartTime.Value.Minute);
                                }
                                if (at.AT_StartTime != null)
                                {
                                    wd.AT_StartTime =Date.Date.AddHours( at.AT_StartTime.Value.Hour).AddMinutes(at.AT_StartTime.Value.Minute);
                                }
                                wd.AT_CommutingType = at.AT_CommutingType;
                            }
                            else
                            {
                                wd = new WorkTimeDto();
                                wd.AT_ASType = WorkOrRest.休息.ToString();
                                wd.AT_CommutingType = at.AT_CommutingType;
                            }
                        }
                    }
                }
            }
            return wd;
        }

        /// <summary>
        /// 得到用户某年某月需统计的日期
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="YearAndMonth">某年某月</param>
        public List<DateTime> GetDayOfMonthlyStatistics(string UserID, DateTime YearAndMonth)
        {
            List<DateTime> dt = new List<DateTime>();
            //得到用户某个月的排班信息(某个月的01-下个月的01之前,且为上班的)
            string temp = YearAndMonth.ToString("yyyyMM" + "01");
            DateTime StartDate = DateTime.ParseExact(temp, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
            string temp2 = YearAndMonth.AddMonths(1).ToString("yyyyMM" + "01");
            DateTime EndDate = DateTime.ParseExact(temp2, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
            dt = _attendanceSchedulingRepository.GetDateByUserIDAndPeriod(UserID, StartDate, EndDate).ToList();
            if (dt.Contains(DateTime.Now.Date))
            {
                dt.Remove(DateTime.Now.Date);
            }
            return dt;
        }

        /// <summary>
        /// 得到用户某年某月的统计
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="YearAndMonth">某年某月</param>
        public MonthlyStatisticsDto GetUserMonthlyStatistics(string UserID, DateTime YearAndMonth)
        {         
            MonthlyStatistics ms = _monthlyStatisticsRepository.GetUserMonthlyStatistics(UserID, YearAndMonth.Year, YearAndMonth.Month).AsNoTracking().FirstOrDefault();
            if (ms == null)
            {
                #region 如果是本月的,则计算出来
                #region 得到基础的月统计对象
                //得到基础的月统计对象
                MonthlyStatisticsDto msd = new MonthlyStatisticsDto();
                msd.MS_AllCount = 0;
                msd.MS_ComeLateCount = 0;
                msd.MS_InTimeCount = 0;
                msd.MS_LeaveEarlyCount = 0;
                msd.MS_Month = YearAndMonth.Month;
                msd.MS_NoSignInCount = 0;
                msd.MS_NoSignOutCount = 0;
                msd.MS_RealCount = 0;
                msd.MS_UserID = UserID;
                msd.MS_Year = YearAndMonth.Year;
                msd.DS_NormalDayCount = 0;
                msd.DS_AbsentDayCount = 0;
                msd.DS_AllDayCount = 0;
                UserDto ud = Mapper.Map<User, UserDto>(_userRepository.GetByID(UserID).AsNoTracking().FirstOrDefault());
                if (ud != null)
                {
                    msd.U_Name = ud.U_Name;
                    msd.U_Portrait = ud.U_Portrait;
                }
                #endregion

                string temp = YearAndMonth.ToString("yyyyMM" + "01");
                DateTime StartDate = DateTime.ParseExact(temp, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                string temp2 = YearAndMonth.AddMonths(1).ToString("yyyyMM" + "01");
                DateTime EndDate = DateTime.ParseExact(temp2, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                StringBuilder sb = new StringBuilder();
                sb.Append("select DS_UserID MS_UserID, year(DS_Date) MS_Year, month(DS_Date) MS_Month ,");
                sb.Append("sum(DS_AllCount) MS_AllCount,sum(DS_RealCount) MS_RealCount,sum(DS_InTimeCount) MS_InTimeCount,");
                sb.Append("sum(DS_ComeLateCount) MS_ComeLateCount,sum(DS_LeaveEarlyCount) MS_LeaveEarlyCount,");
                sb.Append("sum(DS_NoSignInCount) MS_NoSignInCount,sum(DS_NoSignOutCount) MS_NoSignOutCount,");
                sb.Append("sum(DS_IsNormal) DS_NormalDayCount,sum(DS_IsAbsent) DS_AbsentDayCount,count(DS_Date) DS_AllDayCount");
                sb.Append(" from DailyStatistics");
                sb.Append(" where DS_UserID='" + UserID + "' and  DS_Date>='" + StartDate + "' and  DS_Date<'" + EndDate + "' group by year(DS_Date), month(DS_Date),DS_UserID");
                var MonthlyStatistics = smoONEContext.Database.SqlQuery<MonthlyStatisticsDto>(sb.ToString()).FirstOrDefault();
                if (MonthlyStatistics != null)
                {
                    msd.DS_AbsentDayCount = MonthlyStatistics.DS_AbsentDayCount;
                    msd.DS_AllDayCount = MonthlyStatistics.DS_AllDayCount;
                    msd.DS_NormalDayCount = MonthlyStatistics.DS_NormalDayCount;
                    msd.MS_AllCount = MonthlyStatistics.MS_AllCount;
                    msd.MS_ComeLateCount = MonthlyStatistics.MS_ComeLateCount;
                    msd.MS_InTimeCount = MonthlyStatistics.MS_InTimeCount;
                    msd.MS_LeaveEarlyCount = MonthlyStatistics.MS_LeaveEarlyCount;
                    msd.MS_Month = MonthlyStatistics.MS_Month;
                    msd.MS_NoSignInCount = MonthlyStatistics.MS_NoSignInCount;
                    msd.MS_NoSignOutCount = MonthlyStatistics.MS_NoSignOutCount;
                    msd.MS_RealCount = MonthlyStatistics.MS_RealCount;
                    msd.MS_UserID = MonthlyStatistics.MS_UserID;
                    msd.MS_Year = MonthlyStatistics.MS_Year;
                }
                return msd;
                #endregion               
            }
            else
            {
                #region 有月统计数据,则直接返回月统计数据
                MonthlyStatisticsDto msd = Mapper.Map<MonthlyStatistics, MonthlyStatisticsDto>(ms);
                UserDto ud = Mapper.Map<User, UserDto>(_userRepository.GetByID(UserID).AsNoTracking().FirstOrDefault());
                if (ud != null)
                {
                    msd.U_Name = ud.U_Name;
                    msd.U_Portrait = ud.U_Portrait;
                }
                return msd;
                #endregion
            }
        }

        /// <summary>
        /// 得到用户某天的统计
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="Date">某天</param>
        public DailyStatisticsDto GetUserDailyStatistics(string UserID, DateTime Date)
        {
            DailyStatistics ds = _dailyStatisticsRepository.GetDSByUser(UserID, Date.Date).AsNoTracking().FirstOrDefault();
            if (ds == null)
            {
                #region 返回基础的统计对象
                DailyStatisticsDto dsd = new DailyStatisticsDto();
                dsd.DS_UserID = UserID;
                dsd.DS_Date = Date.Date;
                UserDto ud = Mapper.Map<User, UserDto>(_userRepository.GetByID(UserID).AsNoTracking().FirstOrDefault());
                if (ud != null)
                {
                    dsd.U_Name = ud.U_Name;
                    dsd.U_Portrait = ud.U_Portrait;
                }
                dsd.DS_AllCount = 0;
                dsd.DS_ComeLateCount = 0;
                dsd.DS_InTimeCount = 0;
                dsd.DS_IsAbsent = 0;
                dsd.DS_IsNormal = 0;
                dsd.DS_LeaveEarlyCount = 0;
                dsd.DS_NoSignInCount = 0;
                dsd.DS_NoSignOutCount = 0;
                dsd.DS_RealCount = 0;
                return dsd;
                #endregion
            }
            else
            {
                #region 有日统计数据,则直接返回日统计数据
                DailyStatisticsDto dsd = Mapper.Map<DailyStatistics, DailyStatisticsDto>(ds);
                UserDto ud = Mapper.Map<User, UserDto>(_userRepository.GetByID(UserID).AsNoTracking().FirstOrDefault());
                if (ud != null)
                {
                    dsd.U_Name = ud.U_Name;
                    dsd.U_Portrait = ud.U_Portrait;
                }
                return dsd;
                #endregion
            }
        }    

        /// <summary>
        /// 根据用户ID和日期返回某天的日志对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="Date">日期</param>
        public List<ALDto> GetALByUserAndDate(string UserID, DateTime Date)
        {
            List<ALDto> ads = Mapper.Map<List<AttendanceLog>, List<ALDto>>(_AttendanceLogRepository.GetByUserAndDate(UserID, Date).ToList());
            UserDto ud = Mapper.Map<User, UserDto>(_userRepository.GetByID(UserID).AsNoTracking().FirstOrDefault());
            if (ud != null)
            {
                foreach (ALDto ad in ads)
                {
                    ad.U_Name = ud.U_Name;
                    ad.U_Portrait = ud.U_Portrait;
                }
            }
            return ads;
        }

        /// <summary>
        /// 得到用户某年某月某状态的日期
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="YearAndMonth">某年某月</param>
        /// <param name="Type">类型</param>
        public List<ALDto> GetAlDtoOfType(string UserID, DateTime YearAndMonth, List<StatisticsType> Types)
        {
            List<ALDto> dt = new List<ALDto>();
            StringBuilder sb = new StringBuilder();
            if (Types != null)
            {
                if (Types.Count > 0)
                {
                    foreach (StatisticsType st in Types)
                    {
                        sb.Append(st + ",");
                    }
                }
            }

            string type = sb.ToString();
            string temp = YearAndMonth.ToString("yyyyMM" + "01");
            DateTime StartDate = DateTime.ParseExact(temp, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);            
            string temp2 = YearAndMonth.AddMonths(1).ToString("yyyyMM" + "01");
            DateTime EndDate = DateTime.ParseExact(temp2, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
            if (StartDate.Year == DateTime.Now.Year && StartDate.Month == DateTime.Now.Month)
            {
                EndDate = DateTime.Now.Date;
            }
            var q = _AttendanceLogRepository.GetByTypesAndPeriod(UserID, StartDate, EndDate, type);          
            if (q != null)
            {
                dt = Mapper.Map<List<AttendanceLog>, List<ALDto>>(q.ToList());
            }
            return dt;
        }

        /// <summary>
        /// 得到用户某年某月某状态的记录
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="YearAndMonth">某年某月</param>
        /// <param name="Type">类型</param>
        public List<DateTime> GetDayOfType(string UserID, DateTime YearAndMonth, StatisticsType Type)
        {
            List<DateTime> dt = new List<DateTime>();
            string type = Type.ToString().Substring(0, 2);
            string temp = YearAndMonth.ToString("yyyyMM" + "01");
            DateTime StartDate = DateTime.ParseExact(temp, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
            string temp2 = YearAndMonth.AddMonths(1).ToString("yyyyMM" + "01");
            DateTime EndDate = DateTime.ParseExact(temp2, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
            var q = _dailyStatisticsRepository.GetAll().Where(o => o.DS_Date >= StartDate && o.DS_Date < EndDate&&o.DS_UserID==UserID);
            switch (type)
            {
                case "准点":
                    q = q.Where(o => o.DS_InTimeCount > 0);
                    break;
                case "迟到":
                    q = q.Where(o => o.DS_ComeLateCount > 0);
                    break;
                case "早退":
                    q = q.Where(o => o.DS_LeaveEarlyCount > 0);
                    break;
                case "未签":
                    q = q.Where(o => (o.DS_NoSignInCount > 0 || o.DS_NoSignOutCount > 0)&&o.DS_IsAbsent==0);
                    break;
                case "旷工":
                    q = q.Where(o => o.DS_IsAbsent == 1);
                    break;
                default: break;
            }
            dt = q.Select(o => o.DS_Date).ToList();
            return dt;
        }


        /// <summary>
        /// 根据日期返回某天的日统计对象
        /// </summary>
        /// <param name="Date">日期</param>
        public List<DailyStatisticsDto> GetALDayStatistics(DateTime Date)
        {
            List<DailyStatisticsDto> dsds = new List<DailyStatisticsDto>();
            DateTime date=Date.Date;
            List<DailyStatistics> dss = _dailyStatisticsRepository.GetAll().Where(o => o.DS_Date == date).ToList();
            if (dss != null && dss.Count > 0)
            {
                dsds = Mapper.Map<List<DailyStatistics>, List<DailyStatisticsDto>>(dss);
                foreach (DailyStatisticsDto dsd in dsds)
                {
                    UserDto ud = Mapper.Map<User, UserDto>(_userRepository.GetByID(dsd.DS_UserID).AsNoTracking().FirstOrDefault());
                    if (ud != null)
                    {
                        dsd.U_Name = ud.U_Name;
                        dsd.U_Portrait = ud.U_Portrait;
                    }
                }
            }
            return dsds;         
        }

        /// <summary>
        /// 得到某个月的统计数据
        /// </summary>
        /// <param name="YearAndMonth">某月</param>
        public MonthlyResultDto GetMonthlyResult(DateTime YearAndMonth)
        {
            MonthlyResult mr=_monthlyResultRepository.GetMonthlyResult(YearAndMonth.Year, YearAndMonth.Month).FirstOrDefault();
            MonthlyResultDto mrd =null;
            if(mr!=null)
            {
                //某个月有月统计
                mrd = Mapper.Map<MonthlyResult, MonthlyResultDto>(mr);
            }
            else
            {
                //某个月没有月统计
                #region 某个月没有月统计,则计算出来
                mrd = new MonthlyResultDto();
                mrd.MR_AbsentUser = "";
                mrd.MR_AbsentUserCount = 0;
                mrd.MR_AllUserCount = 0;
                mrd.MR_ComeLateUser = "";
                mrd.MR_ComeLateUserCount = 0;
                mrd.MR_Year = YearAndMonth.Year;
                mrd.MR_Month = YearAndMonth.Month;
                mrd.MR_InTimeUser = "";
                mrd.MR_InTimeUserCount = 0;
                mrd.MR_LeaveEarlyUser = "";
                mrd.MR_LeaveEarlyUserCount = 0;
                mrd.MR_NoSignUser = "";
                mrd.MR_NoSignUserCount = 0;               
                //得到时间段
                string temp = YearAndMonth.ToString("yyyyMM" + "01");
                DateTime StartDate = DateTime.ParseExact(temp, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                string temp2 = YearAndMonth.AddMonths(1).ToString("yyyyMM" + "01");
                DateTime EndDate = DateTime.ParseExact(temp2, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                //得到需要统计的全部用户(传准点其实只是为了返回需要统计的全部用户,真正的全月正常签到人待会会计算)
                List<string> All = _dailyStatisticsRepository.GetNamesByTypeAndPeriod(StartDate, EndDate, StatisticsType.准点);
                if (All != null && All.Count > 0)
                {
                    mrd.MR_AllUserCount = All.Count;
                }
                //得到全天旷工的
                List<string> Absent = _dailyStatisticsRepository.GetNamesByTypeAndPeriod(StartDate, EndDate, StatisticsType.旷工);
                if (Absent != null && Absent.Count > 0)
                {
                    StringBuilder sb = new StringBuilder();
                    mrd.MR_AbsentUserCount = Absent.Count;
                    foreach (string ab in Absent)
                    {
                        sb.Append(ab + ",");
                        if (All.Contains(ab))
                        {
                            All.Remove(ab);
                        }
                    }
                    mrd.MR_AbsentUser = sb.ToString().Substring(0, sb.Length - 1);
                }
                //得到迟到的
                List<string> Late = _dailyStatisticsRepository.GetNamesByTypeAndPeriod(StartDate, EndDate, StatisticsType.迟到);
                if (Late != null && Late.Count > 0)
                {
                    StringBuilder sb = new StringBuilder();
                    mrd.MR_ComeLateUserCount = Late.Count;
                    foreach (string lt in Late)
                    {
                        sb.Append(lt + ",");
                        if (All.Contains(lt))
                        {
                            All.Remove(lt);
                        }
                    }
                    mrd.MR_ComeLateUser = sb.ToString().Substring(0, sb.Length - 1);
                }
                //得到早退的
                List<string> Early = _dailyStatisticsRepository.GetNamesByTypeAndPeriod(StartDate, EndDate, StatisticsType.早退);
                if (Early != null && Early.Count > 0)
                {
                    StringBuilder sb = new StringBuilder();
                    mrd.MR_LeaveEarlyUserCount = Early.Count;
                    foreach (string lt in Early)
                    {
                        sb.Append(lt + ",");
                        if (All.Contains(lt))
                        {
                            All.Remove(lt);
                        }
                    }
                    mrd.MR_LeaveEarlyUser = sb.ToString().Substring(0, sb.Length - 1);
                }
                //得到未签的(传未签到/未签退,均会统计存在某天未签但是非全天旷工的人员)
                List<string> Unsign = _dailyStatisticsRepository.GetNamesByTypeAndPeriod(StartDate, EndDate, StatisticsType.未签到);
                if (Unsign != null && Unsign.Count > 0)
                {
                    StringBuilder sb = new StringBuilder();
                    mrd.MR_NoSignUserCount = Unsign.Count;
                    foreach (string un in Unsign)
                    {
                        sb.Append(un + ",");
                        if (All.Contains(un))
                        {
                            All.Remove(un);
                        }
                    }
                    mrd.MR_NoSignUser = sb.ToString().Substring(0, sb.Length - 1);
                }
                mrd.MR_InTimeUserCount = All.Count;
                if (All.Count > 0)
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (string a in All)
                    {
                        sb.Append(a + ",");
                    }
                    mrd.MR_InTimeUser = sb.ToString().Substring(0, sb.Length - 1);
                }                
                #endregion
            }
            return mrd;
        }

        
        /// <summary>
        /// 得到某段时间内的所有用户
        /// </summary>
        /// <param name="StartDate">开始时间</param>
        /// <param name="EndDate">结束时间</param>
        public List<string> GetUserNameByPeriod(DateTime StartDate, DateTime EndDate)
        {
            DateTime Start = StartDate.Date;
            DateTime End = EndDate.Date;
            return _AT_UserLogRepository.GetUserNameByPeriod(Start, End).ToList();        
        }

        /// <summary>
        /// 得到某天的所有用户
        /// </summary>
        /// <param name="Date">开始时间</param>
        public List<string> GetUserNameByDate(DateTime Date)
        {
            return _AT_UserLogRepository.GetUserNameByDate(Date.Date).ToList();
        }

        /// <summary>
        /// 得到未分配模板的用户
        /// </summary>
        public List<UserDto> GetNoATUser()
        {
            StringBuilder sb = new StringBuilder();
            List<string> UserStrings = _AttendanceTemplateRepository.GetAll().Select(x => x.AT_Users).ToList();
            for (int i = 0; i < UserStrings.Count; i++)
            {
                if (i != UserStrings.Count - 1)
                {
                    sb.Append(UserStrings[i] + ",");
                }
                else
                {
                    sb.Append(UserStrings[i]);
                }
            }
            string UserIDs = sb.ToString();           
            var userList = from A in smoONEContext.Users
                           where !UserIDs.Contains(A.U_ID)
                           select new UserDto
                           {
                               U_ID = A.U_ID,
                               U_Name = A.U_Name,
                               U_Portrait = A.U_Portrait
                           };

            return userList.ToList();
        }

        /// <summary>
        /// 得到该模板的用户信息
        /// </summary>
        public List<UserDto> GetATUser(string ATID)
        {          
            var userList = from A in smoONEContext.AttendanceTemplates
                           from B in smoONEContext.Users
                           where A.AT_Users.Contains(B.U_ID) && A.AT_ID == ATID
                           select new UserDto
                           {
                               U_ID = B.U_ID,
                               U_Name = B.U_Name,
                               U_Portrait = B.U_Portrait
                           };
            return userList.ToList();
        }
        #endregion

        #region 操作
        /// <summary>
        /// 添加考勤模板
        /// </summary>
        /// <param name="entity">考勤模板对象</param>
        public ReturnInfo AddAttendanceTemplate(ATInputDto entity)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            string MaxID = _AttendanceTemplateRepository.GetMaxID();
            string NowID = Helper.GenerateIDEx("AT", MaxID);
            entity.AT_ID = NowID;
            string ValidateInfo = Helper.ValidateATInputDto(entity);
            sb.Append(ValidateInfo);
            if (string.IsNullOrEmpty(ValidateInfo))
            {
                try
                {
                    AttendanceTemplate at = Mapper.Map<ATInputDto, AttendanceTemplate>(entity);
                    at.AT_CreateDate = DateTime.Now.Date;
                    at.AT_UpdateUser = entity.AT_CreateUser;
                    at.AT_EffectiveDate = DateTime.Now.AddDays(1).Date;
                    string MaxID2 = _AttendanceTemplateRepository.GetMaxID();
                    string NowID2 = Helper.GenerateIDEx("AT", MaxID2);
                    at.AT_ID = NowID2;
                    _unitOfWork.RegisterNew(at);
                    if (entity.CustomDates.Count > 0)
                    {
                        //添加自定义日期
                        foreach (AT_CDInputDto atcd in entity.CustomDates)
                        {
                            AT_CustomDate ac = Mapper.Map<AT_CDInputDto, AT_CustomDate>(atcd);
                            ac.AT_CD_ATID = NowID2;
                            _unitOfWork.RegisterNew(ac);
                        }
                    }
                    if (!string.IsNullOrEmpty(at.AT_Users))
                    {
                        List<string> Users = at.AT_Users.Split(',').ToList();
                        foreach (string User in Users)
                        {
                            AT_UserLog au = new AT_UserLog();
                            au.AT_UL_CreateDate = DateTime.Now;
                            au.AT_UL_ATID = NowID2;
                            au.AT_UL_EndTime = DateTime.MaxValue;
                            au.AT_UL_StartTime = DateTime.Now.AddDays(1).Date;
                            au.AT_UL_UserID = User;
                            _unitOfWork.RegisterNew(au);
                        }
                    }              
                    bool result = _unitOfWork.Commit();
                    RInfo.IsSuccess = result;
                    RInfo.ErrorInfo = sb.ToString();
                    return RInfo;
                }
                catch (Exception ex)
                {
                    _unitOfWork.Rollback();
                    sb.Append(ex.Message);
                    RInfo.IsSuccess = false;
                    RInfo.ErrorInfo = sb.ToString();
                    return RInfo;
                }
            }
            else
            {
                RInfo.IsSuccess = false;
                RInfo.ErrorInfo = sb.ToString();
                return RInfo;
            }
        }

        /// <summary>
        /// 添加考勤日志
        /// </summary>
        /// <param name="entity">考勤日志对象</param>
        public ReturnInfo AddAttendanceLog(ALInputDto entity)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            string ValidateInfo = Helper.ValidateALInputDto(entity);
            sb.Append(ValidateInfo);
            if (string.IsNullOrEmpty(ValidateInfo))
            {
                try
                {
                    AttendanceLog al = Mapper.Map<ALInputDto, AttendanceLog>(entity);
                    al.AL_Date = DateTime.Now;
                    al.AL_LogTimeType = entity.AL_LogTimeType.ToString();
                    al.AL_CommutingType = entity.AL_CommutingType.ToString();
                    al.AL_Status = entity.AL_Status.ToString();
                    _unitOfWork.RegisterNew(al);
                    bool result = _unitOfWork.Commit();
                    RInfo.IsSuccess = result;
                    RInfo.ErrorInfo = sb.ToString();
                    return RInfo;
                }
                catch (Exception ex)
                {
                    _unitOfWork.Rollback();
                    sb.Append(ex.Message);
                    RInfo.IsSuccess = false;
                    RInfo.ErrorInfo = sb.ToString();
                    return RInfo;
                }
            }
            else
            {
                RInfo.IsSuccess = false;
                RInfo.ErrorInfo = sb.ToString();
                return RInfo;
            }
        }

        /// <summary>
        /// 更新考勤模板
        /// </summary>
        /// <param name="entity">考勤模板对象</param>
        public ReturnInfo UpdateAttendanceTemplate(ATInputDto entity)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            AttendanceTemplate at = _AttendanceTemplateRepository.GetByID(entity.AT_ID).FirstOrDefault();
            if (at != null)
            {
                AttendanceTemplate at2 = _AttendanceTemplateRepository.GetByID(entity.AT_ID).AsNoTracking().FirstOrDefault();
                string ValidateInfo = Helper.ValidateATInputDto(entity);
                sb.Append(ValidateInfo);
                if (string.IsNullOrEmpty(ValidateInfo))
                {
                    List<DateTime> Dates = _AT_CustomDateRepository.GetByATID(entity.AT_ID).Select(x => x.AT_CD_Date).ToList();
                    try
                    {
                        at.AT_EffectiveDate = DateTime.Now.AddDays(1).Date;
                        at.AT_AllowableDeviation = entity.AT_AllowableDeviation;
                        if (entity.AT_AMEndTime != null)
                        {
                            at.AT_AMEndTime = entity.AT_AMEndTime;
                        }
                        at.AT_AMStartTime = entity.AT_AMStartTime;                       
                        at.AT_PMEndTime = entity.AT_PMEndTime;
                        if (entity.AT_PMStartTime != null)
                        {
                            at.AT_PMStartTime = entity.AT_PMStartTime;
                        }
                        at.AT_Positions = entity.AT_Positions;                       
                        at.AT_CommutingType = entity.AT_CommutingType.ToString();
                        at.AT_UpdateDate = DateTime.Now;
                        at.AT_Latitude = entity.AT_Latitude;
                        at.AT_Longitude = entity.AT_Longitude;
                        at.AT_UpdateUser = entity.AT_UpdateUser;
                        at.AT_Users = entity.AT_Users;
                        at.AT_WeeklyWorkingDay = entity.AT_WeeklyWorkingDay;
                        if (at.AT_CommutingType == entity.AT_CommutingType.ToString())
                        {
                            //如果上下班类型不变,则更新自定义日期,如果存在则更新,如果不存在,则添加
                            //更新自定义日期,如果存在则更新,如果不存在,则添加
                            if (entity.CustomDates.Count > 0)
                            {
                                foreach (AT_CDInputDto atcd in entity.CustomDates)
                                {
                                    if (Dates.Contains(atcd.AT_CD_Date.Date))
                                    {
                                        //更新
                                        AT_CustomDate ac = _AT_CustomDateRepository.GetByATIDandDate(entity.AT_ID, atcd.AT_CD_Date).FirstOrDefault();
                                        ac.AT_CD_AMEndTime = atcd.AT_CD_AMEndTime;
                                        ac.AT_CD_AMStartTime = atcd.AT_CD_AMStartTime;
                                        ac.AT_CD_CDType = atcd.AT_CD_CDType.ToString();
                                        ac.AT_CD_Date = atcd.AT_CD_Date.Date;
                                        ac.AT_CD_PMEndTime = atcd.AT_CD_PMEndTime;
                                        ac.AT_CD_PMStartTime = atcd.AT_CD_PMStartTime;
                                        ac.AT_CD_CommutingType = atcd.AT_CD_CommutingType.ToString();
                                        ac.AT_CD_ATID = at.AT_ID;
                                        ac.AT_CD_StartTime = atcd.AT_CD_StartTime;
                                        ac.AT_CD_EndTime = atcd.AT_CD_EndTime;
                                        _unitOfWork.RegisterDirty(ac);
                                    }
                                    else
                                    {
                                        //添加
                                        AT_CustomDate ac = new AT_CustomDate();
                                        ac.AT_CD_AMEndTime = atcd.AT_CD_AMEndTime;
                                        ac.AT_CD_AMStartTime = atcd.AT_CD_AMStartTime;
                                        ac.AT_CD_CDType = atcd.AT_CD_CDType.ToString();
                                        ac.AT_CD_Date = atcd.AT_CD_Date.Date;
                                        ac.AT_CD_PMEndTime = atcd.AT_CD_PMEndTime;
                                        ac.AT_CD_PMStartTime = atcd.AT_CD_PMStartTime;
                                        ac.AT_CD_CommutingType = atcd.AT_CD_CommutingType.ToString();
                                        ac.AT_CD_ATID = at.AT_ID;
                                        ac.AT_CD_StartTime = atcd.AT_CD_StartTime;
                                        ac.AT_CD_EndTime = atcd.AT_CD_EndTime;
                                        _unitOfWork.RegisterNew(ac);
                                    }

                                }
                            }
                        }
                        else
                        { 
                            //如果上下班类型变化,则删除今天之后的自定义,添加传入的自定义日期
                            List<AT_CustomDate> atcds = _AT_CustomDateRepository.GetFutureATCDByATID(entity.AT_ID).AsNoTracking().ToList();
                            if (atcds.Count > 0)
                            {
                                foreach (AT_CustomDate atcd in atcds)
                                {
                                    _unitOfWork.RegisterDeleted(atcd);
                                }
                            }
                            if (entity.CustomDates!=null)
                            {
                                foreach (AT_CDInputDto atcd in entity.CustomDates)
                                {
                                    AT_CustomDate ac = new AT_CustomDate();
                                    ac.AT_CD_AMEndTime = atcd.AT_CD_AMEndTime;
                                    ac.AT_CD_AMStartTime = atcd.AT_CD_AMStartTime;
                                    ac.AT_CD_CDType = atcd.AT_CD_CDType.ToString();
                                    ac.AT_CD_Date = atcd.AT_CD_Date.Date;
                                    ac.AT_CD_PMEndTime = atcd.AT_CD_PMEndTime;
                                    ac.AT_CD_PMStartTime = atcd.AT_CD_PMStartTime;
                                    ac.AT_CD_CommutingType = atcd.AT_CD_CommutingType.ToString();
                                    ac.AT_CD_ATID = atcd.AT_CD_ATID;
                                    ac.AT_CD_StartTime = atcd.AT_CD_StartTime;
                                    ac.AT_CD_EndTime = atcd.AT_CD_EndTime;
                                    _unitOfWork.RegisterNew(ac);
                                }
                            }
                        }
                        List<string> OldUsers = new List<string>();
                        if (!string.IsNullOrEmpty(at2.AT_Users))
                        {
                            OldUsers = at2.AT_Users.Split(',').ToList();
                        }                        
                        List<string> NewUsers = new List<string>();
                        if (!string.IsNullOrEmpty(entity.AT_Users))
                        {
                            NewUsers = entity.AT_Users.Split(',').ToList();
                        }
                        List<string> Add = NewUsers.Except(OldUsers).ToList();
                        List<string> Update = OldUsers.Intersect(NewUsers).ToList();
                        List<string> Delete = OldUsers.Except(NewUsers).ToList();
                        if (Add.Count > 0)
                        {
                            foreach (string a in Add)
                            {
                                AT_UserLog au = new AT_UserLog();
                                au.AT_UL_ATID = entity.AT_ID;
                                au.AT_UL_CreateDate = DateTime.Now;
                                au.AT_UL_EndTime = DateTime.MaxValue;
                                au.AT_UL_StartTime = DateTime.Now.AddDays(1).Date;
                                au.AT_UL_UserID = a;
                                _unitOfWork.RegisterNew(au);
                            }
                        }
                        if (Delete.Count > 0)
                        {
                            foreach (string d in Delete)
                            {
                                AT_UserLog au = _AT_UserLogRepository.GetNewestByUser(d);
                                if (au != null)
                                {
                                    au.AT_UL_EndTime = DateTime.Now.Date;
                                    _unitOfWork.RegisterDirty(au);
                                }
                            }
                        }
                        _unitOfWork.RegisterDirty(at);

                        
                        bool result = _unitOfWork.Commit();
                        RInfo.IsSuccess = result;
                        RInfo.ErrorInfo = sb.ToString();
                        return RInfo;
                    }
                    catch (Exception ex)
                    {
                        _unitOfWork.Rollback();
                        sb.Append(ex.Message);
                        RInfo.IsSuccess = false;
                        RInfo.ErrorInfo = sb.ToString();
                        return RInfo;
                    }
                }
                else
                {
                    RInfo.IsSuccess = false;
                    RInfo.ErrorInfo = sb.ToString();
                    return RInfo;
                }

            }
            else
            {
                RInfo.IsSuccess = false;
                RInfo.ErrorInfo = "查找不到该ID的考勤模板!";
                return RInfo;
            }
            
        }

        /// <summary>
        /// 删除考勤模板
        /// </summary>
        /// <param name="ATID">考勤模板对象ID</param>
        public ReturnInfo DeleteAttendanceTemplate(string ATID)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            AttendanceTemplate temp = _AttendanceTemplateRepository.GetByID(ATID).FirstOrDefault();
            if (temp != null)
            {
                List<AT_CustomDate> acs = _AT_CustomDateRepository.GetByATID(ATID).ToList();
                try
                {
                    List<string> UserNames = new List<string>();
                    if (!string.IsNullOrEmpty(temp.AT_Users))
                    {
                        UserNames = temp.AT_Users.Split(',').ToList();
                    }
                    List<AT_UserLog> Logs = new List<AT_UserLog>();
                    if (UserNames.Count > 0)
                    {
                        foreach (string UserName in UserNames)
                        {
                            AT_UserLog au = _AT_UserLogRepository.GetNewestByUser(UserName);
                            au.AT_UL_EndTime = DateTime.Now.Date;
                            Logs.Add(au);
                        }
                        foreach (AT_UserLog au in Logs)
                        {
                            _unitOfWork.RegisterDirty(au);
                        }
                    }
                    _unitOfWork.RegisterDeleted(temp);
                    foreach (AT_CustomDate ac in acs)
                    {
                        _unitOfWork.RegisterDeleted(ac);
                    }
                    bool result = _unitOfWork.Commit();
                    RInfo.IsSuccess = result;
                    RInfo.ErrorInfo = sb.ToString();
                }
                catch (Exception ex)
                {
                    _unitOfWork.RegisterClean(temp);
                    _unitOfWork.Rollback();
                    sb.Append(ex.Message);
                    RInfo.IsSuccess = false;
                    RInfo.ErrorInfo = sb.ToString();
                }
            }
            else
            {
                RInfo.IsSuccess = false;
                sb.Append("不存在ID为" + ATID + "的考勤模板.");
            }

            return RInfo;
        }
        #endregion


        #region 通用方法
        /// <summary>
        /// 得到考勤模板某段时间内的排班
        /// </summary>
        /// <param name="ATID">考勤模板对象ID</param>
        /// <param name="StartDate">开始日期</param>
        /// <param name="EndDate">结束日期</param>
        private List<AttendanceScheduling> GetAttendanceScheduling(string ATID, DateTime StartDate, DateTime EndDate)
        {
            List<AttendanceScheduling> ass = new List<AttendanceScheduling>();
            int count = (EndDate - StartDate).Days;
            if (count >= 0)
            {
                AttendanceTemplate at = _AttendanceTemplateRepository.GetByID(ATID).AsNoTracking().FirstOrDefault();
                List<string> WeeklyDay = at.AT_WeeklyWorkingDay.Split(',').ToList();
                List<AT_CustomDate> dtos = _AT_CustomDateRepository.GetByATIDandDatePeriod(ATID, StartDate, EndDate).ToList();
                List<DateTime> dts = dtos.Select(c => c.AT_CD_Date).ToList();
                for (int i = 0; i < count; i++)
                {
                    DateTime tempdt = StartDate.AddDays(i + 1);
                    AttendanceScheduling a = new AttendanceScheduling();
                    a.AS_DateTime = tempdt.Date;
                    a.AS_AllowableDeviation = at.AT_AllowableDeviation;
                    a.AS_ATID = at.AT_ID;
                    a.AS_CreateDate = DateTime.Now;
                    a.AS_Latitude = at.AT_Latitude;
                    a.AS_Longitude = at.AT_Longitude;
                    a.AS_Positions = at.AT_Positions;
                    a.AS_Users = at.AT_Users;
                    if (at.AT_CommutingType == WorkTimeType.一天二上下班.ToString())
                    {
                        a.AS_LogCount = 4;
                    }
                    else
                    {
                        a.AS_LogCount = 2;
                    }
                    if (dts.Contains(tempdt))
                    {
                        AT_CustomDate ac = dtos.Where(c => c.AT_CD_Date == tempdt).FirstOrDefault();
                        a.AS_AMEndTime = ac.AT_CD_AMEndTime;
                        a.AS_AMStartTime = ac.AT_CD_AMStartTime;
                        a.AS_EndTime = ac.AT_CD_EndTime;
                        a.AS_PMEndTime = ac.AT_CD_PMEndTime;
                        a.AS_PMStartTime = ac.AT_CD_PMStartTime;
                        a.AS_StartTime = ac.AT_CD_StartTime;
                        a.AS_CommutingType = ac.AT_CD_CommutingType;
                        a.AS_ASType = ac.AT_CD_CDType;
                        if (ac.AT_CD_CDType == WorkOrRest.休息.ToString())
                        {
                            a.AS_LogCount = 0;
                        }
                    }
                    else
                    {
                        Week temp = (Week)tempdt.DayOfWeek;
                        int tempint = (int)temp;
                        if (WeeklyDay.Contains(tempint.ToString()))
                        {
                            //当天是上班的
                            if (at.AT_AMEndTime != null)
                            {
                                a.AS_AMEndTime = tempdt.Date.AddHours(at.AT_AMEndTime.Value.Hour).AddMinutes(at.AT_AMEndTime.Value.Minute);
                            }
                            if (at.AT_AMStartTime != null)
                            {
                                a.AS_AMStartTime = tempdt.Date.AddHours(at.AT_AMStartTime.Value.Hour).AddMinutes(at.AT_AMStartTime.Value.Minute);
                            }
                            if (at.AT_EndTime != null)
                            {
                                a.AS_EndTime = tempdt.Date.AddHours(at.AT_EndTime.Value.Hour).AddMinutes(at.AT_EndTime.Value.Minute);
                            }
                            if (at.AT_PMEndTime != null)
                            {
                                a.AS_PMEndTime = tempdt.Date.AddHours(at.AT_PMEndTime.Value.Hour).AddMinutes(at.AT_PMEndTime.Value.Minute);
                            }
                            if (at.AT_PMStartTime != null)
                            {
                                a.AS_PMStartTime = tempdt.Date.AddHours(at.AT_PMStartTime.Value.Hour).AddMinutes(at.AT_PMStartTime.Value.Minute);
                            }
                            if (at.AT_StartTime != null)
                            {
                                a.AS_StartTime = tempdt.Date.AddHours(at.AT_StartTime.Value.Hour).AddMinutes(at.AT_StartTime.Value.Minute);
                            }
                            a.AS_CommutingType = at.AT_CommutingType;
                            a.AS_ASType = WorkOrRest.上班.ToString();
                        }
                        else
                        {
                            a.AS_CommutingType = at.AT_CommutingType;
                            a.AS_ASType = WorkOrRest.休息.ToString();
                            a.AS_LogCount = 0;
                        }
                    }
                    ass.Add(a);
                }
            }

            return ass;
        }

        /// <summary>
        /// 批量添加模板排班
        /// </summary>
        /// <param name="at">考勤模板对象</param>
        /// <param name="StartDate">开始日期</param>
        /// <param name="EndDate">结束日期</param>
        private void AddHisAttendanceScheduling(AttendanceTemplate at)
        {
            List<AttendanceScheduling> aslist = new List<AttendanceScheduling>();
            DateTime? MaxDate = _attendanceSchedulingRepository.GetMaxDateByATID(at.AT_ID);
            if (MaxDate == null)
            {
                //该考勤模板未存在考勤排班记录
                aslist = GetAttendanceScheduling(at.AT_ID, at.AT_CreateDate.Date, DateTime.Now.Date);
            }
            else
            {
                //该考勤模板中已经存在考勤排班记录
                aslist = GetAttendanceScheduling(at.AT_ID, MaxDate.Value, DateTime.Now.Date);
            }
            //添加排班表
            try
            {
                foreach (AttendanceScheduling ats in aslist)
                {
                    _unitOfWork.RegisterNew(ats);
                }
                bool result = _unitOfWork.Commit();
            }
            catch (Exception ex)
            {
                _unitOfWork.Rollback();
            }
        }
        #endregion
    }
}
