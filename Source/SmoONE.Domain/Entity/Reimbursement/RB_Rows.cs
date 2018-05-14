using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmoONE.Domain
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2016/11
    // 主要内容：  报销明细/消费记录,用DataAnnotations定义映射到数据库.继承IAggregateRoot，不想使用InputDto的话,可以根据IAggregateRoot类型进行DataAnnotations验证,也方便以后扩展.有部分配置在RB_RowsConfiguration中
    // ******************************************************************

    /// <summary>
    /// 报销明细/消费记录
    /// </summary>
    [Table("RB_Rows")]
    public class RB_Rows:IAggregateRoot
    {
        /// <summary>
        /// 报销明细ID
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("消费明细ID")]
        public int R_ID { get; set; }

        /// <summary>
        /// 报销单ID
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("报销单")]        
        public string RB_ID { get; set; }

        /// <summary>
        /// 报销明细金额
        /// </summary>
        [Required]
        [DisplayName("报销明细金额")]
        public decimal R_Amount { get; set; }

        /// <summary>
        /// 报销类型ID
        /// </summary>
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("报销类型")]       
        public string R_TypeID { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [Required]
        [StringLength(maximumLength: 500, ErrorMessage = "长度不能超过500")]
        [DisplayName("备注")]
        public string R_Note { get; set; }
        
        /// <summary>
        /// 创建者
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("创建者")]
        public string R_CreateUser { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [Column(TypeName = "datetime2")]
        [DisplayName("创建时间")]
        public DateTime R_CreateDate { get; set; }

        /// <summary>
        /// 消费时间
        /// </summary>
        [Column(TypeName = "datetime2")]
        [DisplayName("消费时间")]
        public DateTime R_ConsumeDate { get; set; }

    }
}


