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
    // 主要内容：  部门,用DataAnnotations定义映射到数据库.继承IAggregateRoot，不想使用InputDto的话,可以根据IAggregateRoot类型进行DataAnnotations验证,也方便以后扩展.有部分配置在DepartmentConfiguration中
    // ******************************************************************

    /// <summary>
    /// 部门
    /// </summary>
    [Table("Department")]
    public class Department:IAggregateRoot
    {
        /// <summary>
        /// 部门ID
        /// </summary>
        [Key]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("部门ID")]
        public string Dep_ID { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("部门名称")]
        public string Dep_Name { get; set; }

        /// <summary>
        /// 是否激活
        /// </summary>
        [Required]
        [DisplayName("激活状态")]
        public int Dep_IsActive { get; set; }

        /// <summary>
        /// 负责人
        /// </summary>
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("负责人")]
        public string Dep_Leader { get; set; }

        /// <summary>
        /// 更新者
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("更新者")]
        public string Dep_UpdateUser { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [Column(TypeName = "datetime2")]
        [DisplayName("更新时间")]
        public DateTime Dep_UpdateDate { get; set; }

        /// <summary>
        /// 目标项目/人天
        /// </summary>
        [DisplayName("目标项目/人天")]
        public decimal Dep_ProDay { get; set; }

        /// <summary>
        /// 目标其他/人天
        /// </summary>
        [DisplayName("目标其他/人天")]
        public decimal Dep_OtherDay { get; set; }


        /// <summary>
        /// 部门头像
        /// </summary>
        [StringLength(maximumLength: 50, ErrorMessage = "长度不能超过50")]
        [DisplayName("部门头像")]
        public string Dep_Icon { get; set; }

        ////新增加的
        ///// <summary>
        ///// 部门考勤模板
        ///// </summary>
        //[StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        //[DisplayName("考勤模板")]
        //public string Dep_ATID { get; set; }
    }
}
