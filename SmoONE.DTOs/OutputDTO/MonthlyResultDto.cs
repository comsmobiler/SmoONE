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
    // 主要内容： 历史的月统计数据,用于返回查询结果
    // ******************************************************************
    /// <summary>
    /// 历史的月统计数据,用于返回查询结果
    /// </summary>
    public class MonthlyResultDto
    {
        /// <summary>
        /// 月统计信息ID
        /// </summary>
        public int MR_ID { get; set; }

        /// <summary>
        /// 统计年份
        /// </summary>
        public int MR_Year { get; set; }

        /// <summary>
        /// 统计月份
        /// </summary>
        public int MR_Month { get; set; }

        /// <summary>
        /// 应该签到人数
        /// </summary>
        public int MR_AllUserCount { get; set; }

        /// <summary>
        /// 全月正常签到人数
        /// </summary>
        public int MR_InTimeUserCount { get; set; }

        /// <summary>
        /// 全月正常签到人员
        /// </summary>
        public string MR_InTimeUser { get; set; }

        /// <summary>
        /// 迟到人数
        /// </summary>
        public int MR_ComeLateUserCount { get; set; }

        /// <summary>
        /// 迟到人员
        /// </summary>
        public string MR_ComeLateUser { get; set; }

        /// <summary>
        /// 早退人数
        /// </summary>
        public int MR_LeaveEarlyUserCount { get; set; }

        /// <summary>
        /// 早退人员
        /// </summary>
        public string MR_LeaveEarlyUser { get; set; }

        /// <summary>
        /// 未签人数
        /// </summary>
        public int MR_NoSignUserCount { get; set; }

        /// <summary>
        /// 未签人员
        /// </summary>
        public string MR_NoSignUser { get; set; }

        /// <summary>
        /// 全天旷工人数
        /// </summary>
        public int MR_AbsentUserCount { get; set; }

        /// <summary>
        /// 全天旷工人员
        /// </summary>
        public string MR_AbsentUser { get; set; }
    }
}
