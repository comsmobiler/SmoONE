using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace SmoONE.UI.Layout
{
    [System.ComponentModel.ToolboxItem(true)]
    partial class frmATFootLayout : Smobiler.Core.Controls.MobileUserControl
    {
        private void btnSave_Press(object sender, EventArgs e)
        {
            try
            {
               
                    if (((SmoONE.UI.Attendance.frmATUser)this.Form).selectUserQty <= 0)
                    {
                        throw new Exception("请至少选择一位考勤成员！");
                    }
                    else
                    {
                        ((SmoONE.UI.Attendance.frmATUser)this.Form).selectUser = null;
                        foreach (ListViewRow rows in ((SmoONE.UI.Attendance.frmATUser)this.Form).gridATUserData.Rows)
                        {
                            if (Convert.ToBoolean(((frmATUserLayout)(rows.Control)).Check.BindDisplayValue) == true)
                            {
                                if (string.IsNullOrEmpty(((SmoONE.UI.Attendance.frmATUser)this.Form).selectUser) == true)
                                {

                                    ((SmoONE.UI.Attendance.frmATUser)this.Form).selectUser = ((frmATUserLayout)(rows.Control)).lblUser.BindDataValue.ToString();

                                }
                                else
                                {
                                    ((SmoONE.UI.Attendance.frmATUser)this.Form).selectUser += "," + ((frmATUserLayout)(rows.Control)).lblUser.BindDataValue.ToString();
                                }
                            }
                        }
                      this.Form .ShowResult = ShowResult.Yes;
                     this .Form . Close();
                    }

                }
            catch (Exception ex)
            {
               this.Form . Toast(ex.Message, ToastLength.SHORT);
            }
        }
    }
}