using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SmoONE.DTOs;

namespace SmoONE.UI.Layout
{
    // ******************************************************************
    // 文件版本： SmoONE 1.1
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2017/2
    // 主要内容： 考勤报表统计(按月统计)模板
    // ******************************************************************
    partial class frmATStatSelfDetailDayLayout : Smobiler.Core.Controls.MobileUserControl
    {
        /// <summary>
        /// 跳转到考勤详细界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_Press(object sender, EventArgs e)
        {
            try
            {
                //if (string.IsNullOrEmpty(((SmoONE.UI.Attendance.frmAttendanceStatSelfDetail)this.Form).Type ) == false)
                //{
                //    switch ((StatisticsType)Enum.Parse(typeof(StatisticsType), ((SmoONE.UI.Attendance.frmAttendanceStatMonthTypeDay)this.Form).atType))
                //    {
                //        case StatisticsType.准点:
                //        case StatisticsType.迟到:
                //        case StatisticsType.早退:
                //        case StatisticsType.未签到:
                //        case StatisticsType.未签退:
                //            SmoONE.UI.Attendance.frmAttendanceMain frmMain = new SmoONE.UI.Attendance.frmAttendanceMain();
                //            frmMain.DayTime = lblDay.Text;            //选择查看的日期
                //            frmMain.enter = (int)Enum.Parse(typeof(ATMainState), ATMainState.统计查看.ToString());
                //            frmMain.UserID = ((SmoONE.UI.Attendance.frmAttendanceStatMonthTypeDay)this.Form).UserID;
                //            this.Form.Show(frmMain);
                //            break;
                //    }
                //}
            }
            catch (Exception ex)
            {
                this.Form.Toast(ex.Message);
            }
        }

    }
}