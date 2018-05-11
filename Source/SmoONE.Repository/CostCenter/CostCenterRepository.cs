using SmoONE.Domain;
using SmoONE.Domain.IRepository;
using SmoONE.DTOs;
using SmoONE.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SmoONE.Repository
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
    public class CostCenterRepository:BaseRepository<CostCenter>, ICostCenterRepository
    {
        /// <summary>
        /// 仓储类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public CostCenterRepository(IDbContext dbContext)
            : base(dbContext)
        { }

        /// <summary>
        /// 根据成本中心ID返回成本中心对象
        /// </summary>
        /// <param name="ID">成本中心ID</param>
        public IQueryable<CostCenter> GetByID(string ID)
        {
            return _entities.Where(x => x.CC_ID == ID);
        }

        /// <summary>
        /// 根据成本中心名称和负责人来查询成本中心
        /// </summary>
        /// <param name="Name">成本中心名称</param>
        /// <param name="LiableMan">负责人</param>
        public IQueryable<CostCenter> QueryCC(string Name, string LiableMan)
        {
            IQueryable<CostCenter> cc = _entities;
            if (!string.IsNullOrEmpty(Name))
            {
                cc = cc.Where(o => o.CC_Name.Contains(Name));
            }
            if (!string.IsNullOrEmpty(LiableMan))
            {
                cc = cc.Where(o => o.CC_LiableMan.Contains(LiableMan));
            }
            return cc.OrderByDescending(o => o.CC_ID).AsNoTracking();
        }


        /// <summary>
        /// 得到最大的成本中心ID
        /// </summary>
        public string GetMaxID()
        {
            return _entities.Select(e => e.CC_ID).Max();
        }
        
    }
}
