using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmoONE.Domain.IRepository
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2016/11
    // 主要内容： 联系人群组的仓储接口,仅用于查询
    // ******************************************************************

    /// <summary>
    /// 联系人群组的仓储接口,仅用于查询
    /// </summary>
    public interface ICGroupRepository: IRepository<CGroup>
    {
        /// <summary>
        /// 根据群组ID返回联系人群组对象
        /// </summary>
        /// <param name="ID">群组ID</param>
        IQueryable<CGroup> GetByID(string  ID);

        /// <summary>
        /// 根据创建用户返回联系人群组对象
        /// </summary>
        /// <param name="ID">群组创建用户</param>
        IQueryable<CGroup> GetByCreateUsers(string UserID);

        /// <summary>
        /// 得到最大的群组ID
        /// </summary>
        string GetMaxID();
    }
}
