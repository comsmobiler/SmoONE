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
    // 主要内容：  用户类仓储的实现,仅用于查询
    // ******************************************************************

    /// <summary>
    /// 用户类仓储的实现,仅用于查询
    /// </summary>
    public class UserRepository: BaseRepository<User>, IUserRepository
    {
        /// <summary>
        /// 仓储类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public UserRepository(IDbContext dbContext)
            : base(dbContext)
        { }

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="Password">用户密码</param>
        /// <returns>true表示成功，false表示失败</returns>
        public bool Login(string UserID, String Password)
        {
            return _entities.Any(x => x.U_ID == UserID && x.U_Pwd == Password);
        }

        /// <summary>
        /// 判断该用户ID是否存在
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <returns>true表示存在，false表示不存在</returns>
        public bool IsExists(string UserID)
        {
            return _entities.Any(x => x.U_ID == UserID);
        }

        /// <summary>
        /// 判断该用户ID手势是否正确
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="Gestures">手势</param>
        public bool  IsGesture(string UserID, String Gestures)
        {
            return _entities.Any(x => x.U_ID == UserID && x.U_Gestures ==Gestures );
        }


        /// <summary>
        /// 根据用户ID返回用户对象
        /// </summary>
        /// <param name="ID">用户ID</param>
        public IQueryable<User> GetByID(string ID)
        {
            return _entities.Where(x => x.U_ID == ID);
        }

        /// <summary>
        /// 得到所有的审批人
        /// </summary>
        public IQueryable<User> GetCheckUsers()
        {
            return _entities.Where(x => x.U_IsCheck == 1).AsNoTracking();
        }

        /// <summary>
        /// 得到所有的抄送人
        /// </summary>
        public IQueryable<User> GetCCUsers()
        {
            return _entities.Where(x => x.U_IsCC == 1).AsNoTracking();
        }

        /// <summary>
        /// 查询所有的审批人
        /// </summary>
        public IQueryable<User> QueryCheckUsers(string UserName)
        {
            return _entities.Where(x => x.U_IsCheck == 1 && (x.U_Name.Contains(UserName))).AsNoTracking();
        }

        /// <summary>
        /// 查询所有的抄送人
        /// </summary>
        public IQueryable<User> QueryCCUsers(string UserName)
        {
            return _entities.Where(x => x.U_IsCC == 1 && (x.U_Name.Contains(UserName))).AsNoTracking();
        }

        /// <summary>
        /// 得到最大的用户ID
        /// </summary>
        public string GetMaxID()
        {
            return _entities.Select(e => e.U_ID).Max();
        }      
    }
}
