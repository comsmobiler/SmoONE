using SmoONE.Domain;
using System;
using System.Collections.Generic;
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
    // 主要内容：  成本中心表的配置信息类,通过Fluent API补全配置信息(最终的配置为DataAnnotations配置的+Fluent API配置的)
    // ******************************************************************
    /// <summary>
    /// 成本中心表的配置信息类
    /// </summary>
    public class CostCenterConfiguration: EntityTypeConfiguration<CostCenter>
    {
        /// <summary>
        /// 配置成本中心表的映射信息
        /// </summary>
        public CostCenterConfiguration()
        {
            Property(l => l.CC_Amount).HasPrecision(10, 2);
            Property(l => l.CC_UsedAmount).HasPrecision(10, 2);
        }
    }
}
