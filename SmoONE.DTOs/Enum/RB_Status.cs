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
    // 主要内容：  枚举类,表示报销单的状态
    // ******************************************************************
    /// <summary>
    /// 报销单状态
    /// </summary>
    public enum RB_Status : int
    {
        新建 = 0,
        责任人审批 = 1,
        行政审批 = 2,
        财务审批 = 3,
        已拒绝 = -1,
    }
}
