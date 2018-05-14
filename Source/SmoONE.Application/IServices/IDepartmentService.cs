using SmoONE.CommLib;
using SmoONE.Domain;
using SmoONE.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmoONE.Application
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2016/11
    // 主要内容：  部门的服务接口
    // ******************************************************************
    /// <summary>
    /// 部门的服务接口
    /// </summary>
    public interface IDepartmentService
    {
        #region 查询
        /// <summary>
        /// 根据部门ID返回部门对象
        /// </summary>
        /// <param name="ID">部门ID</param>
        DepDetailDto GetDepartmentByDepID(string ID);

        /// <summary>
        /// 得到所有部门
        /// </summary>
        List<DepartmentDto> GetAllDepartment();

        /// <summary>
        /// 查询该用户是否已经是责任人
        /// </summary>
        bool IsLeader(string UserID);

        #endregion

        #region 操作
        /// <summary>
        /// 添加部门
        /// </summary>
        /// <param name="entity">部门对象</param>
        ReturnInfo AddDepartment(DepInputDto entity);

        /// <summary>
        /// 更新部门
        /// </summary>
        /// <param name="entity">部门对象</param>
        ReturnInfo UpdateDepartment(DepInputDto entity);

        /// <summary>
        /// 分配人员
        /// </summary>
        /// <param name="UserIDs">用户ID列表</param>
        /// <param name="DepartmentID">部门ID</param>
        ReturnInfo AssignUserToDepartment(List<string> UserIDs, string DepartmentID);

        /// <summary>
        /// 删除部门
        /// </summary>
        /// <param name="DepartmentID">部门对象ID</param>
        ReturnInfo DeleteDepartment(string DepartmentID);
        #endregion

    }
}
