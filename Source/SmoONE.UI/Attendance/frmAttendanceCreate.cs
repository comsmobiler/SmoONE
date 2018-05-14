using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SmoONE.DTOs;
using SmoONE.CommLib;

namespace SmoONE.UI.Attendance
{
    // ******************************************************************
    // 文件版本： SmoONE 1.1
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2017/2
    // 主要内容： 考勤模板创建或编辑界面
    // ******************************************************************
    partial class frmAttendanceCreate : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        public string ATNo;//考勤模板编号
        private WorkTimeType ATMode;//考勤类型
        private ATInputDto ATemplate = new ATInputDto();//考勤
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类 
        #endregion
        /// <summary>
        /// 初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAttendanceCreate_Load(object sender, EventArgs e)
        {
            GetAT();
        }
        /// <summary>
        /// 获取考勤信息
        /// </summary>
        private void GetAT()
        {
            try
            {
                if (string.IsNullOrEmpty(ATNo) == false)
                {
                    btnSave.Width = 134;
                    btnDelete.Visible = true;
                    ATDetailDto At = AutofacConfig.attendanceService.GetATByID(ATNo);
                    if (At != null)
                    {
                        ATemplate.AT_ID = At.AT_ID;
                        ATemplate.AT_Name = At.AT_Name;
                        txtName.Text = ATemplate.AT_Name;
                        //工作日考勤时间
                        if (string.IsNullOrEmpty(At.AT_CommutingType) == false)
                        {
                            ATMode = (WorkTimeType)Enum.Parse(typeof(WorkTimeType), At.AT_CommutingType);
                            ATemplate.AT_CommutingType = ATMode;
                            switch (ATMode)
                            {
                                case WorkTimeType.一天一上下班:
                                    if (At.AT_StartTime != null)
                                    {
                                        ATemplate.AT_AMStartTime = At.AT_StartTime;
                                    }
                                    if (At.AT_PMEndTime != null)
                                    {
                                        ATemplate.AT_PMEndTime = At.AT_EndTime;
                                    }
                                    break;
                                case WorkTimeType.一天二上下班:
                                    if (At.AT_AMStartTime != null)
                                    {
                                        ATemplate.AT_AMStartTime = At.AT_AMStartTime;
                                    }

                                    if (At.AT_AMEndTime != null)
                                    {
                                        ATemplate.AT_AMEndTime = At.AT_AMEndTime;
                                    }

                                    if (At.AT_PMStartTime != null)
                                    {
                                        ATemplate.AT_PMStartTime = At.AT_PMStartTime;
                                    }

                                    if (At.AT_PMEndTime != null)
                                    {
                                        ATemplate.AT_PMEndTime = At.AT_PMEndTime;
                                    }

                                    break;
                            }
                        }
                        //考勤工作日
                        if (string.IsNullOrEmpty(At.AT_WeeklyWorkingDay) == false)
                        {
                            ATemplate.AT_WeeklyWorkingDay = At.AT_WeeklyWorkingDay;
                        }
                        else
                        {
                            ATemplate.AT_WeeklyWorkingDay = ((int)Week.Monday).ToString() + "," + ((int)Week.Tuesday).ToString() + "," + ((int)Week.Wednesday).ToString() + "," + ((int)Week.Thursday).ToString() + "," + ((int)Week.Friday).ToString();
                        }

                        int nATUser = 0; //考勤人数
                        if (string.IsNullOrEmpty(At.AT_Users) == false)
                        {
                            string[] atUser = At.AT_Users.Split(',');
                            nATUser = atUser.Length;
                            ATemplate.AT_Users = At.AT_Users;

                        }
                        btnUser.Text = nATUser.ToString() + "人"+ "   > ";
                        //考勤位置
                        ATemplate.AT_Longitude = At.AT_Longitude;
                        ATemplate.AT_Latitude = At.AT_Latitude;
                        if (string.IsNullOrEmpty(At.AT_Positions) == false)
                        {
                            ATemplate.AT_Positions = At.AT_Positions;
                        }
                        ATemplate.AT_AllowableDeviation = At.AT_AllowableDeviation;
                        lblAddress.Text = At.AT_Positions;
                        txtADeviation.Text = At.AT_AllowableDeviation.ToString();

                    }
                }
                else
                {
                    btnSave.Width = 280;
                    btnDelete.Visible = false;
                    gps1.GetGps();
                    ATMode = (int)WorkTimeType.一天一上下班;
                    ATemplate.AT_WeeklyWorkingDay = ((int)Week.Monday).ToString() + "," + ((int)Week.Tuesday).ToString() + "," + ((int)Week.Wednesday).ToString() + "," + ((int)Week.Thursday).ToString() + "," + ((int)Week.Friday).ToString();
                    ATemplate.AT_CommutingType = ATMode;
                }
                if (Convert.IsDBNull(ATMode) == false)
                {
                    upATMode();//更新考勤模式
                }
                upATweeklyWorkingDay();//更新日期
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 考勤模式更新
        /// </summary>
        private void upATMode()
        {
            if (Convert.IsDBNull(ATMode) == false)
            {
                switch (ATMode)//考勤模式 0-一天一次上下班模式，1-一天两次上下班模式
                {
                    case WorkTimeType.一天一上下班:

                        if (ATemplate.AT_StartTime != null)
                        {

                            dpStartWork.Value = Convert.ToDateTime(ATemplate.AT_StartTime);
                        }
                        else
                        {
                            DateTime starttime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 9, 0, 0);
                            dpStartWork.Value = starttime;
                            ATemplate.AT_StartTime = starttime;
                        }
                        if (ATemplate.AT_EndTime != null)
                        {

                            dpEndWork.Value = Convert.ToDateTime(ATemplate.AT_EndTime);
                        }
                        else
                        {
                            DateTime endtime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 17, 30, 0);
                            dpEndWork.Value = endtime;
                            ATemplate.AT_EndTime = endtime;
                        }
                        dpStartWork.Visible = true;
                        dpEndWork.Visible = true;
                        lblPMEndWork.Visible = false;
                        lblPMStartWork.Visible = false;
                        dpAMStartWork.Visible = false;
                        dpAMEndWork.Visible = false;
                        dpPMStartWork.Visible = false;
                        dpPMEndWork.Visible = false;
                        lblStartWork.Text = "上班时间";
                        lblEndWork.Text = "下班时间";
                        btnATMode.Text = "切换到一天两次上下班";
                        lblDate1.Top = lblEndWork.Top + lblEndWork.Height;
                        break;
                    case WorkTimeType.一天二上下班:
                        if (ATemplate.AT_AMStartTime != null)
                        {
                            dpAMStartWork.Value = Convert.ToDateTime(ATemplate.AT_AMStartTime);
                        }
                        else
                        {
                            DateTime amstarttime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 9, 0, 0);
                            dpAMStartWork.Value = amstarttime;
                            ATemplate.AT_AMStartTime = amstarttime;
                        }

                        if (ATemplate.AT_AMEndTime != null)
                        {
                            dpAMEndWork.Value = Convert.ToDateTime(ATemplate.AT_AMEndTime);
                        }
                        else
                        {
                            DateTime amendtime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 0, 0);
                            dpAMEndWork.Value = amendtime;
                            ATemplate.AT_AMEndTime = amendtime;
                        }
                        if (ATemplate.AT_PMStartTime != null)
                        {
                            dpPMStartWork.Value = Convert.ToDateTime(ATemplate.AT_PMStartTime);
                        }
                        else
                        {
                            DateTime pmstarttime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 13, 0, 0);
                            dpPMStartWork.Value = pmstarttime;
                            ATemplate.AT_PMStartTime = pmstarttime;
                        }
                        if (ATemplate.AT_PMEndTime != null)
                        {
                            dpPMEndWork.Value = Convert.ToDateTime(ATemplate.AT_PMEndTime);
                        }
                        else
                        {
                            DateTime pmsendtime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 17, 30, 0);
                            dpPMEndWork.Value = pmsendtime;
                            ATemplate.AT_PMEndTime = pmsendtime;
                        }
                        dpStartWork.Visible = false;
                        dpEndWork.Visible = false;
                        lblPMEndWork.Visible = true;
                        lblPMStartWork.Visible = true;
                        dpAMStartWork.Visible = true;
                        dpAMEndWork.Visible = true;
                        dpPMEndWork.Visible = true;
                        dpPMStartWork.Visible = true;
                        lblStartWork.Text = "上午上班";
                        lblEndWork.Text = "上午下班";
                        btnATMode.Text = "切换到一天一次上下班";
                        lblDate1.Top = lblPMEndWork.Top + lblPMEndWork.Height;
                        break;
                }
                btnDate.Top = lblDate1.Top;
                btnATMode.Top = lblDate1.Top + lblDate1.Height;
                lblException.Top = btnATMode.Top + btnATMode.Height + 10;
                btnUser.Top = lblException.Top;
                lblAddress1.Top = lblException.Top + lblException.Height;
                pAddress .Top = lblAddress1.Top;
                btnAddress2.Top = lblAddress1.Top;
                lblAllowableDeviation.Top = lblAddress1.Top + lblAddress1.Height;
                txtADeviation.Top = lblAllowableDeviation.Top;
                btnAllowableDeviation2.Top = lblAllowableDeviation.Top;
                lblADeviation.Top = lblAllowableDeviation.Top + lblAllowableDeviation.Height;
                //btnSave.Top = lblADeviation.Top + lblADeviation.Height  + 10;
                if (string.IsNullOrEmpty(ATNo) == false)
                {
                    btnDelete.Top = btnSave.Top;
                }
            }
        }

        /// <summary>
        /// 更新工作日期
        /// </summary>
        private void upATweeklyWorkingDay()
        {
            AttendanceManager atManager = new AttendanceManager();
            btnDate.Text = atManager.getWeekDesc(ATemplate.AT_WeeklyWorkingDay);
        }
        /// <summary>
        /// 更新考勤地址
        /// </summary>
        private void upATMap()
        {
            try
            {
                if (string.IsNullOrEmpty(ATemplate.AT_Positions) == false)
                {
                    lblAddress.Text = ATemplate.AT_Positions;
                }
                // gps1.GetEditGpsAsyn(new GPSData(ATemplate.AT_Longitude, ATemplate.AT_Latitude, ATemplate.AT_Positions));
            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }
        }

        /// <summary>
        /// 更新考勤模式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnATMode_Click(object sender, EventArgs e)
        {

            MessageBox.Show("切换后，需重新设置考勤时间，你确定么？", MessageBoxButtons.YesNo, (object o, MessageBoxHandlerArgs args) =>
                {
                    try
                    {
                        if (args.Result == Smobiler.Core.Controls.ShowResult.Yes)
                        {
                            switch (ATMode)
                            {
                                case WorkTimeType.一天一上下班:
                                    ATMode = WorkTimeType.一天二上下班;
                                    break;
                                case WorkTimeType.一天二上下班:
                                    ATMode = WorkTimeType.一天一上下班;
                                    break;
                            }
                            ATemplate.AT_CommutingType = ATMode;
                            ATemplate.CustomDates.Clear();
                            upATMode();
                        }
                    }
                    catch (Exception ex)
                    {
                        Toast(ex.Message, ToastLength.SHORT);
                    }
                });

        }
        /// <summary>
        /// 地址
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddress1_Click(object sender, EventArgs e)
        {

            //upATMap();

            frmATGPSEdit frmATGPSEdit = new frmATGPSEdit();
            frmATGPSEdit.Longitude = (float)ATemplate.AT_Longitude;
            frmATGPSEdit.Latitude = (float)ATemplate.AT_Latitude;
            frmATGPSEdit.addressInfo = ATemplate.AT_Positions;
            this.Show(frmATGPSEdit, (MobileForm form, object args) =>
             {
                 if (frmATGPSEdit.ShowResult == ShowResult.Yes)
                 {
                     ATemplate.AT_Longitude = (decimal)frmATGPSEdit.Longitude;
                     ATemplate.AT_Latitude = (decimal)frmATGPSEdit.Latitude;
                     ATemplate.AT_Positions = frmATGPSEdit.addressInfo;
                     lblAddress.Text = ATemplate.AT_Positions;
                 }
             });




        }
        /// <summary>
        /// 手机自带回退按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAttendanceCreate_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                Close();         //关闭当前页面
            }
        }
        /// <summary>
        /// 标题栏图片按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAttendanceCreate_TitleImageClick(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text.Trim().Length <= 0)
                {
                    throw new Exception("请输入考勤名称！");
                }
                if (Convert.IsDBNull(ATMode) == true)
                {
                    throw new Exception("请输入考勤类型！");
                }
                if (string.IsNullOrEmpty(ATemplate.AT_WeeklyWorkingDay) == true)
                {
                    throw new Exception("请输入考勤每周上班时间！");
                }

                if (ATemplate.AT_Latitude <= 0 & ATemplate.AT_Longitude <= 0 & (string.IsNullOrEmpty(ATemplate.AT_Positions) == true || string.IsNullOrWhiteSpace(ATemplate.AT_Positions) == true))
                {
                    throw new Exception("请输入考勤地点！");
                }
                if (txtADeviation.Text.Trim().Length <= 0)
                {
                    throw new Exception("请输入考勤地点允许偏差值！");
                }
                ATemplate.AT_Name = txtName.Text.Trim();
                //允许考勤地址偏差
                ATemplate.AT_AllowableDeviation = Convert.ToInt32(txtADeviation.Text);
                ReturnInfo result;
                if (string.IsNullOrEmpty(ATNo) == false)
                {
                    ATemplate.AT_UpdateUser = Client.Session["U_ID"].ToString();
                    //更新考勤
                    result = AutofacConfig.attendanceService.UpdateAttendanceTemplate(ATemplate);
                }
                else
                {
                    //创建考勤
                    ATemplate.AT_CreateUser = Client.Session["U_ID"].ToString();
                    result = AutofacConfig.attendanceService.AddAttendanceTemplate(ATemplate);
                }
                //如果返回值true表示考勤创建或更新成功，否则失败并抛出错误
                if (result.IsSuccess == true)
                {
                    ShowResult = ShowResult.Yes;
                    Close();
                    Toast("您的考勤已成功提交！", ToastLength.SHORT);

                }
                else
                {
                    throw new Exception(result.ErrorInfo);
                }

            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }
        }

        /// <summary>
        /// 允许偏差
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtADeviation_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtADeviation.Text.Trim().Length > 0)
                {
                    if (Convert.ToInt32(txtADeviation.Text) < 300 || Convert.ToInt32(txtADeviation.Text) > 5000)
                    {
                        txtADeviation.Text = "300";
                    }
                }
                else
                {
                    txtADeviation.Text = "300";
                }
            }
            catch (Exception ex)
            {
                txtADeviation.Text = "300";
            }
        }
        /// <summary>
        /// 跳转到日期
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDate_Click(object sender, EventArgs e)
        {

            AttendanceWorkDate atWorkDate = new AttendanceWorkDate();
            atWorkDate.AT_Type = ATMode;
            switch (ATMode)
            {
                case WorkTimeType.一天一上下班:


                    if (Convert.IsDBNull(ATemplate.AT_StartTime) == false || Convert.IsDBNull(ATemplate.AT_EndTime) == false)
                    {
                        atWorkDate.AT_StartTime = ATemplate.AT_StartTime;

                    }
                    if (Convert.IsDBNull(ATemplate.AT_EndTime) == false)
                    {
                        atWorkDate.AT_EndTime = ATemplate.AT_EndTime;

                    }
                    break;
                case WorkTimeType.一天二上下班:
                    if (Convert.IsDBNull(ATemplate.AT_AMStartTime) == false)
                    {
                        atWorkDate.AT_AMStartTime = ATemplate.AT_AMStartTime;
                    }
                    if (Convert.IsDBNull(ATemplate.AT_AMEndTime) == false)
                    {
                        atWorkDate.AT_AMEndTime = ATemplate.AT_AMEndTime;
                    }
                    if (Convert.IsDBNull(ATemplate.AT_PMStartTime) == false)
                    {
                        atWorkDate.AT_PMStartTime = ATemplate.AT_PMStartTime;
                    }
                    if (Convert.IsDBNull(ATemplate.AT_PMEndTime) == false)
                    {
                        atWorkDate.AT_PMEndTime = ATemplate.AT_PMEndTime;
                    }
                    break;
            }

            frmAttendanceDate frm = new frmAttendanceDate();
            frm.weekdays = ATemplate.AT_WeeklyWorkingDay;
            frm.atWorkDate = atWorkDate;
            frm.listatcdInput = ATemplate.CustomDates;
            if (string.IsNullOrEmpty(ATNo) == false)
            {
                frm.ATNo = ATNo;
            }
            frm.listatcdInput = ATemplate.CustomDates;
            Show(frm, (MobileForm form, object args) =>
            {
                if (frm.ShowResult == ShowResult.Yes)
                {
                    ATemplate.AT_WeeklyWorkingDay = frm.weekdays;
                    upATweeklyWorkingDay();
                    ATemplate.CustomDates = frm.listatcdInput;
                }
            });
        }

        /// <summary>
        /// 上班时间更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dpStartWork_DatePicked(object sender, EventArgs e)
        {
            ATemplate.AT_StartTime = dpStartWork.Value;
        }
        /// <summary>
        /// 下班时间更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dpEndWork_DatePicked(object sender, EventArgs e)
        {
            ATemplate.AT_EndTime = dpEndWork.Value;
        }
        /// <summary>
        /// 上午上班时间更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dpAMStartWork_DatePicked(object sender, EventArgs e)
        {
            ATemplate.AT_AMStartTime = dpAMStartWork.Value;
        }
        /// <summary>
        /// 上午下班时间更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dpAMEndWork_DatePicked(object sender, EventArgs e)
        {
            ATemplate.AT_AMEndTime = dpAMEndWork.Value;
        }
        /// <summary>
        /// 下午上班时间更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dpPMStartWork_DatePicked(object sender, EventArgs e)
        {
            ATemplate.AT_PMStartTime = dpPMStartWork.Value;
        }
        /// <summary>
        /// 下午下班时间更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dpPMEndWork_DatePicked(object sender, EventArgs e)
        {
            ATemplate.AT_PMEndTime = dpPMEndWork.Value;
        }
        /// <summary>
        /// 获取gps
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gps1_GotLocation(object sender, GPSResultArgs e)
        {
            try
            {
                if ((e.isError).Equals(false))
                {
                    if (e.Longitude != 0 & e.Latitude != 0)
                    {

                        ATemplate.AT_Longitude = (decimal)e.Longitude;
                        ATemplate.AT_Latitude = (decimal)e.Latitude;
                        ATemplate.AT_Positions = e.Location;
                        lblAddress.Text = ATemplate.AT_Positions;
                    }
                    else
                    {
                        throw new Exception("定位失败！");
                    }

                }
                else
                {
                    throw new Exception("定位失败！");
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }
        }
        /// <summary>
        /// 跳转到考勤人员选择界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUser_Click(object sender, EventArgs e)
        {
            frmATUser frm = new frmATUser();
            if (string.IsNullOrEmpty(ATNo) == false)
            {
                frm.ATNo = ATNo;
            }
            if (string.IsNullOrEmpty(ATemplate.AT_Users) == false)
            {
                frm.selectUser = ATemplate.AT_Users;
            }

            Show(frm, (MobileForm form, object args) =>
            {
                if (frm.ShowResult == ShowResult.Yes)
                {
                    ATemplate.AT_Users = frm.selectUser;
                    if (string.IsNullOrEmpty(ATemplate.AT_Users) == false)
                    {
                        btnUser.Text = (ATemplate.AT_Users.Split(',').Length).ToString() + "人" + "   > ";
                    }

                }
            });
        }
        /// <summary>
        /// 删除考勤
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("是否确定删除考勤模板？", "删除", MessageBoxButtons.YesNo, (Object s1, MessageBoxHandlerArgs args1) =>
               {
                   if (args1.Result == Smobiler.Core.Controls.ShowResult.Yes)
                   {
                       ReturnInfo r = AutofacConfig.attendanceService.DeleteAttendanceTemplate(ATNo);
                       if (r.IsSuccess == true)
                       {
                           this.ShowResult = Smobiler.Core.Controls.ShowResult.Yes;
                           this.Close();
                           Toast("考勤模板已删除!");
                       }
                       else
                       {
                           throw new Exception(r.ErrorInfo);
                       }
                   }
               });
            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }
        }

    }
}