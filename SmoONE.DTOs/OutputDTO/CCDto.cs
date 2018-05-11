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
    // 主要内容：  成本中心列表里的传输对象,用于返回查询结果
    // ******************************************************************
    /// <summary>
    /// 成本中心列表里的传输对象,用于返回查询结果
    /// </summary>
    public class CCDto
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
        /// 成本中心金额
        /// </summary>
        public decimal CC_Amount { get; set; }

        /// <summary>
        /// 成本中心已使用金额
        /// </summary>
        public decimal CC_UsedAmount { get; set; }

        /// <summary>
        /// 成本中心责任人
        /// </summary>
        public string CC_LiableMan { get; set; }
    }
}
