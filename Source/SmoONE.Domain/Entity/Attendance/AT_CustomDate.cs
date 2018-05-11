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
    // 主要内容： 考勤模板的自定义日期
    // ******************************************************************
    /// <summary>
    /// 考勤模板的自定义日期
    /// </summary>
    [Table("AT_CustomDate")]
    public class AT_CustomDate : IAggregateRoot
    {
        /// <summary>
        /// 自定义日期ID
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("自定义日期ID")]
        public int AT_CD_ID { get; set; }

        /// <summary>
        /// 考勤模板ID
        /// </summary>
        [StringLength(maximumLength: 20)]
        [DisplayName("考勤模板ID")]
        public string AT_CD_ATID { get; set; }

        /// <summary>
        /// 上下班类型
        /// </summary>
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("上下班类型")]
        public string AT_CD_CommutingType { get; set; }

        /// <summary>
        /// 自定义日期
        /// </summary>
        [Column(TypeName = "datetime2")]
        [DisplayName("自定义日期")]
        public DateTime AT_CD_Date { get; set; }

        /// <summary>
        /// 自定义类型
        /// </summary>
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("自定义类型")]
        public string AT_CD_CDType { get; set; }

        /// <summary>
        /// 上班时间
        /// </summary>
        [Column(TypeName = "datetime2")]
        [DisplayName("上班时间")]
        public DateTime? AT_CD_StartTime { get; set; }

        /// <summary>
        /// 下班时间
        /// </summary>
        [Column(TypeName = "datetime2")]
        [DisplayName("下班时间")]
        public DateTime? AT_CD_EndTime { get; set; }

        /// <summary>
        /// 上午上班时间
        /// </summary>
        [Column(TypeName = "datetime2")]
        [DisplayName("上午上班时间")]
        public DateTime? AT_CD_AMStartTime { get; set; }

        /// <summary>
        /// 上午下班时间
        /// </summary>
        [Column(TypeName = "datetime2")]
        [DisplayName("上午下班时间")]
        public DateTime? AT_CD_AMEndTime { get; set; }

        /// <summary>
        /// 下午上班时间
        /// </summary>
        [Column(TypeName = "datetime2")]
        [DisplayName("下午上班时间")]
        public DateTime? AT_CD_PMStartTime { get; set; }

        /// <summary>
        /// 下午下班时间
        /// </summary>
        [Column(TypeName = "datetime2")]
        [DisplayName("下午下班时间")]
        public DateTime? AT_CD_PMEndTime { get; set; }

    }
}
