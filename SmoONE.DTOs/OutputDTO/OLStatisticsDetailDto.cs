using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmoONE.DTOs
{
    /// <summary>
    /// 加班详情的数据传输对象,用于返回查询结果
    /// </summary>
    public class OLStatisticsDetailDto
    {
        /// <summary>
        /// 用户表传输对象,用于返回查询结果
        /// </summary>
        public UserDto UserInfo;

        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime StartTime;

        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime EndTime;

        /// <summary>
        /// 共计加班时间
        /// </summary>
        public int Minute;
    }
}
