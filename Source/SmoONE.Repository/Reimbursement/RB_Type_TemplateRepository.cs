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
    // 主要内容：  消费类型模板的仓储接口,仅用于查询
    // ******************************************************************

    /// <summary>
    /// 消费类型模板的仓储接口,仅用于查询
    /// </summary>
    public class RB_Type_TemplateRepository: BaseRepository<RB_RType_Template>, IRB_Type_TemplateRepository
    {
        /// <summary>
        /// 仓储类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public RB_Type_TemplateRepository(IDbContext dbContext)
            : base(dbContext)
        { }

        /// <summary>
        /// 根据消费类型模板ID返回消费类型模板对象
        /// </summary>
        /// <param name="ID">消费类型模板ID</param>
        public IQueryable< RB_RType_Template> GetByID(string ID)
        {
            return _entities.Where(x => x.RB_RTT_TemplateID == ID);
        }

        /// <summary>
        /// 根据消费类型ID返回消费类型模板对象
        /// </summary>
        /// <param name="TypeID">消费类型ID</param>
        public IQueryable<RB_RType_Template> GetByTypeID(string TypeID)
        {
            return _entities.Where(x => x.RB_RTT_TypeID == TypeID).OrderByDescending(o => o.RB_RTT_TemplateID).AsNoTracking();
        }

        /// <summary>
        /// 根据用户ID返回消费类型模板对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        public IQueryable<RB_RType_Template> GetByCreateUser(string UserID)
        {
            return _entities.Where(x => x.RB_RTT_CreateUser == UserID).OrderByDescending(o => o.RB_RTT_TemplateID).AsNoTracking();
        }


        /// <summary>
        /// 得到最大的消费类型模板ID
        /// </summary>
        public string GetMaxID()
        {
            return _entities.Select(e => e.RB_RTT_TemplateID).Max();
        }
    }
}
