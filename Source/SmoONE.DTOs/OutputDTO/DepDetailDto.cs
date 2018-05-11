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
    // 主要内容：  部门详情传输对象,用于返回查询结果
    // ******************************************************************
    /// <summary>
    /// 部门详情传输对象,用于返回查询结果
    /// </summary>
    public class DepDetailDto
    {
        /// <summary>
        /// 部门ID
        /// </summary>
        public string Dep_ID { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        public string Dep_Name { get; set; }

        /// <summary>
        /// 是否激活
        /// </summary>
        public int Dep_IsActive { get; set; }

        /// <summary>
        /// 负责人
        /// </summary>
        public string Dep_Leader { get; set; }

        /// <summary>
        /// 负责人昵称
        /// </summary>
        public string U_Name { get; set; }

        /// <summary>
        /// 目标项目/人天
        /// </summary>
        public decimal Dep_ProDay { get; set; }

        /// <summary>
        /// 目标其他/人天
        /// </summary>
        public decimal Dep_OtherDay { get; set; }

        /// <summary>
        /// 部门头像
        /// </summary>
        public string Dep_Icon { get; set; }

    }
}
