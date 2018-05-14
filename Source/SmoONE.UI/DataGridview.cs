using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmoONE.UI
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler 
    // 创建时间： 2016/11
    // 主要内容：  我审批的、我发布的、我创建的列表属性
    // ******************************************************************
    class DataGridview
    {
        /// <summary>
        /// 编号ID
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// 用户头像
        /// </summary>
        public string U_Portrait { get; set; }

        /// <summary>
        /// 用户名称描述
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 状态描述
        /// </summary>
        public string L_StatusDesc { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public string  Type { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public string CreateDate { get; set; }

    }
    public enum DataGridviewType:int
    {
        请假 = 0,
        报销 =1,
    }
}
