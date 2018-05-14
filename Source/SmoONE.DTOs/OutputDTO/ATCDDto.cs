using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmoONE.DTOs
{
    // ******************************************************************
    // 文件版本： SmoONE 1.1
    // Copyright  (c)  2016-2017 Smobiler 
    // 创建时间： 2017/2
    // 主要内容： 自定义日期列表的数据传输对象,用于返回查询结果
    // ******************************************************************
    /// <summary>
    /// 自定义日期列表的数据传输对象,用于返回查询结果
    /// </summary>
    public class ATCDDto
    {
        /// <summary>
        /// 自定义日期ID
        /// </summary>
        public int AT_CD_ID { get; set; }

        /// <summary>
        /// 自定义日期
        /// </summary>
        public DateTime AT_CD_Date { get; set; }

        /// <summary>
        /// 自定义类型
        /// </summary>
        public string AT_CD_CDType { get; set; }

    }
}
