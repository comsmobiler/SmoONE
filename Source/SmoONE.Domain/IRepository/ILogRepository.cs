using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmoONE.Domain.IRepository
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2016/11
    // 主要内容：  日志的仓储接口,仅用于查询
    // ******************************************************************
    /// <summary>
    /// 日志的仓储接口,仅用于查询
    /// </summary>
    public interface ILogRepository:IRepository<Log>
    {
        /// <summary>
        /// 根据日志ID返回日志对象
        /// </summary>
        /// <param name="ID">日志ID</param>
        IQueryable<Log> GetByID(int ID);

        /// <summary>
        /// 根据用户ID返回日志对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        IQueryable<Log> GetByUserID(string UserID);
    }
}
