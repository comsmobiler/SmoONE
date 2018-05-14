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
    // 主要内容： 自定义日期传输对象,用于提供新增/更新所需的数据
    // ******************************************************************
    /// <summary>
    /// 自定义日期传输对象,用于提供新增/更新所需的数据
    /// </summary>
    public class AT_CDInputDto:IEntity
    {
        /// <summary>
        /// 自定义日期ID
        /// </summary>
        [Key]
        [DisplayName("自定义日期ID")]
        public int AT_CD_ID { get; set; }

        /// <summary>
        /// 考勤模板ID
        /// </summary>
        [StringLength(maximumLength: 20)]
        [DisplayName("考勤模板ID")]
        public string AT_CD_ATID { get; set; }

        /// <summary>
        /// 上下班类型ID
        /// </summary>
        [Required]
        [DisplayName("上下班类型")]
        public WorkTimeType AT_CD_CommutingType { get; set; }

        /// <summary>
        /// 自定义日期
        /// </summary>
        [DisplayName("自定义日期")]
        public DateTime AT_CD_Date { get; set; }

        /// <summary>
        /// 自定义类型
        /// </summary>
        [Required]
        [DisplayName("自定义类型")]
        public WorkOrRest AT_CD_CDType { get; set; }

        /// <summary>
        /// 上午上班时间
        /// </summary>
        [DisplayName("上班时间")]
        public DateTime? AT_CD_StartTime { get; set; }

        /// <summary>
        /// 上午下班时间
        /// </summary>
        [DisplayName("下班时间")]
        public DateTime? AT_CD_EndTime { get; set; }

        /// <summary>
        /// 上午上班时间
        /// </summary>
        [DisplayName("上午上班时间")]
        public DateTime? AT_CD_AMStartTime { get; set; }

        /// <summary>
        /// 上午下班时间
        /// </summary>
        [DisplayName("上午下班时间")]
        public DateTime? AT_CD_AMEndTime { get; set; }

        /// <summary>
        /// 下午上班时间
        /// </summary>
        [DisplayName("下午上班时间")]
        public DateTime? AT_CD_PMStartTime { get; set; }

        /// <summary>
        /// 下午下班时间
        /// </summary>
        [DisplayName("下午下班时间")]
        public DateTime? AT_CD_PMEndTime { get; set; }
    }
}
