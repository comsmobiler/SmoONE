using SmoONE.Domain;
using SmoONE.Domain.IRepository;
using SmoONE.DTOs;
using SmoONE.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmoONE.Repository
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
    public class UserRoleRepository: BaseRepository<UserRole>, IUserRoleRepository
    {
        /// <summary>
        /// 仓储类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public UserRoleRepository(IDbContext dbContext)
            : base(dbContext)
        { }

        /// <summary>
        /// 根据用户角色ID返回用户角色对象
        /// </summary>
        /// <param name="ID">用户角色ID</param>
        public UserRole GetByID(int ID)
        {
            return _entities.Where(x => x.ID == ID).FirstOrDefault();
        }

        /// <summary>
        /// 根据用户ID返回用户角色对象
        /// </summary>
        /// <param name="ID">用户ID</param>
        public IQueryable<UserRole> GetByUserID(string UserID)
        {
            return _entities.Where(x => x.UserID == UserID);
        }

        /// <summary>
        /// 根据用户ID返回角色ID清单
        /// </summary>
        /// <param name="UserID">用户ID</param>
        public IQueryable<string> GetByUserIDEx(string UserID)
        {
            return _entities.Where(x => x.UserID == UserID).Select(o=>o.RoleID);
        }

        /// <summary>
        /// 根据用户ID和角色ID返回用户角色ID
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="RoleID">角色ID</param>
        public IQueryable<UserRole> GetIDByUserIDAndRoleID(string UserID, string RoleID)
        {
            return _entities.Where(x => x.UserID == UserID&&x.RoleID==RoleID); 
        }
    }
}
