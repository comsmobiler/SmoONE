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
    // 主要内容：  用户角色表,用DataAnnotations定义映射到数据库.继承IAggregateRoot，不想使用InputDto的话,可以根据IAggregateRoot类型进行DataAnnotations验证,也方便以后扩展.
    // ******************************************************************
    /// <summary>
    /// 用户角色表
    /// </summary>
    [Table("UserRole")]
    public class UserRole : IAggregateRoot
    {
        /// <summary>
        /// 用户角色ID
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("用户角色ID")]
        public int ID { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("用户ID")]
        public string UserID { get; set; }

        /// <summary>
        /// 角色ID
        /// </summary>
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("角色ID")]
        public string RoleID { get; set; }
    }
}
