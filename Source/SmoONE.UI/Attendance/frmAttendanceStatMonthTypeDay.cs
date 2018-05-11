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
    // 主要内容： 考勤报表统计(按月统计)
    // ******************************************************************
    partial class frmAttendanceStatMonthTypeDay : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        public string UserID;//用户
        public string atType;         //类型
        public string Daytime;         //时间
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
      

        /// <summary>
        /// 根据用户、考勤类型和月份获取日期
        /// </summary>
        private void Bind()
        {
            try
            {
                lblATMonth.Text = Convert.ToDateTime(Daytime).ToString("yyyy年  M月");
                List<DateTime> listDate = new List<DateTime>();
                if (string.IsNullOrEmpty(UserID) == false & string.IsNullOrEmpty(Daytime) == false & string.IsNullOrEmpty(atType) == false)
                {
                    listDate = AutofacConfig.attendanceService.GetDayOfType(UserID, Convert.ToDateTime(Daytime), (StatisticsType)Enum.Parse(typeof(StatisticsType), atType));
                 switch ((StatisticsType)Enum.Parse(typeof(StatisticsType), atType))
                    {
                        case StatisticsType.旷工:
                            gridATTypeDaydata.TemplateControlName = "frmATStatSelfDetailDayLayout";
                            break;
                        case StatisticsType.准点:
                        case StatisticsType.迟到:
                        case StatisticsType.早退:
                        case StatisticsType.未签到:
                        case StatisticsType.未签退:
                            gridATTypeDaydata.TemplateControlName = "frmAttendanceStatDayLayout";
                            break;
                    }
                }
                gridATTypeDaydata.Rows.Clear();//清空数据
                if (listDate.Count > 0)
                {
                    DataTable table = new DataTable();
                    switch ((StatisticsType)Enum.Parse(typeof(StatisticsType), atType))
                    {
                        case StatisticsType.旷工:
                            table.Columns.Add("AL_Date");         //签到日期
                            table.Columns.Add("AL_DateDesc");         //签到日期描述
                            foreach (DateTime Row in listDate)
                            {
                                string atSignTime = Row.ToString("yyyy年M月d日    dddd", new System.Globalization.CultureInfo("zh-CN"));
                                table.Rows.Add(Row,atSignTime);
                            }
                            break;
                        case StatisticsType.准点:
                        case StatisticsType.迟到:
                        case StatisticsType.早退:
                        case StatisticsType.未签到:
                        case StatisticsType.未签退:
                           table.Columns.Add("Day");         //签到日期
                            foreach (DateTime Row in listDate)
                            {
                                string atSignTime = Row.ToString("yyyy年M月d日    dddd", new System.Globalization.CultureInfo("zh-CN"));
                                table.Rows.Add(atSignTime);
                            }
                            break;
                    }
                    
                    if (table.Rows.Count > 0)
                    {
                        this.gridATTypeDaydata.DataSource = table;
                        this.gridATTypeDaydata.DataBind();
                    }
                }
            }
            catch(Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 初始化页面加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAttendanceStatMonthTypeDay_Load(object sender, EventArgs e)
        {
            Bind();
        }
        /// <summary>
        /// 手机自带回退按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAttendanceStatMonthTypeDay_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                Close();
            }
        }
        /// <summary>
        /// 标题栏图片按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAttendanceStatMonthTypeDay_TitleImageClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}