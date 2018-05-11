using Smobiler.Core.Controls;
using SmoONE.UI.Work;
using System;

namespace SmoONE.UI.Layout
{
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmLeaveLayout : Smobiler.Core.Controls.MobileUserControl
    {
        /// <summary>
        /// 行项点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tpLeave_Press(object sender, EventArgs e)
        {
            if(this.Form.ToString()== "SmoONE.UI.Work.frmCCTo")
            {
                string ID = lblId.BindDataValue.ToString();
                switch (Convert.ToInt32(lblType.BindDataValue.ToString()))
                {
                    //跳转到请假详细界面
                    case (int)DataGridviewType.请假:
                        Leave.frmLeaveDetail frmLeaveDetail = new Leave.frmLeaveDetail();
                        frmLeaveDetail.lID = ID;
                        this.Form.Show(frmLeaveDetail, (MobileForm form, object args) =>
                        {
                            if (frmLeaveDetail.ShowResult == ShowResult.Yes)
                            {
                                ((frmCCTo)(this.Form)).Bind();
                            }
                        });
                        break;
                    case (int)DataGridviewType.报销:
                        break;
                }
            }
            else if(this.Form.ToString() == "SmoONE.UI.Work.frmCheck")
            {
                string ID = lblId.BindDataValue.ToString();
                switch (Convert.ToInt32(lblType.BindDataValue.ToString()))
                {
                    //跳转到请假详细界面
                    case (int)DataGridviewType.请假:
                        Leave.frmLeaveDetail frmLeaveDetail = new Leave.frmLeaveDetail();
                        frmLeaveDetail.lID = ID;
                        this.Form.Show(frmLeaveDetail, (MobileForm form, object args) =>
                        {
                            if (frmLeaveDetail.ShowResult == ShowResult.Yes)
                            {
                                ((frmCheck)(this.Form)).type = "";
                                ((frmCheck)(this.Form)).state = "";
                                ((frmCheck)(this.Form)).Bind();
                               
                            }
                        });
                        break;
                    //跳转到报销详细界面
                    case (int)DataGridviewType.报销:
                        RB.frmRBDetail frmRBDetail = new RB.frmRBDetail();
                        frmRBDetail.ID = ID;
                        this.Form.Show(frmRBDetail, (MobileForm form, object args) =>
                        {
                            if (frmRBDetail.ShowResult == ShowResult.Yes)
                            {
                                ((frmCheck)(this.Form)).type = "";
                                ((frmCheck)(this.Form)).state = "";
                                ((frmCheck)(this.Form)).Bind();
                                
                            }
                        });
                        break;
                }
            }
            else if(this.Form.ToString() == "SmoONE.UI.Work.frmCreated")
            {
                string ID = lblId.BindDataValue.ToString();
                switch (Convert.ToInt32(lblType.BindDataValue.ToString()))
                {
                    //跳转到请假详细界面
                    case (int)DataGridviewType.请假:
                        Leave.frmLeaveDetail frmLeaveDetail = new Leave.frmLeaveDetail();
                        frmLeaveDetail.lID = ID;
                        this.Form.Show(frmLeaveDetail, (MobileForm form, object args) =>
                        {
                            if (frmLeaveDetail.ShowResult == ShowResult.Yes)
                            {
                                ((frmCreated)(this.Form)).Bind();
                            }
                        });
                        break;
                    //跳转到报销详细界面
                    case (int)DataGridviewType.报销:
                        RB.frmRBDetail frmRBDetail = new RB.frmRBDetail();
                        frmRBDetail.ID = ID;
                        this.Form.Show(frmRBDetail, (MobileForm form, object args) =>
                        {
                            if (frmRBDetail.ShowResult == ShowResult.Yes)
                            {
                                ((frmCreated)(this.Form)).Bind();
                            }
                        });
                        break;
                }
            }
        }
    }
}