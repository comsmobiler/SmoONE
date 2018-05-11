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
    // 主要内容：  用户表详情的传输对象,用于返回查询结果
    // ******************************************************************
    /// <summary>
    /// 用户表详情的传输对象,用于返回查询结果
    /// </summary>
    public class UserDetailDto
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public string U_ID { get; set; }

        /// <summary>
        /// 用户昵称
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
        /// 邮箱
        /// </summary>
        public string U_Email { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        public string U_Tel { get; set; }


        /// <summary>
        /// 是否审批人
        /// </summary>
        public int U_IsCheck { get; set; }

        /// <summary>
        /// 是否抄送人
        /// </summary>
        public int U_IsCC { get; set; }

        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime U_Birthday { get; set; }

        /// <summary>
        /// 部门ID
        /// </summary>
        public string U_DepID { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        public string U_DepName { get; set; }

        /// <summary>
        /// 手势
        /// </summary>
        public string U_Gestures { get; set; }
    }
}
