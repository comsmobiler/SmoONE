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
    // 主要内容：  报销明细仓储的实现,仅用于查询
    // ******************************************************************

    /// <summary>
    /// 报销明细仓储的实现,仅用于查询
    /// </summary>
    public class RB_RowsRepository : BaseRepository<RB_Rows>, IRB_RowsRepository
    {
        /// <summary>
        /// 仓储类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public RB_RowsRepository(IDbContext dbContext)
            : base(dbContext)
        { }

        /// <summary>
        /// 根据报销明细ID返回报销明细对象
        /// </summary>
        /// <param name="ID">报销明细ID</param>
        public IQueryable<RB_Rows> GetByID(int ID)
        {
            return _entities.Where(x => x.R_ID == ID);
        }

        /// <summary>
        /// 根据报销单ID返回报销明细对象
        /// </summary>
        /// <param name="ID">报销单ID</param>
        public IQueryable<RB_Rows> GetByRBID(string ID)
        {
            return _entities.Where(x => x.RB_ID == ID).OrderByDescending(o => o.R_ID).AsNoTracking();
        }

        /// <summary>
        /// 根据用户ID返回未报销的消费明细对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        public IQueryable<RB_Rows> GetByCreateUser(string UserID)
        {
            return _entities.Where(x => x.R_CreateUser == UserID && (x.RB_ID == null || x.RB_ID == "")).OrderByDescending(o => o.R_ID).AsNoTracking();
        }      
    }
}


