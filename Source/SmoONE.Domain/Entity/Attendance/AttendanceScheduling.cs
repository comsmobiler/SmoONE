using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace SmoONE.Domain
{
    // ******************************************************************
    // 文件版本： SmoONE 1.1
    // Copyright  (c)  2016-2017 Smobiler 
    // 创建时间： 2017/2
    // 主要内容： 考勤排班
    // ******************************************************************
    /// <summary>
    /// 考勤排班
    /// </summary>
    [Table("AttendanceScheduling")]
    public class AttendanceScheduling : IAggregateRoot
    {
        /// <summary>
        /// 考勤排班ID
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("考勤排班表ID")]
        public int AS_ID { get; set; }

        /// <summary>
        /// 考勤模板ID
        /// </summary>
        [Required]
        [StringLength(maximumLength: 20)]
        [DisplayName("考勤模板ID")]
        public string AS_ATID { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        [Column(TypeName = "datetime2")]
        [DisplayName("日期")]
        public DateTime AS_DateTime { get; set; }

        /// <summary>
        /// 上下班类型
        /// </summary>
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("上下班类型")]
        public string AS_CommutingType { get; set; }

        /// <summary>
        /// 排班类型
        /// </summary>
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("排班类型")]
        public string AS_ASType { get; set; }

        /// <summary>
        /// 上班时间
        /// </summary>
        [Column(TypeName = "datetime2")]
        [DisplayName("上班时间")]
        public DateTime? AS_StartTime { get; set; }

        /// <summary>
        /// 下班时间
        /// </summary>
        [Column(TypeName = "datetime2")]
        [DisplayName("下班时间")]
        public DateTime? AS_EndTime { get; set; }

        /// <summary>
        /// 上午上班时间
        /// </summary>
        [Column(TypeName = "datetime2")]
        [DisplayName("上午上班时间")]
        public DateTime? AS_AMStartTime { get; set; }

        /// <summary>
        /// 上午下班时间
        /// </summary>
        [Column(TypeName = "datetime2")]
        [DisplayName("上午下班时间")]
        public DateTime? AS_AMEndTime { get; set; }

        /// <summary>
        /// 下午上班时间
        /// </summary>
        [Column(TypeName = "datetime2")]
        [DisplayName("下午上班时间")]
        public DateTime? AS_PMStartTime { get; set; }

        /// <summary>
        /// 下午下班时间
        /// </summary>
        [Column(TypeName = "datetime2")]
        [DisplayName("下午下班时间")]
        public DateTime? AS_PMEndTime { get; set; }

        /// <summary>
        /// 考勤的用户
        /// </summary>
        [Required]
        [DisplayName("考勤的用户")]
        public string AS_Users{ get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [Range(0, 180, ErrorMessage = "经度范围为0-180.")]
        public decimal AS_Longitude { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [Range(0, 90, ErrorMessage = "纬度范围为0-90.")]
        public decimal AS_Latitude { get; set; }

        /// <summary>
        /// 考勤地点
        /// </summary>
        [Required]
        [StringLength(maximumLength: 500, ErrorMessage = "长度不能超过500")]
        [DisplayName("考勤地点")]
        public string AS_Positions { get; set; }

        /// <summary>
        /// 允许的偏差值
        /// </summary>
        [Required]
        [DisplayName("允许的偏差值")]
        public int AS_AllowableDeviation { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        [Column(TypeName = "datetime2")]
        [DisplayName("创建日期")]
        public DateTime AS_CreateDate { get; set; }

        /// <summary>
        /// 应签次数
        /// </summary>
        [Required]
        [DisplayName("应签次数")]
        public int AS_LogCount { get; set; }
    }
}
