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
    // 主要内容：  验证码,用DataAnnotations定义映射到数据库.继承IAggregateRoot，不想使用InputDto的话,可以根据IAggregateRoot类型进行DataAnnotations验证,也方便以后扩展.
    // ******************************************************************
    /// <summary>
    /// 验证码
    /// </summary>
    [Table("ValidateCode")]
    public class ValidateCode : IAggregateRoot
    {
        /// <summary>
        /// 验证码ID
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("验证码ID")]
        public int V_CodeID { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [Required]
        [StringLength(maximumLength: 20,ErrorMessage="长度不能超过20")]
        [RegularExpression(@"^1(3[0-9]|4[57]|5[0-35-9]|7[0135678]|8[0-9])\d{8}$", ErrorMessage = "格式不正确")]
        [DisplayName("手机号")]
        public string V_PhoneNumber { get; set; }

        /// <summary>
        /// 验证码
        /// </summary>
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("验证码")]
        public string V_VCode { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [Required]
        [Column(TypeName = "datetime2")]
        [DisplayName("更新时间")]
        public DateTime V_UpdateDate { get; set; }

        /// <summary>
        /// 设备ID
        /// </summary>
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "长度不能超过50")]
        [DisplayName("设备ID")]
        public string V_DeviceID { get; set; }
    }
}
