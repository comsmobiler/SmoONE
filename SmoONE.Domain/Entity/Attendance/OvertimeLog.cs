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
    /// 加班日志
    /// </summary>
    [Table("OvertimeLog")]
    public class OvertimeLog : IAggregateRoot
    {
        /// <summary>
        /// 加班日志表ID
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("加班日志表ID")]
        public int OL_ID { get; set; }

        /// <summary>
        /// 加班人员ID
        /// </summary>
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("加班人员")]
        public string OL_UserID { get; set; }

        /// <summary>
        /// 加班日期
        /// </summary>
        [Required]
        [Column(TypeName = "datetime2")]
        [DisplayName("加班日期")]
        public DateTime OL_DateTime { get; set; }

        /// <summary>
        /// 时间类型(开始时间/结束时间)
        /// </summary>
        [Required]
        [DisplayName("时间类型")]
        public int OL_DateType { get; set; }

        /// <summary>
        /// 加班的开始/结束时间
        /// </summary>
        [Required]
        [Column(TypeName = "datetime2")]
        [DisplayName("加班的开始/结束时间")]
        public DateTime OL_LogTime { get; set; }
    }
}
