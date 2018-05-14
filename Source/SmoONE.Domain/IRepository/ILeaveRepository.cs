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
    // 主要内容：  请假单的仓储接口,仅用于查询
    // ******************************************************************

    /// <summary>
    /// 请假单的仓储接口,仅用于查询
    /// </summary>
    public interface ILeaveRepository : IRepository<Leave>
    {
        /// <summary>
        /// 根据请假单ID返回请假单对象
        /// </summary>
        /// <param name="ID">请假单ID</param>
        IQueryable<Leave> GetByID(string ID);

        /// <summary>
        /// 根据审批用户ID返回待审批请假单传输对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        IQueryable<Leave> GetNewByCheckUsers(string UserID);

        /// <summary>
        /// 根据审批用户ID返回已审批请假单传输对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        IQueryable<Leave> GetCheckedByCheckUsers(string UserID);


        /// <summary>
        /// 根据审批用户ID和状态返回已审批请假单传输对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="Status">状态</param>
        IQueryable<Leave> QueryCheckedByCheckUsers(string UserID, int Status);

        /// <summary>
        /// 根据创建用户ID返回请假单传输对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        IQueryable<Leave> GetByCreateUsers(string UserID);

        /// <summary>
        /// 根据抄送用户ID返回请假单传输对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        IQueryable<Leave> GetByCCTo(string UserID);

        /// <summary>
        /// 得到最大的请假单ID
        /// </summary>
        string GetMaxID();

    }
}