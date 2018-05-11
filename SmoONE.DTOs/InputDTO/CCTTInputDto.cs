using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SmoONE.DTOs
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2016/11
    // 主要内容：  成本中心类型模板详情传输对象,用于提供新增/更新所需的数据.继承IEntity，方便根据IEntity类型进行DataAnnotations验证,也方便以后扩展
    // ******************************************************************
    /// <summary>
    /// 成本中心类型模板详情传输对象,用于提供新增/更新所需的数据
    /// </summary>
    public class CCTTInputDto:IEntity
    {
        /// <summary>
        /// 成本中心类型模板ID
        /// </summary>
        [Key]
        [StringLength(maximumLength: 20)]
        [DisplayName("成本中心模板ID")]
        public string CC_TT_TemplateID { get; set; }

        /// <summary>
        /// 成本中心类型ID
        /// </summary>
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("成本中心类型")]
        public string CC_TT_TypeID { get; set; }


        /// <summary>
        /// 行政审批人
        /// </summary>
        [Required]
        [StringLength(maximumLength: 200, ErrorMessage = "长度不能超过200")]
        [DisplayName("行政审批人")]
        public string CC_TT_AEACheckers { get; set; }

        /// <summary>
        /// 财务审批人
        /// </summary>
        [Required]
        [StringLength(maximumLength: 200, ErrorMessage = "长度不能超过200")]
        [DisplayName("财务审批人")]
        public string CC_TT_FinancialCheckers { get; set; }

        /// <summary>
        /// 更新者
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("更新者")]
        public string CC_TT_UpdateUser { get; set; }
    }
}
