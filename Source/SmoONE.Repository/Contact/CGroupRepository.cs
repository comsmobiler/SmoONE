using SmoONE.Domain;
using SmoONE.Domain.IRepository;
using SmoONE.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace SmoONE.Repository.Contact
{
   public    class CGroupRepository : BaseRepository<SmoONE.Domain.CGroup>, ICGroupRepository 
    {
        // <summary>
        /// 仓储类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public CGroupRepository(IDbContext dbContext)
            : base(dbContext)
        { }
        /// <summary>
        /// 根据ID返回联系人对象
        /// </summary>
        /// <param name="ID">请假单ID</param>
        public IQueryable<SmoONE.Domain.CGroup> GetByID(string  ID)
        {
            return _entities.Where(x => x.G_ID == ID);
        }
        /// <summary>
        /// 根据创建用户ID返回联系人传输对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        public IQueryable<SmoONE.Domain.CGroup> GetByCreateUsers(string UserID)
        {
            return _entities.Where(x => x.G_CreateUser == UserID).OrderByDescending(o => o.G_ID).AsNoTracking();
        }
        /// <summary>
        /// 得到最大的群组ID
        /// </summary>
        public string GetMaxID()
        {
            return _entities.Select(e => e.G_ID).Max();
        }
    }
}
