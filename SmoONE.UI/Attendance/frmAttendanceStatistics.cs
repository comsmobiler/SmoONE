using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SmoONE.DTOs;

namespace SmoONE.UI.Attendance
{
    // ******************************************************************
    // 文件版本： SmoONE 1.1
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2017/2
    // 主要内容： 考勤统计查看界面
    // ******************************************************************
    partial class frmAttendanceStatistics : Smobiler.Core.Controls.MobileForm
    {       
        #region "definition"
        public  int btnMode;             //选择显示模板
        internal string UserID;          //用户ID
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        /// <summary>
        /// 手机自带回退按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAttendanceStatistics_KeyDown(object sender, KeyDownEventArgs e)
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
        private void frmAttendanceStatistics_TitleImageClick(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// 绑定数据
        /// </summary>
        private void Bind()
        {
            try
            {
                string[] Year = this.btnYear.Text.Split('▼');           //年份
                string[] Month = this.btnMonth.Text.Split('▼');         //月份             
                DataTable table = new DataTable();
                switch (btnMode)
                {
                    case 1:
                        //  this.gridATdata.TemplateControlName = "frmAttendanceStatisticsLayout";
                        gridATdata.Rows.Clear();    //清除考勤统计列表数据
                        //获取某月考勤用户数据
                        List<string> Users = AutofacConfig.attendanceService.GetUserNameByPeriod(Convert.ToDateTime(Year[0] + Month[0]).AddDays(-DateTime.Now.Day + 1), Convert.ToDateTime(Year[0] + Month[0]).AddDays(1 - DateTime.Now.Day).AddMonths(1));
                    if (Users.Count > 0)
                    {
                        table.Columns.Add("ID");                //用户ID
                        table.Columns.Add("Pict");              //用户头像
                        table.Columns.Add("Name");              //用户名称
                        table.Columns.Add("Total");             //应签到次数
                        table.Columns.Add("Al");                //准时签到次数
                        table.Columns.Add("Late");              //迟到次数
                        table.Columns.Add("Early");             //早退次数
                        table.Columns.Add("No");                //未签次数
                        foreach (string Row in Users)
                        {
                            MonthlyStatisticsDto Stat = AutofacConfig.attendanceService.GetUserMonthlyStatistics(Row, Convert.ToDateTime(Year[0] + Month[0]));
                            UserDetails UserDetail = new UserDetails();
                            UserDetailDto User = UserDetail.getUser(Row);
                                if (User != null)
                                {
                                    table.Rows.Add(User.U_ID, User.U_Portrait, User.U_Name, Stat.MS_AllCount, Stat.MS_InTimeCount, Stat.MS_ComeLateCount, Stat.MS_LeaveEarlyCount, Stat.MS_NoSignInCount + Stat.MS_NoSignOutCount);
                                }

                            }
                       
                        this.gridATdata.DataSource = table;
                        this.gridATdata.DataBind();
                    }
                      
                    break;
                    case 2:

                        //  this.gridATdata.TemplateControlName = "frmAttendanceStatDayLayout";
                        gridATdata1.Rows.Clear();    //清除考勤统计列表数据
                        //获取某月考勤日期
                        List<DateTime> listDate = AutofacConfig.attendanceService.GetDayOfMonthlyStatistics(UserID, Convert.ToDateTime(Year[0] + Month[0]));
                        if (listDate.Count > 0)
                        {
                            table.Columns.Add("Day");         //需要签到的日期
                            foreach (DateTime Row in listDate)
                            {
                                string Time = Row.ToString("yyyy年M月d日    dddd", new System.Globalization.CultureInfo("zh-CN"));
                                table.Rows.Add(Time);
                            }
                           
                            this.gridATdata1.DataSource = table;
                            this.gridATdata1.DataBind();
                            
                        }
                        break;
                }
                
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 页面加载，初始化数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAttendanceStatistics_Load(object sender, EventArgs e)
        {
            try
            {
                UserID = Client.Session["U_ID"].ToString();
                this.btnYear.Text = DateTime.Now.Year.ToString() + "年▼";              //年份
                this.btnMonth.Text = DateTime.Now.Month.ToString() + "月▼";            //月份
                PopListGroup poli = new PopListGroup();
                popListYear.Groups.Add(poli);
                popListYear.Title = "请选择年份";
                for (int i = DateTime.Now.Year; DateTime.Now.Year - i < 10; i--)        //添加年份选择范围
                {
                    poli.Items.Add(new PopListItem(i.ToString(), i.ToString()));

                }
                btnMode = 1;
                tabPageView1.Controls.Add(gridATdata);
                tabPageView1.Controls.Add(gridATdata1);
                Bind();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
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
                if (popListYear.Selection != null)       //如果选择了年份
                {
                    this.btnYear.Text = popListYear.Selection.Text + "年▼";
                    Bind();         //重新加载数据
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
                if (popListMonth.Selection != null)     //如果选择了月份
                {
                    this.btnMonth.Text = popListMonth.Selection.Text + "月▼";
                    Bind();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 点击进行年份选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButYear_Click(object sender, EventArgs e)
        {
            popListYear.Show();              //显示年份选择列表
        }
        /// <summary>
        /// 点击进行月份选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButMonth_Click(object sender, EventArgs e)
        {
            popListMonth.Show();           //显示月份选择列表
        }
        /// <summary>
        /// 查看选择月份的签到统计
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButCheck_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnMode == 2)
                {
                    frmAttendanceStatMonth frmMonth = new frmAttendanceStatMonth();
                    string[] Year = this.btnYear.Text.Split('年');
                    frmMonth.Year = Year[0];                 //年份
                    string[] Month = this.btnMonth.Text.Split('月');
                    frmMonth.month = Month[0];          //月份
                    this.Show(frmMonth);
                }
            }
            catch(Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 模式选择，用来控制GradView显示模板和数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textTabBar1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.btnYear.Text = DateTime.Now.Year.ToString() + "年▼";          //年份
                this.btnMonth.Text = DateTime.Now.Month.ToString() + "月▼";        //月份
              // popListYear.ClearSelections();
               // popListYear.SetSelections(popListYear.Groups[0].Items[0]);
                //popListMonth.ClearSelections();
                //popListMonth.SetSelections(popListMonth.Groups[0].Items[(DateTime.Now.Month - 1)]);
                switch (textTabBar1.SelectedIndex)
                {
                    case 0:
                        tabPageView1.PageIndex = 0;
                        btnMode = 1;
                        this.btnCheck.Text = "";
                       // btnCheck.Enabled = false;
                        break;
                    case  1:
                        tabPageView1.PageIndex = 1;
                        btnMode = 2;
                        this.btnCheck.Text = ">";
                       // btnCheck.Enabled = true;
                        break;
                }
                Bind();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void tabPageView1_PageIndexChanged(object sender, EventArgs e)
        {
            switch (tabPageView1 .PageIndex)
            {
                case 0:
                    textTabBar1.SelectedIndex = 0;
                    break;
                case 1:
                    textTabBar1.SelectedIndex = 1;

                    break;
            }
        }
    }
}