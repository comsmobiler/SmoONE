using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmoONE.DTOs
{
    /// <summary>
    /// 日统计数据
    /// </summary>
    public class DailyResultDto
    {
        /// <summary>
        /// 日统计信息ID
        /// </summary>
        public int DR_ID { get; set; }

        /// <summary>
        /// 统计日期
        /// </summary>
        public DateTime DR_Date { get; set; }

        /// <summary>
        /// 应该签到人数
        /// </summary>
        public int DR_AllUserCount { get; set; }

        /// <summary>
        /// 全月正常签到人数
        /// </summary>
        public int DR_InTimeUserCount { get; set; }

        /// <summary>
        /// 全月正常签到人员
        /// </summary>
        public string DR_InTimeUser { get; set; }

        /// <summary>
        /// 迟到人数
        /// </summary>
        public int DR_ComeLateUserCount { get; set; }

        /// <summary>
        /// 迟到人员
        /// </summary>
        public string DR_ComeLateUser { get; set; }

        /// <summary>
        /// 早退人数
        /// </summary>
        public int DR_LeaveEarlyUserCount { get; set; }

        /// <summary>
        /// 早退人员
        /// </summary>
        public string DR_LeaveEarlyUser { get; set; }

        /// <summary>
        /// 未签人数
        /// </summary>
        public int DR_NoSignUserCount { get; set; }

        /// <summary>
        /// 未签人员
        /// </summary>
        public string DR_NoSignUser { get; set; }

        /// <summary>
        /// 全天旷工人数
        /// </summary>
        public int DR_AbsentUserCount { get; set; }

        /// <summary>
        /// 全天旷工人员
        /// </summary>
        public string DR_AbsentUser { get; set; }
    }
}
