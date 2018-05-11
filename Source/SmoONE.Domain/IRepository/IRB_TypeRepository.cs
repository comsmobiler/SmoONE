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
    // 主要内容：  报销类型的仓储接口,仅用于查询
    // ******************************************************************
    /// <summary>
    /// 报销类型的仓储接口,仅用于查询
    /// </summary>
    public interface IRB_TypeRepository : IRepository<RB_RType>
    {
        /// <summary>
        /// 根据报销类型ID返回报销类型对象
        /// </summary>
        /// <param name="ID">报销类型ID</param>
        RB_RType GetByID(string ID);
    }
}

