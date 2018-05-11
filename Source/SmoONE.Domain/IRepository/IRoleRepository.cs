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
    // 主要内容：  角色的仓储接口,仅用于查询
    // ******************************************************************
    /// <summary>
    /// 角色的仓储接口,仅用于查询
    /// </summary>
    public interface IRoleRepository:IRepository<Role>
    {
        /// <summary>
        /// 根据角色ID返回角色对象
        /// </summary>
        /// <param name="ID">角色ID</param>
        Role GetByID(string ID);
    }
}
