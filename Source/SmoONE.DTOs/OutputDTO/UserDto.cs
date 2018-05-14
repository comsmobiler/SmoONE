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
    // 主要内容：  用户表传输对象,用于返回查询结果
    // ******************************************************************
    /// <summary>
    /// 用户表传输对象,用于返回查询结果
    /// </summary>
    public class UserDto
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public string U_ID { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string U_Name { get; set; }

        /// <summary>
        /// 用户头像
        /// </summary>
        public string U_Portrait { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public int U_Sex { get; set; }

        /// <summary>
        /// 部门ID
        /// </summary>
        public string U_DepID { get; set; }

    }
}
