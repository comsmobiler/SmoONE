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
    // 主要内容：  报销单,用DataAnnotations定义映射到数据库.继承IAggregateRoot，不想使用InputDto的话,可以根据IAggregateRoot类型进行DataAnnotations验证,也方便以后扩展.有部分配置在ReimbursementConfiguration中
    // ******************************************************************

    /// <summary>
    /// 报销单
    /// </summary>
    [Table("Reimbursement")]
    public class Reimbursement:IAggregateRoot
    {
        /// <summary>
        /// 报销单ID
        /// </summary>
        [Key]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("报销单ID")]
        public string RB_ID { get; set; }

        /// <summary>
        /// 总金额
        /// </summary>
        [Required]
        [DisplayName("总金额")]
        public decimal RB_TotalAmount { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [StringLength(maximumLength: 500, ErrorMessage = "长度不能超过500")]
        [DisplayName("备注")]
        public string RB_Note { get; set; }

        /// <summary>
        /// 图片1
        /// </summary>
        [StringLength(maximumLength: 50, ErrorMessage = "路径长度不能超过50")]
        [DisplayName("图片1")]
        public string RB_Img1 { get; set; }

        /// <summary>
        /// 图片2
        /// </summary>
        [StringLength(maximumLength: 50, ErrorMessage = "路径长度不能超过50")]
        [DisplayName("图片2")]
        public string RB_Img2 { get; set; }

        /// <summary>
        /// 图片3
        /// </summary>
        [StringLength(maximumLength: 50, ErrorMessage = "路径长度不能超过50")]
        [DisplayName("图片3")]
        public string RB_Img3 { get; set; }

        /// <summary>
        /// 图片4
        /// </summary>
        [StringLength(maximumLength: 50, ErrorMessage = "路径长度不能超过50")]
        [DisplayName("图片4")]
        public string RB_Img4 { get; set; }

        /// <summary>
        /// 图片5
        /// </summary>
        [StringLength(maximumLength: 50, ErrorMessage = "路径长度不能超过50")]
        [DisplayName("图片5")]
        public string RB_Img5 { get; set; }

        /// <summary>
        /// 图片6
        /// </summary>
        [StringLength(maximumLength: 50, ErrorMessage = "路径长度不能超过50")]
        [DisplayName("图片6")]
        public string RB_Img6 { get; set; }

        /// <summary>
        /// 图片7
        /// </summary>
        [StringLength(maximumLength: 50, ErrorMessage = "路径长度不能超过50")]
        [DisplayName("图片7")]
        public string RB_Img7 { get; set; }

        /// <summary>
        /// 图片8
        /// </summary>
        [StringLength(maximumLength: 50, ErrorMessage = "路径长度不能超过50")]
        [DisplayName("图片8")]
        public string RB_Img8 { get; set; }

        /// <summary>
        /// 图片9
        /// </summary>
        [StringLength(maximumLength: 50, ErrorMessage = "路径长度不能超过50")]
        [DisplayName("图片9")]
        public string RB_Img9 { get; set; }

        /// <summary>
        /// 成本中心责任人
        /// </summary>
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("成本中心责任人")]
        public string RB_LiableMan { get; set; }

        /// <summary>
        /// 行政审批人
        /// </summary>
        [Required]
        [StringLength(maximumLength: 200, ErrorMessage = "长度不能超过200")]
        [DisplayName("行政审批人")]
        public string RB_AEACheckers { get; set; }

        /// <summary>
        /// 财务审批人
        /// </summary>
        [Required]
        [StringLength(maximumLength: 200, ErrorMessage = "长度不能超过200")]
        [DisplayName("财务审批人")]
        public string RB_FinancialCheckers { get; set; }

        /// <summary>
        /// 当前负责审批人
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("当前负责审批人")]
        public string RB_CurrantLiableMan { get; set; }

        /// <summary>
        /// 负责人审批时间
        /// </summary>
        [Column(TypeName = "datetime2")]
        [DisplayName("负责人审批时间")]
        public DateTime RB_LiableDate { get; set; }

        /// <summary>
        /// 当前行政审批人
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("当前行政审批人")]
        public string RB_CurrantAEACheck { get; set; }

        /// <summary>
        /// 行政审批时间
        /// </summary>
        [Column(TypeName = "datetime2")]
        [DisplayName("行政审批时间")]
        public DateTime RB_AEADate { get; set; }

        /// <summary>
        /// 当前财务审批人
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("当前财务审批人")]
        public string RB_CurrantFinCheck { get; set; }

        /// <summary>
        /// 财务审批时间
        /// </summary>
        [Column(TypeName = "datetime2")]
        [DisplayName("财务审批时间")]
        public DateTime RB_FinDate { get; set; }


        /// <summary>
        /// 当前审批人
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("当前审批人")]
        public string RB_CurrantCheck { get; set; }

        /// <summary>
        /// 报销单状态
        /// </summary>
        [DisplayName("报销单状态")]
        public int RB_Status { get; set; }

        /// <summary>
        /// 拒绝缘由
        /// </summary>
        [StringLength(maximumLength: 500, ErrorMessage = "长度不能超过500")]
        [DisplayName("拒绝理由")]
        public string RB_RejectionReason { get; set; }

        /// <summary>
        /// 创建者（报销人）
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("创建者")]
        public string RB_CreateUser { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [Column(TypeName = "datetime2")]
        [DisplayName("创建时间")]
        public DateTime RB_CreateDate { get; set; }

        /// <summary>
        /// 更新者
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("更新者")]
        public string RB_UpdateUser { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [Column(TypeName = "datetime2")]
        [DisplayName("更新时间")]
        public DateTime RB_UpdateDate { get; set; }

        /// <summary>
        /// 成本中心ID
        /// </summary>
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("成本中心")]
        public string CC_ID { get; set; }

    }
}
