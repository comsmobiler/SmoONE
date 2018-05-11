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
    // 主要内容：  消费明细的数据传输对象,用于返回查询结果
    // ******************************************************************
    /// <summary>
    /// 消费明细的数据传输对象,用于返回查询结果
    /// </summary>
    public class RB_RowsDto
    {
        /// <summary>
        /// 报销明细ID
        /// </summary>
        public int R_ID { get; set; }

        /// <summary>
        /// 报销单ID
        /// </summary>
        public string RB_ID { get; set; }

        /// <summary>
        /// 报销明细金额
        /// </summary>
        public decimal R_Amount { get; set; }

        /// <summary>
        /// 报销类型ID
        /// </summary>
        public string R_TypeID { get; set; }

        /// <summary>
        /// 报销类型名称
        /// </summary>
        public string R_TypeName { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string R_Note { get; set; }

        /// <summary>
        /// 创建者
        /// </summary>
        public string R_CreateUser { get; set; }

        /// <summary>
        /// 消费时间
        /// </summary>
        public DateTime R_ConsumeDate { get; set; }
    }
}
