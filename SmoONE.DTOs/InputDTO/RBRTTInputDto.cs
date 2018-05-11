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
    // 主要内容：  报销类型模板详情传输对象,用于提供新增/更新所需的数据.继承IEntity，方便根据IEntity类型进行DataAnnotations验证,也方便以后扩展
    // ******************************************************************
    /// <summary>
    /// 报销类型模板详情传输对象,用于提供新增/更新所需的数据
    /// </summary>
    public class RBRTTInputDto:IEntity
    {
        /// <summary>
        /// 报销类型模板ID
        /// </summary>
        [Key]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("报销类型模板ID")]
        public string RB_RTT_TemplateID { get; set; }

        /// <summary>
        /// 报销类型ID
        /// </summary>
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("报销类型ID")]
        public string RB_RTT_TypeID { get; set; }

        /// <summary>
        /// 消费金额
        /// </summary>
        [Required]
        [DisplayName("消费金额")]
        public decimal RB_RTT_Amount { get; set; }

        /// <summary>
        /// 消费备注
        /// </summary>
        [StringLength(maximumLength: 200, ErrorMessage = "长度不能超过200")]
        [DisplayName("消费备注")]
        public string RB_RTT_Note { get; set; }

        /// <summary>
        /// 创建者
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("创建者")]
        public string RB_RTT_CreateUser { get; set; }
    }
}
