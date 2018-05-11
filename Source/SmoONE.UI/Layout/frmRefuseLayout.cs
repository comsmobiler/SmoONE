using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SmoONE.CommLib;
using SmoONE.DTOs;

namespace SmoONE.UI.Layout
{
    partial class frmRefuseLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "definition"
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Press(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 拒绝审批
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Press(object sender, EventArgs e)
        {
            try
            {
                if (txtReason.Text.Trim().Length <= 0)
                {
                    throw new Exception("请输入拒绝理由！");
                }
                switch (this .Form.ToString ())
                {
                    case "SmoONE.UI.Leave.frmLeaveDetail":
                        //审批人驳回请假
                        ReturnInfo result = AutofacConfig.leaveService.UpdateLeaveStatus(((SmoONE.UI.Leave.frmLeaveDetail)this.Form).lID, L_Status.已拒绝, Client.Session["U_ID"].ToString(), txtReason.Text.Trim());
                        //如果返回true则审批成功，否则失败并抛出错误
                        if (result.IsSuccess == true)
                        {
                          ((SmoONE.UI.Leave.frmLeaveDetail)this.Form).GetLeave();
                           this.Close();
                           this.Form . ShowResult = ShowResult.Yes;
                           this.Form . Toast("已拒绝请假！", ToastLength.SHORT);
                        }
                        else
                        {
                            throw new Exception(result.ErrorInfo);
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                this.Form .Toast(ex.Message, ToastLength.SHORT);
            }
        }
    }
}