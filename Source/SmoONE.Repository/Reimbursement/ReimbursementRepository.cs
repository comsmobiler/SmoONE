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
    // 主要内容：  报销单仓储的实现,仅用于查询
    // ******************************************************************

    /// <summary>
    /// 报销单仓储的实现,仅用于查询
    /// </summary>
    public class ReimbursementRepository : BaseRepository<Reimbursement>, IReimbursementRepository
    {
        /// <summary>
        /// 仓储类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public ReimbursementRepository(IDbContext dbContext)
            : base(dbContext)
        { }

        /// <summary>
        /// 根据报销单ID返回报销单对象
        /// </summary>
        /// <param name="ID">报销单ID</param>
        public IQueryable< Reimbursement> GetByID(string ID)
        {
            return _entities.Where(x => x.RB_ID == ID);
        }

        /// <summary>
        /// 根据审批用户ID返回待审批的报销单传输对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        public IQueryable<Reimbursement> GetNewByCheckUsers(string UserID)
        {
            return _entities.Where(x => (x.RB_LiableMan.Contains(UserID) && x.RB_Status == 0) || (x.RB_AEACheckers.Contains(UserID) && x.RB_Status == 1) || (x.RB_FinancialCheckers.Contains(UserID) && x.RB_Status == 2)).OrderByDescending(o => o.RB_ID).AsNoTracking();
        }

        /// <summary>
        /// 根据审批用户ID和状态返回待审批报销单传输对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="Status">状态</param>
        public IQueryable<Reimbursement> QueryNewByCheckUsers(string UserID, int Status)
        {
            IQueryable<Reimbursement> rb = _entities;
            if (Status == 0)
            {
                rb = rb.Where(x => x.RB_LiableMan.Contains(UserID));
            }
            else if (Status == 1)
            {
                rb = rb.Where(x => x.RB_AEACheckers.Contains(UserID));
            }
            else if (Status == 2)
            {
                rb = rb.Where(x => x.RB_FinancialCheckers.Contains(UserID));
            }
            rb = rb.Where(x => x.RB_Status == Status).OrderByDescending(o => o.RB_ID);
            return rb.AsNoTracking();
        }

        /// <summary>
        /// 根据审批用户ID返回审批好的报销单传输对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        public IQueryable<Reimbursement> GetCheckedByCheckUsers(string UserID)
        {
            return _entities.Where(x => x.RB_CurrantCheck == UserID).OrderByDescending(o => o.RB_ID).AsNoTracking();
        }

        /// <summary>
        /// 根据审批用户ID和状态返回已审批报销单传输对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="Status">状态</param>
        public IQueryable<Reimbursement> QueryCheckedByCheckUsers(string UserID, int Status)
        {
            return _entities.Where(x => x.RB_CurrantCheck == UserID && x.RB_Status == Status).OrderByDescending(o => o.RB_ID).AsNoTracking();
        }


        /// <summary>
        /// 根据创建用户ID返回报销单传输对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        public IQueryable<Reimbursement> GetByCreateUsers(string UserID)
        {
            return _entities.Where(x => x.RB_CreateUser == UserID).OrderByDescending(o => o.RB_ID).AsNoTracking();
        }


        /// <summary>
        /// 根据成本中心返回报销单传输对象
        /// </summary>
        /// <param name="CCID">成本中心ID</param>
        public IQueryable<Reimbursement> GetByCCID(string CCID)
        {
            return _entities.Where(x => x.CC_ID  == CCID).OrderByDescending(o => o.RB_ID).AsNoTracking();

        }

        /// <summary>
        /// 得到最大的报销单ID
        /// </summary>
        public string GetMaxID()
        {
            return _entities.Select(e => e.RB_ID).Max();
        }
    }
}

