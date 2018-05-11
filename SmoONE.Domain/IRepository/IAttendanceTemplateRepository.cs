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
    // 主要内容： 考勤模板的仓储接口,仅用于查询
    // ******************************************************************
    /// <summary>
    /// 考勤模板的仓储接口,仅用于查询
    /// </summary>
    public interface IAttendanceTemplateRepository : IRepository<AttendanceTemplate>
    {
        /// <summary>
        /// 根据考勤模板ID返回考勤模板对象
        /// </summary>
        /// <param name="ID">考勤模板ID</param>
        IQueryable<AttendanceTemplate> GetByID(string ID);

        /// <summary>
        /// 得到用户当前的考勤模板
        /// </summary>
        /// <param name="UserID">用户ID</param>
        IQueryable<AttendanceTemplate> GetCurrentATByUser(string UserID);

        /// <summary>
        /// 根据日期返回考勤模板对象
        /// </summary>
        /// <param name="Date">日期</param>
        IQueryable<AttendanceTemplate> GetByDate(DateTime Date);

        /// <summary>
        /// 得到最大的成本中心ID
        /// </summary>
        string GetMaxID();     
    }
}
