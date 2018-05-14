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

namespace SmoONE.Application
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2016/11
    // 主要内容：  部门的服务实现
    // ******************************************************************
    /// <summary>
    /// 部门的服务实现
    /// </summary>
    public class DepartmentService:IDepartmentService
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
        /// 部门服务实现的构造函数
        /// </summary>
        public DepartmentService(IUnitOfWork unitOfWork,
            IUserRepository userRepository,
            IDepartmentRepository departmentRepository)
        {
            _unitOfWork = unitOfWork;
            _userRepository = userRepository;
            _departmentRepository = departmentRepository;
        }

        #region 查询
        /// <summary>
        /// 根据部门ID返回部门对象
        /// </summary>
        /// <param name="ID">部门ID</param>
        public DepDetailDto GetDepartmentByDepID(string ID)
        {
            DepDetailDto d = Mapper.Map<Department,DepDetailDto>( _departmentRepository.GetByID(ID).AsNoTracking().FirstOrDefault());
            if (d != null)
            {
                User u = _userRepository.GetByID(d.Dep_Leader).AsNoTracking().FirstOrDefault();
                if (u != null)
                {
                    d.U_Name = u.U_Name;
                }
            }
            return d;
        }

        /// <summary>
        /// 得到所有部门
        /// </summary>
        public List<DepartmentDto> GetAllDepartment()
        {           
            List<DepartmentDto> dtos =Mapper.Map<List<Department>,List<DepartmentDto>>( _departmentRepository.GetAll().OrderByDescending(o => o.Dep_ID).AsNoTracking().ToList());
            if (dtos.Count > 0)
            {
                foreach (DepartmentDto dto in dtos)
                {
                    User u = _userRepository.GetByID(dto.Dep_Leader).AsNoTracking().FirstOrDefault();
                    if (u != null)
                    {
                        dto.U_Name = u.U_Name;
                    }
                }
            }
            return dtos;
        }

        /// <summary>
        /// 查询该用户是否已经是责任人
        /// </summary>
        public bool IsLeader(string UserID)
        {
            return _departmentRepository.IsLeader(UserID);
        }
        #endregion


        #region 操作
        /// <summary>
        /// 添加部门
        /// </summary>
        /// <param name="entity">部门对象</param>
        public ReturnInfo AddDepartment(DepInputDto entity)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            string MaxID = _departmentRepository.GetMaxID();
            string NowID = Helper.GenerateID("Dep", MaxID);
            entity.Dep_ID = NowID;
            string ValidateInfo = Helper.ValidateDepInputDto(entity);
            sb.Append(ValidateInfo);
            if (string.IsNullOrEmpty(ValidateInfo))
            {
                try
                {                    
                    Department d = Mapper.Map<DepInputDto,Department>(entity);
                    d.Dep_IsActive = (int)IsActive.激活;
                    d.Dep_UpdateDate = DateTime.Now;
                    string MaxID2 = _departmentRepository.GetMaxID();
                    string NowID2 = Helper.GenerateID("Dep", MaxID2);
                    d.Dep_ID = NowID2;
                    _unitOfWork.RegisterNew(d);
                    foreach (string s in entity.UserIDs)
                    {
                        User u = _userRepository.GetByID(s).FirstOrDefault();
                        u.U_DepID = NowID;
                        _unitOfWork.RegisterDirty(u);
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
                RInfo.ErrorInfo = sb.ToString();
                return RInfo;
            }
        }

        /// <summary>
        /// 更新部门
        /// </summary>
        /// <param name="entity">部门对象</param>
        public ReturnInfo UpdateDepartment(DepInputDto entity)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();          
            string ValidateInfo = Helper.ValidateDepInputDto(entity);
            sb.Append(ValidateInfo);
            if (string.IsNullOrEmpty(ValidateInfo))
            {
                Department d = _departmentRepository.GetByID(entity.Dep_ID).FirstOrDefault();
                if (d == null)
                {
                    RInfo.IsSuccess = false;
                    RInfo.ErrorInfo = "找不到该部门!";
                    return RInfo;
                }
                else
                {
                    try
                    {
                        #region 如果字段非空或0,则更新对应字段
                        if (entity.Dep_Leader != null)
                        {
                            d.Dep_Leader = entity.Dep_Leader;
                        }
                        if (entity.Dep_Name != null)
                        {
                            d.Dep_Name = entity.Dep_Name;
                        }
                        if (entity.Dep_OtherDay > 0)
                        {
                            d.Dep_OtherDay = entity.Dep_OtherDay;
                        }
                        if (entity.Dep_ProDay > 0)
                        {
                            d.Dep_ProDay = entity.Dep_ProDay;
                        }
                        d.Dep_UpdateDate = DateTime.Now;
                        if (entity.Dep_UpdateUser != null)
                        {
                            d.Dep_UpdateUser = entity.Dep_UpdateUser;
                        }
                        if (entity.Dep_Icon != null)
                        {
                            d.Dep_Icon = entity.Dep_Icon;
                        }
                        #endregion
                        _unitOfWork.RegisterDirty(d);
                        List<string> OldIDs = GetUserByDepID(entity.Dep_ID).Select(o => o.U_ID).ToList();
                        List<string> Add = entity.UserIDs.Except(OldIDs).ToList();
                        List<string> Delete = OldIDs.Except(entity.UserIDs).ToList();
                        if (Add.Count > 0)
                        {
                            foreach (string addID in Add)
                            {
                                if (!string.IsNullOrEmpty(addID))
                                {
                                    User u = _userRepository.GetByID(addID).FirstOrDefault();
                                    u.U_DepID = entity.Dep_ID;
                                    _unitOfWork.RegisterDirty(u);
                                }
                                else
                                {
                                    RInfo.IsSuccess = false;
                                    RInfo.ErrorInfo = "不能存在空的用户ID!";
                                }
                            }
                        }
                        if (Delete.Count > 0)
                        {
                            foreach (string deleteID in Delete)
                            {
                                if (!string.IsNullOrEmpty(deleteID))
                                {
                                    User u = _userRepository.GetByID(deleteID).FirstOrDefault();
                                    u.U_DepID = "";
                                    _unitOfWork.RegisterDirty(u);
                                }
                                else
                                {
                                    RInfo.IsSuccess = false;
                                    RInfo.ErrorInfo = "不能存在空的用户ID!";
                                }

                            }
                        }
                        bool result = _unitOfWork.Commit();
                        RInfo.IsSuccess = result;
                        RInfo.ErrorInfo = sb.ToString();
                        return RInfo;
                    }
                    catch (Exception ex)
                    {
                        _unitOfWork.RegisterClean(d);
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
                RInfo.ErrorInfo = sb.ToString();
                return RInfo;
            }
        }

        /// <summary>
        /// 分配人员
        /// </summary>
        /// <param name="UserIDs">用户ID列表</param>
        /// <param name="DepartmentID">部门ID</param>
        public ReturnInfo AssignUserToDepartment(List<string> UserIDs, string DepartmentID)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            if (UserIDs.Count > 0)
            {
                if (!string.IsNullOrEmpty(DepartmentID))
                {
                    try
                    {
                        List<string> OldIDs = GetUserByDepID(DepartmentID).Select(o => o.U_ID).ToList();
                        List<string> Add = UserIDs.Except(OldIDs).ToList();
                        List<string> Delete = OldIDs.Except(UserIDs).ToList();
                        if (Add.Count > 0)
                        {
                            foreach (string addID in Add)
                            {
                                if (!string.IsNullOrEmpty(addID))
                                {
                                    User entity = _userRepository.GetByID(addID).FirstOrDefault();
                                    entity.U_DepID = DepartmentID;
                                    _unitOfWork.RegisterDirty(entity);
                                }
                                else
                                {
                                    RInfo.IsSuccess = false;
                                    RInfo.ErrorInfo = "不能存在空的用户ID!";
                                }
                            }
                        }
                        if (Delete.Count > 0)
                        {
                            foreach (string deleteID in Delete)
                            {
                                if (!string.IsNullOrEmpty(deleteID))
                                {
                                    User entity = _userRepository.GetByID(deleteID).FirstOrDefault();
                                    entity.U_DepID = "";
                                    _unitOfWork.RegisterDirty(entity);
                                }
                                else
                                {
                                    RInfo.IsSuccess = false;
                                    RInfo.ErrorInfo = "不能存在空的用户ID!";
                                }

                            }
                        }
                        bool result = _unitOfWork.Commit();
                        RInfo.IsSuccess = result;
                        RInfo.ErrorInfo = sb.ToString();

                    }
                    catch (Exception ex)
                    {
                        _unitOfWork.Rollback();
                        sb.Append(ex.Message);
                        RInfo.IsSuccess = false;
                        RInfo.ErrorInfo = sb.ToString();
                    }
                }
                else
                {
                    RInfo.IsSuccess = false;
                    sb.Append("部门ID不能为空!");
                }


                RInfo.ErrorInfo = sb.ToString();
                return RInfo;
            }
            else
            {
                RInfo.IsSuccess = false;
                RInfo.ErrorInfo = "至少需要一个用户!";
                return RInfo;
            }
        }

        /// <summary>
        /// 删除部门
        /// </summary>
        /// <param name="DepartmentID">部门对象ID</param>
        public ReturnInfo DeleteDepartment(string DepartmentID)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            Department dep = _departmentRepository.GetByID(DepartmentID).FirstOrDefault();
            if (dep != null)
            {
                List<User> users = GetUserByDepID(DepartmentID);
                try
                {                    
                    foreach (User u in users)
                    {
                        u.U_DepID = "";
                        _unitOfWork.RegisterDirty(dep);
                    }
                    _unitOfWork.RegisterDeleted(dep);
                    bool result = _unitOfWork.Commit();
                    RInfo.IsSuccess = result;
                    RInfo.ErrorInfo = sb.ToString();
                }
                catch (Exception ex)
                {
                    foreach (User u in users)
                    {
                        _unitOfWork.RegisterClean(u);
                    }
                    _unitOfWork.RegisterClean(dep);
                    _unitOfWork.Rollback();
                    sb.Append(ex.Message);
                    RInfo.IsSuccess = false;
                    RInfo.ErrorInfo = sb.ToString();
                }
            }
            else
            {
                RInfo.IsSuccess = false;
                sb.Append("不存在ID为" + DepartmentID + "的部门!");
            }

            return RInfo;
        }


        #endregion


        #region 用到的其他方法
        /// <summary>
        /// 得到某个部门的所有用户
        /// </summary>
        public List<User> GetUserByDepID(string DepartmentID)
        {
            return _userRepository.GetAll().Where(o => o.U_DepID == DepartmentID).ToList();
        }
        #endregion
    }
}
