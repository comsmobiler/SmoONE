using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmoONE.DTOs
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2016/11
    // 主要内容：  成本中心类型模板的传输对象,用于返回查询结果
    // ******************************************************************
    /// <summary>
    /// 成本中心类型模板的传输对象,用于返回查询结果
    /// </summary>
    public class CC_Type_TemplateDto
    {
        /// <summary>
        /// 成本中心模板ID
        /// </summary>
        public string CC_TT_TemplateID { get; set; }

        /// <summary>
        /// 成本中心类型ID
        /// </summary>
        public string CC_TT_TypeID { get; set; }

        /// <summary>
        /// 成本中心类型名称
        /// </summary>
        public string CC_TT_TypeName { get; set; }

        /// <summary>
        /// 行政审批人
        /// </summary>
        public string CC_TT_AEACheckers { get; set; }

        /// <summary>
        /// 财政审批人
        /// </summary>
        public string CC_TT_FinancialCheckers { get; set; }
    }
}
