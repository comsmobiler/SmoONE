using SmoONE.CommLib;
using SmoONE.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmoONE.Application
{
    // ******************************************************************
    // 文件版本： SmoONE 1.1
    // Copyright  (c)  2016-2017 Smobiler 
    // 创建时间： 2017/2
    // 主要内容： 考勤的服务接口
    // ******************************************************************
    /// <summary>
    /// 考勤的服务接口
    /// </summary>
    public interface IAttendanceService
    {
        #region 查询
        /// <summary>
        /// 根据考勤模板ID返回考勤模板对象
        /// </summary>
        /// <param name="ID">考勤模板ID</param>
        ATDetailDto GetATByID(string ID);

        /// <summary>
        /// 返回所有考勤模板对象
        /// </summary>
        List<ATDto> GetAll();

        /// <summary>
        /// 得到用户当天的排班
        /// </summary>
        /// <param name="UserID">用户ID</param>
        WorkTimeDto GetCurrantASByUser(string UserID);

        /// <summary>
        /// 得到模板某天的排班
        /// </summary>
        /// <param name="ATID">考勤模板ID</param>
        /// <param name="Date">天数</param>
        WorkTimeDto GetASByATIDAndDate(string ATID, DateTime Date);

        /// <summary>
        /// 得到用户某年某月需统计的日期
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="YearAndMonth">某年某月</param>
        List<DateTime> GetDayOfMonthlyStatistics(string UserID, DateTime YearAndMonth);

        /// <summary>
        /// 得到用户某年某月的统计
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="YearAndMonth">某年某月</param>
        MonthlyStatisticsDto GetUserMonthlyStatistics(string UserID, DateTime YearAndMonth);

        /// <summary>
        /// 得到用户某天的统计
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="Date">某天</param>
        DailyStatisticsDto GetUserDailyStatistics(string UserID, DateTime Date);

        /// <summary>
        /// 根据用户ID和日期返回某天的日志对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="Date">日期</param>
        List<ALDto> GetALByUserAndDate(string UserID, DateTime Date);

        /// <summary>
        /// 得到用户某年某月某些状态的日志记录
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="YearAndMonth">某年某月</param>
        /// <param name="Type">类型</param>
        List<ALDto> GetAlDtoOfType(string UserID, DateTime YearAndMonth, List<StatisticsType> Types);

        /// <summary>
        /// 得到用户某年某月某状态的记录
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="YearAndMonth">某年某月</param>
        /// <param name="Type">类型</param>
        List<DateTime> GetDayOfType(string UserID, DateTime YearAndMonth, StatisticsType Type);

        /// <summary>
        /// 得到某个月的统计数据
        /// </summary>
        /// <param name="YearAndMonth">某月</param>
        MonthlyResultDto GetMonthlyResult(DateTime YearAndMonth);

        /// <summary>
        /// 根据日期返回某天的日统计对象
        /// </summary>
        /// <param name="Date">日期</param>
        List<DailyStatisticsDto> GetALDayStatistics(DateTime Date);        

        /// <summary>
        /// 得到未分配模板的用户
        /// </summary>
        List<UserDto> GetNoATUser();

        /// <summary>
        /// 得到该模板的用户信息
        /// </summary>
        List<UserDto> GetATUser(string ATID);

        /// <summary>
        /// 得到某段时间内的所有用户
        /// </summary>
        /// <param name="StartDate">开始时间</param>
        /// <param name="EndDate">结束时间</param>
        List<string> GetUserNameByPeriod(DateTime StartDate, DateTime EndDate);

        /// <summary>
        /// 得到某天的所有用户
        /// </summary>
        /// <param name="Date">开始时间</param>
        List<string> GetUserNameByDate(DateTime Date);
        #endregion

        #region 操作
        /// <summary>
        /// 添加考勤模板
        /// </summary>
        /// <param name="entity">考勤模板对象</param>
        ReturnInfo AddAttendanceTemplate(ATInputDto entity);

        /// <summary>
        /// 添加考勤日志
        /// </summary>
        /// <param name="entity">考勤日志对象</param>
        ReturnInfo AddAttendanceLog(ALInputDto entity);

        /// <summary>
        /// 更新考勤模板
        /// </summary>
        /// <param name="entity">考勤模板对象</param>
        ReturnInfo UpdateAttendanceTemplate(ATInputDto entity);

        /// <summary>
        /// 删除考勤模板
        /// </summary>
        /// <param name="ATID">考勤模板对象ID</param>
        ReturnInfo DeleteAttendanceTemplate(string ATID);
        #endregion
    }
}
