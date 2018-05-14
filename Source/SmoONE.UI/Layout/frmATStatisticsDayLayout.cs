using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace SmoONE.UI.Layout
{
    partial class frmATStatisticsDayLayout : Smobiler.Core.Controls.MobileUserControl
    {
       
 
         /// <summary>
        /// 跳转到考勤模板界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_Press(object sender, EventArgs e)
        {
            try
            {
                //如果不是全天旷工则跳转到考勤查看详细，否则不跳转。
                if (Convert.ToBoolean(lblAbsenteeism.BindDataValue) == false)
                {
                    SmoONE.UI.Attendance.frmAttendanceMain frmMain = new SmoONE.UI.Attendance.frmAttendanceMain();
                    frmMain.DayTime = ((SmoONE.UI.Attendance.frmAttendanceStatMan)this.Form).DayTime;            //时间
                    frmMain.enter = (int)Enum.Parse(typeof(ATMainState), ATMainState.统计查看.ToString());
                    frmMain.UserID = lblUser.BindDataValue.ToString();
                    this.Form.Show(frmMain);
                }
            }
            catch (Exception ex)
            {
                this.Form.Toast(ex.Message);
            }
        }
    }
}