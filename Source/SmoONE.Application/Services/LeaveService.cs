using SmoONE.Domain;
using SmoONE.Domain.IRepository;
using SmoONE.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;
using SmoONE.DTOs;
using SmoONE.CommLib;
using System.Data.Entity;
using AutoMapper;

namespace SmoONE.Application
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2016/11
    // 主要内容：  请假单的服务实现
    // ******************************************************************
    /// <summary>
    /// 请假单的服务实现
    /// </summary>
    public class LeaveService: ILeaveService
    {
        /// <summary>
        /// 工作单元的接口
        /// </summary>
        private IUnitOfWork _unitOfWork;

        /// <summary>
        /// 请假单的仓储类的接口
        /// </summary>
        private ILeaveRepository _leaveRepository;

        /// <summary>
        /// 请假类型的仓储类的接口
        /// </summary>
        private ILeaveTypeRepository _leaveTypeRepository;

        /// <summary>
        /// 用户的仓储类的接口
        /// </summary>
        private IUserRepository _userRepository;


        /// <summary>
        /// 请假单服务实现的构造函数
        /// </summary>
        public LeaveService(IUnitOfWork unitOfWork,
            ILeaveRepository leaveRepository,
            ILeaveTypeRepository leaveTypeRepository,
            IUserRepository userRepository)
        {
            _unitOfWork = unitOfWork;
            _leaveRepository = leaveRepository;
            _leaveTypeRepository = leaveTypeRepository;
            _userRepository = userRepository;
        }

        #region 查询
        /// <summary>
        /// 根据请假单ID返回请假单对象
        /// </summary>
        /// <param name="ID">请假单ID</param>
        public LeaveDetailDto GetByID(string ID)
        {
            LeaveDetailDto lv = Mapper.Map<Leave,LeaveDetailDto> (_leaveRepository.GetByID(ID).AsNoTracking().FirstOrDefault());
            if (lv != null&&!string.IsNullOrEmpty(lv.L_TypeID))
            {
                LeaveType lt = _leaveTypeRepository.GetByID(lv.L_TypeID);
                if (lt != null)
                {
                    lv.L_TypeName = lt.L_T_Name;
                }
            }
            return lv;
        }

        /// <summary>
        /// 根据审批用户ID返回待审批的请假单对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        public List<LeaveDto> GetNewByCheckUsers(string UserID)
        {
            List<LeaveDto> temp = Mapper.Map<List<Leave>,List<LeaveDto>>(_leaveRepository.GetNewByCheckUsers(UserID).AsNoTracking().ToList());
            return GetLeaveDetail(temp);
        }

        /// <summary>
        /// 根据审批用户ID返回已审批的请假单对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        public List<LeaveDto> GetCheckedByCheckUsers(string UserID)
        {
            List<LeaveDto> temp = Mapper.Map<List<Leave>,List<LeaveDto>>( _leaveRepository.GetCheckedByCheckUsers(UserID).AsNoTracking().ToList());
            return GetLeaveDetail(temp);
        }

        /// <summary>
        /// 根据审批用户ID和状态返回已审批请假单传输对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="Status">状态</param>
        public List<LeaveDto> QueryCheckedByCheckUsers(string UserID, int Status)
        {
            List<LeaveDto> temp = Mapper.Map<List<Leave>,List<LeaveDto>>( _leaveRepository.QueryCheckedByCheckUsers(UserID,Status).AsNoTracking().ToList());
            return GetLeaveDetail(temp);
        }

        /// <summary>
        /// 根据创建用户ID返回请假单传输对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        public List<LeaveDto> GetByCreateUsers(string UserID)
        {
            List<LeaveDto> temp =Mapper.Map<List<Leave>,List<LeaveDto>>(_leaveRepository.GetByCreateUsers(UserID).AsNoTracking().ToList());
            return GetLeaveDetail(temp);
        }

        /// <summary>
        /// 根据抄送用户ID返回请假单传输对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        public List<LeaveDto> GetByCCTo(string UserID)
        {
            List<LeaveDto> temp =Mapper.Map<List<Leave>,List<LeaveDto>>( _leaveRepository.GetByCCTo(UserID).AsNoTracking().ToList());
            return GetLeaveDetail(temp);
        }

        /// <summary>
        /// 根据请假类型ID返回请假类型名称
        /// </summary>
        /// <param name="TypeID">请假类型ID</param>
        public string GetTypeNameByID(string TypeID)
        {
            return _leaveTypeRepository.GetByID(TypeID).L_T_Name;
        }

        /// <summary>
        /// 得到所有的请假类型
        /// </summary>
        public List<LeaveType> GetAllType()
        {
            return _leaveTypeRepository.GetAll().AsNoTracking().ToList();
        }
        #endregion


        #region 操作
        /// <summary>
        /// 添加请假单
        /// </summary>
        /// <param name="lvInputDto">请假单对象</param>
        public ReturnInfo AddLeave(LeaveInputDto lvInputDto)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            string MaxID = _leaveRepository.GetMaxID();
            string NowID = Helper.GenerateID("Lv", MaxID);
            lvInputDto.L_ID = NowID;
            string ValidateInfo = Helper.ValidateLeaveInputDto(lvInputDto);
            sb.Append(ValidateInfo);
            if (string.IsNullOrEmpty(ValidateInfo))
            {
                try
                {                  
                    Leave entity = Mapper.Map<LeaveInputDto,Leave>(lvInputDto);
                    entity.L_CreateDate = DateTime.Now;
                    entity.L_Status = (int)L_Status.新建;
                    entity.L_UpdateDate = DateTime.Now;
                    if (lvInputDto.L_EndDate != null)
                    {
                        entity.L_EndDate = (DateTime)lvInputDto.L_EndDate;
                    }                   
                    if (lvInputDto.L_StartDate != null)
                    {
                        entity.L_StartDate = (DateTime)lvInputDto.L_StartDate;
                    }                    
                    string MaxID2 = _leaveRepository.GetMaxID();
                    string NowID2 = Helper.GenerateID("Lv", MaxID2);
                    entity.L_ID = NowID2;
                    _unitOfWork.RegisterNew(entity);
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
        /// 更新请假单
        /// </summary>
        /// <param name="entity">请假单对象</param>
        public ReturnInfo UpdateLeave(LeaveInputDto entity)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            string ValidateInfo = Helper.ValidateLeaveInputDto(entity);
            sb.Append(ValidateInfo);
            if (string.IsNullOrEmpty(ValidateInfo))
            {
                Leave lv = _leaveRepository.GetByID(entity.L_ID).FirstOrDefault();
                if (lv != null)
                {
                    Leave lv2 = _leaveRepository.GetByID(entity.L_ID).AsNoTracking().FirstOrDefault();
                    if (lv2.L_Status >= (int)L_Status.已审批)
                    {
                        RInfo.IsSuccess = false;
                        RInfo.ErrorInfo = "只有新建和已拒绝的才能修改!";
                        return RInfo;
                    }
                    else
                    {

                        try
                        {
                            #region 如果字段非空或0,则更新对应字段
                            if (entity.L_CCTo != null)
                            {
                                lv.L_CCTo = entity.L_CCTo;
                            }
                            if (entity.L_CheckUsers != null)
                            {
                                lv.L_CheckUsers = entity.L_CheckUsers;
                            }
                            if (entity.L_EndDate != null)
                            {
                                lv.L_EndDate = (DateTime)entity.L_EndDate;
                            }
                            if (entity.L_Img1 != null)
                            {
                                lv.L_Img1 = entity.L_Img1;
                            }
                            if (entity.L_Img2 != null)
                            {
                                lv.L_Img2 = entity.L_Img2;
                            }
                            if (entity.L_Img3 != null)
                            {
                                lv.L_Img3 = entity.L_Img3;
                            }
                            if (entity.L_Img4 != null)
                            {
                                lv.L_Img4 = entity.L_Img4;
                            }
                            if (entity.L_Img5 != null)
                            {
                                lv.L_Img5 = entity.L_Img5;
                            }
                            if (entity.L_Img6 != null)
                            {
                                lv.L_Img6 = entity.L_Img6;
                            }
                            if (entity.L_Img7 != null)
                            {
                                lv.L_Img7 = entity.L_Img7;
                            }
                            if (entity.L_Img8 != null)
                            {
                                lv.L_Img8 = entity.L_Img8;
                            }
                            if (entity.L_Img9 != null)
                            {
                                lv.L_Img9 = entity.L_Img9;
                            }
                            if (entity.L_LDay > 0)
                            {
                                lv.L_LDay = entity.L_LDay;
                            }
                            if (entity.L_Reason != null)
                            {
                                lv.L_Reason = entity.L_Reason;
                            }
                            if (entity.L_StartDate != null)
                            {
                                lv.L_StartDate = (DateTime)entity.L_StartDate;
                            }
                            lv.L_Status = (int)L_Status.新建;
                            if (entity.L_TypeID != null)
                            {
                                lv.L_TypeID = entity.L_TypeID;
                            }
                            if (entity.L_UpdateUser != null)
                            {
                                lv.L_UpdateUser = entity.L_UpdateUser;
                            }
                            lv.L_UpdateDate = DateTime.Now;
                            lv.L_CurrantCheck = "";
                            #endregion
                            _unitOfWork.RegisterDirty(lv);
                            bool result = _unitOfWork.Commit();
                            RInfo.IsSuccess = result;
                            RInfo.ErrorInfo = sb.ToString();
                            return RInfo;
                        }
                        catch (Exception ex)
                        {
                            _unitOfWork.RegisterClean(lv);
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
                    RInfo.ErrorInfo = "未找到该请假单!";
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
        /// 更新请假单状态
        /// </summary>
        /// <param name="id">请假单ID</param>
        /// <param name="Status">状态</param>
        /// <param name="UserID">更新的用户ID</param>
        /// <param name="RejectionReason">拒绝理由</param>
        public ReturnInfo UpdateLeaveStatus(string ID, L_Status Status,string UserID, string RejectionReason)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            Leave entity = _leaveRepository.GetByID(ID).FirstOrDefault();
            if (entity != null)
            {
                Leave entity2 = _leaveRepository.GetByID(entity.L_ID).AsNoTracking().FirstOrDefault();
                if (entity2.L_Status == (int)L_Status.已审批)
                {
                    RInfo.IsSuccess = false;
                    RInfo.ErrorInfo = "审核通过的不能继续审核!";
                    return RInfo;
                }
                else
                {
                    if (entity2.L_Status + 1 == (int)Status || Status == L_Status.已拒绝)
                    {
                        try
                        {
                            entity.L_UpdateDate = DateTime.Now;
                            entity.L_Status = (int)Status;
                            entity.L_CurrantCheck = UserID;
                            entity.L_UpdateUser = UserID;
                            entity.L_RejectionReason = RejectionReason;
                            _unitOfWork.RegisterDirty(entity);
                            bool result = _unitOfWork.Commit();
                            RInfo.IsSuccess = result;
                            RInfo.ErrorInfo = sb.ToString();
                            return RInfo;
                        }
                        catch (Exception ex)
                        {
                            _unitOfWork.RegisterClean(entity);
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
                        RInfo.ErrorInfo = "错误的审批流程!";
                        return RInfo;
                    }
                }

            }
            else
            {
                RInfo.IsSuccess = false;
                RInfo.ErrorInfo = "该请假单ID不存在!";
                return RInfo;
            }          
        }
        #endregion        

        #region 通用方法
        private List<LeaveDto> GetLeaveDetail(List<LeaveDto> temp)
        {
            List<LeaveDto> Final = new List<LeaveDto>();
            foreach (LeaveDto dto in temp)
            {
                UserDto u = Mapper.Map<User,UserDto>(_userRepository.GetByID(dto.U_ID).AsNoTracking().FirstOrDefault());
                if (u != null)
                {
                    dto.U_Name = u.U_Name;
                    dto.U_Portrait = u.U_Portrait;
                }
                Final.Add(dto);
            }
            return Final;
        }
        #endregion
    }
}
