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
    // 主要内容：  部门详情传输对象,用于提供新增/更新所需的数据.继承IEntity，方便根据IEntity类型进行DataAnnotations验证,也方便以后扩展
    // ******************************************************************
    /// <summary>
    /// 部门详情传输对象,用于提供新增/更新所需的数据
    /// </summary>
    public class DepInputDto:IEntity
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
        /// 部门人员
        /// </summary>
        public List<string> UserIDs = new List<string>();

        /// <summary>
        /// 部门头像
        /// </summary>
        [StringLength(maximumLength: 50, ErrorMessage = "路径长度不能超过50")]
        [DisplayName("部门头像")]
        public string Dep_Icon { get; set; }
    }
}
