using System;
using System.Collections.Generic;
using Smobiler.Core.Controls;
using System.Data;
using SmoONE.DTOs;
using SmoONE.CommLib;
using SmoONE.UI.Layout;

namespace SmoONE.UI.RB
{
    // ******************************************************************
    // 文件版本： SmoONE 2.0
    // Copyright  (c)  2017-2018 Smobiler 
    // 创建时间： 2017/07
    // 主要内容：  报销单详情界面
    // ******************************************************************
    partial class frmRBDetail : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        internal string ID;                 //报销单编号
        internal string UserID;               //当前用户ID
        internal RB_Status Status;               //报销单状态
        RefuseDialog Refuse = new RefuseDialog();        //报销拒绝弹出框
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        /// <summary>
        /// 初始化数据
        /// </summary>
        private void Bind()
        {
            try
            {
                UserID = Client.Session["U_ID"].ToString();               //当前用户ID
                List<RB_RowsDto> Rows = AutofacConfig.rBService.GetRowByRBID(ID);         //查找报销单的消费记录信息
                RBDetailDto Reim = AutofacConfig.rBService.GetByID(ID);             //查找报销单的相关信息
                Status = (RB_Status)Reim.RB_Status;             //报销订单当前状态                             
                string[] ReimAEACheckers = Reim.RB_AEACheckers.Split(Convert.ToChar(","));       //获取行政审批人员
                string[] ReimFinancialCheckers = Reim.RB_FinancialCheckers.Split(Convert.ToChar(","));       //获取财务审批人员
                UserDetailDto userInfo = AutofacConfig.userService.GetUserByUserID(Reim.RB_CreateUser);
                title1.TitleText = userInfo.U_Name + "的报销";                                     //标题
                lblUserName.Text = userInfo.U_Name;                                   //报销单创建用户               
                //当没有设置用户头像时，根据用户性别显示默认头像
                if (string.IsNullOrEmpty(userInfo.U_Portrait) == true)
                {
                    switch (userInfo.U_Sex)
                    {
                        case (int)Sex.男:
                            imgPortrait.ResourceID = "boy";
                            break;
                        case (int)Sex.女:
                            imgPortrait.ResourceID = "girl";
                            break;
                    }
                }
                else
                {
                    imgPortrait.ResourceID = userInfo.U_Portrait;
                }
                //默认状态下，不显示同意，拒绝，编辑按钮
                btnAgreed.Visible = false;
                btnRefuse.Visible = false;
                btnEdit.Visible = false;
                switch (Status)
                {
                    case RB_Status.新建:                        //如果是已创建状态，当前用户为责任人，则显示审批按钮
                        lblRBState.Text = "等待责任人审批";
                        if (UserID == Reim.RB_LiableMan)
                        {
                            btnAgreed.Visible = true;
                            btnRefuse.Visible = true;
                            if (UserID == Reim.RB_CreateUser)
                            {
                                btnEdit.Visible = true;
                                btnAgreed.Width = 85;
                                btnAgreed.Left = 10;
                                btnRefuse.Width = 85;
                                btnRefuse.Left = 108;
                                btnEdit.Width = 85;
                                btnEdit.Left = 205;
                            }
                            else
                            {
                                btnAgreed.Width = 134;
                                btnAgreed.Left = 10;
                                btnRefuse.Width = 134;
                                btnRefuse.Left = 156;
                            }
                        }
                        else
                        {
                            if (UserID == Reim.RB_CreateUser)
                            {
                                btnEdit.Visible = true;
                                btnEdit.Width = 280;
                                btnEdit.Left = 10;
                            }
                            else
                            {
                                plButton.Border = new Border(0);
                            }
                        }
                        break;
                    case RB_Status.责任人审批:                  //如果是责任人已审批状态，当前用户为行政审批人，则显示审批功能按钮
                        lblRBState.Text = "等待行政审批";
                        foreach (string ReimAEAChecker in ReimAEACheckers)
                        {
                            if (UserID == ReimAEAChecker)
                            {
                                btnAgreed.Visible = true;
                                btnRefuse.Visible = true;
                                btnAgreed.Width = 134;
                                btnAgreed.Left = 10;
                                btnRefuse.Width = 134;
                                btnRefuse.Left = 156;
                            }
                        }
                        break;
                    case RB_Status.行政审批:                //如果当前行政已审批，当前用户为财务，则显示审批功能按钮
                        lblRBState.Text = "等待财务审批";
                        foreach (string ReimFinancialChecker in ReimFinancialCheckers)
                        {
                            if (UserID == ReimFinancialChecker)
                            {
                                btnAgreed.Visible = true;
                                btnRefuse.Visible = true;
                                btnAgreed.Width = 134;
                                btnAgreed.Left = 10;
                                btnRefuse.Width = 134;
                                btnRefuse.Left = 156;
                            }
                        }
                        break;
                    case RB_Status.财务审批:                     //报销通过，不显示任何按钮
                        lblRBState.Text = "已审批（完成）";
                        plButton.Border = new Border(0);
                        break;
                    case RB_Status.已拒绝:                   //报销驳回，如果当前用户为报销单创始人，则显示编辑按钮
                        lblRBState.Text = "已审批（拒绝）";
                        if (UserID == Reim.RB_CreateUser)
                        {
                            btnEdit.Visible = true;
                            btnEdit.Width = 280;
                            btnEdit.Left = 10;
                        }
                        else
                        {
                            plButton.Border = new Border(0);
                        }
                        break;
                }
                CCDetailDto Cost = AutofacConfig.costCenterService.GetCCByID(Reim.CC_ID);
                lblRBNO.Text = Reim.RB_ID;     //报销单编号
                lblRBCC.Text = Cost.CC_Name;        //成本中心名称
                lblAmount.Text = Reim.RB_TotalAmount.ToString();           //总金额
                lblAmount.Text = Reim.RB_TotalAmount.ToString();//报销单总金额
                lblCreateTime.Text = Reim.RB_CreateDate.ToString("yyyy/MM/dd");
                lblnote.Text = Reim.RB_Note;              //报销单备注

                if (string.IsNullOrEmpty(Reim.RB_RejectionReason) == true)
                {
                    lblReason.Text = "";
                    lblReason.Height = 25;
                    lblReason1.Height = 25;
                    lblReason.VerticalAlignment = VerticalAlignment.Center;
                    lblReason1.VerticalAlignment = VerticalAlignment.Center;
                    lblReason.Padding = new Padding(0, 0, 0, 0);
                    lblReason1.Padding = new Padding(0, 0, 0, 0);
                }
                else
                {
                    lblReason.Text = Reim.RB_RejectionReason;       //报销单拒绝原因
                    lblReason.Height = 50;
                    lblReason1.Height = 50;
                    lblReason.VerticalAlignment = VerticalAlignment.Top;
                    lblReason1.VerticalAlignment = VerticalAlignment.Top;
                    lblReason.Padding = new Padding(0, 5, 0, 0);
                    lblReason1.Padding = new Padding(0, 5, 0, 0);
                }
                listRBRowData.Top = lblReason.Top + lblReason.Height;

                //如果审批已结束，则隐藏按钮所占区域
                if (btnAgreed.Visible == false && btnEdit.Visible == false && btnRefuse.Visible==false)
                {
                    plButton.Visible = false;
                }

                //创建表，将数据进行处理后放入表内，然后显示在页面上
                DataTable rbrowtable = new DataTable();
                rbrowtable.Columns.Add("ID", typeof(System.Int32));         //消费记录编号
                rbrowtable.Columns.Add("RB_NO", typeof(System.String));   //报销单号
                rbrowtable.Columns.Add("RBROW_DATE", typeof(System.String));       //消费日期
                rbrowtable.Columns.Add("RBROW_TYPE", typeof(System.String));      //消费类型ID
                rbrowtable.Columns.Add("RBROW_TYPENAME", typeof(System.String));   //消费类型名称
                rbrowtable.Columns.Add("RBROW_AMOUNT", typeof(System.Decimal));      //消费日期
                rbrowtable.Columns.Add("RBROW_NOTE", typeof(System.String));       //消费记录备注
                foreach (RB_RowsDto Row in Rows)
                {
                    string TypeName = AutofacConfig.rBService.GetTypeNameByID(Row.R_TypeID);
                    rbrowtable.Rows.Add(Row.R_ID, Row.RB_ID, Row.R_ConsumeDate.ToString("yyyy/MM/dd"), Row.R_TypeID, TypeName, Row.R_Amount, Row.R_Note);
                }
                listRBRowData.Rows.Clear();//清空报销单行项列表数据
                if (rbrowtable.Rows.Count > 0)
                {
                    this.listRBRowData.DataSource = rbrowtable;
                    this.listRBRowData.DataBind();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 手机自带回退按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRBDetail_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                this.Close();            //关闭当前页面
            }
        }
        /// <summary>
        /// 初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRBDetail_Load(object sender, EventArgs e)
        {
            try
            {
                title1.TitleText = "报销详情";
                Bind();               //数据初始化操作
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 同意报销
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgreed_Press(object sender, EventArgs e)
        {
            try
            {
                switch (Status)
                {
                    case RB_Status.新建:
                        Status = RB_Status.责任人审批;
                        break;
                    case RB_Status.责任人审批:
                        Status = RB_Status.行政审批;
                        break;
                    case RB_Status.行政审批:
                        Status = RB_Status.财务审批;
                        break;
                }
                ReturnInfo r = AutofacConfig.rBService.UpdateRBStatus(ID, Status, UserID, "");           //保存报销单
                if (r.IsSuccess == true)
                {
                    Bind();               //刷新页面
                    this.ShowResult = ShowResult.Yes;
                    Toast("审批成功");
                }
                else
                {
                    throw new Exception(r.ErrorInfo);
                }
            }
            catch(Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 拒绝报销
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefuse_Press(object sender, EventArgs e)
        {
            try
            {
                //弹出输入拒绝理由界面               
                this.ShowDialog(Refuse);
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        //提交拒绝操作到数据库
        public void SureRefuse()
        {
            try
            {
                ReturnInfo r = AutofacConfig.rBService.UpdateRBStatus(ID, RB_Status.已拒绝, UserID, this.lblReason.Text);
                if (r.IsSuccess == true)
                {
                    Bind();     //操作成功，刷新页面
                    this.ShowResult = ShowResult.Yes;
                    //Refuse.Close();
                    this.Form.Toast("审批成功");
                }
                else
                {
                    throw new Exception(r.ErrorInfo);
                }
            }
            catch(Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 报销编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Press(object sender, EventArgs e)
        {
            try
            {
                frmRBEdit RBEdit = new frmRBEdit();
                RBEdit.ID = ID;
                this.Show(RBEdit, (MobileForm from, object args) =>
                {
                    if (RBEdit.ShowResult == ShowResult.Yes)
                    {
                        Bind();          //重新加载数据
                    }
                });
                this.ShowResult = ShowResult.Yes;
            }
            catch(Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}