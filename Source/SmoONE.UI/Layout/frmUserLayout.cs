using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SmoONE.UI.UserInfo;

namespace SmoONE.UI.Layout
{
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmUserLayout : Smobiler.Core.Controls.MobileUserControl
    {
        /// <summary>
        /// Êý¾Ý´«µÝ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tpUser_Press(object sender, EventArgs e)
        {
            try
            {
                switch (this .Form.ToString ())
                {
                    case "SmoONE.UI.Attendance.frmAttendanceStatUser":
                          SmoONE.UI.Attendance.frmAttendanceStatMonthTypeDay frm =new SmoONE.UI.Attendance.frmAttendanceStatMonthTypeDay ();
                          frm.atType = ((SmoONE.UI.Attendance.frmAttendanceStatUser)(this.Form)).atType;
                         frm.UserID=lblUser.BindDataValue.ToString ();
                          frm.Daytime = ((SmoONE.UI.Attendance.frmAttendanceStatUser)(this.Form)).atDate;
                        this.Form .Show (frm);
                        break ;
                    case "SmoONE.UI.UserInfo.frmCheckOrCCTo":
                         ((frmCheckOrCCTo)(this.Form)).userInfo = lblUser.BindDataValue.ToString() + "," + lblUser.BindDisplayValue.ToString() + "," + imgPortrait.BindDataValue.ToString();
                        this.Form.ShowResult = ShowResult.Yes;
                        this.Form.Close();
                        break;
                }
               
            }
            catch(Exception ex)
            {
                this.Form.Toast(ex.Message);
            }
        }
    }
}