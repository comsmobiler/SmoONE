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
    // 主要内容： 用户模板变更日志的仓储接口,仅用于查询
    // ******************************************************************
    /// <summary>
    /// 用户模板变更日志的仓储接口,仅用于查询
    /// </summary>
    public interface IAT_UserLogRepository : IRepository<AT_UserLog>
    {
        /// <summary>
        /// 根据日期返回模板ID
        /// </summary>
        /// <param name="Date">日期</param>
        IQueryable<string> GetATIDByDate(DateTime Date);

        /// <summary>
        /// 得到用户某段时间内的模板变更日志
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="StartDate">开始时间</param>
        /// <param name="EndDate">结束时间</param>
        IQueryable<AT_UserLog> GetByPeriod(string UserID, DateTime StartDate, DateTime EndDate);

        /// <summary>
        /// 得到某段时间内的所有用户
        /// </summary>
        /// <param name="StartDate">开始时间</param>
        /// <param name="EndDate">结束时间</param>
        IQueryable<string> GetUserNameByPeriod(DateTime StartDate, DateTime EndDate);

        /// <summary>
        /// 得到某段时间内的所有模板ID
        /// </summary>
        /// <param name="StartDate">开始时间</param>
        /// <param name="EndDate">结束时间</param>
        IQueryable<string> GetATIDsByPeriod(DateTime StartDate, DateTime EndDate);

        /// <summary>
        /// 得到某天的所有用户
        /// </summary>
        /// <param name="Date">开始时间</param>
        IQueryable<string> GetUserNameByDate(DateTime Date);

        /// <summary>
        /// 得到用户最新的变更日志
        /// </summary>
        /// <param name="UserID">用户ID</param>
        AT_UserLog GetNewestByUser(string UserID);
    }
}
