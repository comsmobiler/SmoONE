using SmoONE.DTOs;
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
    // 主要内容：  报销明细的仓储接口,仅用于查询
    // ******************************************************************
    /// <summary>
    /// 报销明细的仓储接口,仅用于查询
    /// </summary>
    public interface IRB_RowsRepository : IRepository<RB_Rows>
    {
        /// <summary>
        /// 根据报销明细ID返回报销明细对象
        /// </summary>
        /// <param name="ID">报销明细ID</param>
        IQueryable<RB_Rows> GetByID(int ID);

        /// <summary>
        /// 根据报销单ID返回报销明细对象
        /// </summary>
        /// <param name="ID">报销单ID</param>
        IQueryable<RB_Rows> GetByRBID(string RBID);

        /// <summary>
        /// 根据用户ID返回未报销的消费明细对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        IQueryable<RB_Rows> GetByCreateUser(string UserID);
    }
}
