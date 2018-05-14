using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace SmoONE.UI.Layout
{
    partial class frmAttendanceStatisticsLayout : Smobiler.Core.Controls.MobileUserControl
    {
        /// <summary>
        /// 根据相应选择，在页面上显示相应内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_Press(object sender, EventArgs e)
        {
            try
            {
                string[] Year = ((SmoONE.UI.Attendance.frmAttendanceStatistics)this.Form).btnYear.Text.Split('▼');      //年份
                string[] Month = ((SmoONE.UI.Attendance.frmAttendanceStatistics)this.Form).btnMonth.Text.Split('▼');       //月份
                SmoONE.UI.Attendance.frmAttendanceStatDay frmDay = new SmoONE.UI.Attendance.frmAttendanceStatDay();
                frmDay.UserID = image1.BindDataValue .ToString();
                frmDay.DayTime = Year[0] + Month[0];         //将年月信息传递到下个页面
                this.Form.Show(frmDay);
            
            }
            catch (Exception ex)
            {
                this.Form .Toast(ex.Message);
            }
        }

      

    }
}