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
    // 主要内容：  部门的仓储接口,仅用于查询
    // ******************************************************************

    /// <summary>
    /// 部门的仓储接口,仅用于查询
    /// </summary>
    public class DepartmentRepository : BaseRepository<Department>, IDepartmentRepository
    {
        /// <summary>
        /// 仓储类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public DepartmentRepository(IDbContext dbContext)
            : base(dbContext)
        { }

        /// <summary>
        /// 根据部门ID返回部门对象
        /// </summary>
        /// <param name="ID">部门ID</param>
        public IQueryable<Department> GetByID(string ID)
        {
            return _entities.Where(x => x.Dep_ID == ID);
        }


        /// <summary>
        /// 查询该用户是否已经是责任人
        /// </summary>
        public bool IsLeader(string UserID)
        {
            return _entities.Any(x => x.Dep_Leader == UserID); 
        }

        
        /// <summary>
        /// 得到最大的部门ID
        /// </summary>
        public string GetMaxID()
        {
            return _entities.Select(e => e.Dep_ID).Max();
        }
    }
}
