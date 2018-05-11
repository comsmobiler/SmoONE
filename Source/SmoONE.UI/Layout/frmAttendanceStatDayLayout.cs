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
    partial class frmAttendanceStatDayLayout : Smobiler.Core.Controls.MobileUserControl
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
                switch (this .Form.ToString () )
                {
                    case "SmoONE.UI.Attendance.frmAttendanceStatMonthTypeDay":
                        if (string.IsNullOrEmpty(((SmoONE.UI.Attendance.frmAttendanceStatMonthTypeDay)this.Form).atType) == false)
                        {
                            switch ((StatisticsType)Enum.Parse(typeof(StatisticsType), ((SmoONE.UI.Attendance.frmAttendanceStatMonthTypeDay)this.Form).atType))
                            {
                                case StatisticsType.准点:
                                case StatisticsType.迟到:
                                case StatisticsType.早退:
                                case StatisticsType.未签到:
                                case StatisticsType.未签退:
                                    SmoONE.UI.Attendance.frmAttendanceMain frmMain = new SmoONE.UI.Attendance.frmAttendanceMain();
                                    frmMain.DayTime = lblDay.BindDisplayValue .ToString ();             //选择查看的日期
                                    frmMain.enter = (int)Enum.Parse(typeof(ATMainState), ATMainState.统计查看.ToString());
                                    frmMain.UserID = ((SmoONE.UI.Attendance.frmAttendanceStatMonthTypeDay)this.Form).UserID;
                                    this.Form .Show(frmMain);
                                    break;
                            }
                        }
                     break;
                    case "SmoONE.UI.Attendance.frmAttendanceStatDay":
                         SmoONE.UI.Attendance.frmAttendanceMain frmMain1 = new SmoONE.UI.Attendance.frmAttendanceMain();
                        frmMain1.DayTime = lblDay.BindDisplayValue .ToString ();            //选择查看的日期
                        frmMain1.UserID =((SmoONE.UI.Attendance.frmAttendanceStatDay)this.Form ). UserID;             //所查看用户ID
                        frmMain1.enter = (int)Enum.Parse(typeof(ATMainState), ATMainState.统计查看.ToString());
                        this.Form.Show(frmMain1);
                     break;
                    case "SmoONE.UI.Attendance.frmAttendanceStatistics":
                             SmoONE.UI.Attendance.frmAttendanceStatMan frmMan = new SmoONE.UI.Attendance.frmAttendanceStatMan();
                             frmMan.DayTime =lblDay.BindDisplayValue .ToString ();     //将选择日期，传递到下个页面
                             this.Form .Show(frmMan);
                     break;
                    case "SmoONE.UI.Attendance.frmAttendanceStatSelfDay":
                        SmoONE.UI.Attendance.frmAttendanceMain frmMain2 = new SmoONE.UI.Attendance.frmAttendanceMain();
                        frmMain2.DayTime = lblDay.BindDisplayValue.ToString();            //选择查看的日期
                        frmMain2.UserID = ((SmoONE.UI.Attendance.frmAttendanceStatSelfDay)this.Form).UserID;             //所查看用户ID
                        frmMain2.enter = (int)Enum.Parse(typeof(ATMainState), ATMainState.统计查看.ToString());
                        this.Form.Show(frmMain2);
                        break;

                 }
            }
            catch (Exception ex)
            {
               this.Form . Toast(ex.Message);
            }
        }

       
    }
}