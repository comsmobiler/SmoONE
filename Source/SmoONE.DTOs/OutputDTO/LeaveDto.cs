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
    // 主要内容：  请假单列表里的传输对象,用于返回查询结果
    // ******************************************************************
    /// <summary>
    /// 请假单列表里的传输对象,用于返回查询结果
    /// </summary>
    public class LeaveDto
    {
        /// <summary>
        /// 创建用户ID
        /// </summary>
        public string U_ID { get; set; }

        /// <summary>
        /// 创建用户的名称
        /// </summary>
        public string U_Name { get; set; }

        /// <summary>
        /// 所有审批用户ID
        /// </summary>
        public string L_CheckUsers { get; set; }

        /// <summary>
        /// 创建用户的头像
        /// </summary>
        public string U_Portrait { get; set; }

        /// <summary>
        /// 请假单ID
        /// </summary>
        public string L_ID { get; set; }

        /// <summary>
        /// 请假天数
        /// </summary>
        public decimal L_LDay { get; set; }

        /// <summary>
        /// 请假事由
        /// </summary>
        public string L_Reason { get; set; }

        /// <summary>
        /// 请假单状态
        /// </summary>
        public int L_Status { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime L_CreateDate { get; set; }
    }
}

