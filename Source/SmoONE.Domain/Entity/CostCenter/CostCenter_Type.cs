using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace SmoONE.Domain
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2016/11
    // 主要内容：  成本中心类型,用DataAnnotations定义映射到数据库.继承IAggregateRoot，不想使用InputDto的话,可以根据IAggregateRoot类型进行DataAnnotations验证,也方便以后扩展.
    // ******************************************************************
    /// <summary>
    /// 成本中心类型
    /// </summary>
    [Table("CostCenter_Type")]
    public class CostCenter_Type : IAggregateRoot
    {
        /// <summary>
        /// 成本中心类型ID
        /// </summary>
        [Key]
        [StringLength(maximumLength: 20)]
        [DisplayName("成本中心类型ID")]
        public string CC_T_TypeID { get; set; }

        /// <summary>
        /// 成本中心类型说明
        /// </summary>
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("成本中心类型说明")]
        public string CC_T_Description { get; set; }

        /// <summary>
        /// 是否激活
        /// </summary>
        [Required]
        [DisplayName("激活状态")]
        public int CC_T_IsActive { get; set; }
    }
}
