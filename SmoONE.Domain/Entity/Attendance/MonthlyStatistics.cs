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
    // 主要内容： 用户的历史的月统计数据
    // ******************************************************************
    /// <summary>
    /// 用户的历史的月统计数据
    /// </summary>
    [Table("MonthlyStatistics")]
    public class MonthlyStatistics:IAggregateRoot
    {
        /// <summary>
        /// 月统计信息ID
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("月统计信息ID")]
        public int MS_ID { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [StringLength(maximumLength: 20)]
        [DisplayName("用户ID")]
        public string MS_UserID { get; set; }

        /// <summary>
        /// 统计年份
        /// </summary>
        [DisplayName("统计年份")]
        public int MS_Year { get; set; }

        /// <summary>
        /// 统计月份
        /// </summary>
        [DisplayName("统计月份")]
        public int MS_Month { get; set; }

        /// <summary>
        /// 应该签到次数
        /// </summary>
        [Required]
        [DisplayName("应该签到次数")]
        public int MS_AllCount { get; set; }

        /// <summary>
        /// 实际签到次数
        /// </summary>
        [Required]
        [DisplayName("实际签到次数")]
        public int MS_RealCount { get; set; }

        /// <summary>
        /// 正常签到次数
        /// </summary>
        [Required]
        [DisplayName("正常签到次数")]
        public int MS_InTimeCount { get; set; }

        /// <summary>
        /// 迟到次数
        /// </summary>
        [Required]
        [DisplayName("迟到次数")]
        public int MS_ComeLateCount { get; set; }

        /// <summary>
        /// 早退次数
        /// </summary>
        [Required]
        [DisplayName("早退次数")]
        public int MS_LeaveEarlyCount { get; set; }

        /// <summary>
        /// 未签到次数
        /// </summary>
        [Required]
        [DisplayName("未签到次数")]
        public int MS_NoSignInCount { get; set; }

        /// <summary>
        /// 未签退次数
        /// </summary>
        [Required]
        [DisplayName("未签退次数")]
        public int MS_NoSignOutCount { get; set; }

        /// <summary>
        /// 应该签到天数
        /// </summary>
        [Required]
        [DisplayName("应该签到天数")]
        public int DS_AllDayCount { get; set; }

        /// <summary>
        /// 正常签到天数
        /// </summary>
        [Required]
        [DisplayName("正常签到天数")]
        public int DS_NormalDayCount { get; set; }

        /// <summary>
        /// 全天旷工天数
        /// </summary>
        [Required]
        [DisplayName("全天旷工天数")]
        public int DS_AbsentDayCount { get; set; }
    }
}
