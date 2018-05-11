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
    // 主要内容：  请假单详情传输对象,用于提供新增/更新所需的数据.继承IEntity，方便根据IEntity类型进行DataAnnotations验证,也方便以后扩展
    // ******************************************************************
    /// <summary>
    /// 请假单详情传输对象,用于提供新增/更新所需的数据
    /// </summary>
    public class LeaveInputDto:IEntity
    {
        /// <summary>
        /// 请假单ID
        /// </summary>
        [Key]
        [StringLength(maximumLength: 20)]
        [DisplayName("请假单ID")]
        public string L_ID { get; set; }

        /// <summary>
        /// 请假类型ID
        /// </summary>
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "最长为20字节")]
        [DisplayName("请假类型")]
        public string L_TypeID { get; set; }

        /// <summary>
        /// 请假开始日期
        /// </summary>
        [Required]
        [DisplayName("请假开始日期")]
        public DateTime? L_StartDate { get; set; }

        /// <summary>
        /// 请假结束日期
        /// </summary>
        [Required]
        [DisplayName("请假结束日期")]
        public DateTime? L_EndDate { get; set; }

        /// <summary>
        /// 请假天数
        /// </summary>
        [DisplayName("请假天数")]
        public decimal L_LDay { get; set; }

        /// <summary>
        /// 请假缘由
        /// </summary>
        [StringLength(maximumLength: 500, ErrorMessage = "长度不能超过500字节")]
        [DisplayName("请假缘由")]
        public string L_Reason { get; set; }

        /// <summary>
        /// 图片1
        /// </summary>
        [StringLength(maximumLength: 50, ErrorMessage = "路径长度不能超过50")]
        [DisplayName("图片1")]
        public string L_Img1 { get; set; }

        /// <summary>
        /// 图片2
        /// </summary>
        [StringLength(maximumLength: 50, ErrorMessage = "路径长度不能超过50")]
        [DisplayName("图片2")]
        public string L_Img2 { get; set; }

        /// <summary>
        /// 图片3
        /// </summary>
        [StringLength(maximumLength: 50, ErrorMessage = "路径长度不能超过50")]
        [DisplayName("图片3")]
        public string L_Img3 { get; set; }

        /// <summary>
        /// 图片4
        /// </summary>
        [StringLength(maximumLength: 50, ErrorMessage = "路径长度不能超过50")]
        [DisplayName("图片4")]
        public string L_Img4 { get; set; }

        /// <summary>
        /// 图片5
        /// </summary>
        [StringLength(maximumLength: 50, ErrorMessage = "路径长度不能超过50")]
        [DisplayName("图片5")]
        public string L_Img5 { get; set; }

        /// <summary>
        /// 图片6
        /// </summary>
        [StringLength(maximumLength: 50, ErrorMessage = "路径长度不能超过50")]
        [DisplayName("图片6")]
        public string L_Img6 { get; set; }

        /// <summary>
        /// 图片7
        /// </summary>
        [StringLength(maximumLength: 50, ErrorMessage = "路径长度不能超过50")]
        [DisplayName("图片7")]
        public string L_Img7 { get; set; }

        /// <summary>
        /// 图片8
        /// </summary>
        [StringLength(maximumLength: 50, ErrorMessage = "路径长度不能超过50")]
        [DisplayName("图片8")]
        public string L_Img8 { get; set; }

        /// <summary>
        /// 图片9
        /// </summary>
        [StringLength(maximumLength: 50, ErrorMessage = "路径长度不能超过50")]
        [DisplayName("图片9")]
        public string L_Img9 { get; set; }

        /// <summary>
        /// 所有审批人
        /// </summary>
        [Required]
        [StringLength(maximumLength: 200, ErrorMessage = "长度不能超过200")]
        [DisplayName("所有审批人")]
        public string L_CheckUsers { get; set; }

        /// <summary>
        /// 抄送人
        /// </summary>
        [StringLength(maximumLength: 200, ErrorMessage = "长度不能超过200")]
        [DisplayName("抄送人")]
        public string L_CCTo { get; set; }

        /// <summary>
        /// 创建者（请假人）
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("创建人")]
        public string L_CreateUser { get; set; }

        /// <summary>
        /// 更新者
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("更新者")]
        public string L_UpdateUser { get; set; }
    }
}
