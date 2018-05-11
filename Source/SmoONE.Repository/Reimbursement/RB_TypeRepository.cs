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
    // 主要内容：  报销类型仓储的接实现,仅用于查询
    // ******************************************************************

    /// <summary>
    /// 报销类型仓储的接实现,仅用于查询
    /// </summary>
    public class RB_TypeRepository: BaseRepository<RB_RType>, IRB_TypeRepository
    {
        /// <summary>
        /// 仓储类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public RB_TypeRepository(IDbContext dbContext)
            : base(dbContext)
        { }

        /// <summary>
        /// 根据报销类型ID返回报销类型对象
        /// </summary>
        /// <param name="ID">报销类型ID</param>
        public RB_RType GetByID(string ID)
        {
            return _entities.Where(x => x.RB_RT_ID == ID).FirstOrDefault();
        }

    }
}