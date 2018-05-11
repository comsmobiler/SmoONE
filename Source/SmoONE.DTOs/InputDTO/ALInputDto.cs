using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SmoONE.DTOs
{
    // ******************************************************************
    // 文件版本： SmoONE 1.1
    // Copyright  (c)  2016-2017 Smobiler 
    // 创建时间： 2017/2
    // 主要内容： 考勤日志传输对象,用于提供新增/更新所需的数据
    // ******************************************************************
    /// <summary>
    /// 考勤日志传输对象,用于提供新增/更新所需的数据
    /// </summary>
    public class ALInputDto:IEntity
    {
        /// <summary>
        /// 考勤日志ID
        /// </summary>
        [Key]
        [DisplayName("考勤日志ID")]
        public int AL_LogID { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [Required]
        [StringLength(maximumLength: 20)]
        [DisplayName("用户")]
        public string AL_UserID { get; set; }

        /// <summary>
        /// 考勤日期
        /// </summary>
        [Required]
        [DisplayName("考勤日期")]
        public DateTime AL_Date { get; set; }

        /// <summary>
        /// 上下班类型
        /// </summary>
        [Required]
        [DisplayName("上下班类型")]
        public WorkTimeType AL_CommutingType { get; set; }

        /// <summary>
        /// 准点时间
        /// </summary>
        [Required]
        [DisplayName("准点时间")]
        public DateTime AL_OnTime { get; set; }

        /// <summary>
        /// 所属的时间
        /// </summary>
        [Required]
        [DisplayName("所属的时间")]
        public StatisticsTime AL_LogTimeType { get; set; }

        /// <summary>
        /// 签到类型
        /// </summary>
        [Required]
        [DisplayName("签到类型")]
        public AttendanceType AL_Status { get; set; }

        /// <summary>
        /// 考勤地点
        /// </summary>
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "长度不能超过50.")]
        [DisplayName("考勤地点")]
        public string AL_Position { get; set; }

        /// <summary>
        /// 迟到/早退的理由
        /// </summary>
        [StringLength(maximumLength: 200, ErrorMessage = "长度不能超过200.")]
        [DisplayName("迟到/早退的理由")]
        public string AL_Reason { get; set; }
    }
}
