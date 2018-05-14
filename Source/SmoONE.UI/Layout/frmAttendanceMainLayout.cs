using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SmoONE.DTOs;
using SmoONE.UI.Attendance;
using SmoONE.CommLib;

namespace SmoONE.UI.Layout
{
    partial class frmAttendanceMainLayout : Smobiler.Core.Controls.MobileUserControl
    {
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类  
        private void panel1_Press(object sender, EventArgs e)
        {
            try
            {
                string userID = ((SmoONE.UI.Attendance.frmAttendanceMain)this.Form).UserID;
                if ((ATMainState)Enum.Parse(typeof(ATMainState), ((SmoONE.UI.Attendance.frmAttendanceMain)this.Form).enter.ToString()) == ATMainState.统计查看)                   //进入的是查看签到页面
                {
                    List<ALDto> listStats = AutofacConfig.attendanceService.GetALByUserAndDate(userID, Convert.ToDateTime(((SmoONE.UI.Attendance.frmAttendanceMain)this.Form).DayTime));
                    foreach (ALDto Row in listStats)
                    {
                        if (Row.AL_OnTime.ToString("HH:mm") == lblTime.BindDisplayValue.ToString() && string.IsNullOrEmpty(Row.AL_Reason) == false)
                        {
                            //DetailLayout.LayoutData.Items["lblLocation"].Text = Row.AL_Position;        //显示考勤地点
                            //DetailLayout.LayoutData.Items["lblReason"].Text = Row.AL_Reason;            //显示迟到早退原因
                            //DetailLayout.Show();
                            frmAttendanceMainDetailLayout atMainDControl = new frmAttendanceMainDetailLayout();
                            atMainDControl.lblLocation.Text = Row.AL_Position;
                            atMainDControl.lblReason.Text = Row.AL_Reason;
                            this.Form.ShowDialog(atMainDControl);
                        }
                    }
                }
                else if (string.IsNullOrEmpty(btnCheck.BindDisplayValue.ToString()) == true)                  //当前行项已签到
                {
                    List<ALDto> listLogs = AutofacConfig.attendanceService.GetALByUserAndDate(userID, DateTime.Now);
                    foreach (ALDto Row in listLogs)
                    {
                        if (Row.AL_OnTime.ToString("HH:mm") == lblTime.BindDisplayValue.ToString() && string.IsNullOrEmpty(Row.AL_Reason) == false)
                        {
                            //DetailLayout.LayoutData.Items["lblLocation"].Visible = false;         //隐藏考勤地点信息
                            //DetailLayout.LayoutData.Items["imgLocation"].Visible = false;         //隐藏位置图标
                            //DetailLayout.LayoutData.Items["lblReason"].Top = 0;
                            //DetailLayout.LayoutData.Items["lblReason"].Text = Row.AL_Reason;            //显示迟到早退原因
                            //DetailLayout.Show();
                            frmAttendanceMainDetailLayout atMainDControl = new frmAttendanceMainDetailLayout();
                            atMainDControl.lblLocation.Visible = false;
                            atMainDControl.imgLocation.Visible = false;
                            atMainDControl.lblReason.Top = 0;
                            atMainDControl.lblReason.Text = Row.AL_Reason;
                            this.Form.ShowDialog(atMainDControl);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                this.Form.Toast(ex.Message);
            }
        }
        /// <summary>
        /// 进行签到或签退
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheck_Press(object sender, EventArgs e)
        {
            try
            {
                if (((frmAttendanceMain)(Form)).hasgps.HasValue == false) throw new Exception("定位尚未完成，请稍后再试");
                if (((frmAttendanceMain)(Form)).hasgps.Value == false) throw new Exception("未获取GPS信息，请检查权限");
                ((frmAttendanceMain)(Form)).newLog.AL_Reason = "";
                switch ((StatisticsTime)Enum.Parse(typeof(StatisticsTime), lblType.BindDataValue.ToString()))
                {
                    case StatisticsTime.上午上班时间:
                        ((frmAttendanceMain)(Form)).newLog.AL_LogTimeType = StatisticsTime.上午上班时间;
                        break;
                    case StatisticsTime.上午下班时间:
                        ((frmAttendanceMain)(Form)).newLog.AL_LogTimeType = StatisticsTime.上午下班时间;
                        break;
                    case StatisticsTime.下午上班时间:
                        ((frmAttendanceMain)(Form)).newLog.AL_LogTimeType = StatisticsTime.下午上班时间;
                        break;
                    case StatisticsTime.下午下班时间:
                        ((frmAttendanceMain)(Form)).newLog.AL_LogTimeType = StatisticsTime.下午下班时间;
                        break;
                    case StatisticsTime.上班时间:
                        ((frmAttendanceMain)(Form)).newLog.AL_LogTimeType = StatisticsTime.上班时间;
                        break;
                    case StatisticsTime.下班时间:
                        ((frmAttendanceMain)(Form)).newLog.AL_LogTimeType = StatisticsTime.下班时间;
                        break;
                }
                ((frmAttendanceMain)(Form)).newLog.AL_Date = DateTime.Now;          //签到时间
                ((frmAttendanceMain)(Form)).newLog.AL_UserID = Client.Session["U_ID"].ToString();              //用户ID
                if ((WorkTimeType)Enum.Parse(typeof(WorkTimeType), ((frmAttendanceMain)(Form)).CommutingType) == WorkTimeType.一天一上下班)
                {
                    ((frmAttendanceMain)(Form)).newLog.AL_CommutingType = WorkTimeType.一天一上下班;
                }
                else
                {
                    ((frmAttendanceMain)(Form)).newLog.AL_CommutingType = WorkTimeType.一天二上下班;
                }
                ((frmAttendanceMain)(Form)).newLog.AL_Position = ((frmAttendanceMain)(Form)).Location;                //签到位置
                ((frmAttendanceMain)(Form)).newLog.AL_OnTime = Convert.ToDateTime(lblTime.BindDisplayValue.ToString());       //签到准点
                if (((frmAttendanceMain)(Form)).LocState == 1)              //已成功定位
                {
                    if (btnCheck.Text == "签到")
                    {
                        if (DateTime.Now > Convert.ToDateTime(lblTime.BindDisplayValue.ToString()))
                        {
                            ((frmAttendanceMain)(Form)).newLog.AL_Status = AttendanceType.迟到;         //签到状态  
                            frmAttendanceMainLayoutDialog frmReason = new frmAttendanceMainLayoutDialog();
                            frmReason.newLog = ((frmAttendanceMain)(Form)).newLog;
                            frmReason.lblTitle.Text = "迟到理由";
                            this.Form.ShowDialog(frmReason);
                            //this.Form.Show(frmReason, (MobileForm from, object args) =>
                            //{
                            //    if (frmReason.ShowResult == true)
                            //    {
                            //        ((frmAttendanceMain)(Form)).Bind();          //重新加载数据
                            //    }
                            //});
                        }
                        else
                        {
                            ((frmAttendanceMain)(Form)).newLog.AL_Status = AttendanceType.准点;             //签到状态
                            ReturnInfo r = AutofacConfig.attendanceService.AddAttendanceLog(((frmAttendanceMain)(Form)).newLog);
                            if (r.IsSuccess == true)         //添加记录成功
                            {
                                this.Form.Toast("签到成功！");
                                ((frmAttendanceMain)(Form)).Bind();                     //刷新页面
                            }
                            else
                            {
                                throw new Exception(r.ErrorInfo);        //提示添加记录失败原因
                            }
                        }
                    }
                    else if (btnCheck.Text == "签退")
                    {
                        if (DateTime.Now < Convert.ToDateTime(lblTime.BindDisplayValue.ToString()))
                        {
                            MessageBox.Show("现在是早退时间，确认签退吗？", MessageBoxButtons.OKCancel, (object o, MessageBoxHandlerArgs args) =>
                            {
                                if (args.Result == ShowResult.OK)
                                {
                                    ((frmAttendanceMain)(Form)).newLog.AL_Status = AttendanceType.早退;           //签到状态
                                    frmAttendanceMainLayoutDialog frmReason = new frmAttendanceMainLayoutDialog();
                                    frmReason.newLog = ((frmAttendanceMain)(Form)).newLog;
                                    frmReason.lblTitle.Text = "早退理由";
                                    this.Form.ShowDialog(frmReason);
                                    //this.Form.Show(frmReason, (MobileForm from, object arg) =>
                                    //{
                                    //    if (frmReason.ShowResult == true)
                                    //    {
                                    //        ((frmAttendanceMain)(Form)).Bind();          //重新加载数据
                                    //    }
                                    //});
                                }
                            });
                        }
                        else
                        {
                            ((frmAttendanceMain)(Form)).newLog.AL_Status = AttendanceType.准点;
                            ReturnInfo r = AutofacConfig.attendanceService.AddAttendanceLog(((frmAttendanceMain)(Form)).newLog);
                            if (r.IsSuccess == true)             //添加记录成功
                            {
                                this.Form.Toast("签退成功！");
                                ((frmAttendanceMain)(Form)).Bind();                  //刷新页面
                            }
                            else
                            {
                                throw new Exception(r.ErrorInfo);
                            }
                        }
                    }
                }
                else if (((frmAttendanceMain)(Form)).LocState == 2)
                {
                    if (btnCheck.Text == "签到")
                    {
                        throw new Exception("签到失败，您当前不在公司附近");
                    }
                    else if (btnCheck.Text == "签退")
                    {
                        throw new Exception("签退失败，您当前不在公司附近");
                    }
                }
            }
            catch (Exception ex)
            {
                this.Form.Toast(ex.Message);
            }
        }
    }
}