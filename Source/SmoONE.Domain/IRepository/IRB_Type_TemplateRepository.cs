using SmoONE.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmoONE.Domain.IRepository
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2016/11
    // 主要内容：  消费类型模板的仓储接口,仅用于查询
    // ******************************************************************
    /// <summary>
    /// 消费类型模板的仓储接口,仅用于查询
    /// </summary>
    public interface IRB_Type_TemplateRepository:IRepository<RB_RType_Template>
    {
        /// <summary>
        /// 根据消费类型模板ID返回消费类型模板对象
        /// </summary>
        /// <param name="ID">消费类型模板ID</param>
        IQueryable<RB_RType_Template> GetByID(string ID);

        /// <summary>
        /// 根据消费类型ID返回消费类型模板对象
        /// </summary>
        /// <param name="TypeID">消费类型ID</param>
        IQueryable<RB_RType_Template> GetByTypeID(string TypeID);

        /// <summary>
        /// 根据用户ID返回消费类型模板对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        IQueryable<RB_RType_Template> GetByCreateUser(string UserID);

        /// <summary>
        /// 得到最大的消费类型模板ID
        /// </summary>
        string GetMaxID();
    }
}
