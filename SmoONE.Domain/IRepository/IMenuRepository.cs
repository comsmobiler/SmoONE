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
    // 主要内容：  菜单的仓储接口,仅用于查询
    // ******************************************************************
    /// <summary>
    /// 菜单的仓储接口,仅用于查询
    /// </summary>
    public interface IMenuRepository:IRepository<Menu>
    {
        /// <summary>
        /// 根据菜单ID返回菜单对象
        /// </summary>
        /// <param name="ID">菜单ID</param>
        Menu GetByID(string ID);

        /// <summary>
        /// 得到最大的菜单ID
        /// </summary>
        string GetMaxID();
    }
}
