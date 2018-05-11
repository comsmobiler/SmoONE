using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmoONE.DTOs
{
    /// <summary>
    /// 日志统计列表的数据传输对象,用于返回查询结果
    /// </summary>
    public class ALStatisticsDto
    {
        /// <summary>
        /// 考勤日期
        /// </summary>
        public DateTime AL_Date { get; set; }

        /// <summary>
        /// 准点时间
        /// </summary>
        public DateTime AL_OnTime { get; set; }

        /// <summary>
        /// 考勤类型
        /// </summary>
        public StatisticsTime AL_ADType { get; set; }

        /// <summary>
        /// 统计项的信息
        /// </summary>
        public List<ALStatisticsItems> Items = new List<ALStatisticsItems>();
    }
}
