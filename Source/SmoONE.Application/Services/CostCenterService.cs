using SmoONE.Domain;
using SmoONE.Domain.IRepository;
using SmoONE.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SmoONE.DTOs;
using SmoONE.CommLib;
using AutoMapper;

namespace SmoONE.Application
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2016/11
    // 主要内容：  成本中心的服务实现
    // ******************************************************************
    /// <summary>
    /// 成本中心的服务实现
    /// </summary>
    public class CostCenterService : ICostCenterService
    {
        /// <summary>
        /// 工作单元的接口
        /// </summary>
        private IUnitOfWork _unitOfWork;

        /// <summary>
        /// 成本中心的仓储类的接口
        /// </summary>
        private ICostCenterRepository _costCenterRepository;

        /// <summary>
        /// 成本中心类型的仓储类的接口
        /// </summary>
        private ICostCenter_TypeRepository _costCenter_TypeRepository;

        /// <summary>
        /// 成本中心类型的模板的仓储类的接口
        /// </summary>
        private ICC_Type_TemplateRepository _cc_Type_TemplateRepository;


        /// <summary>
        /// 用户的仓储类的接口
        /// </summary>
        private IUserRepository _userRepository;

        /// <summary>
        /// 部门的仓储类的接口
        /// </summary>
        private IDepartmentRepository _departmentRepository;

        /// <summary>
        /// 成本中心服务实现的构造函数
        /// </summary>
        public CostCenterService(IUnitOfWork unitOfWork,
            ICostCenterRepository costCenterRepository,
            ICostCenter_TypeRepository costCenter_TypeRepository,
            ICC_Type_TemplateRepository cc_Type_TemplateRepository,
            IUserRepository userRepository,
            IDepartmentRepository departmentRepository)
        {
            _unitOfWork = unitOfWork;
            _costCenterRepository = costCenterRepository;
            _costCenter_TypeRepository = costCenter_TypeRepository;
            _cc_Type_TemplateRepository = cc_Type_TemplateRepository;
            _userRepository = userRepository;
            _departmentRepository = departmentRepository;
        }

        #region 查询
        /// <summary>
        /// 根据成本中心ID返回成本中心对象
        /// </summary>
        /// <param name="ID">成本中心ID</param>
        public CCDetailDto GetCCByID(string ID)
        {
            CCDetailDto cc =Mapper.Map<CostCenter,CCDetailDto> (_costCenterRepository.GetByID(ID).AsNoTracking().FirstOrDefault());
            if (cc != null)
            {
                if (!string.IsNullOrEmpty(cc.CC_TypeID))
                {
                    CostCenter_Type c = _costCenter_TypeRepository.GetByID(cc.CC_TypeID);
                    if (c != null)
                    {
                        cc.CC_TypeName = c.CC_T_Description;
                    }
                }
                if (!string.IsNullOrEmpty(cc.CC_TemplateID))
                {
                    CC_Type_TemplateDto ctp =Mapper.Map<CC_Type_Template,CC_Type_TemplateDto>( _cc_Type_TemplateRepository.GetByID(cc.CC_TemplateID).AsNoTracking().FirstOrDefault());
                    if (ctp != null)
                    {
                        cc.CC_AEACheckers = ctp.CC_TT_AEACheckers;
                        cc.CC_FinancialCheckers = ctp.CC_TT_FinancialCheckers;
                    }
                }
                if (!string.IsNullOrEmpty(cc.CC_DepartmentID))
                {
                    DepDetailDto d = Mapper.Map<Department,DepDetailDto>( _departmentRepository.GetByID(cc.CC_DepartmentID).AsNoTracking().FirstOrDefault());
                    if (d != null)
                    {
                        cc.CC_DepName = d.Dep_Name;
                    }
                }
            }
            return cc;
        }       

        /// <summary>
        /// 根据成本中心类型模板ID返回成本中心类型模板对象
        /// </summary>
        /// <param name="ID">成本中心类型模板ID</param>
        public CC_Type_TemplateDto GetTemplateByID(string ID)
        {
            CC_Type_TemplateDto ctp =Mapper.Map<CC_Type_Template,CC_Type_TemplateDto>(_cc_Type_TemplateRepository.GetByID(ID).AsNoTracking().FirstOrDefault());
            if (ctp != null && !string.IsNullOrEmpty(ctp.CC_TT_TypeID))
            {
                ctp.CC_TT_TypeName = _costCenter_TypeRepository.GetByID(ctp.CC_TT_TypeID).CC_T_Description;
            }
            return ctp;
        }

        /// <summary>
        /// 根据成本中心类型ID返回成本中心类型模板对象
        /// </summary>
        /// <param name="TypeID">成本中心类型ID</param>
        public List<CC_Type_TemplateDto> GetTemplateByTypeID(string TypeID)
        {
            List<CC_Type_TemplateDto> dtos =Mapper.Map<List<CC_Type_Template>,List<CC_Type_TemplateDto>>( _cc_Type_TemplateRepository.GetByTypeID(TypeID).AsNoTracking().ToList());
            if (!string.IsNullOrEmpty(TypeID)&&(dtos.Count>0))
            {
                foreach (CC_Type_TemplateDto dto in dtos)
                {

                    dto.CC_TT_TypeName = _costCenter_TypeRepository.GetByID(TypeID).CC_T_Description;
                }
            }
            return dtos;
        }

        /// <summary>
        /// 根据成本中心类型ID返回成本中心类型对象
        /// </summary>
        /// <param name="ID">成本中心类型ID</param>
        public CostCenter_Type GetTypeByID(string ID)
        {
            return _costCenter_TypeRepository.GetByID(ID);
        }

        /// <summary>
        /// 得到所有成本中心类型对象
        /// </summary>
        public List<CostCenter_Type> GetAllCCType()
        {
            return _costCenter_TypeRepository.GetAll().AsNoTracking().ToList();
        }

        /// <summary>
        /// 得到所有的成本中心
        /// </summary>
        public List<CCDto> GetAllCC()
        {
            return Mapper.Map<List<CostCenter>, List<CCDto>>(_costCenterRepository.GetAll().OrderByDescending(o => o.CC_ID).AsNoTracking().ToList());
        }

        /// <summary>
        /// 得到所有的成本中心类型模板
        /// </summary>
        public List<CC_Type_TemplateDto> GetAllCCTTemplate()
        {
            List<CC_Type_TemplateDto> dtos =Mapper.Map<List<CC_Type_Template>,List<CC_Type_TemplateDto>>(_cc_Type_TemplateRepository.GetAll().OrderByDescending(o => o.CC_TT_TemplateID).AsNoTracking().ToList());
            if (dtos.Count > 0)
            {
                foreach (CC_Type_TemplateDto dto in dtos)
                {
                    if (!string.IsNullOrEmpty(dto.CC_TT_TypeID))
                    {
                        dto.CC_TT_TypeName = _costCenter_TypeRepository.GetByID(dto.CC_TT_TypeID).CC_T_Description;
                    }
                }
            }           
            return dtos;
        }


        /// <summary>
        /// 根据成本中心名称和负责人来查询成本中心
        /// </summary>
        /// <param name="Name">成本中心名称</param>
        /// <param name="LiableMan">负责人</param>
        public List<CCDto> QueryCC(string Name, string LiableMan)
        {
            return Mapper.Map<List<CostCenter>,List<CCDto>>(_costCenterRepository.QueryCC(Name, LiableMan).AsNoTracking().ToList());
        }
        #endregion

        #region 操作
        /// <summary>
        /// 添加成本中心
        /// </summary>
        /// <param name="entity">成本中心对象</param>
        public ReturnInfo AddCostCenter(CCInputDto entity)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            string MaxID = _costCenterRepository.GetMaxID();
            string NowID = Helper.GenerateIDEx("CC", MaxID);
            entity.CC_ID = NowID;
            //entity.CC_IsActive= 1;
            string ValidateInfo = Helper.ValidateCCInputDto(entity);
            sb.Append(ValidateInfo);
            if (string.IsNullOrEmpty(ValidateInfo))
            {
                try
                {
                    CostCenter c = Mapper.Map<CCInputDto,CostCenter>(entity);
                    c.CC_CreateDate = DateTime.Now;
                    if (entity.CC_EndDate != null)
                    {
                        c.CC_EndDate = (DateTime)entity.CC_EndDate;
                    }
                    c.CC_IsActive = (int)IsActive.激活;
                    if (entity.CC_StartDate != null)
                    {
                        c.CC_StartDate = (DateTime)entity.CC_StartDate;
                    }
                    c.CC_UpdateDate = DateTime.Now;
                    c.CC_UsedAmount = 0;
                    
                    string MaxID2 = _costCenterRepository.GetMaxID();
                    string NowID2 = Helper.GenerateIDEx("CC", MaxID2);
                    c.CC_ID = NowID2;
                    _unitOfWork.RegisterNew(c);
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
        /// 添加成本中心类型的模板
        /// </summary>
        /// <param name="entity">成本中心类型的模板对象</param>
        public ReturnInfo AddCC_Type_Template(CCTTInputDto entity)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            string MaxID = _cc_Type_TemplateRepository.GetMaxID();
            string NowID = Helper.GenerateIDEx("CT", MaxID);
            entity.CC_TT_TemplateID = NowID;
            string ValidateInfo = Helper.ValidateCCTTInputDto(entity);
            sb.Append(ValidateInfo);
            if (string.IsNullOrEmpty(ValidateInfo))
            {
                try
                {
                    CC_Type_Template cctt = Mapper.Map<CCTTInputDto,CC_Type_Template>(entity);
                    cctt.CC_TT_UpdateDate = DateTime.Now;
                    string MaxID2 = _cc_Type_TemplateRepository.GetMaxID();
                    string NowID2 = Helper.GenerateIDEx("CT", MaxID2);
                    cctt.CC_TT_TemplateID = NowID2;
                    _unitOfWork.RegisterNew(cctt);
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
        /// 更新成本中心
        /// </summary>
        /// <param name="entity">成本中心对象</param>
        public ReturnInfo UpdateCostCenter(CCInputDto entity)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            string ValidateInfo = Helper.ValidateCCInputDto(entity);

            if (string.IsNullOrEmpty(ValidateInfo))
            {
                CostCenter cc = _costCenterRepository.GetByID(entity.CC_ID).FirstOrDefault();
                if (cc != null)
                {
                    try
                    {
                        #region 如果字段非空或0,则更新对应字段
                        cc.CC_UpdateDate = DateTime.Now;
                        if (entity.CC_Amount > 0)
                        {
                            cc.CC_Amount = entity.CC_Amount;
                        }
                        if (entity.CC_DepartmentID != null)
                        {
                            cc.CC_DepartmentID = entity.CC_DepartmentID;
                        }
                        if (entity.CC_EndDate != null)
                        {
                            cc.CC_EndDate = (DateTime)entity.CC_EndDate;
                        }
                        //cc.CC_IsActive = entity.CC_IsActive;
                        if (entity.CC_LiableMan != null)
                        {
                            cc.CC_LiableMan = entity.CC_LiableMan;
                        }
                        if (entity.CC_Name != null)
                        {
                            cc.CC_Name = entity.CC_Name;
                        }
                        if (entity.CC_StartDate != null)
                        {
                            cc.CC_StartDate = (DateTime)entity.CC_StartDate;
                        }
                        if (entity.CC_TemplateID != null)
                        {
                            cc.CC_TemplateID = entity.CC_TemplateID;
                        }
                        if (entity.CC_TypeID != null)
                        {
                            cc.CC_TypeID = entity.CC_TypeID;
                        }
                        if (entity.CC_UpdateUser != null)
                        {
                            cc.CC_UpdateUser = entity.CC_UpdateUser;
                        }
                        #endregion
                        _unitOfWork.RegisterDirty(cc);
                        bool result = _unitOfWork.Commit();
                        RInfo.IsSuccess = result;
                        RInfo.ErrorInfo = sb.ToString();
                        return RInfo;
                    }
                    catch (Exception ex)
                    {
                        _unitOfWork.RegisterClean(cc);
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
                    RInfo.ErrorInfo = "找不到该成本中心!";
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
        /// 更新成本中心类型的模板
        /// </summary>
        /// <param name="entity">成本中心类型的模板对象</param>
        public ReturnInfo UpdateCC_Type_Template(CCTTInputDto entity)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            string ValidateInfo = Helper.ValidateCCTTInputDto(entity);
            if (string.IsNullOrEmpty(ValidateInfo))
            {
                CC_Type_Template cctt = _cc_Type_TemplateRepository.GetByID(entity.CC_TT_TemplateID).FirstOrDefault();
                if (cctt != null)
                {
                    try
                    {
                        cctt.CC_TT_UpdateDate = DateTime.Now;
                        if (entity.CC_TT_AEACheckers != null)
                        {
                            cctt.CC_TT_AEACheckers = entity.CC_TT_AEACheckers;
                        }
                        if (entity.CC_TT_FinancialCheckers != null)
                        {
                            cctt.CC_TT_FinancialCheckers = entity.CC_TT_FinancialCheckers;
                        }
                        if (entity.CC_TT_TypeID != null)
                        {
                            cctt.CC_TT_TypeID = entity.CC_TT_TypeID;
                        }
                        if (entity.CC_TT_UpdateUser != null)
                        {
                            cctt.CC_TT_UpdateUser = entity.CC_TT_UpdateUser;
                        }
                        _unitOfWork.RegisterDirty(cctt);
                        bool result = _unitOfWork.Commit();
                        RInfo.IsSuccess = result;
                        RInfo.ErrorInfo = sb.ToString();
                        return RInfo;
                    }
                    catch (Exception ex)
                    {
                        _unitOfWork.RegisterClean(cctt);
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
                    RInfo.ErrorInfo = "找不到该成本中心类型的模板!";
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
        /// 更新成本中心状态
        /// </summary>
        /// <param name="CC_ID">成本中心ID</param>
        /// <param name="IsActive">是否激活</param>
        /// <param name="UserID">更新用户的ID</param>
        public ReturnInfo UpdateCostCenterStatus(string CC_ID, IsActive IsActive, string UserID)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            CostCenter entity = _costCenterRepository.GetByID(CC_ID).FirstOrDefault();            
            if (entity != null)
            {
                try
                {
                    entity.CC_UpdateDate = DateTime.Now;
                    entity.CC_IsActive = (int)IsActive;
                    entity.CC_UpdateUser = UserID;
                    _unitOfWork.RegisterDirty(entity);
                    bool result =_unitOfWork.Commit();
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
                RInfo.ErrorInfo = "该成本中心ID不存在";
                return RInfo;
            }
        }

        /// <summary>
        /// 更新成本中心类型的状态
        /// </summary>
        /// <param name="TypeID">成本中心类型的ID</param>
        /// <param name="IsActive">是否激活</param>
        public ReturnInfo UpdateCC_TypeStatus(string TypeID, IsActive IsActive)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            CostCenter_Type entity = GetTypeByID(TypeID);
            if (entity != null)
            {
                try
                {
                    entity.CC_T_IsActive = (int)IsActive;
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
                RInfo.ErrorInfo = "该成本中心类型的ID不存在";
                return RInfo;
            }
        }

        #endregion

    }
}
