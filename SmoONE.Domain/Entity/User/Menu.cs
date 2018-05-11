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
    // 主要内容：  菜单,用DataAnnotations定义映射到数据库.继承IAggregateRoot，不想使用InputDto的话,可以根据IAggregateRoot类型进行DataAnnotations验证,也方便以后扩展.
    // ******************************************************************

    /// <summary>
    /// 菜单
    /// </summary>
    [Table("Menu")]
    public class Menu : IAggregateRoot
    {
        /// <summary>
        /// 菜单ID
        /// </summary>
        [Key]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("菜单ID")]
        public string M_MenuID { get; set; }

        /// <summary>
        /// 菜单说明
        /// </summary>
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("菜单说明")]
        public string M_Description { get; set; }

        /// <summary>
        /// 菜单排序
        /// </summary>
        [DisplayName("显示顺序")]
        public int M_Sort { get; set; }

        /// <summary>
        /// 是否激活
        /// </summary>
        [Required]
        [DisplayName("激活状态")]
        public int M_IsActive { get; set; }

        /// <summary>
        /// 父级菜单ID
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("父级菜单ID")]
        public string M_ParentID { get; set; }

        /// <summary>
        /// 菜单图标
        /// </summary>
        [StringLength(maximumLength: 50, ErrorMessage = "长度不能超过50")]
        [DisplayName("菜单图标")]
        public string M_Portrait { get; set; }

        /// <summary>
        /// 更新者
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("更新者")]
        public string M_UpdateUser { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [Column(TypeName = "datetime2")]
        [DisplayName("更新时间")]
        public DateTime M_UpdateDate { get; set; }

    }
}
