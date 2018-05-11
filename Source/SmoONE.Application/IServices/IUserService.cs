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
    // 主要内容：  用户的服务接口
    // ******************************************************************
    /// <summary>
    /// 用户的服务接口
    /// </summary>
    public interface IUserService
    {
        #region 查询
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="Password">加密后的用户密码</param>
        ReturnInfo Login(string UserID, String Password);

        /// <summary>
        /// 手势登录
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="Gestures">手势</param>
        ReturnInfo GesturesLogin(string UserID, String Gestures);

        /// <summary>
        /// 用户通过验证码登录
        /// </summary>
        /// <param name="PhoneNumber">电话号码</param>
        /// <param name="VCode">验证码</param>
        ReturnInfo LoginByVCode(string PhoneNumber, String VCode);

        /// <summary>
        /// 根据用户ID返回用户对象
        /// </summary>
        /// <param name="ID">用户ID</param>
        UserDetailDto GetUserByUserID(string ID);

        /// <summary>
        /// 查询所有的审批人
        /// </summary>
        List<UserDto> QueryCheckUsers(string UserName);

        /// <summary>
        /// 查询所有的抄送人
        /// </summary>
        List<UserDto> QueryCCUsers(string UserName);

        /// <summary>
        /// 根据用户ID返回用户和部门信息
        /// </summary>
        /// <param name="UserID">用户ID</param>
        UserDepDto GetUseDepByUserID(string UserID);

        /// <summary>
        /// 根据角色ID返回角色对象
        /// </summary>
        /// <param name="ID">角色ID</param>
        Role GetRoleByRoleID(string ID);

        /// <summary>
        /// 根据用户ID返回角色对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        List<Role> GetRoleByUserID(string UserID);

        /// <summary>
        /// 得到角色对象列表
        /// </summary>
        List<Role> GetAllRoles();

        /// <summary>
        /// 根据菜单ID返回菜单对象
        /// </summary>
        /// <param name="ID">菜单ID</param>
        Menu GetMenuByMenuID(string ID);

        /// <summary>
        /// 根据角色ID返回菜单对象
        /// </summary>
        /// <param name="RoleID">角色ID</param>
        List<Menu> GetMenuByRoleID(string RoleID);

        /// <summary>
        /// 根据用户ID返回菜单对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        List<Menu> GetMenuByUserID(string UserID);

        /// <summary>
        /// 根据用户ID和上级菜单返回菜单对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="MenuID">一级菜单ID</param>
        List<Menu> GetSubMenuByUserID(string UserID,string MenuID);

        /// <summary>
        /// 得到所有用户
        /// </summary>
        List<UserDto> GetAllUsers();

        /// <summary>
        /// 得到某个部门的所有用户
        /// </summary>
        List<UserDto> GetUserByDepID(string DepartmentID);

        /// <summary>
        /// 得到未分配部门的所有用户
        /// </summary>
        List<UserDto> GetNoDepUser();

        /// <summary>
        /// 判断该用户ID是否存在
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <returns>true表示存在，false表示不存在</returns>
        bool IsExists(string UserID);

        /// <summary>
        /// 判断该设备ID是否恶意注册
        /// </summary>
        /// <param name="DeviceID">设备ID</param>
        /// <returns>true表示存在，false表示不存在</returns>
        bool IsMalicious(string DeviceID);

        /// <summary>
        /// 判断当前用户的原密码是否正确
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="Pwd">原密码</param>
        /// <returns>true表示存在，false表示不存在</returns>
        bool IsPwd(string UserID, string Pwd);
        #endregion

        #region 增删改操作
        /// <summary>
        /// 通过验证码注册用户
        /// </summary>
        /// <param name="PhoneNumber">电话号码</param>
        /// <param name="Pwd">加密后的密码</param>
        /// <param name="Name">用户昵称</param>
        /// <param name="RoleIDs">用户角色列表</param>
        /// <param name="VCode">验证码</param>
        ReturnInfo RegisterByVCode(string PhoneNumber,string Pwd,string Name,List<string> RoleIDs,string VCode);

        /// <summary>
        /// 更新用户
        /// </summary>      
        /// <param name="entity">用户对象</param>
        ReturnInfo UpdateUser(UserInputDto entity);


        /// <summary>
        /// 修改密码
        /// </summary>      
        /// <param name="UserID">用户ID</param>
        /// <param name="OldPwd">原密码</param>
        /// <param name="NewPwd">新密码</param>
        ReturnInfo ChangePwd(string UserID, string OldPwd, string NewPwd);

        /// <summary>
        /// 添加日志
        /// </summary>
        /// <param name="entity">日志对象</param>
        bool AddLog(Log entity);
        
        /// <summary>
        /// 分配用户角色
        /// </summary>
        /// <param name="entitys">用户角色对象列表</param>
        ReturnInfo AssignUserRole(List<UserRole> entitys);

        #endregion

        #region 其他操作
        /// <summary>
        /// 发送验证码
        /// </summary>
        /// <param name="PhoneNumber">发送的手机号</param>
        /// <param name="DeviceID">设备ID</param>
        ReturnInfo SendVCode(string PhoneNumber,string DeviceID);

        /// <summary>
        /// 模拟发送验证码
        /// </summary>
        /// <param name="PhoneNumber">发送的手机号</param>
        ReturnInfo SimulateSendVCode(string PhoneNumber);

        /// <summary>
        /// 加密密码
        /// </summary>
        /// <param name="Pwd">密码</param>
        string Encrypt(string Pwd);
        #endregion
    }
}
