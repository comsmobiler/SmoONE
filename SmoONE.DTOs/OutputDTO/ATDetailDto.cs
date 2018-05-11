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
    // 主要内容： 考勤模板详情的数据传输对象,用于返回查询结果
    // ******************************************************************
    /// <summary>
    /// 考勤模板详情的数据传输对象,用于返回查询结果
    /// </summary>
    public class ATDetailDto
    {
        /// <summary>
        /// 考勤模板ID
        /// </summary>
        public string AT_ID { get; set; }

        /// <summary>
        /// 考勤模板名称
        /// </summary>
        public string AT_Name { get; set; }

        /// <summary>
        /// 上下班类型
        /// </summary>
        public string AT_CommutingType { get; set; }

        /// <summary>
        /// 每周的上班时间
        /// </summary>
        public string AT_WeeklyWorkingDay { get; set; }

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
        /// 考勤的用户
        /// </summary>
        public string AT_Users { get; set; }

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

        /// <summary>
        /// 生效日期
        /// </summary>
        public DateTime AT_EffectiveDate { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime AT_CreateDate { get; set; }
    }
}
