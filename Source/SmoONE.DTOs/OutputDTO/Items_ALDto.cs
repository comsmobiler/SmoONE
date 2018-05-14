using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmoONE.DTOs
{
    /// <summary>
    /// 签到统计项的签到明细的数据传输对象,用于返回查询结果
    /// </summary>
    public class Items_ALDto
    {
        /// <summary>
        /// 考勤类型
        /// </summary>
        public int AL_ADType { get; set; }

        /// <summary>
        /// 签到类型
        /// </summary>
        public int AL_Status { get; set; }

        /// <summary>
        /// 考勤地点
        /// </summary>
        public string AL_Position { get; set; }
    }
}
