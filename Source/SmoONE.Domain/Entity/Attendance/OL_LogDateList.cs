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
    /// 加班时间列表
    /// </summary>
    [Table("OL_LogDateList")]
    public class OL_LogDateList : IAggregateRoot
    {
        /// <summary>
        /// 加班时间列表
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("加班时间列表")]
        public int OLL_ID { get; set; }

        /// <summary>
        /// 考勤模板ID
        /// </summary>
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("考勤模板ID")]
        public string OLL_ATID { get; set; }

        /// <summary>
        /// 加班人员ID
        /// </summary>
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("加班人员")]
        public string OLL_UserID { get; set; }

        /// <summary>
        /// 加班日期
        /// </summary>
        [Required]
        [Column(TypeName = "datetime2")]
        [DisplayName("加班日期")]
        public DateTime OLL_DateTime { get; set; }
    }
}
