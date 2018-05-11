using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmoONE.DTOs
{
    /// <summary>
    /// 一段时间内的统计信息
    /// </summary>
    public class ResultInfo
    {
        /// <summary>
        /// 应该签到人数
        /// </summary>
        public int AllUserCount { get; set; }

        /// <summary>
        /// 正常签到人数
        /// </summary>
        public int InTimeUserCount { get; set; }

        /// <summary>
        /// 正常签到人员
        /// </summary>
        public string InTimeUser { get; set; }

        /// <summary>
        /// 迟到人数
        /// </summary>
        public int ComeLateUserCount { get; set; }

        /// <summary>
        /// 迟到人员
        /// </summary>
        public string ComeLateUser { get; set; }

        /// <summary>
        /// 早退人数
        /// </summary>
        public int LeaveEarlyUserCount { get; set; }

        /// <summary>
        /// 早退人员
        /// </summary>
        public string LeaveEarlyUser { get; set; }

        /// <summary>
        /// 未签人数
        /// </summary>
        public int NoSignUserCount { get; set; }

        /// <summary>
        /// 未签人员
        /// </summary>
        public string NoSignUser { get; set; }

        /// <summary>
        /// 全天旷工人数
        /// </summary>
        public int AbsentUserCount { get; set; }

        /// <summary>
        /// 全天旷工人员
        /// </summary>
        public string AbsentUser { get; set; }
    }
}

