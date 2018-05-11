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
    // 主要内容： 月统计数据
    // ******************************************************************
    /// <summary>
    /// 月统计数据
    /// </summary>
    [Table("MonthlyResult")]
    public class MonthlyResult : IAggregateRoot
    {
        /// <summary>
        /// 月统计信息ID
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("月统计日期ID")]
        public int MR_ID { get; set; }

        /// <summary>
        /// 统计年份
        /// </summary>
        [DisplayName("统计年份")]
        public int MR_Year { get; set; }

        /// <summary>
        /// 统计月份
        /// </summary>
        [DisplayName("统计月份")]
        public int MR_Month { get; set; }

        /// <summary>
        /// 应该签到人数
        /// </summary>
        [Required]
        [DisplayName("应该签到人数")]
        public int MR_AllUserCount { get; set; }

        /// <summary>
        /// 全月正常签到人数
        /// </summary>
        [Required]
        [DisplayName("全月正常签到人数")]
        public int MR_InTimeUserCount { get; set; }

        /// <summary>
        /// 全月正常签到人员
        /// </summary>
        [DisplayName("全月正常签到人员")]
        public string MR_InTimeUser { get; set; }

        /// <summary>
        /// 迟到人数
        /// </summary>
        [Required]
        [DisplayName("迟到人数")]
        public int MR_ComeLateUserCount { get; set; }

        /// <summary>
        /// 迟到人员
        /// </summary>
        [DisplayName("迟到人员")]
        public string MR_ComeLateUser { get; set; }

        /// <summary>
        /// 早退人数
        /// </summary>
        [Required]
        [DisplayName("早退人数")]
        public int MR_LeaveEarlyUserCount { get; set; }

        /// <summary>
        /// 早退人员
        /// </summary>
        [DisplayName("早退人员")]
        public string MR_LeaveEarlyUser { get; set; }

        /// <summary>
        /// 未签人数
        /// </summary>
        [Required]
        [DisplayName("未签人数")]
        public int MR_NoSignUserCount { get; set; }

        /// <summary>
        /// 未签人员
        /// </summary>
        [DisplayName("未签人员")]
        public string MR_NoSignUser { get; set; }

        /// <summary>
        /// 全天旷工人数
        /// </summary>
        [Required]
        [DisplayName("全天旷工人数")]
        public int MR_AbsentUserCount { get; set; }

        /// <summary>
        /// 全天旷工人员
        /// </summary>
        [DisplayName("全天旷工人员")]
        public string MR_AbsentUser { get; set; }
    }
}
