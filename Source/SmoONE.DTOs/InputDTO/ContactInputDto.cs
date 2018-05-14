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
    // 主要内容：  联系人传输对象,用于提供新增/更新所需的数据.继承IEntity，方便根据IEntity类型进行DataAnnotations验证,也方便以后扩展
    // ******************************************************************
    /// <summary>
    /// 联系人传输对象,用于提供新增/更新所需的数据
    /// </summary>
 public    class ContactInputDto:IEntity
    {
        /// <summary>
        /// 联系人ID
        /// </summary>
        [Key]
        [DisplayName("联系人ID")]
        public int C_ID { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("联系人")]
        public string C_USER { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        [DisplayName("创建日期")]
        public DateTime C_CreateDate { get; set; }

        /// <summary>
        /// 创建者ID
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("创建者")]
        public string C_CreateUser { get; set; }

        /// <summary>
        /// 更新日期
        /// </summary>
        [DisplayName("更新日期")]
        public DateTime C_UpdateDate { get; set; }

        /// <summary>
        /// 更新者ID
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("更新者")]
        public string C_UpdateUser { get; set; }
    }
}
