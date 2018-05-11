using SmoONE.Domain;
using SmoONE.Domain.IRepository;
using SmoONE.DTOs;
using SmoONE.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SmoONE.Repository
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
    public class RoleMenuRepository: BaseRepository<RoleMenu>, IRoleMenuRepository
    {
        /// <summary>
        /// 仓储类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public RoleMenuRepository(IDbContext dbContext)
            : base(dbContext)
        { }

        /// <summary>
        /// 根据角色ID返回菜单ID列表
        /// </summary>
        /// <param name="RoleID">角色ID</param>
        public IQueryable<string> GetMenusByRoleID(string RoleID)
        {
            return _entities.Where(x => x.RM_RoleID == RoleID).Select(o => o.RM_MenuID);
        }

    }
}
