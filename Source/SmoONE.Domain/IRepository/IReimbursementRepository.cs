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
    // 主要内容：  报销单的仓储接口,仅用于查询
    // ******************************************************************
    /// <summary>
    /// 报销单的仓储接口,仅用于查询
    /// </summary>
    public interface IReimbursementRepository : IRepository<Reimbursement>
    {
        /// <summary>
        /// 根据报销单ID返回报销单对象
        /// </summary>
        /// <param name="ID">报销单ID</param>
        IQueryable<Reimbursement> GetByID(string ID);

        /// <summary>
        /// 根据审批用户ID返回待审批报销单传输对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        IQueryable<Reimbursement> GetNewByCheckUsers(string UserID);

        /// <summary>
        /// 根据审批用户ID和状态返回待审批报销单传输对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="Status">状态</param>
        IQueryable<Reimbursement> QueryNewByCheckUsers(string UserID, int Status);


        /// <summary>
        /// 根据审批用户ID返回已审批报销单传输对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        IQueryable<Reimbursement> GetCheckedByCheckUsers(string UserID);


        /// <summary>
        /// 根据审批用户ID和状态返回已审批报销单传输对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="Status">状态</param>
        IQueryable<Reimbursement> QueryCheckedByCheckUsers(string UserID, int Status);

        /// <summary>
        /// 根据创建用户ID返回报销单传输对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        IQueryable<Reimbursement> GetByCreateUsers(string UserID);


        /// <summary>
        /// 根据成本中心返回报销单传输对象
        /// </summary>
        /// <param name="CCID">成本中心ID</param>
        IQueryable<Reimbursement> GetByCCID(string CCID);

        /// <summary>
        /// 得到最大的报销单ID
        /// </summary>
        string GetMaxID();

    }
}
