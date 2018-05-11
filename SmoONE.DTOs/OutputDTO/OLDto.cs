using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmoONE.DTOs
{
    /// <summary>
    /// 加班日志传输对象,用于返回查询结果
    /// </summary>
    public class OLDto
    {
        /// <summary>
        /// 加班日志表ID
        /// </summary>
        public int OL_ID { get; set; }

        /// <summary>
        /// 加班日期
        /// </summary>
        public DateTime OL_DateTime { get; set; }

        /// <summary>
        /// 时间类型(开始时间/结束时间)
        /// </summary>
        public TimeType OL_DateType { get; set; }

        /// <summary>
        /// 加班的开始/结束时间
        /// </summary>
        public DateTime OL_LogTime { get; set; }
    }
}
