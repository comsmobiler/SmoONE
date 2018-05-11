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
    // 主要内容：  请假类型,用DataAnnotations定义映射到数据库.继承IAggregateRoot，不想使用InputDto的话,可以根据IAggregateRoot类型进行DataAnnotations验证,也方便以后扩展.
    // ******************************************************************

    /// <summary>
    /// 请假类型
    /// </summary>
    [Table("LeaveType")]
    public class LeaveType : IAggregateRoot
    {
        /// <summary>
        /// 请假类型ID
        /// </summary>
        [Key]
        [StringLength(maximumLength: 20)]
        [DisplayName("请假类型ID")]
        public string L_T_ID { get; set; }

        /// <summary>
        /// 请假类型名称
        /// </summary>
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("请假类型名称")]
        public string L_T_Name { get; set; }
    }
}

