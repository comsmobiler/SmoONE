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
    // 主要内容：  用户详情传输对象,用于提供新增/更新所需的数据.继承IEntity，方便根据IEntity类型进行DataAnnotations验证,也方便以后扩展
    // ******************************************************************
    /// <summary>
    /// 用户详情传输对象,用于提供新增/更新所需的数据
    /// </summary>
    public class UserInputDto:IEntity
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        [Key]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("用户ID")]
        public string U_ID { get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "长度不能超过50")]
        [DisplayName("用户昵称")]
        public string U_Name { get; set; }

        /// <summary>
        /// 用户头像
        /// </summary>
        [StringLength(maximumLength: 50, ErrorMessage = "路径长度不能超过50")]
        [DisplayName("用户头像")]
        public string U_Portrait { get; set; }


        /// <summary>
        /// 性别
        /// </summary>
        [DisplayName("性别")]
        public Sex? U_Sex { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [RegularExpression(@"(\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)", ErrorMessage = "格式不正确")]
        [StringLength(maximumLength: 50, ErrorMessage = "长度不能超过50")]
        [DisplayName("邮箱")]
        public string U_Email { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        [RegularExpression(@"^1(3[0-9]|4[57]|5[0-35-9]|7[0135678]|8[0-9])\d{8}$", ErrorMessage = "格式不正确")]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("电话号码")]
        public string U_Tel { get; set; }

        /// <summary>
        /// 出生日期
        /// </summary>
        [DisplayName("出生日期")]
        public DateTime? U_Birthday { get; set; }

        /// <summary>
        /// 部门ID
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("部门")]
        public string U_DepID { get; set; }

        /// <summary>
        /// 手势
        /// </summary>
        [StringLength(maximumLength: 50, ErrorMessage = "长度不能超过50")]
        [DisplayName("手势")]
        public string U_Gestures { get; set; }
    }
}
