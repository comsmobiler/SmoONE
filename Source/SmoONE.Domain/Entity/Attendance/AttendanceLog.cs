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
    // 主要内容： 考勤日志
    // ******************************************************************
    /// <summary>
    /// 考勤日志
    /// </summary>
    [Table("AttendanceLog")]
    public class AttendanceLog : IAggregateRoot
    {
        /// <summary>
        /// 考勤日志ID
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
        [Column(TypeName = "datetime2")]
        [DisplayName("考勤日期")]
        public DateTime AL_Date { get; set; }

        /// <summary>
        /// 上下班类型
        /// </summary>
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("上下班类型")]
        public string AL_CommutingType { get; set; }

        /// <summary>
        /// 所属的时间
        /// </summary>
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("所属的时间")]
        public string AL_LogTimeType { get; set; }

        /// <summary>
        /// 准点时间
        /// </summary>
        [Required]
        [Column(TypeName = "datetime2")]
        [DisplayName("准点时间")]
        public DateTime AL_OnTime { get; set; }

        /// <summary>
        /// 签到类型
        /// </summary>
        [Required]
        [DisplayName("签到类型")]
        public string AL_Status { get; set; }

        /// <summary>
        /// 考勤地点
        /// </summary>
        [StringLength(maximumLength: 50, ErrorMessage = "长度不能超过50")]
        [DisplayName("考勤地点")]
        public string AL_Position { get; set; }

        /// <summary>
        /// 迟到/早退的理由
        /// </summary>
        [StringLength(maximumLength: 200, ErrorMessage = "长度不能超过200")]
        [DisplayName("迟到/早退的理由")]
        public string AL_Reason { get; set; }
    }
}
