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
    // 主要内容：  仓储类的基础接口,仅用于查询
    // ******************************************************************
    /// <summary>
    /// 仓储类的基础接口,仅用于查询
    /// </summary>
    public interface IRepository<TAggregateRoot>
        where TAggregateRoot : class, IAggregateRoot
    {
        //IQueryable<TAggregateRoot> Get(int id);

        /// <summary>
        /// 得到所有该仓储类对象的信息
        /// </summary>
        IQueryable<TAggregateRoot> GetAll();
    }
}
