using SmoONE.Application.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmoONE.CommLib;
using SmoONE.DTOs;
using SmoONE.Infrastructure;
using SmoONE.Domain.IRepository;
using AutoMapper;
using SmoONE.Domain;
using System.Data.Entity;

namespace SmoONE.Application.Services
{
    public class ContactService : IContactService
    {
        /// <summary>
        /// 工作单元的接口
        /// </summary>
        private IUnitOfWork _unitOfWork;

        /// <summary>
        /// 联系人群组的仓储类的接口
        /// </summary>
        private IContactRepository _contactRepository;


        /// <summary>
        /// 联系人群组服务实现的构造函数
        /// </summary>
        public ContactService(IUnitOfWork unitOfWork,
            IContactRepository contactRepository)
        {
            _unitOfWork = unitOfWork;
            _contactRepository = contactRepository;

        }
        #region 查询
        /// <summary>
        /// 根据请假单ID返回请假单对象
        /// </summary>
        /// <param name="ID">请假单ID</param>
        public ContactDto GetByID(int ID)
        {
            ContactDto group = Mapper.Map<Contact, ContactDto>(_contactRepository.GetByID(ID).AsNoTracking().FirstOrDefault());

            return group;
        }


        /// <summary>
        /// 根据创建用户ID返回联系人传输对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        public List<ContactDto> GetByCreateUsers(string UserID)
        {
            List<ContactDto> ads = Mapper.Map<List<Contact>, List<ContactDto>>(_contactRepository.GetByCreateUsers(UserID).ToList());
            return ads;
        }
        #endregion

        #region 操作
        /// <summary>
        /// 添加群组
        /// </summary>
        /// <param name="contactInputDto">群组对象</param>
        public ReturnInfo AddContact(ContactInputDto contactInputDto)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            string ValidateInfo = Helper.ValidateContactInputDto(contactInputDto);
            sb.Append(ValidateInfo);
            if (string.IsNullOrEmpty(ValidateInfo))
            {
                try
                {
                    Contact entity = Mapper.Map<ContactInputDto, Contact>(contactInputDto);
                    entity.C_CreateDate = DateTime.Now;
                    entity.C_UpdateDate = DateTime.Now;

                   
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

        #endregion
    }
}
