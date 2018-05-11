using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmoONE.Infrastructure
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2016/11
    // 主要内容：  数据库初始化操作类,暂时不使用,因为直接调用产生的迁移文件会和项目中的迁移文件不同
    // ******************************************************************
    /// <summary>
    /// 数据库初始化操作类
    /// </summary>
    public static class DatabaseInitializer
    {
        /// <summary>
        /// 数据库初始化,暂时用不到
        /// </summary>
        public static void Initialize()
        {
            Database.SetInitializer<SmoONEDbContext>(
                    new CreateDatabaseIfNotExists<SmoONEDbContext>());
        }
    }
}
