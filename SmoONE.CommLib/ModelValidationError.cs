using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmoONE.CommLib
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2016/11
    // 主要内容：  基础验证的错误信息
    // ******************************************************************
    /// <summary>
    /// 基础验证的错误信息
    /// </summary>
    public class ModelValidationError
    {
        /// <summary>
        /// 错误字段
        /// </summary>
        public string FieldName { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        public string Message { get; set; }
    }
}
