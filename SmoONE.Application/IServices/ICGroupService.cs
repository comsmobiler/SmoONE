using SmoONE.CommLib;
using SmoONE.Domain;
using SmoONE.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmoONE.Application.IServices
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2016/11
    // 主要内容：  联系人群组的服务接口
    // ******************************************************************
    /// <summary>
    /// 联系人群组的服务接口
    /// </summary>
    public interface ICGroupService
    {
        #region 查询
        /// <summary>
        /// 根据ID返回联系人群组对象
        /// </summary>
        /// <param name="ID">ID</param>
        CGroupDto GetByID(string  ID);

        /// <summary>
        /// 根据创建用户ID返回联系人传输对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        List<CGroupDto> GetByCreateUsers(string UserID);

        #endregion

        #region 操作
        /// <summary>
        /// 添加群组
        /// </summary>
        /// <param name="entity">群组对象</param>
        ReturnInfo AddGroup(CGroupInputDto entity);

       
        #endregion
    }
}
