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
    // 主要内容：  成本中心类型模板的仓储接口,仅用于查询
    // ******************************************************************

    /// <summary>
    /// 成本中心类型模板的仓储接口,仅用于查询
    /// </summary>
    public class CC_Type_TemplateRepository:BaseRepository<CC_Type_Template>,ICC_Type_TemplateRepository
    {
        /// <summary>
        /// 仓储类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public CC_Type_TemplateRepository(IDbContext dbContext)
            : base(dbContext)
        { }


        /// <summary>
        /// 根据成本中心类型模板ID返回成本中心类型模板对象
        /// </summary>
        /// <param name="ID">成本中心类型模板ID</param>
        public IQueryable<CC_Type_Template> GetByID(string ID)
        {
            return _entities.Where(x => x.CC_TT_TemplateID == ID);
        }

        /// <summary>
        /// 根据成本中心类型ID返回成本中心类型模板对象
        /// </summary>
        /// <param name="TypeID">成本中心类型ID</param>
        public IQueryable<CC_Type_Template> GetByTypeID(string TypeID)
        {
            return _entities.Where(x => x.CC_TT_TypeID == TypeID).OrderByDescending(o => o.CC_TT_TemplateID);
        }

        /// <summary>
        /// 得到最大的成本中心类型模板ID
        /// </summary>
        public string GetMaxID()
        {
            return _entities.Select(e => e.CC_TT_TemplateID).Max();
        }
      
    }
}
