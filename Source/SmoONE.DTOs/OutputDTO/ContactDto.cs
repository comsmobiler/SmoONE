using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmoONE.DTOs
{
    // ******************************************************************
    // 文件版本： SmoONE 1.1
    // Copyright  (c)  2016-2018 Smobiler 
    // 创建时间： 2018/1
    // 主要内容： 联系人的数据传输对象,用于返回查询结果
    // ******************************************************************
    /// <summary>
    /// 联系人的数据传输对象,用于返回查询结果
   public  class ContactDto
    {
        /// <summary>
        /// 联系人ID
        /// </summary>
        public int C_ID { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        public string C_USER { get; set; }
    }
}
