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
    // 主要内容：  请假单,用DataAnnotations定义映射到数据库.继承IAggregateRoot，不想使用InputDto的话,可以根据IAggregateRoot类型进行DataAnnotations验证,也方便以后扩展.有部分配置在LeaveConfiguration中
    // ******************************************************************

    /// <summary>
    /// 请假单
    /// </summary>
    [Table("Leave")]
    public class Leave : IAggregateRoot
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
        [StringLength(maximumLength: 20,ErrorMessage="最长为20字节")]
        [DisplayName("请假类型")] 
        public string L_TypeID { get; set; }

        /// <summary>
        /// 请假开始日期
        /// </summary>
        [Required]
        [Column(TypeName = "datetime2")]
        [DisplayName("请假开始日期")]
        public DateTime L_StartDate { get; set; }

        /// <summary>
        /// 请假结束日期
        /// </summary>
        [Required]
        [Column(TypeName = "datetime2")]
        [DisplayName("请假结束日期")]
        public DateTime L_EndDate { get; set; }

        /// <summary>
        /// 请假天数
        /// </summary>
        [DisplayName("请假天数")]
        public decimal L_LDay { get; set; }

        /// <summary>
        /// 请假缘由
        /// </summary>
        [StringLength(maximumLength: 500,ErrorMessage="长度不能超过500字节")]
        [DisplayName("请假缘由")]
        public string L_Reason { get; set; }

        /// <summary>
        /// 图片1
        /// </summary>
        [StringLength(maximumLength: 50,ErrorMessage="路径长度不能超过50")]
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
        /// 当前审批人
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过50")]
        [DisplayName("当前审批人")]
        public string L_CurrantCheck { get; set; }

        /// <summary>
        /// 请假单状态
        /// </summary>
        [DisplayName("请假单状态")]
        public int L_Status { get; set; }

        /// <summary>
        /// 抄送人
        /// </summary>
        [StringLength(maximumLength: 200, ErrorMessage = "长度不能超过200")]
        [DisplayName("抄送人")]
        public string L_CCTo { get; set; }

        /// <summary>
        /// 拒绝理由
        /// </summary>
        [StringLength(maximumLength: 500, ErrorMessage = "长度不能超过500")]
        [DisplayName("拒绝理由")]
        public string L_RejectionReason { get; set; }

        /// <summary>
        /// 创建者（请假人）
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("创建人")]
        public string L_CreateUser { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [Column(TypeName = "datetime2")]
        [DisplayName("创建时间")]
        public DateTime L_CreateDate { get; set; }

        /// <summary>
        /// 更新者
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("更新者")]
        public string L_UpdateUser { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [Column(TypeName = "datetime2")]
        [DisplayName("更新时间")]
        public DateTime L_UpdateDate { get; set; }

    }
}
