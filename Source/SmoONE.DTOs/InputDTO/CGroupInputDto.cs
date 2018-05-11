using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SmoONE.DTOs
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2018 Smobiler
    // 创建时间： 2018/1
    // 主要内容：  联系人群组传输对象,用于提供新增/更新所需的数据.继承IEntity，方便根据IEntity类型进行DataAnnotations验证,也方便以后扩展
    // ******************************************************************
    /// <summary>
    /// 联系人群组传输对象,用于提供新增/更新所需的数据
 public    class CGroupInputDto:IEntity
    {
        /// <summary>
        /// 联系人群组ID
        /// </summary>
        [Key]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("联系人群组ID")]
        public string  G_ID { get; set; }

        /// <summary>
        /// 群组名称
        /// </summary>
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("群组名称")]
        public string G_NAME { get; set; }

        /// <summary>
        /// 群组成员
        /// </summary>
        [Required]
        [DisplayName("群组成员")]
        public string G_USER { get; set; }


        /// <summary>
        /// 创建日期
        /// </summary>
        [DisplayName("创建日期")]
        public DateTime G_CreateDate { get; set; }

        /// <summary>
        /// 创建者ID
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("创建者")]
        public string G_CreateUser { get; set; }

        /// <summary>
        /// 更新日期
        /// </summary>
        [DisplayName("更新日期")]
        public DateTime G_UpdateDate { get; set; }

        /// <summary>
        /// 更新者ID
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("更新者")]
        public string G_UpdateUser { get; set; }
    }
}
