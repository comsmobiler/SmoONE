using SmoONE.CommLib;
using SmoONE.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmoONE.Application.IServices
{
   public  interface IContactService
    {
        #region 查询
        /// <summary>
        /// 根据ID返回联系人对象
        /// </summary>
        /// <param name="ID">ID</param>
        ContactDto GetByID(int ID);

       

        /// <summary>
        /// 根据创建用户ID返回联系人传输对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        List<ContactDto> GetByCreateUsers(string UserID);  
      #endregion


        #region 操作
        /// <summary>
        /// 添加联系人
        /// </summary>
        /// <param name="entity">联系人对象</param>
        ReturnInfo AddContact(ContactInputDto entity);

       

        #endregion
    }
}
