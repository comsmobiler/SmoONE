using SmoONE.CommLib;
using SmoONE.Domain;
using SmoONE.Domain.IRepository;
using SmoONE.DTOs;
using SmoONE.Infrastructure;
using SmoONE.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using AutoMapper;

namespace SmoONE.Application
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2016/11
    // 主要内容：  报销单的服务实现
    // ******************************************************************
    /// <summary>
    /// 报销单的服务实现
    /// </summary>
    public class ReimbursementService: IReimbursementService
    {
        /// <summary>
        /// 工作单元的接口
        /// </summary>
        private IUnitOfWork _unitOfWork;

        /// <summary>
        /// 报销单的仓储类的接口
        /// </summary>
        private IReimbursementRepository _reimbursementRepository;

        /// <summary>
        /// 报销类型的仓储类的接口
        /// </summary>
        private IRB_TypeRepository _rbTypeRepository;

        /// <summary>
        /// 报销单明细的仓储类的接口
        /// </summary>
        private IRB_RowsRepository _rbrowsRepository;

        /// <summary>
        /// 消费类型的模板的仓储类的接口
        /// </summary>
        private IRB_Type_TemplateRepository _rbTypeTemplateRepository;

        /// <summary>
        /// 成本中心的仓储类的接口
        /// </summary>
        private ICostCenterRepository _costCenterRepository;


        /// <summary>
        /// 成本中心类型的模板的仓储类的接口
        /// </summary>
        private ICC_Type_TemplateRepository _cc_Type_TemplateRepository;

        /// <summary>
        /// 用户的仓储类的接口
        /// </summary>
        private IUserRepository _userRepository;

         /// <summary>
        /// 报销单服务实现的构造函数
        /// </summary>
        public ReimbursementService(IUnitOfWork unitOfWork,
            IReimbursementRepository reimbursementRepository,
            IRB_TypeRepository rbTypeRepository,
            IRB_RowsRepository rbrowsRepository,
            IRB_Type_TemplateRepository rbTypeTemplateRepository,
            ICostCenterRepository costCenterRepository,
            ICC_Type_TemplateRepository cc_Type_TemplateRepository,
            IUserRepository userRepository)
        {
            _unitOfWork = unitOfWork;
            _reimbursementRepository = reimbursementRepository;
            _rbTypeRepository = rbTypeRepository;
            _rbrowsRepository = rbrowsRepository;
            _rbTypeTemplateRepository = rbTypeTemplateRepository;
            _costCenterRepository = costCenterRepository;
            _cc_Type_TemplateRepository = cc_Type_TemplateRepository;
            _userRepository = userRepository;
        }

        #region 查询
        /// <summary>
        /// 根据报销单ID返回报销单对象
        /// </summary>
        /// <param name="ID">报销单ID</param>
        public RBDetailDto GetByID(string ID)
        {
            RBDetailDto rb = Mapper.Map<Reimbursement,RBDetailDto>( _reimbursementRepository.GetByID(ID).AsNoTracking().FirstOrDefault());
            if (rb != null&&!string.IsNullOrEmpty(rb.RB_ID))
            {
                rb.RB_Rows =Mapper.Map<List<RB_Rows>,List<RB_RowsDto>> (_rbrowsRepository.GetByRBID(rb.RB_ID).AsNoTracking().ToList());
                foreach (RB_RowsDto row in rb.RB_Rows)
                {
                    if (!string.IsNullOrEmpty(row.R_TypeID))
                    {
                        row.R_TypeName = _rbTypeRepository.GetByID(row.R_TypeID).RB_RT_Name;
                    }
                }
            }
            return rb;
        }

        /// <summary>
        /// 根据审批用户ID返回待审批报销单传输对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        public List<ReimbursementDto> GetNewByCheckUsers(string UserID)
        {
            List<ReimbursementDto> temp = Mapper.Map<List<Reimbursement>,List<ReimbursementDto>>( _reimbursementRepository.GetNewByCheckUsers(UserID).AsNoTracking().ToList());
            return GetRBDetail(temp);
        }

        /// <summary>
        /// 根据审批用户ID和状态返回待审批报销单传输对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="Status">状态</param>
        public List<ReimbursementDto> QueryNewByCheckUsers(string UserID, int Status)
        {
            List<ReimbursementDto> temp = Mapper.Map<List<Reimbursement>,List<ReimbursementDto>>(_reimbursementRepository.QueryNewByCheckUsers(UserID,Status).AsNoTracking().ToList());
            return GetRBDetail(temp);
        }

        /// <summary>
        /// 根据审批用户ID返回已审批报销单传输对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        public List<ReimbursementDto> GetCheckedByCheckUsers(string UserID)
        {
            List<ReimbursementDto> temp =Mapper.Map<List<Reimbursement>,List<ReimbursementDto>>( _reimbursementRepository.GetCheckedByCheckUsers(UserID).AsNoTracking().ToList());
            return GetRBDetail(temp);
        }

        /// <summary>
        /// 根据审批用户ID和状态返回已审批报销单传输对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="Status">状态</param>
        public List<ReimbursementDto> QueryCheckedByCheckUsers(string UserID, int Status)
        {
            List<ReimbursementDto> temp = Mapper.Map<List<Reimbursement>,List<ReimbursementDto>>( _reimbursementRepository.QueryCheckedByCheckUsers(UserID, Status).AsNoTracking().ToList());
            return GetRBDetail(temp);
        }

        /// <summary>
        /// 根据创建用户ID返回报销单传输对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        public List<ReimbursementDto> GetByCreateUsers(string UserID)
        {
            List<ReimbursementDto> temp = Mapper.Map<List<Reimbursement>,List<ReimbursementDto>>( _reimbursementRepository.GetByCreateUsers(UserID).AsNoTracking().ToList());
            return GetRBDetail(temp);
        }

        /// <summary>
        /// 根据成本中心返回报销单传输对象
        /// </summary>
        /// <param name="CCID">成本中心ID</param>
        public List<ReimbursementDto> GetByCCID(string CCID)
        {
            List<ReimbursementDto> temp = Mapper.Map<List<Reimbursement>, List<ReimbursementDto>>(_reimbursementRepository.GetByCCID(CCID).AsNoTracking().ToList());
            return GetRBDetail(temp);
        }

        /// <summary>
        /// 根据明细金额计算总金额
        /// </summary>
        /// <param name="UserID">用户ID</param>
        public decimal GetTotalAmount(List<decimal> amounts)
        {
            decimal Total = 0;
            foreach (decimal amount in amounts)
            {
                Total += amount;
            }
            return Total;
        }

        /// <summary>
        /// 根据报销类型ID返回报销类型名称
        /// </summary>
        /// <param name="TypeID">报销类型ID</param>
        public string GetTypeNameByID(string TypeID)
        {
            return _rbTypeRepository.GetByID(TypeID).RB_RT_Name;
        }

        /// <summary>
        /// 得到所有的报销类型
        /// </summary>
        public List<RB_RType> GetAllType()
        {
            return _rbTypeRepository.GetAll().AsNoTracking().ToList();
        }

        /// <summary>
        /// 根据消费类型模板ID返回消费类型模板对象
        /// </summary>
        /// <param name="ID">消费类型模板ID</param>
        public RB_RType_TemplateDto GetTemplateByTemplateID(string ID)
        {
            RB_RType_TemplateDto dto = Mapper.Map<RB_RType_Template,RB_RType_TemplateDto> (_rbTypeTemplateRepository.GetByID(ID).AsNoTracking().FirstOrDefault());
            if (!string.IsNullOrEmpty(dto.RB_RTT_TypeID))
            {
                RB_RType rt = _rbTypeRepository.GetByID(dto.RB_RTT_TypeID);
                if (rt != null)
                {
                    dto.RB_TypeName = rt.RB_RT_Name;
                }
            }
            return dto;
        }

        /// <summary>
        /// 根据消费类型ID返回消费类型模板对象
        /// </summary>
        /// <param name="TypeID">消费类型ID</param>
        public List<RB_RType_TemplateDto> GetByTypeID(string TypeID)
        {
            List<RB_RType_TemplateDto> dtos =Mapper.Map<List<RB_RType_Template>,List<RB_RType_TemplateDto>>( _rbTypeTemplateRepository.GetByTypeID(TypeID).AsNoTracking().ToList());
            if (dtos.Count > 0)
            {
                foreach (RB_RType_TemplateDto dto in dtos)
                {
                    if (!string.IsNullOrEmpty(dto.RB_RTT_TypeID))
                    {
                        RB_RType rt = _rbTypeRepository.GetByID(dto.RB_RTT_TypeID);
                        if (rt != null)
                        {
                            dto.RB_TypeName = rt.RB_RT_Name;
                        }
                    }
                }
            }
            return dtos;
        }

        /// <summary>
        /// 根据报销明细ID返回报销明细对象
        /// </summary>
        /// <param name="ID">报销明细ID</param>
        public RB_RowsDto GetRowByRowID(int ID)
        {
            RB_RowsDto rr = Mapper.Map<RB_Rows,RB_RowsDto> (_rbrowsRepository.GetByID(ID).AsNoTracking().FirstOrDefault());
            if (rr != null&&!string.IsNullOrEmpty(rr.R_TypeID))
            {
                RB_RType rt = _rbTypeRepository.GetByID(rr.R_TypeID);
                if (rt != null)
                {
                    rr.R_TypeName = rt.RB_RT_Name;
                }
            }
            return rr;
        }

        /// <summary>
        /// 根据报销单ID返回报销明细对象
        /// </summary>
        /// <param name="ID">报销单ID</param>
        public List<RB_RowsDto> GetRowByRBID(string RBID)
        {
            List<RB_RowsDto> rows = Mapper.Map<List<RB_Rows>,List<RB_RowsDto>> (_rbrowsRepository.GetByRBID(RBID).AsNoTracking().ToList());
            if (rows.Count > 0)
            {
                foreach (RB_RowsDto row in rows)
                {
                    if (!string.IsNullOrEmpty(row.R_TypeID))
                    {
                        RB_RType rt = _rbTypeRepository.GetByID(row.R_TypeID);
                        if (rt != null)
                        {
                            row.R_TypeName = rt.RB_RT_Name;
                        }                        
                    }
                }
            }
            return rows;
        }

        /// <summary>
        /// 根据用户ID返回未报销的消费明细对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        public List<RB_RowsDto> GetRowsByCreateUser(string UserID)
        {
            List<RB_RowsDto> rows = Mapper.Map<List<RB_Rows>,List<RB_RowsDto>>( _rbrowsRepository.GetByCreateUser(UserID).AsNoTracking().ToList());
            if (rows.Count > 0)
            {
                foreach (RB_RowsDto row in rows)
                {
                    if (!string.IsNullOrEmpty(row.R_TypeID))
                    {
                        RB_RType rt = _rbTypeRepository.GetByID(row.R_TypeID);
                        if (rt != null)
                        {
                            row.R_TypeName = rt.RB_RT_Name;
                        }
                    }
                }
            }
            return rows;
        }


        /// <summary>
        /// 根据用户ID返回消费类型模板对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        public List<RB_RType_TemplateDto> GetTemplateByCreateUser(string UserID)
        {
            List<RB_RType_TemplateDto> dtos = Mapper.Map<List<RB_RType_Template>,List<RB_RType_TemplateDto>> (_rbTypeTemplateRepository.GetByCreateUser(UserID).AsNoTracking().ToList());
            if (dtos.Count > 0)
            {
                foreach (RB_RType_TemplateDto dto in dtos)
                {
                    if (!string.IsNullOrEmpty(dto.RB_RTT_TypeID))
                    {
                        RB_RType rt = _rbTypeRepository.GetByID(dto.RB_RTT_TypeID);
                        if (rt != null)
                        {
                            dto.RB_TypeName = rt.RB_RT_Name;
                        }
                    }
                }
            }
            return dtos;
        }
        #endregion


        #region 操作
        /// <summary>
        /// 添加报销单
        /// </summary>
        /// <param name="entity">报销单对象</param>
        public ReturnInfo CreateRB(RBInputDto entity)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            string MaxID = _reimbursementRepository.GetMaxID();
            string NowID = Helper.GenerateID("RB", MaxID);
            entity.RB_ID = NowID;
            string ValidateInfo = Helper.ValidateRBInputDto(entity);
            sb.Append(ValidateInfo);
            if (string.IsNullOrEmpty(ValidateInfo))
            {
                try
                {                   
                    Reimbursement rb = Mapper.Map<RBInputDto,Reimbursement>(entity);
                    rb.RB_CreateDate = DateTime.Now;
                    rb.RB_UpdateDate = DateTime.Now;
                    rb.RB_AEADate = DateTime.Now;
                    rb.RB_FinDate = DateTime.Now;
                    rb.RB_LiableDate = DateTime.Now;
                    rb.RB_Status = (int)RB_Status.新建;
                    rb.RB_CurrantCheck = "";
                    if (!string.IsNullOrEmpty(entity.CC_ID))
                    {
                        CCDetailDto cc =Mapper.Map<CostCenter,CCDetailDto> (_costCenterRepository.GetByID(entity.CC_ID).AsNoTracking().FirstOrDefault());
                        rb.RB_LiableMan = cc.CC_LiableMan;
                        if (!string.IsNullOrEmpty(cc.CC_TemplateID))
                        {
                            CC_Type_TemplateDto ctp =Mapper.Map<CC_Type_Template,CC_Type_TemplateDto>( _cc_Type_TemplateRepository.GetByID(cc.CC_TemplateID).AsNoTracking().FirstOrDefault());
                            rb.RB_AEACheckers = ctp.CC_TT_AEACheckers;
                            rb.RB_FinancialCheckers = ctp.CC_TT_FinancialCheckers;
                        }
                    }
                    decimal Total = 0;
                    string MaxID2 = _reimbursementRepository.GetMaxID();
                    string NowID2 = Helper.GenerateID("RB", MaxID2);
                    rb.RB_ID = NowID2;
                    foreach (RB_RowsInputDto row in entity.RB_Rows)
                    {
                        RB_Rows r = _rbrowsRepository.GetByID(row.R_ID).FirstOrDefault();
                        r.RB_ID = NowID2;
                        _unitOfWork.RegisterDirty(r);
                        Total += row.R_Amount;
                    }
                    rb.RB_TotalAmount = Total;                    
                    _unitOfWork.RegisterNew(rb);
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
        /// 更新报销单
        /// </summary>
        /// <param name="entity">报销单对象</param>
        public ReturnInfo UpdateRB(RBInputDto entity)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            Reimbursement rb = _reimbursementRepository.GetByID(entity.RB_ID).FirstOrDefault();
            if (rb != null)
            {
                Reimbursement rb2 = _reimbursementRepository.GetByID(entity.RB_ID).AsNoTracking().FirstOrDefault();
                if (rb2.RB_Status >= 1)
                {
                    RInfo.IsSuccess = false;
                    RInfo.ErrorInfo = "只有新建和已拒绝的才能修改.";
                    return RInfo;

                }
                else
                {
                    string ValidateInfo = Helper.ValidateRBInputDto(entity);
                    sb.Append(ValidateInfo);
                    if (string.IsNullOrEmpty(ValidateInfo))
                    {
                        try
                        {
                            rb.RB_UpdateDate = DateTime.Now;
                            List<int> OldIDs = _rbrowsRepository.GetByRBID(entity.RB_ID).Select(o=>o.R_ID).ToList();
                            List<int> NewIDs = new List<int>();
                            decimal Total = 0;
                            foreach (RB_RowsInputDto row in entity.RB_Rows)
                            {
                                NewIDs.Add(row.R_ID);
                                Total += row.R_Amount;
                            }
                            rb.RB_TotalAmount = Total;
                            CostCenter cc = _costCenterRepository.GetByID(entity.CC_ID).AsNoTracking().FirstOrDefault();
                            if (cc != null)
                            {
                                rb.RB_LiableMan = cc.CC_LiableMan;
                            }
                            CC_Type_Template ctp = _cc_Type_TemplateRepository.GetByID(cc.CC_TemplateID).AsNoTracking().FirstOrDefault();
                            if (ctp != null)
                            {
                                rb.RB_AEACheckers = ctp.CC_TT_AEACheckers;
                                rb.RB_FinancialCheckers = ctp.CC_TT_FinancialCheckers;
                            }
                            if (entity.CC_ID != null)
                            {
                                rb.CC_ID = entity.CC_ID;
                            }
                            rb.RB_Img1 = entity.RB_Img1;
                            rb.RB_Img2 = entity.RB_Img2;
                            rb.RB_Img3 = entity.RB_Img3;
                            rb.RB_Img4 = entity.RB_Img4;
                            rb.RB_Img5 = entity.RB_Img5;
                            rb.RB_Img6 = entity.RB_Img6;
                            rb.RB_Img7 = entity.RB_Img7;
                            rb.RB_Img8 = entity.RB_Img8;
                            rb.RB_Img9 = entity.RB_Img9;
                            if (entity.RB_Note != null)
                            {
                                rb.RB_Note = entity.RB_Note;
                            }
                            //rb.RB_RejectionReason = entity.RB_RejectionReason;
                            rb.RB_Status = (int)RB_Status.新建;
                            rb.RB_UpdateDate = DateTime.Now;
                            if (entity.RB_UpdateUser != null)
                            {
                                rb.RB_UpdateUser = entity.RB_UpdateUser;
                            }
                            rb.RB_CurrantCheck = "";
                            _unitOfWork.RegisterDirty(rb);
                            List<int> Add = NewIDs.Except(OldIDs).ToList();
                            List<int> Delete = OldIDs.Except(NewIDs).ToList();
                            foreach (int addID in Add)
                            {
                                RB_Rows row = _rbrowsRepository.GetByID(addID).FirstOrDefault();
                                row.RB_ID = entity.RB_ID;
                                _unitOfWork.RegisterDirty(row);
                            }
                            foreach (int deleteID in Delete)
                            {
                                RB_Rows row = _rbrowsRepository.GetByID(deleteID).FirstOrDefault();
                                row.RB_ID = null;
                                _unitOfWork.RegisterDirty(row);
                            }
                            bool result = _unitOfWork.Commit();
                            RInfo.IsSuccess = result;
                            RInfo.ErrorInfo = sb.ToString();
                            return RInfo;
                        }
                        catch (Exception ex)
                        {
                            _unitOfWork.RegisterClean(rb);
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


            }
            else
            {
                RInfo.IsSuccess = false;
                RInfo.ErrorInfo = "查找不到该ID的报销单!";
                return RInfo;
            }
            
        }

        /// <summary>
        /// 更新报销单状态
        /// </summary>
        /// <param name="ID">报销单ID</param>
        /// <param name="Status">报销单状态</param>
        /// <param name="UserID">当前审批者的ID</param>
        public ReturnInfo UpdateRBStatus(string ID, RB_Status Status, string UserID, string RejectionReason)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            Reimbursement entity = _reimbursementRepository.GetByID(ID).FirstOrDefault();
            if (entity != null)
            {
                try
                {
                    Reimbursement entity2 = _reimbursementRepository.GetByID(ID).AsNoTracking().FirstOrDefault();
                    if (entity2.RB_Status == (int)RB_Status.财务审批)
                    {
                        RInfo.IsSuccess = false;
                        RInfo.ErrorInfo = "财务审批通过后,不能变更状态了!";
                        return RInfo;
                    }
                    else
                    {
                        entity.RB_UpdateDate = DateTime.Now;
                        if (Status == RB_Status.已拒绝)
                        {
                            if (entity2.RB_Status == (int)RB_Status.责任人审批 || entity2.RB_Status == (int)RB_Status.行政审批)
                            {
                                //行政和财务拒绝的时候,成本中心已用金额减少
                                CostCenter cc = _costCenterRepository.GetByID(entity.CC_ID).FirstOrDefault();
                                decimal Used = cc.CC_UsedAmount;
                                cc.CC_UsedAmount = Used - entity.RB_TotalAmount;
                                _unitOfWork.RegisterDirty(cc);
                                if (entity2.RB_Status == (int)RB_Status.责任人审批)
                                {
                                    entity.RB_CurrantLiableMan = UserID;
                                    entity.RB_LiableDate = DateTime.Now;
                                }
                                else if (entity2.RB_Status == (int)RB_Status.行政审批)
                                {
                                    entity.RB_CurrantAEACheck = UserID;
                                    entity.RB_AEADate = DateTime.Now;
                                }
                            }
                            entity.RB_Status = (int)Status;
                            entity.RB_CurrantCheck = UserID;
                            entity.RB_RejectionReason = RejectionReason;
                            entity.RB_UpdateUser = UserID;
                            _unitOfWork.RegisterDirty(entity);
                            bool result = _unitOfWork.Commit();
                            RInfo.IsSuccess = result;
                            RInfo.ErrorInfo = sb.ToString();
                            return RInfo;
                        }
                        else
                        {
                            if (entity2.RB_Status + 1 == (int)Status)
                            {

                                entity.RB_Status = (int)Status;
                                entity.RB_CurrantCheck = UserID;
                                entity.RB_UpdateUser = UserID;
                                entity.RB_RejectionReason = RejectionReason;
                                //责任人审核通过的话，需要更新成本中心里的已使用金额
                                if (Status == RB_Status.责任人审批)
                                {
                                    CostCenter cc = _costCenterRepository.GetByID(entity.CC_ID).FirstOrDefault();
                                    decimal Used = cc.CC_UsedAmount;
                                    decimal Left = cc.CC_Amount - Used;
                                    if (Left >= entity.RB_TotalAmount)
                                    {
                                        cc.CC_UsedAmount = Used + entity.RB_TotalAmount;
                                        _unitOfWork.RegisterDirty(cc);
                                    }
                                    else
                                    {
                                        RInfo.IsSuccess = false;
                                        RInfo.ErrorInfo = "成本中心余额不足!";
                                        return RInfo;
                                    }
                                    entity.RB_CurrantLiableMan = UserID;
                                    entity.RB_LiableDate = DateTime.Now;
                                }
                                else if (Status == RB_Status.行政审批)
                                {
                                    entity.RB_CurrantAEACheck = UserID;
                                    entity.RB_AEADate = DateTime.Now;
                                }
                                else if (Status == RB_Status.财务审批)
                                {
                                    entity.RB_CurrantFinCheck = UserID;
                                    entity.RB_FinDate = DateTime.Now;
                                }
                                _unitOfWork.RegisterDirty(entity);
                                bool result = _unitOfWork.Commit();
                                RInfo.IsSuccess = result;
                                RInfo.ErrorInfo = sb.ToString();
                                return RInfo;
                            }
                            else
                            {
                                RInfo.IsSuccess = false;
                                RInfo.ErrorInfo = "不符合审批流程!";
                                return RInfo;
                            }
                        }

                    }

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
                RInfo.ErrorInfo = "该报销单ID不存在!";
                return RInfo;
            }
           
        }

        /// <summary>
        /// 添加消费明细
        /// </summary>
        /// <param name="entity">消费明细对象</param>
        public ReturnInfo CreateRB_Rows(RB_RowsInputDto entity)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            string ValidateInfo = Helper.ValidateRB_RowsInputDto(entity);
            sb.Append(ValidateInfo);
            if (string.IsNullOrEmpty(ValidateInfo))
            {
                try
                {
                    RB_Rows r = Mapper.Map<RB_RowsInputDto,RB_Rows>(entity);
                    r.R_CreateDate = DateTime.Now;
                    _unitOfWork.RegisterNew(r);
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
        /// 更新消费明细
        /// </summary>
        /// <param name="entity">消费明细对象</param>
        public ReturnInfo UpdateRB_Rows(RB_RowsInputDto entity)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            string ValidateInfo = Helper.ValidateRB_RowsInputDto(entity);
            sb.Append(ValidateInfo);
            if (string.IsNullOrEmpty(ValidateInfo))
            {
                RB_Rows r = _rbrowsRepository.GetByID(entity.R_ID).FirstOrDefault();
                try
                {
                    
                    if (r != null)
                    {
                        r.R_Amount = entity.R_Amount;
                        r.R_ConsumeDate = entity.R_ConsumeDate;
                        r.R_Note = entity.R_Note;
                        r.R_TypeID = entity.R_TypeID;
                        r.RB_ID = entity.RB_ID;
                        _unitOfWork.RegisterDirty(r);
                        bool result = _unitOfWork.Commit();
                        RInfo.IsSuccess = result;
                        RInfo.ErrorInfo = sb.ToString();
                        return RInfo;
                    }
                    else
                    {
                        RInfo.IsSuccess = false;
                        RInfo.ErrorInfo = "找不到该消费明细!";
                        return RInfo;
                    }
                }
                catch (Exception ex)
                {
                    _unitOfWork.RegisterClean(r);
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
        /// 删除消费明细
        /// </summary>
        /// <param name="entity">消费明细对象</param>
        public ReturnInfo DeleteRB_Rows(int RB_RID)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            RB_Rows row = _rbrowsRepository.GetByID(RB_RID).FirstOrDefault();
            if (row != null)
            {
                try
                {
                    _unitOfWork.RegisterDeleted(row);
                    bool result = _unitOfWork.Commit();
                    RInfo.IsSuccess = result;
                    RInfo.ErrorInfo = sb.ToString();
                }
                catch (Exception ex)
                {
                    _unitOfWork.RegisterClean(row);
                    _unitOfWork.Rollback();
                    sb.Append(ex.Message);
                    RInfo.IsSuccess = false;
                    RInfo.ErrorInfo = sb.ToString();
                }
            }
            else
            {
                RInfo.IsSuccess = false;
                sb.Append("不存在ID为"+RB_RID.ToString()+"的报销明细!");
            }
            
            return RInfo;
        }


        /// <summary>
        /// 添加消费类型的模板
        /// </summary>
        /// <param name="entity">消费类型的模板对象</param>
        public ReturnInfo CreateRB_Type_Template(RBRTTInputDto entity)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            string MaxID = _rbTypeTemplateRepository.GetMaxID();
            string NowID = Helper.GenerateID("RTT", MaxID);
            entity.RB_RTT_TemplateID = NowID;
            string ValidateInfo = Helper.ValidateRBRTTInputDto(entity);
            sb.Append(ValidateInfo);
            if (string.IsNullOrEmpty(ValidateInfo))
            {
                try
                {
                    RB_RType_Template r = Mapper.Map<RBRTTInputDto,RB_RType_Template>(entity);
                    r.RB_RTT_CreateDate = DateTime.Now;
                    string MaxID2 = _rbTypeTemplateRepository.GetMaxID();
                    string NowID2 = Helper.GenerateID("RTT", MaxID2);
                    r.RB_RTT_TemplateID = NowID2;
                    _unitOfWork.RegisterNew(r);
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
        /// 更新消费类型的模板
        /// </summary>
        /// <param name="entity">消费类型的模板对象</param>
        public ReturnInfo UpdateRB_Type_Template(RBRTTInputDto entity)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            string ValidateInfo = Helper.ValidateRBRTTInputDto(entity);
            sb.Append(ValidateInfo);
            if (string.IsNullOrEmpty(ValidateInfo))
            {
                RB_RType_Template r = _rbTypeTemplateRepository.GetByID(entity.RB_RTT_TemplateID).FirstOrDefault();
                try
                {
                    
                    if (r != null)
                    {
                        r.RB_RTT_TypeID = entity.RB_RTT_TypeID;
                        r.RB_RTT_Note = entity.RB_RTT_Note;
                        r.RB_RTT_Amount = entity.RB_RTT_Amount;
                        _unitOfWork.RegisterDirty(r);
                        bool result = _unitOfWork.Commit();
                        RInfo.IsSuccess = result;
                        RInfo.ErrorInfo = sb.ToString();
                        return RInfo;
                    }
                    else
                    {
                        RInfo.IsSuccess = false;
                        RInfo.ErrorInfo = "找不到该消费类型的模板!";
                        return RInfo;
                    }
                    
                }
                catch (Exception ex)
                {
                    _unitOfWork.RegisterClean(r);
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
        /// 删除消费明细类型的模板
        /// </summary>
        /// <param name="RB_RTT_TemplateID">消费明细类型的模板ID</param>
        public ReturnInfo DeleteRB_Type_Template(string RB_RTT_TemplateID)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            RB_RType_Template temp = _rbTypeTemplateRepository.GetByID(RB_RTT_TemplateID).FirstOrDefault();
            if (temp != null)
            {
                try
                {
                    _unitOfWork.RegisterDeleted(temp);
                    bool result = _unitOfWork.Commit();
                    RInfo.IsSuccess = result;
                    RInfo.ErrorInfo = sb.ToString();
                }
                catch (Exception ex)
                {
                    _unitOfWork.RegisterClean(temp);
                    _unitOfWork.Rollback();
                    sb.Append(ex.Message);
                    RInfo.IsSuccess = false;
                    RInfo.ErrorInfo = sb.ToString();
                }
            }
            else
            {
                RInfo.IsSuccess = false;
                sb.Append("不存在ID为" + RB_RTT_TemplateID + "消费明细类型的模板.");
            }

            return RInfo;
        }

        #endregion


        #region 通用方法
        private List<ReimbursementDto> GetRBDetail(List<ReimbursementDto> temp)
        {
            List<ReimbursementDto> Final = new List<ReimbursementDto>();
            foreach (ReimbursementDto dto in temp)
            {
                if (!string.IsNullOrEmpty(dto.CC_ID))
                {
                    CostCenter cc = _costCenterRepository.GetByID(dto.CC_ID).AsNoTracking().FirstOrDefault();
                    if (cc != null)
                    {
                        dto.CC_Name = cc.CC_Name;
                    }
                }
                if (!string.IsNullOrEmpty(dto.U_ID))
                {
                    User u = _userRepository.GetByID(dto.U_ID).AsNoTracking().FirstOrDefault();
                    if (u != null)
                    {
                        dto.U_Name = u.U_Name;
                        dto.U_Portrait = u.U_Portrait;
                    }
                }               
                Final.Add(dto);
            }
            return Final;        
        }

        #endregion
    }
}
