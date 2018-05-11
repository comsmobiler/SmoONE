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
    // 主要内容：  部门界面展示类型
    // ******************************************************************
    public enum DepartmentMode
    {
        /// <summary>
        /// 列表
       /// </summary>
       列表= 0,
        /// <summary>
        /// 层级
        /// </summary>
       层级=1,
    }
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler 
    // 创建时间： 2016/11
    // 主要内容：  请假层级展示节点类型
    // ******************************************************************
    public enum TreeMode
    {
        /// <summary>
        /// 部门
        /// </summary>
        dep = 0,
        /// <summary>
        /// 用户
        /// </summary>
        user = 1,
    }
}
