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
    // 主要内容： 考勤模板的用户变更日志
    // ******************************************************************
    /// <summary>
    /// 考勤模板的用户变更日志
    /// </summary>
    [Table("AT_UserLog")]
    public class AT_UserLog : IAggregateRoot
    {
        /// <summary>
        /// 变更日志ID
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("变更日志ID")]
        public int AT_UL_ID { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [Required]
        [StringLength(maximumLength: 20)]
        [DisplayName("用户ID")]
        public string AT_UL_UserID { get; set; }

        /// <summary>
        /// 考勤模板ID
        /// </summary>
        [Required]
        [StringLength(maximumLength: 20)]
        [DisplayName("考勤模板ID")]
        public string AT_UL_ATID { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [Column(TypeName = "datetime2")]
        [DisplayName("开始时间")]
        public DateTime AT_UL_StartTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [Column(TypeName = "datetime2")]
        [DisplayName("结束时间")]
        public DateTime AT_UL_EndTime { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        [Column(TypeName = "datetime2")]
        [DisplayName("创建日期")]
        public DateTime AT_UL_CreateDate { get; set; }
    }
}

