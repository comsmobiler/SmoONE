using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SmoONE.DTOs;

namespace SmoONE.UI.Attendance
{
    // ******************************************************************
    // 文件版本： SmoONE 1.1
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2017/2
    // 主要内容： 考勤报表统计(按月统计)
    // ******************************************************************
    partial class frmAttendanceStatMonth : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        public string Year;               //年份
        public string month; //月份
        private string atType;//考勤类型
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        private string[] atTypeUser= {"","","","","" };//考勤用户
        #endregion
        /// <summary>
        /// 左上角返回键，退出页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAttendanceStatMonth_TitleImageClick(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// 手机自带返回键，退出页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAttendanceStatMonth_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                Close();
            }
        }
        /// <summary>
        /// 点击选择年份
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButYear_Click(object sender, EventArgs e)
        {
            popListYear.Show();
        }
        /// <summary>
        /// 点击选择月份
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButMonth_Click(object sender, EventArgs e)
        {
            popListMonth.Show();
        }
        /// <summary>
        /// 选择年份
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void popListYear_Selected(object sender, EventArgs e)
        {
            try
            {
                if (popListYear.Selection != null)     //如果选择了月份，则显示在页面上
                {
                    this.btnYear.Text = popListYear.Selection.Text;
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 选择月份
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void popListMonth_Selected(object sender, EventArgs e)
        {
            try
            {
                if (popListMonth.Selection != null)          //如果选择了年份，则显示在页面上
                {
                    this.BtnMonth.Text = popListMonth.Selection.Text;
                }
                Bind();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 加载初始页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAttendanceStatMonth_Load(object sender, EventArgs e)
        {
            try
            {
                this.btnYear.Text = Year;                       //年份
                this.BtnMonth.Text = month;                     //月份
                Bind();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }
        /// <summary>
        /// 数据加载
        /// </summary>
        private void Bind()
        {
            try
            {
                //根据年月获取考勤统计数据
                MonthlyResultDto monthlyResultDto = AutofacConfig.attendanceService.GetMonthlyResult(Convert.ToDateTime(Year + "/" + month));
                if (monthlyResultDto != null)
                {
                    if (monthlyResultDto.MR_AllUserCount > 0)
                    {
                        this.btnMSAllCount.Text = monthlyResultDto.MR_AllUserCount.ToString() + "人";            //应签到人数
                        this.progress1.Value = 1;
                        this.btnMSInTimeCount.Text = monthlyResultDto.MR_InTimeUserCount.ToString() + "人";       //正常签到人数
                        this.proMSInTime.Value = (float)monthlyResultDto.MR_InTimeUserCount / monthlyResultDto.MR_AllUserCount;
                        if (string.IsNullOrEmpty(monthlyResultDto.MR_InTimeUser) == false)
                        {
                            atTypeUser[0] = monthlyResultDto.MR_InTimeUser;
                        }
                        this.btnMSCLateCount.Text = monthlyResultDto.MR_ComeLateUserCount.ToString() + "人";      //迟到人数
                        this.proMSCLate.Value = (float)monthlyResultDto.MR_ComeLateUserCount / monthlyResultDto.MR_AllUserCount;
                        if (string.IsNullOrEmpty(monthlyResultDto.MR_ComeLateUser) == false)
                        {
                            atTypeUser[1] = monthlyResultDto.MR_ComeLateUser;
                        }
                        this.btnMSLEarlyCount.Text = monthlyResultDto.MR_LeaveEarlyUserCount.ToString() + "人";     //早退人数
                        this.proMSLEarly.Value = (float)monthlyResultDto.MR_LeaveEarlyUserCount / monthlyResultDto.MR_AllUserCount;
                        if (string.IsNullOrEmpty(monthlyResultDto.MR_LeaveEarlyUser) == false)
                        {
                            atTypeUser[2] = monthlyResultDto.MR_LeaveEarlyUser;
                        }
                        this.btnMSNoSignCount.Text = monthlyResultDto.MR_NoSignUserCount.ToString() + "人";    //未签到人数
                        this.proMSNoSign.Value = (float)monthlyResultDto.MR_NoSignUserCount / monthlyResultDto.MR_AllUserCount;
                        if (string.IsNullOrEmpty(monthlyResultDto.MR_NoSignUser) == false)
                        {
                            atTypeUser[3] = monthlyResultDto.MR_NoSignUser;
                        }
                        this.btnATAbsentCount.Text = monthlyResultDto.MR_AbsentUserCount.ToString() + "人";    //全天旷工人数
                        this.proATAbsent.Value = (float)monthlyResultDto.MR_AbsentUserCount / monthlyResultDto.MR_AllUserCount;
                        if (string.IsNullOrEmpty(monthlyResultDto.MR_AbsentUser) == false)
                        {
                            atTypeUser[4] = monthlyResultDto.MR_AbsentUser;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 跳转到当前月报表考勤用户界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnATTypeSign_Click(object sender, EventArgs e)
        {
            try
            {
                bool isForm = false;//是否跳转界面
                int i=0;
                switch (((Button)sender).Name)
                {
                    //正常
                    case "btnATInTime":
                    case "btnMSInTimeCount":
                        if (proMSInTime.Value > 0)
                        {
                            i = 0;
                            atType = StatisticsType.准点.ToString();
                            isForm = true;
                        }
                        break;
                    //迟到
                    case "btnATLate":
                    case "btnMSCLateCount":
                        if (proMSCLate.Value > 0)
                        {
                            i = 1;
                            atType = StatisticsType.迟到.ToString();
                            isForm = true;
                        }
                        break;
                    //早退
                    case "btnLEarly":
                    case "btnMSLEarlyCount":
                        if (proMSLEarly.Value > 0)
                        {
                            i = 2;
                            atType = StatisticsType.早退.ToString();
                            isForm = true;
                        }
                        break;
                    //未签到
                    case "btnATNoSign":
                    case "btnMSNoSignCount":
                        if (proMSNoSign.Value > 0)
                        {
                            i = 3;
                            atType = StatisticsType.未签到.ToString();
                            isForm = true;
                        }
                        break;
                    //全天旷工
                    case "btnATAbsent":
                    case "btnATAbsentCount":
                        if (proATAbsent.Value > 0)
                        {
                            i = 4;
                            atType = StatisticsType.旷工.ToString();
                            isForm = true;
                        }
                        break;

                }
                if (isForm == true)
                {
                    frmAttendanceStatUser frm = new frmAttendanceStatUser();
                    frm.atDate = Year + "/" + month;
                    if (string.IsNullOrEmpty(atType) == false)
                    {
                        frm.atType = atType;
                    }
                    if (string.IsNullOrEmpty(atTypeUser[i]) == false)
                    {
                        frm.atTypeUser = atTypeUser[i];
                    }
                    Show(frm);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}