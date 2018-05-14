using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmoONE.Infrastructure
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2016/11
    // 主要内容：  工作单元的接口，用于处理增删改操作
    // ******************************************************************
    /// <summary>
    /// 工作单元的接口，用于处理增删改操作
    /// </summary>
    public interface IUnitOfWork
    {
        /// <summary>
        /// 新增
        /// </summary>
        void RegisterNew<TEntity>(TEntity entity)
            where TEntity : class;

        /// <summary>
        /// 更新
        /// </summary>
        void RegisterDirty<TEntity>(TEntity entity)
            where TEntity : class;

        /// <summary>
        /// 不更新
        /// </summary>
        void RegisterClean<TEntity>(TEntity entity)
            where TEntity : class;

        /// <summary>
        /// 删除
        /// </summary>
        void RegisterDeleted<TEntity>(TEntity entity)
            where TEntity : class;


        /// <summary>
        /// 直接提交
        /// </summary>
        bool Commit();

        /// <summary>
        /// 事务回滚
        /// </summary>
        void Rollback();
    }
}

