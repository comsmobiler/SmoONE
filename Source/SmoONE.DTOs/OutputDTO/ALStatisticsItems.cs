using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmoONE.DTOs
{
    /// <summary>
    /// 统计项的信息
    /// </summary>
    public class ALStatisticsItems
    {
        /// <summary>
        /// 统计类型
        /// </summary>
        public StatisticsType AL_Status { get; set; }

        /// <summary>
        /// 人数
        /// </summary>
        public int Count { get; set; }
    }
}
