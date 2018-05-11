using SmoONE.UI.RB;
using System;

namespace SmoONE.UI.Layout
{
    [System.ComponentModel.ToolboxItem(true)]
    partial class RefuseDialog : Smobiler.Core.Controls.MobileUserControl
    {
        private void btnCancel_Press(object sender, EventArgs e)
        {
            //((frmRBDetail)(this.Form)).refuseDialog.Close();
            this.Close();
        }

        private void btnOK_Press(object sender, EventArgs e)
        {
            ((frmRBDetail)(this.Form)).lblReason.Text = txtReason.Text;
            ((frmRBDetail)(this.Form)).SureRefuse();    //提交拒绝操作到数据库
            this .Close();
        }
    }
}