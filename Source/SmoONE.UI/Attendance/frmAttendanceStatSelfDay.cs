using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;

namespace SmoONE.UI.Attendance
{
    // ******************************************************************
    // 文件版本： SmoONE 1.1
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2017/2
    // 主要内容： 个人考勤按月统计页面
    // ******************************************************************
    partial class frmAttendanceStatSelfDay : Smobiler.Core.Controls.MobileForm
    {

        #region "definition"
        internal string UserID;         //用户ID
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        /// <summary>
        /// 左上角按钮，退出页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAttendanceStatSelfDay_TitleImageClick(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// 手机自带返回键，退出页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAttendanceStatSelfDay_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                Close();
            }
        }
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAttendanceStatSelfDay_Load(object sender, EventArgs e)
        {
            try
            {
                UserID = Client.Session["U_ID"].ToString();                //用户ID
                this.btnYear.Text = DateTime.Now.Year.ToString() + "年▼";          //年份显示
                this.btnMonth.Text = DateTime.Now.Month.ToString() + "月▼";        //月份显示
                PopListGroup popYearG = new PopListGroup();
                popYearG.Title = "请选择年份";
                popListYear.Groups.Add(popYearG);
                for (int i = DateTime.Now.Year; DateTime.Now.Year - i <10; i--)        //添加年份选择范围
                {
                    PopListItem YearItem = new PopListItem();
                    YearItem.Text = i.ToString();
                    popYearG.Items.Add(YearItem);
                    if (i == DateTime.Now.Year)
                    {
                        popListYear.SetSelections(YearItem);
                    }
                }
                popListMonth.SetSelections(popListMonth.Groups[0].Items[(DateTime.Now.Month - 1)]);
                Bind();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 绑定数据
        /// </summary>
        private void Bind()
        {
            try
            {
                DataTable table = new DataTable();
                string[] Year = this.btnYear.Text.Split('▼');           //年份显示
                string[] Month = this.btnMonth.Text.Split('▼');         //月份显示
                List<DateTime> listDate = AutofacConfig.attendanceService.GetDayOfMonthlyStatistics(UserID, Convert.ToDateTime(Year[0] + Month[0]));
                table.Columns.Add("Day");      //本月需要考勤的日期
                foreach (DateTime Row in listDate)
                {
                    string Time = Row.ToString("yyyy年M月d日    dddd", new System.Globalization.CultureInfo("zh-CN"));
                    table.Rows.Add(Time);
                }
                gridATdata.Rows.Clear();         //清空数据
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
        /// 进行年份选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButYear_Click(object sender, EventArgs e)
        {
            popListYear.Show();    //显示年份选择列表
        }
        /// <summary>
        /// 进行月份选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButMonth_Click(object sender, EventArgs e)
        {
            popListMonth.Show();     //显示月份选择列表
        }
        /// <summary>
        /// 进入查看考勤报表页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButCheck_Click(object sender, EventArgs e)
        {
            try
            {
                frmAttendanceStatSelf newFrm = new frmAttendanceStatSelf();
                string[] Year = this.btnYear.Text.Split('▼');
                string[] Month = this.btnMonth.Text.Split('▼');
                newFrm.UserID = UserID;          //用户ID传递到下个页面
                newFrm.Daytime = Year[0] + Month[0];       //将年月传递到下个页面
                this.Show(newFrm);
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /////// <summary>
        /////// 进入查看考勤详情页面
        /////// </summary>
        /////// <param name="sender"></param>
        /////// <param name="e"></param>
        ////private void gridATdata_CellClick(object sender, GridViewCellEventArgs e)
        ////{
        ////    try
        ////    {
        ////        frmAttendanceMain frmMain = new frmAttendanceMain();
        ////        frmMain.DayTime = e.Cell.Items["lblDay"].Text;         //将选中时间传递到下个页面
        ////        frmMain.enter = (int)Enum.Parse(typeof(ATMainState), ATMainState.统计查看.ToString());
        ////        frmMain.UserID = UserID;
        ////        this.Show(frmMain);
        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        Toast(ex.Message);
        ////    }
        ////}
        /// <summary>
        ///  选择年份
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void popListYear_Selected(object sender, EventArgs e)
        {
            try
            {
                if (popListYear.Selection != null)         //如果选择了年份，更新页面数据
                {
                    this.btnYear.Text = popListYear.Selection.Text + "年▼";
                    Bind();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        ///  选择月份
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void popListMonth_Selected(object sender, EventArgs e)
        {
            try
            {
                if (popListMonth.Selection != null)     //如果选择了月份，更新页面数据
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
    }
}