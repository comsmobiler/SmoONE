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
    // 主要内容： 用户返回用户的历史的工作日的日统计数据,用于返回查询结果
    // ******************************************************************
    /// <summary>
    /// 用户返回用户的历史的工作日的日统计数据,用于返回查询结果
    /// </summary>
    public class DailyStatisticsDto
    {
        /// <summary>
        /// 日统计信息ID
        /// </summary>
        public int DS_ID { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public string DS_UserID { get; set; }

        /// <summary>
        /// 统计日期
        /// </summary>
        public DateTime DS_Date { get; set; }

        /// <summary>
        /// 应该签到次数
        /// </summary>
        public int DS_AllCount { get; set; }

        /// <summary>
        /// 实际签到次数
        /// </summary>
        public int DS_RealCount { get; set; }

        /// <summary>
        /// 正常签到次数
        /// </summary>
        public int DS_InTimeCount { get; set; }

        /// <summary>
        /// 迟到次数
        /// </summary>
        public int DS_ComeLateCount { get; set; }

        /// <summary>
        /// 早退次数
        /// </summary>
        public int DS_LeaveEarlyCount { get; set; }

        /// <summary>
        /// 未签到次数
        /// </summary>
        public int DS_NoSignInCount { get; set; }

        /// <summary>
        /// 未签退次数
        /// </summary>
        public int DS_NoSignOutCount { get; set; }

        /// <summary>
        /// 是否为正常签到天
        /// </summary>
        public int DS_IsNormal { get; set; }

        /// <summary>
        /// 是否全天旷工
        /// </summary>
        public int DS_IsAbsent { get; set; }

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
