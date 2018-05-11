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
    // 主要内容：  角色菜单表,用DataAnnotations定义映射到数据库.继承IAggregateRoot，不想使用InputDto的话,可以根据IAggregateRoot类型进行DataAnnotations验证,也方便以后扩展.
    // ******************************************************************

    /// <summary>
    /// 角色菜单表
    /// </summary>
    [Table("RoleMenu")]
    public class RoleMenu:IAggregateRoot
    {
        /// <summary>
        /// 角色菜单表ID
        /// </summary>
        [Key]
        [DisplayName("角色菜单表ID")]
        public int RM_ID { get; set; }


        /// <summary>
        /// 角色ID
        /// </summary>
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("角色ID")]
        public string RM_RoleID { get; set; }

        /// <summary>
        /// 菜单ID
        /// </summary>
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("菜单ID")]
        public string RM_MenuID { get; set; }
    }
}
