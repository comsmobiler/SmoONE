using SmoONE.Domain;
using SmoONE.Domain.IRepository;
using SmoONE.DTOs;
using SmoONE.Infrastructure;
using SmoONE.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Data.Entity;

namespace SmoONE.StatisticsService
{
    // ******************************************************************
    // 文件版本： SmoONE 1.1
    // Copyright  (c)  2016-2017 Smobiler 
    // 创建时间： 2017/2
    // 主要内容： 统计服务的具体实现
    // ******************************************************************
    public partial class StatisticsService : ServiceBase
    {
        public StatisticsService()
        {
            smoONEContext =new SmoONEDbContext();
            _unitOfWork = new UnitOfWork(smoONEContext);
            _AT_CustomDateRepository = new AT_CustomDateRepository(smoONEContext);
            _AttendanceLogRepository =new AttendanceLogRepository(smoONEContext);
            _AttendanceTemplateRepository =new AttendanceTemplateRepository(smoONEContext);
            _attendanceSchedulingRepository =new AttendanceSchedulingRepository(smoONEContext);
            _monthlyStatisticsRepository = new MonthlyStatisticsRepository(smoONEContext);
            _dailyStatisticsRepository = new DailyStatisticsRepository(smoONEContext);
            _AT_UserLogRepository =new AT_UserLogRepository(smoONEContext);
            _monthlyResultRepository = new MonthlyResultRepository(smoONEContext);            
            InitializeComponent();
        }

        /// <summary>
        /// 工作单元的接口
        /// </summary>
        private UnitOfWork _unitOfWork;

        /// <summary>
        /// 数据库上下文
        /// </summary>
        private SmoONEDbContext smoONEContext;

        /// <summary>
        /// 自定义日期的仓储类的接口
        /// </summary>
        private AT_CustomDateRepository _AT_CustomDateRepository;

        /// <summary>
        /// 考勤日志的仓储类的接口
        /// </summary>
        private AttendanceLogRepository _AttendanceLogRepository;

        /// <summary>
        /// 考勤模板的仓储类的接口
        /// </summary>
        private AttendanceTemplateRepository _AttendanceTemplateRepository;

        /// <summary>
        /// 用户模板变更日志的仓储接口
        /// </summary>
        private AT_UserLogRepository _AT_UserLogRepository;

        /// <summary>
        /// 用户月统计的仓储接口
        /// </summary>
        private MonthlyStatisticsRepository _monthlyStatisticsRepository;

        /// <summary>
        /// 用户日统计的仓储接口
        /// </summary>
        private DailyStatisticsRepository _dailyStatisticsRepository;

        /// <summary>
        /// 月统计的仓储接口
        /// </summary>
        private MonthlyResultRepository _monthlyResultRepository;

        /// <summary>
        /// 考勤排班的仓储接口
        /// </summary>
        private AttendanceSchedulingRepository _attendanceSchedulingRepository;

        /// <summary>
        /// 服务开始的时候执行的操作(先运行一下统计,然后每隔1小时运行一次统计)
        /// </summary>
        protected override void OnStart(string[] args)
        {
            EventLog.WriteEntry("SmoONE统计服务启动.");//在系统事件查看器里的应用程序事件里来源的描述   
            writestr("SmoONE统计服务启动.");//自定义文本日志
            RunStatistics();
            System.Timers.Timer t = new System.Timers.Timer();
            t.Interval = 3600000;
            t.Elapsed += new System.Timers.ElapsedEventHandler(ChkSrv);//到达时间的时候执行事件；    
            t.AutoReset = true;//设置是执行一次（false）还是一直执行(true)；    
            t.Enabled = true;//是否执行System.Timers.Timer.Elapsed事件；    
        }

        /// <summary>   
        /// 定时检查，并执行方法   
        /// </summary>   
        /// <param name="source"></param>   
        /// <param name="e"></param>   
        public void ChkSrv(object source, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                System.Timers.Timer tt = (System.Timers.Timer)source;
                tt.Enabled = false;
                RunStatistics();
                tt.Enabled = true;
            }
            catch (Exception err)
            {
                writestr(err.Message);
            }
        }

        /// <summary>   
        /// 执行统计（主要包括补全昨天及之前的排班,补全昨天及之前的未签记录和用户日统计,补全上个月及之前的用户月统计,补全上个月及之前的月总统计）   
        /// </summary>    
        public void RunStatistics()
        {
            try
            {
                writestr("服务运行.");
                //这里执行你的东西
                #region 计算模板当天的排班以及补全之前的排班
                //得到今天所有的模板
                List<string> ATIDs = _AT_UserLogRepository.GetATIDByDate(DateTime.Now.Date).AsNoTracking().ToList();
                StringBuilder ATids = new StringBuilder();
                if (ATIDs != null && ATIDs.Count > 0)
                {
                    foreach (string ATID in ATIDs)
                    {
                        ATids.Append(ATID.ToString()+",");  
                        //得到每个模板某天的排班
                        AttendanceScheduling ass = _attendanceSchedulingRepository.GetByATIDandDate(ATID, DateTime.Now.Date).FirstOrDefault();
                        if (ass != null)
                        {
                        }
                        else
                        {
                            AttendanceTemplate at = _AttendanceTemplateRepository.GetByID(ATID).AsNoTracking().FirstOrDefault();
                            //当天无排班,则先添加排班
                            if (at != null)
                            {
                                AddHisAttendanceScheduling(at);
                            }
                        }
                    }
                    writestr(ATids.ToString() );
                }
                #endregion

                #region 计算用户的所有日统计
                //得到有过模板的所有用户
                List<string> UserNames = _AT_UserLogRepository.GetAll().Select(o => o.AT_UL_UserID).Distinct().ToList();
                //用于日志判断
                StringBuilder uName = new StringBuilder();
                foreach (string User in UserNames)
                {
                    uName.Append(User + ",");
                }
                writestr(uName.ToString());

                foreach (string User in UserNames)
                { 
                    //判断用户昨天的日统计是否存在
                    DailyStatistics ds = _dailyStatisticsRepository.GetDSByUser(User, DateTime.Now.AddDays(-1).Date).AsNoTracking().FirstOrDefault();
                    if (ds == null)
                    { 
                        //用户昨天没有日统计数据,则可能需要补日统计数据
                        //先得到用户最后的日统计数据日期

                        //用于日志判断
                        writestr(User + "昨天的ds为null");

                        ds = _dailyStatisticsRepository.GetNewestByUser(User);
                        DateTime Newest=DateTime.MinValue.Date;
                        if (ds != null)
                        {
                            Newest = ds.DS_Date.AddDays(1).Date;
                        }
                        writestr("Newest日期:"+Newest.ToString());
                        DateTime EndDate = DateTime.Now.Date;
                        AT_UserLog au = _AT_UserLogRepository.GetNewestByUser(User);
                        if (au != null&&au.AT_UL_EndTime!=DateTime.MaxValue)
                        {
                            writestr(au.AT_UL_EndTime.ToString());
                            EndDate = au.AT_UL_EndTime.AddDays(1).Date;
                        }
                        writestr("EndDate日期:" + EndDate.ToString());
                        //得到可能需要补全日统计数据的日期
                        List<DateTime> dates = _attendanceSchedulingRepository.GetByUserIDAndPeriod(User, Newest, EndDate).Select(o=>o.AS_DateTime).ToList();
                        //记录日志
                        StringBuilder d = new StringBuilder();
                        if (dates != null && dates.Count > 0)
                        {
                            d.Append("需要补全的日期:");
                            foreach (DateTime dt in dates)
                            {
                                d.Append(dt.ToString() + " ");
                            }
                        }
                        if (dates != null && dates.Count > 0)
                        {
                            foreach (DateTime dt in dates)
                            {
                                CalculateDailyStatistics(User, dt.Date);
                            }
                        }
                    }
                }
                #endregion

                #region 计算用户的月统计和总的月统计
                foreach (string User in UserNames)
                {
                    //判断用户上个月的统计是否存在
                    writestr("进入" + User + "月统计");
                    MonthlyStatistics ms = _monthlyStatisticsRepository.GetUserMonthlyStatistics(User, DateTime.Now.AddMonths(-1).Year, DateTime.Now.AddMonths(-1).Month).AsNoTracking().FirstOrDefault();
                    if (ms == null)
                    { 
                        //从排班中获取需要统计的月份
                        //得到用户最近的月统计月份
                        writestr(User+"上个月不存在月统计.");
                        ms = _monthlyStatisticsRepository.GetNewestUserMonthlyStatistics(User);
                        //加入日志
                        writestr("ms没报错.");
                        int StartYear = 0;
                        int StartMonth = 0;
                        if (ms != null)
                        {
                            StartYear = ms.MS_Year;
                            StartMonth = ms.MS_Month;
                        }
                        else
                        {
                            DailyStatistics ds = _dailyStatisticsRepository.GetOldestByUser(User);
                            if (ds != null)
                            {
                                StartYear = ds.DS_Date.AddMonths(-1).Year;
                                StartMonth = ds.DS_Date.AddMonths(-1).Month;
                            }
                        }
                        //加入日志
                        writestr("StartYear:" + StartYear.ToString()+";StartMonth:"+StartMonth.ToString());
                        if (StartYear != 0)
                        {
                            //用户至少有一条日统计数据才可能需要计算月统计数据
                            //得到用户需要统计的所有年和月
                            StringBuilder s = new StringBuilder();
                            s.Append(StartYear);
                            if (StartMonth < 10)
                            {
                                s.Append("0");
                            }
                            s.Append(StartMonth);
                            s.Append("01");
                            string temp = s.ToString();
                            DateTime StartTemp = DateTime.ParseExact(temp, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                            DateTime StartDate = StartTemp.AddMonths(1).Date;
                            StringBuilder sb = new StringBuilder();
                            sb.Append("select DS_UserID MS_UserID, year(DS_Date) MS_Year, month(DS_Date) MS_Month ,");
                            sb.Append("sum(DS_AllCount) MS_AllCount,sum(DS_RealCount) MS_RealCount,sum(DS_InTimeCount) MS_InTimeCount,");
                            sb.Append("sum(DS_ComeLateCount) MS_ComeLateCount,sum(DS_LeaveEarlyCount) MS_LeaveEarlyCount,");
                            sb.Append("sum(DS_NoSignInCount) MS_NoSignInCount,sum(DS_NoSignOutCount) MS_NoSignOutCount,");
                            sb.Append("sum(DS_IsNormal) DS_NormalDayCount,sum(DS_IsAbsent) DS_AbsentDayCount,count(DS_Date) DS_AllDayCount");
                            sb.Append(" from DailyStatistics");
                            sb.Append(" where DS_UserID='" + User + "' and  DS_Date>='" + StartDate + "' group by year(DS_Date), month(DS_Date),DS_UserID");
                            //加入日志
                            writestr("Sql语句:" + sb.ToString());
                            var MonthlyStatisticsDto = smoONEContext.Database.SqlQuery<MonthlyStatisticsDto>(sb.ToString()).ToList();
                            if (MonthlyStatisticsDto != null && MonthlyStatisticsDto.Count > 0)
                            {
                                //加入日志
                                writestr("MonthlyStatisticsDto未报错.");
                                foreach (MonthlyStatisticsDto msd in MonthlyStatisticsDto)
                                {
                                    if (msd.MS_Year == DateTime.Now.Year && msd.MS_Month == DateTime.Now.Month)
                                    {
                                        //当月的不记入数据库
                                    }
                                    else
                                    {
                                        //保存月统计记录
                                        try
                                        {
                                            MonthlyStatistics ms2 = new MonthlyStatistics();
                                            ms2.DS_AbsentDayCount = msd.DS_AbsentDayCount;
                                            ms2.DS_AllDayCount = msd.DS_AllDayCount;
                                            ms2.DS_NormalDayCount = msd.DS_NormalDayCount;
                                            ms2.MS_AllCount = msd.MS_AllCount;
                                            ms2.MS_ComeLateCount = msd.MS_ComeLateCount;
                                            ms2.MS_InTimeCount = msd.MS_InTimeCount;
                                            ms2.MS_LeaveEarlyCount = msd.MS_LeaveEarlyCount;
                                            ms2.MS_Month = msd.MS_Month;
                                            ms2.MS_NoSignInCount = msd.MS_NoSignInCount;
                                            ms2.MS_NoSignOutCount = msd.MS_NoSignOutCount;
                                            ms2.MS_RealCount = msd.MS_RealCount;
                                            ms2.MS_UserID = msd.MS_UserID;
                                            ms2.MS_Year = msd.MS_Year;
                                            _unitOfWork.RegisterNew(ms2);
                                            bool result = _unitOfWork.Commit();
                                            //加入日志
                                            if (result == true)
                                            {
                                                writestr(ms2.MS_Year.ToString() + ms2.MS_Month.ToString() + "的ms2成功添加.");
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            _unitOfWork.Rollback();
                                        }
                                    }
                                
                                }
                            }
                        }


                    }
                }

                //计算总的月统计
                //上个月的月统计是否存在
                MonthlyResult mr = _monthlyResultRepository.GetMonthlyResult(DateTime.Now.AddMonths(-1).Year, DateTime.Now.AddMonths(-1).Month).AsNoTracking().FirstOrDefault();
                if (mr == null)
                { 
                    //上个月总统计不存在
                    //先得到最近的总统计
                    //加入日志
                    writestr("上个月的总月统计不存在.");
                    mr = _monthlyResultRepository.GetAll().OrderByDescending(o => o.MR_Year).ThenByDescending(o => o.MR_Month).FirstOrDefault();
                    int StartYear = 0;
                    int StartMonth = 0;
                    if (mr == null)
                    {
                        //之前都不存在月总统计
                        MonthlyStatistics ms = _monthlyStatisticsRepository.GetAll().OrderBy(o => o.MS_Year).ThenBy(o => o.MS_Month).AsNoTracking().FirstOrDefault();
                        if (ms!=null)
                        {
                            StartYear = ms.MS_Year;
                            StartMonth = ms.MS_Month;
                        }
                    }
                    else
                    { 
                        //之前存在月总统计
                        if (mr.MR_Month < 12)
                        {
                            StartYear = mr.MR_Year;
                            StartMonth = mr.MR_Month+1;
                        }
                        else
                        {
                            StartYear = mr.MR_Year + 1;
                            StartMonth = 1;
                        }
                    }
                    //加入日志
                    writestr("月总统计的StartYear:" + StartYear.ToString() + ",StartMonth:" + StartMonth.ToString());
                    if (StartYear != 0)
                    {                       
                        StringBuilder sb = new StringBuilder();
                        sb.Append("select distinct MS_Year, MS_Month from MonthlyStatistics ");
                        sb.Append(" where (MS_Year=" + StartYear + " and MS_Month>=" + StartMonth + ") or MS_Year>"+StartYear);
                        //加入日志
                        writestr("得到需要月总统计的年月的Sql:"+sb.ToString());
                        var YearAndMonths = smoONEContext.Database.SqlQuery<MonthlyStatisticsDto>(sb.ToString()).ToList();
                        if (YearAndMonths != null && YearAndMonths.Count > 0)
                        {
                            //加入日志
                            writestr("YearAndMonths未报错.");
                            foreach (MonthlyStatisticsDto yam in YearAndMonths)
                            {
                                //加入日志
                                writestr("YearAndMonth:" + yam.MS_Year.ToString()+yam.MS_Month.ToString());
                                if (yam.MS_Year == DateTime.Now.Year && yam.MS_Month == DateTime.Now.Month)
                                {
                                    //当月的不保存
                                }
                                else
                                {
                                    //加入日志
                                    writestr("进入月总统计的计算.");
                                    CalculateMonthlyResult(yam.MS_Year, yam.MS_Month);
                                }
                            }
                        }
                    }
                }
                #endregion
                Thread.Sleep(10000);
            }
            catch (Exception err)
            {
                writestr(err.Message);
            }
        }

        ///在指定时间过后执行指定的表达式   
        ///   
        ///事件之间经过的时间（以毫秒为单位）   
        ///要执行的表达式   
        public static void SetTimeout(double interval, Action action)
        {
            System.Timers.Timer timer = new System.Timers.Timer(interval);
            timer.Elapsed += delegate(object sender, System.Timers.ElapsedEventArgs e)
            {
                timer.Enabled = false;
                action();
            };
            timer.Enabled = true;
        }


        /// <summary>
        /// 记录日志
        /// </summary>
        /// <param name="readme">日志内容</param>
        public void writestr(string readme)
        {
            //debug==================================================    
            StreamWriter dout = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "SmoONE_StatisticsServiceLog(" + System.DateTime.Now.ToString("yyy-MM-dd") + ").txt", true);
            dout.Write("\r\n事件：" + readme + "\r\n操作时间：" + System.DateTime.Now.ToString("yyy-MM-dd HH:mm:ss"));
            //debug==================================================   
            dout.Close();
        }

        /// <summary>
        /// 服务停止时执行的操作
        /// </summary>
        protected override void OnStop()
        {
            writestr("SmoONE统计服务停止.");
            EventLog.WriteEntry("SmoONE统计服务停止。");   
        }

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

        public void CalculateMonthlyResult(int Year, int Month)
        {
            MonthlyResult mr = new MonthlyResult();
            mr.MR_Year = Year;
            mr.MR_Month = Month;

            #region 得到迟到的人
            StringBuilder sb = new StringBuilder();
            sb.Append("select MS_UserID from [MonthlyStatistics] where MS_Year=" + Year + " and MS_Month=" + Month + " and MS_ComeLateCount>0");
            //加入日志
            writestr("得到迟到的人的Sql:" + sb.ToString());
            var LateUsers = smoONEContext.Database.SqlQuery<string>(sb.ToString()).ToList();
            if (LateUsers != null && LateUsers.Count > 0)
            {
                mr.MR_ComeLateUserCount = LateUsers.Count;
                StringBuilder Late = new StringBuilder();
                foreach (string lateName in LateUsers)
                {
                    Late.Append(lateName + ",");
                }
                mr.MR_ComeLateUser = Late.ToString().Substring(0, Late.Length - 1);
            }
            else
            {
                mr.MR_ComeLateUser = "";
                mr.MR_ComeLateUserCount = 0;
            }
            #endregion

            #region 得到早退的人
            StringBuilder sb2 = new StringBuilder();
            sb2.Append("select MS_UserID from [MonthlyStatistics] where MS_Year=" + Year + " and MS_Month=" + Month + " and MS_LeaveEarlyCount>0");
            //加入日志
            writestr("得到早退的人的Sql:" + sb2.ToString());
            var EarlyUsers = smoONEContext.Database.SqlQuery<string>(sb2.ToString()).ToList();
            if (EarlyUsers != null && EarlyUsers.Count > 0)
            {
                mr.MR_LeaveEarlyUserCount = EarlyUsers.Count;
                StringBuilder Early = new StringBuilder();
                foreach (string earlyName in EarlyUsers)
                {
                    Early.Append(earlyName + ",");
                }
                mr.MR_LeaveEarlyUser = Early.ToString().Substring(0, Early.Length - 1);
            }
            else
            {
                mr.MR_LeaveEarlyUser = "";
                mr.MR_LeaveEarlyUserCount = 0;
            }
            #endregion

            #region 得到未签的人
            StringBuilder sb3 = new StringBuilder();
            sb3.Append("select MS_UserID from [MonthlyStatistics] where MS_Year=" + Year + " and MS_Month=" + Month + " and (MS_NoSignInCount>0 or MS_NoSignOutCount>0) and MS_AllCount*DS_AbsentDayCount/DS_AllDayCount<MS_NoSignInCount+MS_NoSignOutCount");
            //加入日志
            writestr("得到未签的人的Sql:" + sb3.ToString());
            var NoSignUsers = smoONEContext.Database.SqlQuery<string>(sb3.ToString()).ToList();
            if (NoSignUsers != null && NoSignUsers.Count > 0)
            {
                mr.MR_NoSignUserCount = NoSignUsers.Count;
                StringBuilder NoSign = new StringBuilder();
                foreach (string nosignName in NoSignUsers)
                {
                    NoSign.Append(nosignName + ",");
                }
                mr.MR_NoSignUser = NoSign.ToString().Substring(0, NoSign.Length - 1);
            }
            else
            {
                mr.MR_NoSignUser = "";
                mr.MR_NoSignUserCount = 0;
            }
            #endregion

            #region 得到正常签到的人
            StringBuilder sb4 = new StringBuilder();
            sb4.Append("select MS_UserID from [MonthlyStatistics] where MS_Year=" + Year + " and MS_Month=" + Month + " and DS_NormalDayCount=DS_AllDayCount");
            //加入日志
            writestr("得到正常签到的人的Sql:" + sb4.ToString());
            var NormalUsers = smoONEContext.Database.SqlQuery<string>(sb4.ToString()).ToList();
            if (NormalUsers != null && NormalUsers.Count > 0)
            {
                mr.MR_InTimeUserCount = NormalUsers.Count;
                StringBuilder InTime = new StringBuilder();
                foreach (string normalName in NormalUsers)
                {
                    InTime.Append(normalName + ",");
                }
                mr.MR_InTimeUser = InTime.ToString().Substring(0, InTime.Length - 1);
            }
            else
            {
                mr.MR_InTimeUser = "";
                mr.MR_InTimeUserCount = 0;
            }
            #endregion

            #region 得到全天旷工的人
            StringBuilder sb5 = new StringBuilder();
            sb5.Append("select MS_UserID from [MonthlyStatistics] where MS_Year=" + Year + " and MS_Month=" + Month + " and DS_AbsentDayCount>0");
            //加入日志
            writestr("得到全天旷工的人的Sql:" + sb5.ToString());
            var AbsentUsers = smoONEContext.Database.SqlQuery<string>(sb5.ToString()).ToList();
            if (AbsentUsers != null && AbsentUsers.Count > 0)
            {
                mr.MR_AbsentUserCount = AbsentUsers.Count;
                StringBuilder Absent = new StringBuilder();
                foreach (string absentName in AbsentUsers)
                {
                    Absent.Append(absentName + ",");
                }
                mr.MR_AbsentUser = Absent.ToString().Substring(0, Absent.Length - 1);
            }
            else
            {
                mr.MR_AbsentUser = "";
                mr.MR_AbsentUserCount = 0;
            }
            #endregion

            #region 得到应考勤人数
            StringBuilder sb6 = new StringBuilder();
            sb6.Append("select MS_UserID from [MonthlyStatistics] where MS_Year=" + Year + " and MS_Month=" + Month);
            //加入日志
            writestr("得到应考勤人数的人的Sql:" + sb6.ToString());
            var AllUsers = smoONEContext.Database.SqlQuery<string>(sb6.ToString()).ToList();
            if (AllUsers != null && AllUsers.Count > 0)
            {
                mr.MR_AllUserCount = AllUsers.Count;
            }
            else
            {
                mr.MR_AllUserCount = 0;
            }
            #endregion

            #region 保存月总统计
            try
            {
                _unitOfWork.RegisterNew(mr);
                bool result = _unitOfWork.Commit();
            }
            catch (Exception ex)
            {
                _unitOfWork.Rollback();
            }
            #endregion
        }


        /// <summary>
        /// 计算用户某天的统计
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="Date">某天</param>
        public DailyStatistics   CalculateDailyStatistics(string UserID, DateTime Date)
        {
            //需要添加的未签到和未签退记录
            List<AttendanceLog> als = new List<AttendanceLog>();
            #region 得到基础的日统计对象
            //得到基础的日统计对象
            DailyStatistics dsd = new DailyStatistics();
            dsd.DS_AllCount = 0;
            dsd.DS_ComeLateCount = 0;
            dsd.DS_InTimeCount = 0;
            dsd.DS_LeaveEarlyCount = 0;
            dsd.DS_NoSignInCount = 0;
            dsd.DS_NoSignOutCount = 0;
            dsd.DS_RealCount = 0;
            dsd.DS_UserID = UserID;
            dsd.DS_Date = Date.Date;
            dsd.DS_IsNormal = 0;
            dsd.DS_IsAbsent = 0;
            #endregion
            #region 用户该天不存在日统计数据,则计算出来
            //计算数据
            AttendanceScheduling ats = _attendanceSchedulingRepository.GetByUserIDAndDate(UserID, Date.Date).AsNoTracking().FirstOrDefault();
            if (ats != null)
            {
                //应签次数
                //记录日志
                writestr(UserID + Date.ToString() + "的排班ID:" + ats.AS_ID);
                if (ats.AS_CommutingType == WorkTimeType.一天二上下班.ToString())
                {
                    dsd.DS_AllCount = 4;
                }
                else if (ats.AS_CommutingType == WorkTimeType.一天一上下班.ToString())
                {
                    dsd.DS_AllCount = 2;
                }
                //得到当天数据库中的签到记录条数
                int count = _AttendanceLogRepository.GetDayCount(UserID, ats.AS_DateTime);
                if (dsd.DS_AllCount == count)
                {
                    #region 用户当天数据库中的签到记录条数=应签到次数,则直接取对应种类的记录数量就可以了
                    //可以通过Sql语句来优化,不再每种都去读取一遍
                    DateTime d1 = Date.Date;
                    DateTime d2 = Date.AddDays(1).Date;
                    StringBuilder sb = new StringBuilder();
                    sb.Append("select top 1 (select COUNT(AL_Status)  from AttendanceLog where AL_Status='准点'  and AL_UserID='" + UserID + "' and  AL_Date>='" + d1 + "' and AL_Date<'" + d2 + "' ) as DS_InTimeCount,");
                    sb.Append("(select COUNT(AL_Status)  from AttendanceLog where AL_Status='迟到'  and AL_UserID='" + UserID + "' and  AL_Date>='" + d1 + "' and AL_Date<'" + d2 + "' ) as DS_ComeLateCount,");
                    sb.Append("(select COUNT(AL_Status)  from AttendanceLog where AL_Status='早退'  and AL_UserID='" + UserID + "' and  AL_Date>='" + d1 + "' and AL_Date<'" + d2 + "' ) as DS_LeaveEarlyCount,");
                    sb.Append("(select COUNT(AL_Status)  from AttendanceLog where AL_Status='未签到'  and AL_UserID='" + UserID + "' and  AL_Date>='" + d1 + "' and AL_Date<'" + d2 + "' ) as DS_NoSignInCount,");
                    sb.Append("(select COUNT(AL_Status)  from AttendanceLog where AL_Status='未签退'  and AL_UserID='" + UserID + "' and  AL_Date>='" + d1 + "' and AL_Date<'" + d2 + "' ) as DS_NoSignOutCount,");
                    sb.Append("(case AL_CommutingType when '一天一上下班' then 2 else 4 end ) as DS_AllCount");
                    sb.Append(" from [AttendanceLog]");
                    var DailyStatisticsDto = smoONEContext.Database.SqlQuery<DailyStatisticsDto>(sb.ToString()).FirstOrDefault();
                    dsd.DS_ComeLateCount = DailyStatisticsDto.DS_ComeLateCount;
                    dsd.DS_InTimeCount = DailyStatisticsDto.DS_InTimeCount;
                    dsd.DS_LeaveEarlyCount = DailyStatisticsDto.DS_LeaveEarlyCount;
                    dsd.DS_NoSignInCount = DailyStatisticsDto.DS_NoSignInCount;
                    dsd.DS_NoSignOutCount = DailyStatisticsDto.DS_NoSignOutCount;
                    dsd.DS_RealCount = DailyStatisticsDto.DS_ComeLateCount + DailyStatisticsDto.DS_InTimeCount + DailyStatisticsDto.DS_LeaveEarlyCount;
                    if (dsd.DS_AllCount == dsd.DS_InTimeCount)
                    {
                        dsd.DS_IsNormal = 1;
                    }
                    if (dsd.DS_AllCount == dsd.DS_NoSignInCount + dsd.DS_NoSignOutCount)
                    {
                        dsd.DS_IsAbsent = 1;
                    }
                    #endregion
                }
                else
                {
                    #region 存在未签到/未签退的情况,只能逐条去判断
                    //存在未签到/未签退的情况,只能逐条去判断
                    foreach (StatisticsTime st in Enum.GetValues(typeof(StatisticsTime)))
                    {
                        string sTime = st.ToString();
                        if (ats.AS_CommutingType == WorkTimeType.一天二上下班.ToString() && sTime.Contains("午"))
                        {
                            #region 处理一天二上下班的情况
                            //得到记录
                            AttendanceLog al = _AttendanceLogRepository.GetByStatisticsTime(UserID, ats.AS_DateTime.Date, st).AsNoTracking().FirstOrDefault();
                            if (al == null)
                            {
                                #region 没有记录,则记录对应的未签到/未签退记录
                                //没有记录,则记录对应的未签到/未签退记录
                                AttendanceLog al2 = new AttendanceLog();
                                al2.AL_CommutingType = ats.AS_CommutingType;
                                al2.AL_Date = ats.AS_DateTime.Date;
                                al2.AL_LogTimeType = sTime;
                                al2.AL_UserID = UserID;
                                if (sTime.Contains("上班"))
                                {
                                    //未签到
                                    dsd.DS_NoSignInCount++;
                                    if (sTime.Contains("上午"))
                                    {
                                        al2.AL_OnTime = ats.AS_AMStartTime.Value;
                                    }
                                    else
                                    {
                                        al2.AL_OnTime = ats.AS_PMStartTime.Value;
                                    }
                                    al2.AL_Status = AttendanceType.未签到.ToString();
                                }
                                else
                                {
                                    //未签退
                                    dsd.DS_NoSignOutCount++;
                                    if (sTime.Contains("上午"))
                                    {
                                        al2.AL_OnTime = ats.AS_AMEndTime.Value;
                                    }
                                    else
                                    {
                                        al2.AL_OnTime = ats.AS_PMEndTime.Value;
                                    }
                                    al2.AL_Status = AttendanceType.未签退.ToString();
                                }
                                als.Add(al2);
                                #endregion
                            }
                            else
                            {
                                #region  有记录,则直接判断记录的类型
                                //有记录,则直接判断记录的类型
                                switch (al.AL_Status)
                                {
                                    case "准点":
                                        dsd.DS_InTimeCount++;
                                        dsd.DS_RealCount++;
                                        break;
                                    case "迟到":
                                        dsd.DS_ComeLateCount++;
                                        dsd.DS_RealCount++;
                                        break;
                                    case "早退":
                                        dsd.DS_LeaveEarlyCount++;
                                        dsd.DS_RealCount++;
                                        break;
                                    case "未签到":
                                        dsd.DS_NoSignInCount++;
                                        break;
                                    case "未签退":
                                        dsd.DS_NoSignOutCount++;
                                        break;
                                    default:
                                        break;
                                }
                                #endregion
                            }
                            #endregion
                        }
                        else if (ats.AS_CommutingType == WorkTimeType.一天一上下班.ToString() && !sTime.Contains("午"))
                        {
                            //得到记录
                            AttendanceLog al = _AttendanceLogRepository.GetByStatisticsTime(UserID, ats.AS_DateTime.Date, st).AsNoTracking().FirstOrDefault();
                            if (al == null)
                            {
                                #region 没有记录,则记录对应的未签到/未签退记录
                                //没有记录,则记录对应的未签到/未签退记录
                                AttendanceLog al2 = new AttendanceLog();
                                al2.AL_CommutingType = ats.AS_CommutingType;
                                al2.AL_Date = ats.AS_DateTime.Date;
                                al2.AL_LogTimeType = sTime;
                                al2.AL_UserID = UserID;
                                if (sTime.Contains("上班"))
                                {
                                    //未签到
                                    dsd.DS_NoSignInCount++;
                                    al2.AL_OnTime = ats.AS_StartTime.Value;
                                    al2.AL_Status = AttendanceType.未签到.ToString();
                                }
                                else
                                {
                                    //未签退
                                    dsd.DS_NoSignOutCount++;
                                    al2.AL_OnTime = ats.AS_EndTime.Value;
                                    al2.AL_Status = AttendanceType.未签退.ToString();
                                }
                                als.Add(al2);
                                #endregion
                            }
                            else
                            {
                                #region  有记录,则直接判断记录的类型
                                //有记录,则直接判断记录的类型
                                switch (al.AL_Status)
                                {
                                    case "准点":
                                        dsd.DS_InTimeCount++;
                                        dsd.DS_RealCount++;
                                        break;
                                    case "迟到":
                                        dsd.DS_ComeLateCount++;
                                        dsd.DS_RealCount++;
                                        break;
                                    case "早退":
                                        dsd.DS_LeaveEarlyCount++;
                                        dsd.DS_RealCount++;
                                        break;
                                    case "未签到":
                                        dsd.DS_NoSignInCount++;
                                        break;
                                    case "未签退":
                                        dsd.DS_NoSignOutCount++;
                                        break;
                                    default:
                                        break;
                                }
                                #endregion
                            }
                        }

                    }
                    #endregion
                }
                if (dsd.DS_AllCount == dsd.DS_InTimeCount)
                {
                    dsd.DS_IsNormal = 1;
                }
                if (dsd.DS_AllCount == dsd.DS_NoSignInCount + dsd.DS_NoSignOutCount)
                {
                    dsd.DS_IsAbsent = 1;
                }
            }
            #endregion

            #region 保存未签到/未签退的记录
            //保存未签到/未签退的记录
            if (als.Count > 0)
            {
                try
                {
                    foreach (AttendanceLog a in als)
                    {
                        _unitOfWork.RegisterNew(a);
                    }
                    bool result = _unitOfWork.Commit();
                }
                catch (Exception ex)
                {
                    _unitOfWork.Rollback();
                }
            }
            #endregion

            #region 保存未记录的每日统计数据
            //保存未记录的每日统计数据
            try
            {
                _unitOfWork.RegisterNew(dsd);
                bool result = _unitOfWork.Commit();
            }
            catch (Exception ex)
            {
                _unitOfWork.Rollback();
            }
            #endregion

            return dsd;
        }
        #endregion
    }
}
