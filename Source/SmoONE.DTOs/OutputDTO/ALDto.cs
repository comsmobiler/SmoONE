using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmoONE.DTOs
{
    // ******************************************************************
    // 文件版本： SmoONE 1.1
    // Copyright  (c)  2016-2017 Smobiler 
    // 创建时间： 2017/2
    // 主要内容： 日志列表的数据传输对象,用于返回查询结果
    // ******************************************************************
    /// <summary>
    /// 日志列表的数据传输对象,用于返回查询结果
    /// </summary>
    public class ALDto
    {
        /// <summary>
        /// 考勤日志ID
        /// </summary>
        public int AL_LogID { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public string AL_UserID { get; set; }

        /// <summary>
        /// 考勤日期
        /// </summary>
        public DateTime AL_Date { get; set; }

        /// <summary>
        /// 上下班类型
        /// </summary>
        public string AL_CommutingType { get; set; }

        /// <summary>
        /// 准点时间
        /// </summary>
        public DateTime AL_OnTime { get; set; }

        /// <summary>
        /// 所属的时间
        /// </summary>
        public string AL_LogTimeType { get; set; }

        /// <summary>
        /// 签到类型
        /// </summary>
        public string AL_Status { get; set; }

        /// <summary>
        /// 考勤地点
        /// </summary>
        public string AL_Position { get; set; }

        /// <summary>
        /// 迟到/早退的理由
        /// </summary>
        public string AL_Reason { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string U_Name { get; set; }

        /// <summary>
        /// 用户头像
        /// </summary>
        public string U_Portrait { get; set; }
    }
}
