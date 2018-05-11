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
    /// <summary>
    /// 日统计数据
    /// </summary>
    [Table("DailyResult")]
    public class DailyResult : IAggregateRoot
    {
        /// <summary>
        /// 日统计信息ID
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("日统计日期ID")]
        public int DR_ID { get; set; }

        /// <summary>
        /// 统计日期
        /// </summary>
        [Column(TypeName = "datetime2")]
        [DisplayName("统计日期")]
        public DateTime DR_Date { get; set; }

        /// <summary>
        /// 应该签到人数
        /// </summary>
        [Required]
        [DisplayName("应该签到人数")]
        public int DR_AllUserCount { get; set; }

        /// <summary>
        /// 全月正常签到人数
        /// </summary>
        [Required]
        [DisplayName("全月正常签到人数")]
        public int DR_InTimeUserCount { get; set; }

        /// <summary>
        /// 全月正常签到人员
        /// </summary>
        [Required]
        [DisplayName("全月正常签到人员")]
        public string DR_InTimeUser { get; set; }

        /// <summary>
        /// 迟到人数
        /// </summary>
        [Required]
        [DisplayName("迟到人数")]
        public int DR_ComeLateUserCount { get; set; }

        /// <summary>
        /// 迟到人员
        /// </summary>
        [Required]
        [DisplayName("迟到人员")]
        public string DR_ComeLateUser { get; set; }

        /// <summary>
        /// 早退人数
        /// </summary>
        [Required]
        [DisplayName("早退人数")]
        public int DR_LeaveEarlyUserCount { get; set; }

        /// <summary>
        /// 早退人员
        /// </summary>
        [Required]
        [DisplayName("早退人员")]
        public string DR_LeaveEarlyUser { get; set; }

        /// <summary>
        /// 未签人数
        /// </summary>
        [Required]
        [DisplayName("未签人数")]
        public int DR_NoSignUserCount { get; set; }

        /// <summary>
        /// 未签人员
        /// </summary>
        [Required]
        [DisplayName("未签人员")]
        public string DR_NoSignUser { get; set; }

        /// <summary>
        /// 全天旷工人数
        /// </summary>
        [Required]
        [DisplayName("全天旷工人数")]
        public int DR_AbsentUserCount { get; set; }

        /// <summary>
        /// 全天旷工人员
        /// </summary>
        [Required]
        [DisplayName("全天旷工人员")]
        public string DR_AbsentUser { get; set; }
    }
}
