using AutoMapper;
using SmoONE.Application.IServices;
using SmoONE.CommLib;
using SmoONE.Domain;
using SmoONE.Domain.IRepository;
using SmoONE.DTOs;
using SmoONE.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace SmoONE.Application.Services
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2016/11
    // 主要内容：  联系人群组的服务实现
    // ******************************************************************
    /// <summary>
    /// 联系人群组的服务实现
    public class CGroupService:ICGroupService
    {
        /// <summary>
        /// 工作单元的接口
        /// </summary>
        private IUnitOfWork _unitOfWork;

        /// <summary>
        /// 联系人群组的仓储类的接口
        /// </summary>
        private ICGroupRepository _cGroupRepository;


        /// <summary>
        /// 联系人群组服务实现的构造函数
        /// </summary>
        public CGroupService(IUnitOfWork unitOfWork,
            ICGroupRepository cGroupRepository)
        {
            _unitOfWork = unitOfWork;
            _cGroupRepository = cGroupRepository;
          
        }



        #region 查询
        /// <summary>
        /// 根据请假单ID返回请假单对象
        /// </summary>
        /// <param name="ID">请假单ID</param>
        public CGroupDto GetByID(string  ID)
        {
            CGroupDto group= Mapper.Map<CGroup, CGroupDto>(_cGroupRepository.GetByID(ID).AsNoTracking().FirstOrDefault());
           
            return group;
        }


        /// <summary>
        /// 根据创建用户ID返回联系人传输对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        public List<CGroupDto> GetByCreateUsers(string UserID)
        {
            List<CGroupDto> ads = Mapper.Map<List<CGroup>, List<CGroupDto >>(_cGroupRepository.GetByCreateUsers (UserID).ToList());
            return ads;
        }
        #endregion

        #region 操作
        /// <summary>
        /// 添加群组
        /// </summary>
        /// <param name="cGroupInputDto">群组对象</param>
        public ReturnInfo AddGroup(CGroupInputDto cGroupInputDto)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            string ValidateInfo = Helper.ValidateCGroupInputDto(cGroupInputDto);
            sb.Append(ValidateInfo);
            if (string.IsNullOrEmpty(ValidateInfo))
            {
                try
                {
                    CGroup entity = Mapper.Map<CGroupInputDto, CGroup >(cGroupInputDto);
                    entity.G_CreateDate  = DateTime.Now;
                    entity.G_UpdateDate  = DateTime.Now;
                   
                    string MaxID2 = _cGroupRepository.GetMaxID();
                    string NowID2 = Helper.GenerateID2("G", MaxID2);
                    entity.G_ID = NowID2;
                    _unitOfWork.RegisterNew(entity);
                    bool result = _unitOfWork.Commit();
                    RInfo.IsSuccess = result;
                    RInfo.ErrorInfo = sb.ToString();
                    RInfo.ErrorInfo = NowID2;
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

        #endregion
    }
}
