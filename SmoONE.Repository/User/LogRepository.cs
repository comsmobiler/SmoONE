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
    // 主要内容：  日志的仓储接口,仅用于查询
    // ******************************************************************

    /// <summary>
    /// 日志的仓储接口,仅用于查询
    /// </summary>
    public class LogRepository : BaseRepository<Log>, ILogRepository
    {
        /// <summary>
        /// 仓储类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public LogRepository(IDbContext dbContext)
            : base(dbContext)
        { }

        /// <summary>
        /// 根据日志ID返回日志对象
        /// </summary>
        /// <param name="ID">日志ID</param>
        public IQueryable<Log> GetByID(int ID)
        {
            return _entities.Where(x => x.L_ID == ID);
        }

        /// <summary>
        /// 根据用户ID返回日志对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        public IQueryable<Log> GetByUserID(string UserID)
        {
            return _entities.Where(x => x.U_ID == UserID);
        }
    }
}
