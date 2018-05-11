using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmoONE.DTOs
{
    /// <summary>
    /// 签到统计项的明细的数据传输对象,用于返回查询结果
    /// </summary>
    public class ALStatisticsItemsDetailDto
    {
        /// <summary>
        /// 用户表传输对象,用于返回查询结果
        /// </summary>
        public UserDto UserInfo;

        /// <summary>
        /// 签到统计项的签到明细的数据传输对象,用于返回查询结果
        /// </summary>
        public Items_ALDto ALInfo;
    }
}
