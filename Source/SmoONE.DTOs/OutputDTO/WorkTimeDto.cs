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
    // 主要内容： 每天的工作时间,用于返回查询结果
    // ******************************************************************
    /// <summary>
    /// 每天的工作时间,用于返回查询结果
    /// </summary>
    public class WorkTimeDto
    {
        /// <summary>
        /// 排班类型
        /// </summary>
        public string AT_ASType { get; set; }

        /// <summary>
        /// 上下班类型
        /// </summary>
        public string AT_CommutingType { get; set; }

        /// <summary>
        /// 上班时间
        /// </summary>
        public DateTime? AT_StartTime { get; set; }

        /// <summary>
        /// 下班时间
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

        /// <summary>
        /// 经度
        /// </summary>
        public decimal AT_Longitude { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        public decimal AT_Latitude { get; set; }

        /// <summary>
        /// 考勤地点
        /// </summary>
        public string AT_Positions { get; set; }

        /// <summary>
        /// 允许的偏差值
        /// </summary>
        public int AT_AllowableDeviation { get; set; }
    }
}
