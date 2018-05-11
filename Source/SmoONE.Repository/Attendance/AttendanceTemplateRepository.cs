using SmoONE.Domain;
using SmoONE.Domain.IRepository;
using SmoONE.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmoONE.Repository
{
    // ******************************************************************
    // 文件版本： SmoONE 1.1
    // Copyright  (c)  2016-2017 Smobiler 
    // 创建时间： 2017/2
    // 主要内容： 考勤模板的仓储实现,仅用于查询
    // ******************************************************************
    /// <summary>
    /// 考勤模板的仓储实现,仅用于查询
    /// </summary>
    public class AttendanceTemplateRepository : BaseRepository<AttendanceTemplate>, IAttendanceTemplateRepository
    {
        /// <summary>
        /// 仓储类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public AttendanceTemplateRepository(IDbContext dbContext)
            : base(dbContext)
        { }

        /// <summary>
        /// 根据考勤模板ID返回考勤模板对象
        /// </summary>
        /// <param name="ID">考勤模板ID</param>
        public IQueryable<AttendanceTemplate> GetByID(string ID)
        {
            return _entities.Where(x => x.AT_ID == ID);
        }

        /// <summary>
        /// 得到用户当前的考勤模板
        /// </summary>
        /// <param name="UserID">用户ID</param>
        public IQueryable<AttendanceTemplate> GetCurrentATByUser(string UserID)
        {
            return _entities.Where(x => x.AT_Users.Contains(UserID));
        }

        /// <summary>
        /// 根据日期返回考勤模板对象
        /// </summary>
        /// <param name="Date">日期</param>
        public IQueryable<AttendanceTemplate> GetByDate(DateTime Date)
        { 
            DateTime date=Date.Date;
            return _entities.Where(x => x.AT_CreateDate < date);
        }

        /// <summary>
        /// 得到最大的成本中心ID
        /// </summary>
        public string GetMaxID()
        {
            return _entities.Select(e => e.AT_ID).Max();
        }
    }
}
