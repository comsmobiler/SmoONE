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
    // 主要内容：  角色菜单的仓储接口,仅用于查询
    // ******************************************************************
    /// <summary>
    /// 角色菜单的仓储接口,仅用于查询
    /// </summary>
    public interface IRoleMenuRepository
    {
        /// <summary>
        /// 根据角色ID返回菜单ID列表
        /// </summary>
        /// <param name="RoleID">角色ID</param>
        IQueryable<string> GetMenusByRoleID(string RoleID);
    }
}
