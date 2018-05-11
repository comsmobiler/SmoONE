using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;
using SmoONE.DTOs;

namespace SmoONE.UI.Attendance
{
    // ******************************************************************
    // 文件版本： SmoONE 1.1
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2017/2
    // 主要内容： 选择用户的某月应签到天数
    // ******************************************************************
    partial class frmAttendanceStatDay : Smobiler.Core.Controls.MobileForm
    {      
        #region "definition"
        internal string UserID;       //用户ID
        public string DayTime;        //选中的年月日
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类     
        #endregion
        /// <summary>
        /// 左上角关闭页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAttendanceStatDay_TitleImageClick(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 手机自带返回键，退出页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAttendanceStatDay_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)       //点击返回键
            {
                this.Close();
            }
        }
        /// <summary>
        /// 页面赋值，获取数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAttendanceStatDay_Load(object sender, EventArgs e)
        {
            try
            {
                this.btnDate.Text = DayTime + "考勤报表>";         //显示
                UserDetails userDetails = new UserDetails();
                UserDetailDto user = userDetails.getUser(UserID);
                if (user != null)                //如果存在该用户
                {
                   // TitleText = user.U_Name+ "的考勤";      //显示页面标题
                }
                Bind();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 初始化数据
        /// </summary>
        public void Bind()
        {
            try
            {
                List<DateTime> listDate = AutofacConfig.attendanceService.GetDayOfMonthlyStatistics(UserID, Convert.ToDateTime(DayTime));
                DataTable table = new DataTable();
                table.Columns.Add("Day");     //需要签到的日期
                foreach (DateTime Row in listDate)
                {
                    string Time = Row.ToString("yyyy年M月d日    dddd", new System.Globalization.CultureInfo("zh-CN"));
                    table.Rows.Add(Time);
                }
                gridATdata.Rows.Clear();
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
        /// 点击进入查看考勤报表页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButDate_Click(object sender, EventArgs e)
        {
            try
            {
                frmAttendanceStatSelf frmStat = new frmAttendanceStatSelf();
               // frmStat.TitleText = TitleText;             //标题
                frmStat.UserID = UserID;                   //用户ID
                frmStat.Daytime = DayTime;                 //选择查看的日期
                this.Show(frmStat);
            }
            catch(Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}