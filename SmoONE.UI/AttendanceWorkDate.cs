using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmoONE.UI
{
    // ******************************************************************
    // 文件版本： SmoONE 1.1
    // Copyright  (c)  2016-2017 Smobiler 
    // 创建时间： 2017/2
    // 主要内容： 考勤上下班时间
    // ******************************************************************
    class AttendanceWorkDate
    {
        /// <summary>
        /// 上下班类型
        /// </summary>
        public SmoONE.DTOs.WorkTimeType AT_Type { get; set; }

        /// <summary>
        /// 上午上班时间
        /// </summary>
        public DateTime? AT_StartTime { get; set; }

        /// <summary>
        /// 上午下班时间
        /// </summary>
        public DateTime? AT_EndTime { get; set; }

        /// <summary>
        /// 上午上班时间
        /// </summary>
        public DateTime? AT_AMStartTime { get; set; }

        /// <summary>
        /// 上午下班时间
        /// </summary>
        public DateTime? AT_AMEndTime { get; set; }

        /// <summary>
        /// 下午上班时间
        /// </summary>
        public DateTime? AT_PMStartTime { get; set; }

        /// <summary>
        /// 下午下班时间
        /// </summary>
        public DateTime? AT_PMEndTime { get; set; }
    }
}
