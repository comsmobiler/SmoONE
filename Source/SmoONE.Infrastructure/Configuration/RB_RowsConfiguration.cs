using SmoONE.Domain;
using System;
using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmoONE.Infrastructure
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2016/11
    // 主要内容：  报销明细表的配置信息类,通过Fluent API补全配置信息(最终的配置为DataAnnotations配置的+Fluent API配置的)
    // ******************************************************************
    /// <summary>
    /// 报销明细表的配置信息类
    /// </summary>
    public class RB_RowsConfiguration : EntityTypeConfiguration<RB_Rows>
    {
        /// <summary>
        /// 配置报销明细表的映射信息
        /// </summary>
        public RB_RowsConfiguration()
        {
            Property(l => l.R_Amount).IsRequired().HasPrecision(10, 2);
        }
    }
}



