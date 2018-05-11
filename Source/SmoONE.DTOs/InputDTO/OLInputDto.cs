using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SmoONE.DTOs
{
    /// <summary>
    /// 加班日志传输对象,用于提供新增/更新所需的数据
    /// </summary>
    public class OLInputDto:IEntity
    {
        /// <summary>
        /// 加班日志表ID
        /// </summary>
        [Key]
        [DisplayName("加班日志表ID")]
        public int OL_ID { get; set; }

        /// <summary>
        /// 加班日期
        /// </summary>
        [Required]
        [DisplayName("加班日期")]
        public DateTime OL_DateTime { get; set; }

        /// <summary>
        /// 时间类型(开始时间/结束时间)
        /// </summary>
        [Required]
        [DisplayName("时间类型")]
        public TimeType OL_DateType { get; set; }

        /// <summary>
        /// 加班的开始/结束时间
        /// </summary>
        [Required]
        [DisplayName("加班的开始/结束时间")]
        public DateTime OL_LogTime { get; set; }
    }
}
