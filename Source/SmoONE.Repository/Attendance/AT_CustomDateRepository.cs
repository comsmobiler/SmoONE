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
    // 主要内容： 考勤模板的自定义日期的仓储接口实现,仅用于查询
    // ******************************************************************
    /// <summary>
    /// 考勤模板的自定义日期的仓储接口实现,仅用于查询
    /// </summary>
    public class AT_CustomDateRepository : BaseRepository<AT_CustomDate>, IAT_CustomDateRepository
    {
        /// <summary>
        /// 仓储类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public AT_CustomDateRepository(IDbContext dbContext)
            : base(dbContext)
        { }

        /// <summary>
        /// 根据自定义日期ID返回自定义日期对象
        /// </summary>
        /// <param name="ID">自定义日期ID</param>
        public IQueryable<AT_CustomDate> GetByID(int ID)
        {
            return _entities.Where(x => x.AT_CD_ID == ID);
        }

        /// <summary>
        /// 根据考勤模板ID返回自定义日期对象
        /// </summary>
        /// <param name="ATID">考勤模板ID</param>
        public IQueryable<AT_CustomDate> GetByATID(string ATID)
        {
            return _entities.Where(x => x.AT_CD_ATID == ATID);
        }

        /// <summary>
        /// 判断某考勤模板ID和日期是否存在自定义日期对象
        /// </summary>
        /// <param name="ATID">考勤模板ID</param>
        /// <param name="Date">日期</param>
        public bool IsExistByATIDandDate(string ATID, DateTime Date)
        {
            return _entities.Any(x => x.AT_CD_ATID == ATID && x.AT_CD_Date == Date);
        }

        /// <summary>
        /// 根据考勤模板ID和日期返回自定义日期对象
        /// </summary>
        /// <param name="ATID">考勤模板ID</param>
        /// <param name="Date">日期</param>
        public IQueryable<AT_CustomDate> GetByATIDandDate(string ATID, DateTime Date)
        {
            return _entities.Where(x => x.AT_CD_ATID == ATID && x.AT_CD_Date == Date);
        }


        /// <summary>
        /// 根据考勤模板ID和时间段返回自定义日期对象
        /// </summary>
        /// <param name="ATID">考勤模板ID</param>
        /// <param name="StartDate">开始日期</param>
        /// <param name="EndDate">结束日期</param>
        public IQueryable<AT_CustomDate> GetByATIDandDatePeriod(string ATID, DateTime StartDate, DateTime EndDate)
        {
            return _entities.Where(x => x.AT_CD_ATID == ATID && x.AT_CD_Date>=StartDate&&x.AT_CD_Date<=EndDate);
        }

        /// <summary>
        /// 根据考勤模板ID得到今天之后的自定义日期
        /// </summary>
        /// <param name="ATID">考勤模板ID</param>
        public IQueryable<AT_CustomDate> GetFutureATCDByATID(string ATID)
        {
            DateTime dt = DateTime.Now.AddDays(1).Date;
            return _entities.Where(x => x.AT_CD_ATID == ATID && x.AT_CD_Date >= dt);
        }
    }
}
