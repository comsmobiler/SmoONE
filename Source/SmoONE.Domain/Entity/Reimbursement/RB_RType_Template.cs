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
    // 主要内容：  报销类型模板,用DataAnnotations定义映射到数据库.继承IAggregateRoot，不想使用InputDto的话,可以根据IAggregateRoot类型进行DataAnnotations验证,也方便以后扩展.有部分配置在RB_Type_TemplateConfiguration中
    // ******************************************************************
    /// <summary>
    /// 报销类型模板
    /// </summary>
    [Table("RB_RType_Template")]
    public class RB_RType_Template : IAggregateRoot
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

        /// <summary>
        /// 创建时间
        /// </summary>
        [Column(TypeName = "datetime2")]
        [DisplayName("创建时间")]
        public DateTime RB_RTT_CreateDate { get; set; }
    }
}
