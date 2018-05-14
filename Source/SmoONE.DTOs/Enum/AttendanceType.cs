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
    // 主要内容： 枚举类,表示签到种类
    // ******************************************************************
    /// <summary>
    /// 签到种类
    /// </summary>
    public enum AttendanceType
    {
        准点,
        迟到,
        早退,
        未签到,
        未签退
    }
}
