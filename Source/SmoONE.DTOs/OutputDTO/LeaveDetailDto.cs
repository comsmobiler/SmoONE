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
    // 主要内容：  请假单详情传输对象,用于返回查询结果
    // ******************************************************************
    /// <summary>
    /// 请假单详情的传输对象,用于返回查询结果
    /// </summary>
    public class LeaveDetailDto
    {
        /// <summary>
        /// 请假单ID
        /// </summary>
        public string L_ID { get; set; }

        /// <summary>
        /// 请假类型ID
        /// </summary>
        public string L_TypeID { get; set; }


        /// <summary>
        /// 请假类型名称
        /// </summary>
        public string L_TypeName { get; set; }

        /// <summary>
        /// 请假开始日期
        /// </summary>
        public DateTime L_StartDate { get; set; }

        /// <summary>
        /// 请假结束日期
        /// </summary>
        public DateTime L_EndDate { get; set; }

        /// <summary>
        /// 请假天数
        /// </summary>
        public decimal L_LDay { get; set; }

        /// <summary>
        /// 请假缘由
        /// </summary>
        public string L_Reason { get; set; }

        /// <summary>
        /// 图片1
        /// </summary>
        public string L_Img1 { get; set; }

        /// <summary>
        /// 图片2
        /// </summary>
        public string L_Img2 { get; set; }

        /// <summary>
        /// 图片3
        /// </summary>
        public string L_Img3 { get; set; }

        /// <summary>
        /// 图片4
        /// </summary>
        public string L_Img4 { get; set; }

        /// <summary>
        /// 图片5
        /// </summary>
        public string L_Img5 { get; set; }

        /// <summary>
        /// 图片6
        /// </summary>
        public string L_Img6 { get; set; }

        /// <summary>
        /// 图片7
        /// </summary>
        public string L_Img7 { get; set; }

        /// <summary>
        /// 图片8
        /// </summary>
        public string L_Img8 { get; set; }

        /// <summary>
        /// 图片9
        /// </summary>
        public string L_Img9 { get; set; }

        /// <summary>
        /// 所有审批人
        /// </summary>
        public string L_CheckUsers { get; set; }

        /// <summary>
        /// 当前审批人
        /// </summary>
        public string L_CurrantCheck { get; set; }

        /// <summary>
        /// 请假单状态
        /// </summary>
        public int L_Status { get; set; }

        /// <summary>
        /// 抄送人
        /// </summary>
        public string L_CCTo { get; set; }

        /// <summary>
        /// 拒绝理由
        /// </summary>
        public string L_RejectionReason { get; set; }

        /// <summary>
        /// 创建者（请假人）
        /// </summary>
        public string L_CreateUser { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime L_CreateDate { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime L_UpdateDate { get; set; }

    }
}
