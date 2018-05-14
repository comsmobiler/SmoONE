using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using System.Data;
using Smobiler.Core.Controls;
using SmoONE.DTOs;

namespace SmoONE.UI.Attendance
{
    // ******************************************************************
    // 文件版本： SmoONE 1.1
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2017/2
    // 主要内容： 用户月份考勤报表统计界面
    // ******************************************************************
    partial class frmAttendanceStatSelf : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        internal string UserID;        //用户ID
        public string Daytime;         //时间
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        /// <summary>
        /// 手机自带返回键，退出页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAttendanceStatSelf_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                Close();
            }
        }
        /// <summary>
        /// 左上角返回键，退出页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAttendanceStatSelf_TitleImageClick(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// 初始化页面加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAttendanceStatSelf_Load(object sender, EventArgs e)
        {
            try
            {
                MonthlyStatisticsDto Stat = AutofacConfig.attendanceService.GetUserMonthlyStatistics(UserID, Convert.ToDateTime(Daytime));
                UserDetails userDetails = new UserDetails();
                UserDetailDto UserInfo = userDetails.getUser(UserID);
                if(UserInfo == null)
                {
                    throw new Exception("用户不存在");
                }
                if (string.IsNullOrEmpty(this.title1.TitleText) == true)
                {
                    this.title1 .TitleText = UserInfo.U_Name + "的考勤报表";
                }
                lblDay.Text = Stat.DS_NormalDayCount.ToString();//正常考勤天数
                this.lblAll.Text = Stat.MS_AllCount.ToString() + "次";//应签到
                this.lblName.Text = UserInfo.U_Name;                //用户名
                this.image1.ResourceID = UserInfo.U_Portrait;         //用户头像
                if (string.IsNullOrEmpty(Daytime) == true)
                {
                    Daytime = DateTime.Now.ToString();
                }
                this.lblYear.Text = Convert.ToDateTime(Daytime).ToString("yyyy年");       //显示年份
                this.btnMonth.Text = Convert.ToDateTime(Daytime).ToString("MM");          //显示月份
                Bind();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 数据绑定
        /// </summary>
        private void Bind()
        {
            try
            {
                DateTime StatDay = Convert.ToDateTime(this.lblYear.Text + this.btnMonth.Text);
                MonthlyStatisticsDto Stat = AutofacConfig.attendanceService.GetUserMonthlyStatistics(UserID, Convert.ToDateTime(Daytime));
                lblDay.Text = Stat.DS_NormalDayCount.ToString() + "天";
                DataTable table = new DataTable();
                table.Columns.Add("AttendType");            //签到类型
                table.Columns.Add("AttendNumber");          //签到次数
                table.Columns.Add("Number");          //签到次数
                table.Rows.Add(StatisticsType.准点, Stat.MS_InTimeCount.ToString() + "次", Stat.MS_InTimeCount);
                table.Rows.Add(StatisticsType.迟到, Stat.MS_ComeLateCount.ToString() + "次", Stat.MS_ComeLateCount);
                table.Rows.Add(StatisticsType.早退, Stat.MS_LeaveEarlyCount.ToString() + "次", Stat.MS_LeaveEarlyCount);
                table.Rows.Add(StatisticsType.未签到, Stat.MS_NoSignInCount.ToString() + "次", Stat.MS_NoSignInCount);
                table.Rows.Add(StatisticsType.未签退, Stat.MS_NoSignOutCount.ToString() + "次", Stat.MS_NoSignOutCount);
                gridATdata.Rows.Clear();   //清空数据
                if (table.Rows.Count > 0)
                {
                    this.gridATdata.DataSource = table;
                    this.gridATdata.DataBind();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        
        /// <summary>
        /// 点击选择月份
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButMonth_Click(object sender, EventArgs e)
        {
            popListMonth.Show();           //显示月份选择列表
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
                if (popListMonth.Selection != null)    //如果选定了月份
                {
                    this.btnMonth.Text = popListMonth.Selection.Text;
                    Bind();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        ///// <summary>
        ///// 点击进入具体查看签到情况
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void gridATdata_CellClick(object sender, GridViewCellEventArgs e)
        //{
        //    try
        //    {
        //        if (Convert.ToInt32(e.Cell.Items["lblNumber"].Value) == 0)
        //        {
        //            e.Cell.Items["lblDetail"].Enabled = false;
        //            e.Cell.Items["lblNumber"].Enabled = false;
        //        }
        //        else
        //        {
        //            frmAttendanceStatSelfDetail newFrm = new frmAttendanceStatSelfDetail();
        //            newFrm.Type = e.Cell.Items["lblID"].Text;           //签到类型
        //            newFrm.Daytime = Daytime;                   //时间
        //            newFrm.UserID = UserID;                     //用户ID
        //            newFrm.TitleText = lblName.Text + e.Cell.Items["lblID"].Text + "记录";
        //            this.Show(newFrm);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Toast(ex.Message);
        //    }
        //}
    }
}