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
    // 主要内容： 用户的历史的工作日的日统计数据
    // ******************************************************************
    /// <summary>
    /// 用户的历史的工作日的日统计数据
    /// </summary>
    [Table("DailyStatistics")]
    public class DailyStatistics : IAggregateRoot
    {
        /// <summary>
        /// 日统计信息ID
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("日统计信息ID")]
        public int DS_ID { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [StringLength(maximumLength: 20)]
        [DisplayName("用户ID")]
        public string DS_UserID { get; set; }

        /// <summary>
        /// 统计日期
        /// </summary>
        [Column(TypeName = "datetime2")]
        [DisplayName("统计日期")]
        public DateTime DS_Date { get; set; }

        /// <summary>
        /// 应该签到次数
        /// </summary>
        [Required]
        [DisplayName("应该签到次数")]
        public int DS_AllCount { get; set; }

        /// <summary>
        /// 实际签到次数
        /// </summary>
        [Required]
        [DisplayName("实际签到次数")]
        public int DS_RealCount { get; set; }

        /// <summary>
        /// 正常签到次数
        /// </summary>
        [Required]
        [DisplayName("正常签到次数")]
        public int DS_InTimeCount { get; set; }

        /// <summary>
        /// 迟到次数
        /// </summary>
        [Required]
        [DisplayName("迟到次数")]
        public int DS_ComeLateCount { get; set; }

        /// <summary>
        /// 早退次数
        /// </summary>
        [Required]
        [DisplayName("早退次数")]
        public int DS_LeaveEarlyCount { get; set; }

        /// <summary>
        /// 未签到次数
        /// </summary>
        [Required]
        [DisplayName("未签到次数")]
        public int DS_NoSignInCount { get; set; }

        /// <summary>
        /// 未签退次数
        /// </summary>
        [Required]
        [DisplayName("未签退次数")]
        public int DS_NoSignOutCount { get; set; }

        /// <summary>
        /// 是否为正常签到天
        /// </summary>
        [Required]
        [DisplayName("是否为正常签到天")]
        public int DS_IsNormal { get; set; }

        /// <summary>
        /// 是否全天旷工
        /// </summary>
        [Required]
        [DisplayName("是否全天旷工")]
        public int DS_IsAbsent { get; set; }
    }
}

