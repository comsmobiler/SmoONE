using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace SmoONE.UI.Layout
{
    partial class frmAttendanceStatSelfLayout : Smobiler.Core.Controls.MobileUserControl
    {
        /// <summary>
        /// 跳转到签到详细界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_Press(object sender, EventArgs e)
        {
            try
            {
                if ( Convert.ToInt32(lblNumber.BindDataValue) > 0)
                {
                    SmoONE.UI.Attendance.frmAttendanceStatSelfDetail newFrm = new SmoONE.UI.Attendance.frmAttendanceStatSelfDetail();
                    newFrm.Type = lblID.BindDisplayValue.ToString ();           //签到类型
                    newFrm.Daytime = ((SmoONE.UI.Attendance.frmAttendanceStatSelf)this.Form).Daytime;                   //时间
                    newFrm.UserID = ((SmoONE.UI.Attendance.frmAttendanceStatSelf)this.Form).UserID;                     //用户ID
                 //   newFrm.TitleText =((SmoONE.UI.Attendance.frmAttendanceStatSelf)this.Form). lblName.Text + lblID.BindDisplayValue.ToString () + "记录";
                    this.Form.Show(newFrm);
                }
            }
            catch (Exception ex)
            {
               this.Form. Toast(ex.Message);
            }
        }

       
    }
}