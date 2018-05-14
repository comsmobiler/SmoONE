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
    // 主要内容： 考勤模板的自定义日期的仓储接口,仅用于查询
    // ******************************************************************
    /// <summary>
    /// 考勤模板的自定义日期的仓储接口,仅用于查询
    /// </summary>
    public interface IAT_CustomDateRepository : IRepository<AT_CustomDate>
    {
        /// <summary>
        /// 根据自定义日期ID返回自定义日期对象
        /// </summary>
        /// <param name="ID">自定义日期ID</param>
        IQueryable<AT_CustomDate> GetByID(int ID);

        /// <summary>
        /// 根据考勤模板ID返回自定义日期对象
        /// </summary>
        /// <param name="ATID">考勤模板ID</param>
        IQueryable<AT_CustomDate> GetByATID(string ATID);

        /// <summary>
        /// 判断某考勤模板ID和日期是否存在自定义日期对象
        /// </summary>
        /// <param name="ATID">考勤模板ID</param>
        /// <param name="Date">日期</param>
        bool IsExistByATIDandDate(string ATID,DateTime Date);

        /// <summary>
        /// 根据考勤模板ID和日期返回自定义日期对象
        /// </summary>
        /// <param name="ATID">考勤模板ID</param>
        /// <param name="Date">日期</param>
        IQueryable<AT_CustomDate> GetByATIDandDate(string ATID,DateTime Date);

        /// <summary>
        /// 根据考勤模板ID和时间段返回自定义日期对象
        /// </summary>
        /// <param name="ATID">考勤模板ID</param>
        /// <param name="StartDate">开始日期</param>
        /// <param name="EndDate">结束日期</param>
        IQueryable<AT_CustomDate> GetByATIDandDatePeriod(string ATID, DateTime StartDate,DateTime EndDate);

        /// <summary>
        /// 根据考勤模板ID得到今天之后的自定义日期
        /// </summary>
        /// <param name="ATID">考勤模板ID</param>
        IQueryable<AT_CustomDate> GetFutureATCDByATID(string ATID);   
    }
}
