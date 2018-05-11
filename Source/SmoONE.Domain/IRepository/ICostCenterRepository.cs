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
    // 主要内容：  成本中心的仓储接口,仅用于查询
    // ******************************************************************
    /// <summary>
    /// 成本中心的仓储接口,仅用于查询
    /// </summary>
    public interface ICostCenterRepository:IRepository<CostCenter>
    {
        /// <summary>
        /// 根据成本中心ID返回成本中心对象
        /// </summary>
        /// <param name="ID">成本中心ID</param>
        IQueryable<CostCenter> GetByID(string ID);

        /// <summary>
        /// 根据成本中心名称和负责人来查询成本中心
        /// </summary>
        /// <param name="Name">成本中心名称</param>
        /// <param name="LiableMan">负责人</param>
        IQueryable<CostCenter> QueryCC(string Name, string LiableMan);

        /// <summary>
        /// 得到最大的成本中心ID
        /// </summary>
        string GetMaxID();     
    }
}
