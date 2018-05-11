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
    // 主要内容：  报销单列表里的数据传输对象,用于返回查询结果
    // ******************************************************************
    /// <summary>
    /// 报销单列表里的数据传输对象,用于返回查询结果
    /// </summary>
    public class ReimbursementDto
    {
        /// <summary>
        /// 创建用户ID
        /// </summary>
        public string U_ID { get; set; }

        /// <summary>
        /// 创建用户名称
        /// </summary>
        public string U_Name { get; set; }

        /// <summary>
        /// 成本中心责任人
        /// </summary>
        public string LiableMan { get; set; }

        /// <summary>
        /// 行政审批人
        /// </summary>
        public string AEACheckers { get; set; }

        /// <summary>
        /// 财政审批人
        /// </summary>
        public string FinancialCheckers { get; set; }

        /// <summary>
        /// 当前审批人
        /// </summary>
        public string CurrentCheck { get; set; }

        /// <summary>
        /// 创建用户的头像
        /// </summary>
        public string U_Portrait { get; set; }


        /// <summary>
        /// 报销单ID
        /// </summary>
        public string RB_ID { get; set; }

        /// <summary>
        /// 总金额
        /// </summary>
        public decimal RB_TotalAmount { get; set; }

        /// <summary>
        /// 报销单状态
        /// </summary>
        public int RB_Status { get; set; }

        /// <summary>
        /// 成本中心ID
        /// </summary>
        public string CC_ID { get; set; }

        /// <summary>
        /// 成本中心名称
        /// </summary>
        public string CC_Name {get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime RB_CreateDate { get; set; }
    }
}

