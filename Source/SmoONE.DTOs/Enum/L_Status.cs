using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmoONE.DTOs
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2016/11
    // 主要内容：  枚举类,表示请假单的状态
    // ******************************************************************
    /// <summary>
    /// 请假单的状态
    /// </summary>
    public enum L_Status : int
    {
        新建 = 0,
        已审批 = 1,
        已拒绝 = -1
    }
}
