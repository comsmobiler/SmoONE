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
    // 主要内容：  菜单的仓储接口,仅用于查询
    // ******************************************************************

    /// <summary>
    /// 菜单的仓储接口,仅用于查询
    /// </summary>
    public class MenuRepository : BaseRepository<Menu>, IMenuRepository
    {
        /// <summary>
        /// 仓储类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public MenuRepository(IDbContext dbContext)
            : base(dbContext)
        { }

        /// <summary>
        /// 根据菜单ID返回菜单对象
        /// </summary>
        /// <param name="ID">菜单ID</param>
        public Menu GetByID(string ID)
        {
            return _entities.Where(x => x.M_MenuID == ID).FirstOrDefault();
        }

        /// <summary>
        /// 得到最大的菜单ID
        /// </summary>
        public string GetMaxID()
        {
            return _entities.Select(e => e.M_MenuID).Max();
        }
    }
}
