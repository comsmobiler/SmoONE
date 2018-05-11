using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmoONE.DTOs
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2016/11
    // 主要内容：  成本中心详情传输对象,用于返回查询结果
    // ******************************************************************
    /// <summary>
    /// 成本中心详情传输对象,用于返回查询结果
    /// </summary>
    public class CCDetailDto
    {
        /// <summary>
        /// 成本中心ID
        /// </summary>
        public string CC_ID { get; set; }

        /// <summary>
        /// 成本中心名称
        /// </summary>
        public string CC_Name { get; set; }

        /// <summary>
        /// 成本中心类型ID
        /// </summary>
        public string CC_TypeID { get; set; }


        /// <summary>
        /// 成本中心类型名称
        /// </summary>
        public string CC_TypeName { get; set; }
        /// <summary>
        /// 成本中心责任人
        /// </summary>
        public string CC_LiableMan { get; set; }

        /// <summary>
        /// 成本中心所属部门
        /// </summary>
        public string CC_DepartmentID { get; set; }

        /// <summary>
        /// 成本中心所属部门名称
        /// </summary>
        public string CC_DepName { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime CC_StartDate { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime CC_EndDate { get; set; }

        /// <summary>
        /// 成本中心金额
        /// </summary>
        public decimal CC_Amount { get; set; }

        /// <summary>
        /// 成本中心模板ID
        /// </summary>
        public string CC_TemplateID { get; set; }

        /// <summary>
        /// 成本中心已使用金额
        /// </summary>
        public decimal CC_UsedAmount { get; set; }

        /// <summary>
        /// 成本中心是否激活
        /// </summary>
        public int CC_IsActive { get; set; }


        /// <summary>
        /// 行政审批人
        /// </summary>
        public string CC_AEACheckers { get; set; }

        /// <summary>
        /// 财政审批人
        /// </summary>
        public string CC_FinancialCheckers { get; set; }
    }
}
