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
   public  class ContactRepository: BaseRepository<SmoONE.Domain.Contact>,IContactRepository
    {
        // <summary>
        /// 仓储类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public ContactRepository(IDbContext dbContext)
            : base(dbContext)
        { }

        /// <summary>
        /// 根据ID返回联系人对象
        /// </summary>_entities.Where(x => x.C_CreateUser == UserID).OrderByDescending(o => o.C_ID ).AsNoTracking()
        /// <param name="ID">请假单ID</param>
        public IQueryable<SmoONE.Domain.Contact> GetByID(int ID)
        {
            return _entities.Where(x => x.C_ID == ID);
        }
        /// <summary>
        /// 根据创建用户ID返回联系人传输对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        public IQueryable<SmoONE.Domain.Contact> GetByCreateUsers(string UserID)
        {
            return _entities.Where(x => x.C_CreateUser == UserID).OrderByDescending(o => o.C_ID ).AsNoTracking();
        }
    }
}
