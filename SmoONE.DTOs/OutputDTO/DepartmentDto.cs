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
    // 主要内容：  部门列表里的传输对象,用于返回查询结果
    // ******************************************************************
    /// <summary>
    /// 部门列表里的传输对象,用于返回查询结果
    /// </summary>
    public class DepartmentDto
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
        /// 负责人
        /// </summary>
        public string Dep_Leader { get; set; }

        /// <summary>
        /// 责任人昵称
        /// </summary>
        public string U_Name { get; set; }

        /// <summary>
        /// 部门头像
        /// </summary>
        public string Dep_Icon { get; set; }
    }
}
