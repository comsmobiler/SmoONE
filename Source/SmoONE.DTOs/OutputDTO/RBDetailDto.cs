using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmoONE.DTOs
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2016/11
    // 主要内容：  报销单详情的数据传输对象,用于返回查询结果
    // ******************************************************************
    /// <summary>
    /// 报销单详情的数据传输对象,用于返回查询结果
    /// </summary>
    public class RBDetailDto
    {
        /// <summary>
        /// 报销单ID
        /// </summary>
        public string RB_ID { get; set; }

        /// <summary>
        /// 总金额
        /// </summary>
        public decimal RB_TotalAmount { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string RB_Note { get; set; }

        /// <summary>
        /// 图片1
        /// </summary>
        public string RB_Img1 { get; set; }

        /// <summary>
        /// 图片2
        /// </summary>
        public string RB_Img2 { get; set; }

        /// <summary>
        /// 图片3
        /// </summary>
        public string RB_Img3 { get; set; }

        /// <summary>
        /// 图片4
        /// </summary>
        public string RB_Img4 { get; set; }

        /// <summary>
        /// 图片5
        /// </summary>
        public string RB_Img5 { get; set; }

        /// <summary>
        /// 图片6
        /// </summary>
        public string RB_Img6 { get; set; }

        /// <summary>
        /// 图片7
        /// </summary>
        public string RB_Img7 { get; set; }

        /// <summary>
        /// 图片8
        /// </summary>
        public string RB_Img8 { get; set; }

        /// <summary>
        /// 图片9
        /// </summary>
        public string RB_Img9 { get; set; }

        /// <summary>
        /// 成本中心责任人
        /// </summary>
        public string RB_LiableMan { get; set; }

        /// <summary>
        /// 行政审批人
        /// </summary>
        public string RB_AEACheckers { get; set; }

        /// <summary>
        /// 财务审批人
        /// </summary>
        public string RB_FinancialCheckers { get; set; }

        /// <summary>
        /// 当前审批人
        /// </summary>
        public string RB_CurrantCheck { get; set; }

        /// <summary>
        /// 报销单状态
        /// </summary>
        public int RB_Status { get; set; }

        /// <summary>
        /// 拒绝缘由
        /// </summary>
        public string RB_RejectionReason { get; set; }

        /// <summary>
        /// 创建者（报销人）
        /// </summary>
        public string RB_CreateUser { get; set; }


        /// <summary>
        /// 报销明细
        /// </summary>
        public List<RB_RowsDto> RB_Rows = new List<RB_RowsDto>();

        /// <summary>
        /// 成本中心ID
        /// </summary>
        public string CC_ID { get; set; }

        /// <summary>
        /// 当前负责审批人
        /// </summary>
        public string RB_CurrantLiableMan { get; set; }

        /// <summary>
        /// 负责人审批时间
        /// </summary>
        public DateTime RB_LiableDate { get; set; }

        /// <summary>
        /// 当前行政审批人
        /// </summary>
        public string RB_CurrantAEACheck { get; set; }

        /// <summary>
        /// 行政审批时间
        /// </summary>
        public DateTime RB_AEADate { get; set; }

        /// <summary>
        /// 当前财务审批人
        /// </summary>
        public string RB_CurrantFinCheck { get; set; }

        /// <summary>
        /// 财务审批时间
        /// </summary>
        public DateTime RB_FinDate { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime RB_CreateDate { get; set; }
    }
}
