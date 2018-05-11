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
    // 主要内容：  用户类的仓储接口,仅用于查询
    // ******************************************************************
    /// <summary>
    /// 用户类的仓储接口,仅用于查询
    /// </summary>
    public interface IUserRepository : IRepository<User>
    {
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="Password">用户密码</param>
        /// <returns>true表示成功，false表示失败</returns>
        bool Login(string UserID, String Password);


        /// <summary>
        /// 判断该用户ID是否存在
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <returns>true表示存在，false表示不存在</returns>
        bool IsExists(string UserID);

        /// <summary>
        /// 判断该用户ID手势是否正确
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="Gestures">手势</param>
        bool IsGesture(string UserID, String Gestures);


        /// <summary>
        /// 根据用户ID返回用户对象
        /// </summary>
        /// <param name="ID">用户ID</param>
        IQueryable<User> GetByID(string ID);

        /// <summary>
        /// 得到所有的审批人
        /// </summary>
        IQueryable<User> GetCheckUsers();

        /// <summary>
        /// 得到所有的抄送人
        /// </summary>
        IQueryable<User> GetCCUsers();

        /// <summary>
        /// 查询所有的审批人
        /// </summary>
        IQueryable<User> QueryCheckUsers(string UserName);

        /// <summary>
        /// 查询所有的抄送人
        /// </summary>
        IQueryable<User> QueryCCUsers(string UserName);

        /// <summary>
        /// 得到最大的用户ID
        /// </summary>
        string GetMaxID();
    }
}
