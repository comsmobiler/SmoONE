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
    // 主要内容：  成本中心类型的仓储接口,仅用于查询
    // ******************************************************************
    /// <summary>
    /// 成本中心类型的仓储接口,仅用于查询
    /// </summary>
    public interface ICostCenter_TypeRepository:IRepository<CostCenter_Type>
    {
        /// <summary>
        /// 根据成本中心类型ID返回成本中心类型对象
        /// </summary>
        /// <param name="ID">成本中心类型ID</param>
        CostCenter_Type GetByID(string ID);
    }
}
