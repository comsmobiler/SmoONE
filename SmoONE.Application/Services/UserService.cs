using SmoONE.CommLib;
using SmoONE.Domain;
using SmoONE.Domain.IRepository;
using SmoONE.DTOs;
using SmoONE.Infrastructure;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Data.Entity;
using AutoMapper;
using Top.Api;
using Top.Api.Request;
using Top.Api.Response;

namespace SmoONE.Application
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2016/11
    // 主要内容：  用户相关的服务实现
    // ******************************************************************
    /// <summary>
    /// 用户相关的服务实现
    /// </summary>
    public class UserService:IUserService
    {
        /// <summary>
        /// 工作单元的接口
        /// </summary>
        private IUnitOfWork _unitOfWork;

        /// <summary>
        /// 用户的仓储类的接口
        /// </summary>
        private IUserRepository _userRepository;

        /// <summary>
        /// 部门的仓储类的接口
        /// </summary>
        private IDepartmentRepository _departmentRepository;

        /// <summary>
        /// 用户角色的仓储类的接口
        /// </summary>
        private IUserRoleRepository _userRoleRepository;

        /// <summary>
        /// 用户的仓储类的接口
        /// </summary>
        private IRoleRepository _roleRepository;

        /// <summary>
        /// 菜单的仓储类的接口
        /// </summary>
        private IMenuRepository _menuRepository;

        /// <summary>
        /// 验证码的仓储类的接口
        /// </summary>
        private IValidateCodeRepository _validateCodeRepository;

        /// <summary>
        /// 角色菜单的仓储类的接口
        /// </summary>
        private IRoleMenuRepository _roleMenuRepository;

        /// <summary>
        /// 用户服务实现的构造函数
        /// </summary>
        public UserService(IUnitOfWork unitOfWork,
            IUserRepository userRepository,
            IDepartmentRepository departmentRepository,
            IUserRoleRepository userRoleRepository,
            IRoleRepository roleRepository,
            IMenuRepository menuRepository,
            IValidateCodeRepository validateCodeRepository,
            IRoleMenuRepository roleMenuRepository)
        {
            _unitOfWork = unitOfWork;
            _userRepository = userRepository;
            _departmentRepository = departmentRepository;
            _userRoleRepository = userRoleRepository;
            _roleRepository = roleRepository;
            _menuRepository = menuRepository;
            _validateCodeRepository = validateCodeRepository;
            _roleMenuRepository = roleMenuRepository;
        }


        #region 查询
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="Password">基于时间加密后的用户密码（例如201611251213ABCDE加密后的密码）</param>
        public ReturnInfo Login(string UserID, String Password)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            try 
            {
                if (string.IsNullOrEmpty(UserID))
                {
                    RInfo.IsSuccess = false;
                    sb.Append("用户名为空;");
                }
                else
                {
                    bool UserExists = _userRepository.IsExists(UserID);
                    if (UserExists)
                    {
                        string NowPwd = CommLib.DESEncrypt.Decrypt(Password);
                        string Date = NowPwd.Substring(0, 14);
                        string RealPwd = NowPwd.Substring(14, NowPwd.Length - 14);
                        string SavePwd = Encrypt(RealPwd);
                        if (_userRepository.Login(UserID, SavePwd))
                        {
                            DateTime LoginDate = DateTime.ParseExact(Date, "yyyyMMddHHmmss", System.Globalization.CultureInfo.InvariantCulture);
                            if (LoginDate > DateTime.Now.AddSeconds(-30))
                            {
                                RInfo.IsSuccess = true;
                            }
                            else
                            {
                                RInfo.IsSuccess = false;
                                sb.Append("登录时间与系统时间偏差30s以上,登录超时;");
                            }
                        }
                        else
                        {
                            RInfo.IsSuccess = false;
                            sb.Append("密码错误");
                        }
                    }
                    else
                    {
                        RInfo.IsSuccess = false;
                        sb.Append("该用户不存在");
                    }
                }
                //添加日志
                Log l = new Log();
                l.U_ID = UserID;
                l.L_Result = RInfo.IsSuccess.ToString();
                l.L_LoginTime = DateTime.Now;
                AddLog(l);
            }
            catch (Exception ex)
            {
                RInfo.IsSuccess = false;
                sb.Append(ex.Message);
            }

            
            RInfo.ErrorInfo = sb.ToString();
            return RInfo;
        }

        /// <summary>
        /// 手势登录
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="Gestures">手势</param>
        public ReturnInfo GesturesLogin(string UserID, String Gestures)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            try
            {
                if (string.IsNullOrEmpty(UserID))
                {
                    RInfo.IsSuccess = false;
                    sb.Append("用户名为空;");
                }
                else
                {
                    bool UserExists = _userRepository.IsExists(UserID);
                    if (UserExists)
                    {
                        //判断手势是否正确
                        bool GesturesExists = _userRepository.IsGesture(UserID, Gestures);
                        if (GesturesExists)
                        {
                            RInfo.IsSuccess = true;
                        }
                        else
                        {
                            RInfo.IsSuccess = false;
                            sb.Append("手势不正确");
                        }
                    }
                    else
                    {
                        RInfo.IsSuccess = false;
                        sb.Append("该用户不存在");
                    }
                }
                //添加日志
                Log l = new Log();
                l.U_ID = UserID;
                l.L_Result = RInfo.IsSuccess.ToString();
                l.L_LoginTime = DateTime.Now;
                AddLog(l);
            }
            catch (Exception ex)
            {
                RInfo.IsSuccess = false;
                sb.Append(ex.Message);
            }


            RInfo.ErrorInfo = sb.ToString();
            return RInfo;
        }

        /// <summary>
        /// 用户通过验证码登录
        /// </summary>
        /// <param name="PhoneNumber">电话号码</param>
        /// <param name="VCode">验证码</param>
        public ReturnInfo LoginByVCode(string PhoneNumber, String VCode)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            try
            {
                if (string.IsNullOrEmpty(PhoneNumber))
                {
                    RInfo.IsSuccess = false;
                    sb.Append("电话号码不能为空;");
                }
                else
                {
                    if (_userRepository.IsExists(PhoneNumber))
                    {
                        bool IsSendVcode = _validateCodeRepository.IsSendVcode(PhoneNumber);
                        if (IsSendVcode)
                        {
                            DateTime Date = DateTime.Now.AddMinutes(-15);
                            if (_validateCodeRepository.IsValidate(PhoneNumber, VCode, Date))
                            {
                                RInfo.IsSuccess = true;
                            }
                            else
                            {
                                RInfo.IsSuccess = false;
                                sb.Append("验证码错误或者验证超时");
                            }
                        }
                        else
                        {
                            RInfo.IsSuccess = false;
                            sb.Append("未发送过验证码到该号码");
                        }
                    }
                    else
                    {
                        RInfo.IsSuccess = false;
                        sb.Append("该手机号未注册过.");
                    }
                }
                //添加日志
                Log l = new Log();
                l.U_ID = PhoneNumber;
                l.L_Result = RInfo.IsSuccess.ToString();
                l.L_LoginTime = DateTime.Now;
                AddLog(l);
            }
            catch (Exception ex)
            {
                RInfo.IsSuccess = false;
                sb.Append(ex.Message);
            }

            
            RInfo.ErrorInfo = sb.ToString();
            return RInfo;
        }


        /// <summary>
        /// 根据用户ID返回用户对象
        /// </summary>
        /// <param name="ID">用户ID</param>
        public UserDetailDto GetUserByUserID(string ID)
        {
            UserDetailDto u =Mapper.Map<User,UserDetailDto>(_userRepository.GetByID(ID).AsNoTracking().FirstOrDefault());
            if (u != null)
            {
                if (string.IsNullOrEmpty(u.U_ID))
                {
                    u.U_DepName = _departmentRepository.GetByID(u.U_DepID).FirstOrDefault().Dep_Name;
                }
            }
            return u;
        }

        /// <summary>
        /// 查询所有的审批人
        /// </summary>
        public List<UserDto> QueryCheckUsers(string UserName)
        {
            if (string.IsNullOrEmpty(UserName))
            {
                return Mapper.Map<List<User>,List<UserDto>> (_userRepository.GetCheckUsers().AsNoTracking().ToList());
            }
            else
            {
                return Mapper.Map<List<User>,List<UserDto>> (_userRepository.QueryCheckUsers(UserName).ToList());
            }
        }

        /// <summary>
        /// 查询所有的抄送人
        /// </summary>
        public List<UserDto> QueryCCUsers(string UserName)
        {
            if (string.IsNullOrEmpty(UserName))
            {
                return Mapper.Map<List<User>,List<UserDto>> (_userRepository.GetCCUsers().AsNoTracking().ToList());
            }
            else
            {
                return Mapper.Map<List<User>,List<UserDto>>( _userRepository.QueryCCUsers(UserName).AsNoTracking().ToList());
            }
        }

        /// <summary>
        /// 根据用户ID返回用户和部门信息
        /// </summary>
        /// <param name="UserID">用户ID</param>
        public UserDepDto GetUseDepByUserID(string UserID)
        {
            UserDepDto ud =Mapper.Map<User,UserDepDto>( _userRepository.GetByID(UserID).AsNoTracking().FirstOrDefault());
            if (ud != null)
            {
                if (!string.IsNullOrEmpty(ud.Dep_ID))
                {
                    DepDetailDto d =Mapper.Map<Department,DepDetailDto>( _departmentRepository.GetByID(ud.Dep_ID).AsNoTracking().FirstOrDefault());
                    if (d != null)
                    {
                        ud.Dep_Name = d.Dep_Name;                    
                    }
                }
            }
            return ud;
        }

        /// <summary>
        /// 根据角色ID返回角色对象
        /// </summary>
        /// <param name="ID">角色ID</param>
        public Role GetRoleByRoleID(string ID)
        {
            return _roleRepository.GetByID(ID);
        }

        /// <summary>
        /// 根据用户ID返回角色对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        public List<Role> GetRoleByUserID(string UserID)
        {
            List<UserRole> userRoles = _userRoleRepository.GetByUserID(UserID).AsNoTracking().ToList();
            List<Role> roles = new List<Role>();
            foreach (UserRole userRole in userRoles)
            {
                Role role = GetRoleByRoleID(userRole.RoleID);
                roles.Add(role);
            }
            return roles;
        }

        /// <summary>
        /// 得到角色对象列表
        /// </summary>
        public List<Role> GetAllRoles()
        {
            return _roleRepository.GetAll().AsNoTracking().ToList();
        }

        /// <summary>
        /// 根据菜单ID返回菜单对象
        /// </summary>
        /// <param name="ID">菜单ID</param>
        public Menu GetMenuByMenuID(string ID)
        {
            return _menuRepository.GetByID(ID);
        }

        /// <summary>
        /// 根据角色ID返回菜单对象
        /// </summary>
        /// <param name="ID">角色ID</param>
        public List<Menu> GetMenuByRoleID(string RoleID)
        {
            List<string> MenuIDs = _roleMenuRepository.GetMenusByRoleID(RoleID).ToList();
            List<Menu> Menus = new List<Menu>();
            foreach (string MenuID in MenuIDs)
            {
                Menu m = _menuRepository.GetByID(MenuID);
                Menus.Add(m);
            }
            return Menus;
        }

        /// <summary>
        /// 根据用户ID返回菜单对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        public List<Menu> GetMenuByUserID(string UserID)
        {
            List<UserRole> userRoles = _userRoleRepository.GetByUserID(UserID).AsNoTracking().ToList();
            List<Menu> menus = new List<Menu>();
            foreach (UserRole userRole in userRoles)
            {
               List<Menu> menu = GetMenuByRoleID(userRole.RoleID);
               foreach (Menu m in menu)
               {
                   if (!menus.Contains(m))
                   {
                       menus.Add(m);
                   }
               }
            }
            return menus;
        }

        /// <summary>
        /// 根据用户ID和上级菜单返回菜单对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="MenuID">一级菜单ID</param>
        public List<Menu> GetSubMenuByUserID(string UserID, string MenuID)
        {
            List<UserRole> userRoles = _userRoleRepository.GetByUserID(UserID).AsNoTracking().ToList();
            List<Menu> menus = new List<Menu>();
            foreach (UserRole userRole in userRoles)
            {
                List<Menu> menu = GetMenuByRoleID(userRole.RoleID);
                foreach (Menu m in menu)
                {
                    if (!menus.Contains(m)&&m.M_ParentID==MenuID)
                    {
                        menus.Add(m);
                    }
                }
            }
            return menus;
        }


        /// <summary>
        /// 得到所有用户
        /// </summary>
        public List<UserDto> GetAllUsers()
        {
            return Mapper.Map<List<User>,List<UserDto>>( _userRepository.GetAll().AsNoTracking().ToList());
        }


        /// <summary>
        /// 得到某个部门的所有用户
        /// </summary>
        public List<UserDto> GetUserByDepID(string DepartmentID)
        {
            return Mapper.Map<List<User>,List<UserDto>>( _userRepository.GetAll().Where(o => o.U_DepID == DepartmentID).AsNoTracking().ToList());
        }

        /// <summary>
        /// 得到未分配部门的所有用户
        /// </summary>
        public List<UserDto> GetNoDepUser()
        {
            return Mapper.Map<List<User>,List<UserDto>>(_userRepository.GetAll().Where(o => o.U_DepID == null || o.U_DepID == "").AsNoTracking().ToList());
        }

        /// <summary>
        /// 判断该用户ID是否存在
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <returns>true表示存在，false表示不存在</returns>
        public bool IsExists(string UserID)
        {
            return _userRepository.IsExists(UserID);
        }

        /// <summary>
        /// 判断该设备ID是否恶意注册
        /// </summary>
        /// <param name="DeviceID">设备ID</param>
        /// <returns>true表示存在，false表示不存在</returns>
        public bool IsMalicious(string DeviceID)
        {
            return _validateCodeRepository.IsMalicious(DeviceID);
        }

        /// <summary>
        /// 判断当前用户的原密码是否正确
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="Pwd">原密码</param>
        /// <returns>true表示存在，false表示不存在</returns>
        public bool IsPwd(string UserID,string Pwd)
        {
            return _userRepository.GetAll().Any(u=>(u.U_ID==UserID&&u.U_Pwd==Pwd));
        }
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
        public ReturnInfo RegisterByVCode(string PhoneNumber, string Pwd, string Name, List<string> RoleIDs, string VCode)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            if (string.IsNullOrEmpty(PhoneNumber))
            {
                sb.Append("电话号码不能为空.");
            }
            if (string.IsNullOrEmpty(Pwd))
            {
                sb.Append("密码不能为空.");
            }
            if (string.IsNullOrEmpty(Name))
            {
                sb.Append("昵称不能为空.");
            }
            if (string.IsNullOrEmpty(VCode))
            {
                sb.Append("验证码不能为空.");
            }
            if (RoleIDs.Count == 0)
            {
                sb.Append("角色不能为空.");
            }
            if (sb.ToString().Length>0)
            {
                RInfo.IsSuccess = false;
                RInfo.ErrorInfo = sb.ToString();
                return RInfo;
            }
            else
            {
                if (PhoneNumber.Length == 11 && (Regex.IsMatch(PhoneNumber, @"^1(3[0-9]|4[57]|5[0-35-9]|7[0135678]|8[0-9])\d{8}$")))
                {
                    bool IsSend = _validateCodeRepository.IsSendVcode(PhoneNumber);
                    if (IsSend)
                    {
                        bool UserExists = _userRepository.IsExists(PhoneNumber);
                        if (!UserExists)
                        {
                            DateTime Date = DateTime.Now.AddMinutes(-15);
                            bool IsValidate = _validateCodeRepository.IsValidate(PhoneNumber, VCode,Date);
                            if(IsValidate)
                            {
                                User entity = new User();
                                entity.U_ID = PhoneNumber;
                                entity.U_IsCC = 1;                                
                                //部分模块,管理员才有审批权限
                                if (RoleIDs.Contains("Administrator"))
                                {
                                    entity.U_IsCheck = 1;
                                }
                                else
                                {
                                    entity.U_IsCheck = 0;
                                }
                                entity.U_Pwd = Pwd;
                                entity.U_Name = Name;
                                entity.U_CreateDate = DateTime.Now;
                                entity.U_Sex = (int)Sex.男;
                                entity.U_Tel = PhoneNumber;
                                entity.U_Birthday = DateTime.Now;
                                _unitOfWork.RegisterNew(entity);
                                foreach (string RoleID in RoleIDs)
                                {
                                    UserRole ur = new UserRole();
                                    ur.UserID = PhoneNumber;
                                    ur.RoleID = RoleID;
                                    _unitOfWork.RegisterNew(ur);
                                }
                                try
                                {                                   
                                    bool result = _unitOfWork.Commit();
                                    RInfo.IsSuccess = result;
                                    RInfo.ErrorInfo = sb.ToString();
                                    return RInfo;
                                }
                                catch (Exception ex)
                                {
                                    _unitOfWork.Rollback();
                                    sb.Append(ex.Message);
                                    RInfo.IsSuccess = false;
                                    RInfo.ErrorInfo = sb.ToString();
                                    return RInfo;
                                }
                                

                            }
                            else
                            {
                                RInfo.IsSuccess = false;
                                sb.Append("该验证码已经失效.");
                            }
                        }
                        else
                        {
                            RInfo.IsSuccess = false;
                            sb.Append("该用户已经注册过.");
                        }
                    }
                    else
                    {
                        RInfo.IsSuccess = false;
                        sb.Append("该手机号码未发送过验证码.");
                    }

                }
                else
                {
                    RInfo.IsSuccess = false;
                    sb.Append("错误的手机号码.");
                }
                RInfo.ErrorInfo = sb.ToString();
                return RInfo;
            }
        }


        /// <summary>
        /// 更新用户
        /// </summary>      
        /// <param name="entity">用户对象</param>
        public ReturnInfo UpdateUser(UserInputDto entity)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            if (entity == null)
            {
                RInfo.IsSuccess = false;
                RInfo.ErrorInfo = "传入了空的用户对象!";
                return RInfo;
            }
            else
            {
                if (string.IsNullOrEmpty(entity.U_ID))
                {
                    RInfo.IsSuccess = false;
                    RInfo.ErrorInfo = "传入了空的用户ID!";
                    return RInfo;
                }
                else
                {
                    User u = _userRepository.GetByID(entity.U_ID).FirstOrDefault();
                    if (u != null)
                    {
                        try
                        {
                            #region 如果字段非空或0,则更新对应字段
                            if (entity.U_Birthday != null)
                            {
                                u.U_Birthday =(DateTime)entity.U_Birthday;
                            }
                            if (entity.U_Email != null)
                            {
                                u.U_Email = entity.U_Email;
                            }
                            if (entity.U_Name != null)
                            {
                                u.U_Name = entity.U_Name;
                            }
                            if (entity.U_Portrait != null)
                            {
                                u.U_Portrait = entity.U_Portrait;
                            }
                            if (entity.U_Sex != null)
                            {
                                u.U_Sex =(int)entity.U_Sex;
                            }
                            if (entity.U_Gestures  != null)
                            {
                                u.U_Gestures = entity.U_Gestures;
                            }
                            #endregion
                            _unitOfWork.RegisterDirty(u);
                            bool result = _unitOfWork.Commit();
                            RInfo.IsSuccess = result;
                            RInfo.ErrorInfo = sb.ToString();
                            return RInfo;
                        }
                        catch (Exception ex)
                        {
                            _unitOfWork.RegisterClean(u);
                            _unitOfWork.Rollback();
                            sb.Append(ex.Message);
                            RInfo.IsSuccess = false;
                            RInfo.ErrorInfo = sb.ToString();
                            return RInfo;
                        }
                    }
                    else
                    {
                        RInfo.IsSuccess = false;
                        RInfo.ErrorInfo = "找不到该用户!";
                        return RInfo;
                    }
                }
            }
        }


        /// <summary>
        /// 修改密码
        /// </summary>      
        /// <param name="UserID">用户ID</param>
        /// <param name="OldPwd">加密后的原密码</param>
        /// <param name="NewPwd">加密后的新密码</param>
        public ReturnInfo ChangePwd(string UserID, string OldPwd, string NewPwd)
        {
            ReturnInfo RInfo=new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            if (OldPwd == NewPwd)
            {
                RInfo.IsSuccess = false;
                sb.Append("新密码与旧密码相同.");
                return RInfo;
            }
            if (IsPwd(UserID, OldPwd))
            {
                if (string.IsNullOrEmpty(NewPwd))
                {
                    sb.Append("新密码不能为空");
                    RInfo.IsSuccess = false;
                    RInfo.ErrorInfo = sb.ToString();
                    return RInfo;
                }
                else
                {
                    try
                    {
                        User user = _userRepository.GetByID(UserID).FirstOrDefault();
                        if (user != null)
                        {
                            user.U_Pwd = NewPwd;
                            bool result = _unitOfWork.Commit();
                            RInfo.IsSuccess = result;
                            RInfo.ErrorInfo = sb.ToString();
                            return RInfo;
                        }
                        else
                        {
                            RInfo.IsSuccess = false;
                            RInfo.ErrorInfo = "找不到该用户!";
                            return RInfo;
                        }
                    }
                    catch (Exception ex)
                    {
                        _unitOfWork.Rollback();
                        sb.Append(ex.Message);
                        RInfo.IsSuccess = false;
                        RInfo.ErrorInfo = sb.ToString();
                        return RInfo;
                    }

                }
            }
            else
            {
                RInfo.IsSuccess = false;
                sb.Append("用户名和旧密码中存在错误.");
            }
            return RInfo;
        }

        /// <summary>
        /// 添加日志
        /// </summary>
        /// <param name="entity">日志对象</param>
        public bool AddLog(Log entity)
        {
            entity.L_LoginTime = DateTime.Now;
            string ValidateInfo = "";
            if (string.IsNullOrEmpty(ValidateInfo))
            {
                try
                {
                    _unitOfWork.RegisterNew(entity);
                    bool result = _unitOfWork.Commit();
                    return result;
                }
                catch (Exception ex)
                {
                    _unitOfWork.Rollback();
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 分配用户角色
        /// </summary>
        /// <param name="entitys">用户角色对象列表</param>
        public ReturnInfo AssignUserRole(List<UserRole> entitys)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            if (entitys.Count > 0)
            {
                List<string> RoleIDs = new List<string>();
                foreach (UserRole entity in entitys)
                {
                    RoleIDs.Add(entity.RoleID);
                }
                List<string> OldRoleIDs = _userRoleRepository.GetByUserIDEx(entitys[0].UserID).ToList();
                List<string> Add = RoleIDs.Except(OldRoleIDs).ToList();
                List<string> Delete = OldRoleIDs.Except(RoleIDs).ToList();
                try
                {
                    foreach (string addID in Add)
                    {
                        UserRole entity = new UserRole();
                        entity.UserID = entitys[0].UserID;
                        entity.RoleID = addID;
                        _unitOfWork.RegisterDirty(entity);
                    }
                    foreach (string deleteID in Delete)
                    {
                        UserRole entity = _userRoleRepository.GetIDByUserIDAndRoleID(entitys[0].UserID,deleteID).FirstOrDefault();
                        _unitOfWork.RegisterDeleted(entity);
                    }
                    bool result = _unitOfWork.Commit();
                    RInfo.IsSuccess = result;
                    RInfo.ErrorInfo = sb.ToString();
                    return RInfo;
                }
                catch (Exception ex)
                {
                    _unitOfWork.Rollback();
                    sb.Append(ex.Message);
                    RInfo.IsSuccess = false;
                    RInfo.ErrorInfo = sb.ToString();
                    return RInfo;
                }
            }
            else
            {
                RInfo.IsSuccess = false;
                RInfo.ErrorInfo = "用户角色不能为空";
                return RInfo;
            }
        }



        #endregion


        #region 其他操作        
        /// <summary>
        /// 发送验证码
        /// </summary>
        /// <param name="PhoneNumber">发送的手机号</param>
        /// <param name="DeviceID">设备ID</param>
        public ReturnInfo SendVCode(string PhoneNumber,string DeviceID)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            if (PhoneNumber.Length == 11 && (Regex.IsMatch(PhoneNumber, @"^1(3[0-9]|4[57]|5[0-35-9]|7[0135678]|8[0-9])\d{8}$")))
            {
                try
                {
                    Random rad = new Random();//实例化随机数产生器rad；
                    int value = rad.Next(1000, 10000);//用rad生成大于等于1000，小于等于9999的随机数；
                    //appkey为你在http://www.alidayu.com/上申请的Appkey(此处以****代替),appSecret为对应的appSecret(此处以****代替)
                    ITopClient client = new DefaultTopClient("http://gw.api.taobao.com/router/rest", "****", "****");
                    AlibabaAliqinFcSmsNumSendRequest req = new AlibabaAliqinFcSmsNumSendRequest();
                    //回传参数
                    req.Extend = "123456";
                    //短信状态,一般为normal
                    req.SmsType = "normal";
                    //短信签名
                    req.SmsFreeSignName = "注册验证";
                    //短信模板中的字段对应值
                    req.SmsParam = "{\"code\":\""+value.ToString()+"\",\"product\":\"SmoONE\"}";
                    //发送的号码
                    req.RecNum = PhoneNumber;
                    //短信模板ID
                    req.SmsTemplateCode = "****";
                    //服务器返回的执行结果
                    AlibabaAliqinFcSmsNumSendResponse rsp = client.Execute(req);                    
                    if (rsp.IsError==false)
                    {
                        ValidateCode entity = new ValidateCode();
                        entity.V_PhoneNumber = PhoneNumber;
                        entity.V_UpdateDate = DateTime.Now;
                        entity.V_VCode = value.ToString();
                        entity.V_DeviceID = DeviceID;
                        _unitOfWork.RegisterNew(entity);
                        bool result = _unitOfWork.Commit();
                        if (result)
                        {
                            RInfo.IsSuccess = true;
                        }
                        else
                        {
                            RInfo.IsSuccess = false;                            
                            sb.Append("短信发送成功,但是入库失败.");
                        }
                    }
                    else
                    {
                        RInfo.IsSuccess = false;
                        if (rsp.SubErrMsg == "触发业务流控限制")
                        {
                            sb.Append("对同一个手机号码允许每分钟发送1条短信验证码，累计每小时7条,允许每天50条.");
                        }
                        else if (rsp.SubErrMsg == "业务停机")
                        {
                            sb.Append("业务停机,请登陆www.alidayu.com充值.");
                        }
                        else if (rsp.SubErrMsg == "余额不足")
                        {
                            sb.Append("余额不足未能发送成功，请登录阿里云管理中心充值后重新发送.");
                        }
                        else
                        {
                            sb.Append("发送验证码失败.");
                        }
                    };
                }
                catch (Exception ex)
                {
                    RInfo.IsSuccess = false;
                    sb.Append(ex.Message);
                }

                
            }
            else
            {
                RInfo.IsSuccess = false;
                sb.Append("错误的电话号码.");
            }
            RInfo.ErrorInfo = sb.ToString();
            return RInfo;

        }

        /// <summary>
        /// 模拟发送验证码
        /// </summary>
        /// <param name="PhoneNumber">发送的手机号</param>
        public ReturnInfo SimulateSendVCode(string PhoneNumber)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            if (PhoneNumber.Length == 11 && (Regex.IsMatch(PhoneNumber, @"^1(3[0-9]|4[57]|5[0-35-9]|7[0135678]|8[0-9])\d{8}$")))
            {
                try
                {
                    int value = 1234;
                    ValidateCode entity = new ValidateCode();
                    entity.V_PhoneNumber = PhoneNumber;
                    entity.V_UpdateDate = DateTime.Now;
                    entity.V_VCode = value.ToString();
                    entity.V_DeviceID = "使用验证码登录";
                    _unitOfWork.RegisterNew(entity);
                    bool result = _unitOfWork.Commit();
                    if (result)
                    {
                        RInfo.IsSuccess=true;
                        sb.Append(value.ToString());
                    }
                    else
                    {
                        RInfo.IsSuccess = false;
                        sb.Append("验证码入库失败.");
                    }
                }
                catch (Exception ex)
                {
                    RInfo.IsSuccess = false;
                    sb.Append(ex.Message);
                }
            }
            else
            {
                RInfo.IsSuccess = false;
                sb.Append("错误的电话号码.");
            }
            RInfo.ErrorInfo = sb.ToString();
            return RInfo;            
        }



        /// <summary>
        /// 加密密码
        /// </summary>
        /// <param name="Pwd">密码</param>
        public string Encrypt(string Pwd)
        {
            return DESEncrypt.Encrypt(Pwd);
        }
        #endregion
    }
}
