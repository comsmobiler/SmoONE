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
    // 主要内容：  用户角色的仓储接口,仅用于查询
    // ******************************************************************
    /// <summary>
    /// 用户角色的仓储接口,仅用于查询
    /// </summary>
    public interface IUserRoleRepository:IRepository<UserRole>
    {
        /// <summary>
        /// 根据用户角色ID返回用户角色对象
        /// </summary>
        /// <param name="ID">用户角色ID</param>
        UserRole GetByID(int ID);

        /// <summary>
        /// 根据用户ID和角色ID返回用户角色ID
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="RoleID">角色ID</param>
        IQueryable<UserRole> GetIDByUserIDAndRoleID(string UserID,string RoleID);

        /// <summary>
        /// 根据用户ID返回用户角色对象
        /// </summary>
        /// <param name="ID">用户ID</param>
        IQueryable<UserRole> GetByUserID(string UserID);

        /// <summary>
        /// 根据用户ID返回角色ID清单
        /// </summary>
        /// <param name="UserID">用户ID</param>
        IQueryable<string> GetByUserIDEx(string UserID);
    }
}
