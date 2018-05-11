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
    // 主要内容：  报销单详情传输对象,用于提供新增/更新所需的数据.继承IEntity，方便根据IEntity类型进行DataAnnotations验证,也方便以后扩展
    // ******************************************************************
    /// <summary>
    /// 报销单详情传输对象,用于提供新增/更新所需的数据
    /// </summary>
    public class RBInputDto:IEntity
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
        /// 创建者（报销人）
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("创建者")]
        public string RB_CreateUser { get; set; }


        /// <summary>
        /// 更新者
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("更新者")]
        public string RB_UpdateUser { get; set; }

        /// <summary>
        /// 报销明细
        /// </summary>
        public List<RB_RowsInputDto> RB_Rows = new List<RB_RowsInputDto>();

        /// <summary>
        /// 成本中心ID
        /// </summary>
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("成本中心")]
        public string CC_ID { get; set; }

    }
}
