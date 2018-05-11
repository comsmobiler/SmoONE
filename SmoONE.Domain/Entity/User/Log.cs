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
    // 主要内容：  日志表,用DataAnnotations定义映射到数据库.继承IAggregateRoot，不想使用InputDto的话,可以根据IAggregateRoot类型进行DataAnnotations验证,也方便以后扩展.
    // ******************************************************************

    /// <summary>
    /// 日志表
    /// </summary>
    [Table("Log")]
    public class Log : IAggregateRoot
    {
        /// <summary>
        /// 日志表ID
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("日志表ID")]
        public int L_ID { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("用户")]  
        public string U_ID { get; set; }

        /// <summary>
        /// 登录时间
        /// </summary>
        [Column(TypeName = "datetime2")]
        [DisplayName("登录时间")]
        public DateTime L_LoginTime { get; set; }

        /// <summary>
        /// 登录结果
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("登录结果")] 
        public string L_Result { get; set; }

    }
}
