using SmoONE.Domain;
using SmoONE.Domain.IRepository;
using SmoONE.DTOs;
using SmoONE.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmoONE.Repository
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
    public class CostCenter_TypeRepository : BaseRepository<CostCenter_Type>, ICostCenter_TypeRepository
    {
        /// <summary>
        /// 仓储类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public CostCenter_TypeRepository(IDbContext dbContext)
            : base(dbContext)
        { }

        /// <summary>
        /// 根据成本中心类型ID返回成本中心类型对象
        /// </summary>
        /// <param name="ID">成本中心类型ID</param>
        public CostCenter_Type GetByID(string ID)
        {
            return _entities.Where(x => x.CC_T_TypeID == ID).FirstOrDefault();
        }
    }
}
