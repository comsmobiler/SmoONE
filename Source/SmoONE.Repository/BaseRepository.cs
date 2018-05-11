using SmoONE.Domain;
using SmoONE.Domain.IRepository;
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
    // 主要内容：  基础的仓储接口,仅用于查询
    // ******************************************************************

    /// <summary>
    /// 基础的仓储接口,仅用于查询
    /// </summary>
    public abstract class BaseRepository<TAggregateRoot> : IRepository<TAggregateRoot>
        where TAggregateRoot : class, IAggregateRoot
    {
        /// <summary>
        /// 只读的基于继承IAggregateRoot的类的可查询的类对象集合
        /// </summary>
        public readonly IQueryable<TAggregateRoot> _entities;

        /// <summary>
        /// 仓储类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public BaseRepository(IDbContext dbContext)
        {
            _entities = (IQueryable<TAggregateRoot>)dbContext.Set<TAggregateRoot>();
        }

        //public IQueryable<TAggregateRoot> Get(int id)
        //{
        //    return _entities.Where(t => t.Id == id);
        //}

        /// <summary>
        /// 得到该表的所有的对象
        /// </summary>
        public IQueryable<TAggregateRoot> GetAll()
        {
            return _entities;
        }
    }
}
