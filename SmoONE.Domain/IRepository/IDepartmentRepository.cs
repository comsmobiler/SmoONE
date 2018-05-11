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
    // 主要内容：  部门的仓储接口,仅用于查询
    // ******************************************************************
    /// <summary>
    /// 部门的仓储接口,仅用于查询
    /// </summary>
    public interface IDepartmentRepository:IRepository<Department>
    {
        /// <summary>
        /// 根据部门ID返回部门对象
        /// </summary>
        /// <param name="ID">部门ID</param>
        IQueryable<Department> GetByID(string ID);

        /// <summary>
        /// 得到最大的部门ID
        /// </summary>
        string GetMaxID();

        /// <summary>
        /// 查询该用户是否已经是责任人
        /// </summary>
        bool IsLeader(string UserID);

    }
}
