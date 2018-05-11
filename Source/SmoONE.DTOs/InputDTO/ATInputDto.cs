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
    // 主要内容： 考勤模板传输对象,用于提供新增/更新所需的数据
    // ******************************************************************
    /// <summary>
    /// 考勤模板传输对象,用于提供新增/更新所需的数据
    /// </summary>
    public class ATInputDto:IEntity
    {
        /// <summary>
        /// 考勤模板ID
        /// </summary>
        [Key]
        [StringLength(maximumLength: 20)]
        [DisplayName("考勤模板ID")]
        public string AT_ID { get; set; }

        /// <summary>
        /// 上下班类型
        /// </summary>
        [Required]
        [DisplayName("上下班类型")]
        public WorkTimeType AT_CommutingType { get; set; }

        /// <summary>
        /// 考勤模板名称
        /// </summary>
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("考勤模板名称")]
        public string AT_Name { get; set; }

        /// <summary>
        /// 每周的上班时间
        /// </summary>
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "长度不能超过50")]
        [DisplayName("每周的上班时间")]
        public string AT_WeeklyWorkingDay { get; set; }

        /// <summary>
        /// 上午上班时间
        /// </summary>
        [DisplayName("上班时间")]
        public DateTime? AT_StartTime { get; set; }

        /// <summary>
        /// 上午下班时间
        /// </summary>
        [DisplayName("下班时间")]
        public DateTime? AT_EndTime { get; set; }


        /// <summary>
        /// 上午上班时间
        /// </summary>
        [DisplayName("上午上班时间")]
        public DateTime? AT_AMStartTime { get; set; }

        /// <summary>
        /// 上午下班时间
        /// </summary>
        [DisplayName("上午下班时间")]
        public DateTime? AT_AMEndTime { get; set; }

        /// <summary>
        /// 下午上班时间
        /// </summary>
        [DisplayName("下午上班时间")]
        public DateTime? AT_PMStartTime { get; set; }

        /// <summary>
        /// 下午下班时间
        /// </summary>
        [DisplayName("下午下班时间")]
        public DateTime? AT_PMEndTime { get; set; }

        /// <summary>
        /// 考勤的用户
        /// </summary>
        [DisplayName("考勤的用户")]
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
        [Required]
        [StringLength(maximumLength: 500, ErrorMessage = "长度不能超过500")]
        [DisplayName("考勤地点")]
        public string AT_Positions { get; set; }

        /// <summary>
        /// 允许的偏差值
        /// </summary>
        [Required]
        [DisplayName("允许的偏差值")]
        public int AT_AllowableDeviation { get; set; }

        /// <summary>
        /// 生效日期
        /// </summary>
        [DisplayName("生效日期")]
        public DateTime AT_EffectiveDate { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        [DisplayName("创建日期")]
        public DateTime AT_CreateDate { get; set; }

        /// <summary>
        /// 创建者ID
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("创建者")]
        public string AT_CreateUser { get; set; }

        /// <summary>
        /// 更新日期
        /// </summary>
        [DisplayName("更新日期")]
        public DateTime AT_UpdateDate { get; set; }

        /// <summary>
        /// 更新者ID
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("更新者")]
        public string AT_UpdateUser { get; set; }

        /// <summary>
        /// 自定义日期
        /// </summary>
        public List<AT_CDInputDto> CustomDates = new List<AT_CDInputDto>();
    }
}
