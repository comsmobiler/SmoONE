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
    // 主要内容：  请假单仓储的实现,仅用于查询
    // ******************************************************************

    /// <summary>
    /// 请假单仓储的实现,仅用于查询
    /// </summary>
    public class LeaveRepository : BaseRepository<Leave>, ILeaveRepository
    {
        /// <summary>
        /// 仓储类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public LeaveRepository(IDbContext dbContext)
            : base(dbContext)
        { }

        /// <summary>
        /// 根据请假单ID返回请假单对象
        /// </summary>
        /// <param name="ID">请假单ID</param>
        public IQueryable<Leave> GetByID(string ID)
        {
            return _entities.Where(x => x.L_ID == ID);
        }

        /// <summary>
        /// 根据审批用户ID返回请假单传输对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        public IQueryable<Leave> GetByCheckUsers(string UserID)
        {
            return _entities.Where(x => x.L_CheckUsers.Contains(UserID)).OrderByDescending(o => o.L_ID).AsNoTracking();
        }

        /// <summary>
        /// 根据审批用户ID返回待审批请假单传输对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        public IQueryable<Leave> GetNewByCheckUsers(string UserID)
        {
            return _entities.Where(x => x.L_CheckUsers.Contains(UserID) && x.L_Status == 0).OrderByDescending(o => o.L_ID).AsNoTracking();
        }

        /// <summary>
        /// 根据审批用户ID返回已审批请假单传输对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        public IQueryable<Leave> GetCheckedByCheckUsers(string UserID)
        {
            return _entities.Where(x => x.L_CurrantCheck == UserID).OrderByDescending(o => o.L_ID).AsNoTracking();
        }

        /// <summary>
        /// 根据审批用户ID和状态返回已审批请假单传输对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="Status">状态</param>
        public IQueryable<Leave> QueryCheckedByCheckUsers(string UserID, int Status)
        {
            return _entities.Where(x => x.L_CurrantCheck == UserID && x.L_Status == Status).OrderByDescending(o => o.L_ID).AsNoTracking();
        }

        /// <summary>
        /// 根据创建用户ID返回请假单传输对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        public IQueryable<Leave> GetByCreateUsers(string UserID)
        {
            return _entities.Where(x => x.L_CreateUser == UserID).OrderByDescending(o => o.L_ID).AsNoTracking();
        }

        /// <summary>
        /// 根据抄送用户ID返回请假单传输对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        public IQueryable<Leave> GetByCCTo(string UserID)
        {
            return _entities.Where(x => x.L_CCTo.Contains(UserID)).OrderByDescending(o => o.L_ID).AsNoTracking();
        }
      

        /// <summary>
        /// 得到最大的请假单ID
        /// </summary>
        public string GetMaxID()
        {
            return _entities.Select(e => e.L_ID).Max();
        }
    }
}

