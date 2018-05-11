using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmoONE.UI
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler 
    // 创建时间： 2016/11
    // 主要内容： 部门分配人员列表属性
    // ******************************************************************
    class DataGridviewbyUser : SmoONE.DTOs.UserDto
    {
        /// <summary>
        /// 是否选中
        /// </summary>
        public bool  SelectCheck { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        public string U_DepName { get; set; }
    }
}
