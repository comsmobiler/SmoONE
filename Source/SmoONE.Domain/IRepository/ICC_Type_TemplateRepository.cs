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
    // 主要内容：  成本中心类型模板的仓储接口,仅用于查询
    // ******************************************************************
    /// <summary>
    /// 成本中心类型模板的仓储接口,仅用于查询
    /// </summary>
    public interface ICC_Type_TemplateRepository:IRepository<CC_Type_Template>
    {        


        /// <summary>
        /// 根据成本中心类型模板ID返回成本中心类型模板对象
        /// </summary>
        /// <param name="ID">成本中心类型模板ID</param>
        IQueryable<CC_Type_Template> GetByID(string ID);

        /// <summary>
        /// 根据成本中心类型ID返回成本中心类型模板对象
        /// </summary>
        /// <param name="TypeID">成本中心类型ID</param>
        IQueryable<CC_Type_Template> GetByTypeID(string TypeID);

        /// <summary>
        /// 得到最大的部门ID
        /// </summary>
        string GetMaxID();

    }
}
