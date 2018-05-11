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
    // 主要内容： 选中日期，该签到人员的签到状况统计
    // ******************************************************************
    partial class frmAttendanceStatMan : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        public string DayTime;
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        /// <summary>
        /// 页面加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAttendanceStatMan_Load(object sender, EventArgs e)
        {
            try
            {
                this.lblDate.Text = DayTime;        //年月日
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
                List<string> Users = AutofacConfig.attendanceService.GetUserNameByDate(Convert.ToDateTime(DayTime));
                DataTable table = new DataTable();
                table.Columns.Add("U_ID");          //用户编号
                table.Columns.Add("Pict");        //用户头像     
                table.Columns.Add("Name");        //用户昵称
                table.Columns.Add("Total");       //用户应签到次数
                table.Columns.Add("Al");          //用户正常签到次数
                table.Columns.Add("ProAl");          //用户正常签到次数
                table.Columns.Add("Late");        //用户迟到次数
                table.Columns.Add("ProLate");        //用户迟到次数
                table.Columns.Add("Early");       //用户早退次数
                table.Columns.Add("ProEarly");       //用户早退次数
                table.Columns.Add("No");          //用户未签次数
                table.Columns.Add("ProNo");          //用户未签次数
                table.Columns.Add("Absenteeism"); //旷工描述
                table.Columns.Add("ISAbsenteeism");//是否旷工               
                foreach (string User in Users)
                {
                    DailyStatisticsDto Stat = AutofacConfig.attendanceService.GetUserDailyStatistics(User, Convert.ToDateTime(DayTime));
                    UserDetailDto UserInfo = AutofacConfig.userService.GetUserByUserID(User);

                    string absenteeism = "";
                    bool isAbsenteeism = false;
                    if (Stat.DS_AllCount > 0 & Stat.DS_AllCount.Equals(Stat.DS_NoSignInCount + Stat.DS_NoSignOutCount))
                    {
                        absenteeism = "全天旷工：是";
                        isAbsenteeism = true;
                    }
                    float proAl=0;
                    float proLate = 0;
                    float proEarly = 0;
                    float proNo = 0;
                    if (Stat.DS_AllCount > 0)
                    {
                        proAl =(float ) Stat.DS_InTimeCount / Stat.DS_AllCount;
                        proLate = (float)Stat.DS_ComeLateCount / Stat.DS_AllCount;
                        proEarly = (float)Stat.DS_LeaveEarlyCount / Stat.DS_AllCount;
                        proNo = (float)(Stat.DS_NoSignInCount + Stat.DS_NoSignOutCount) / Stat.DS_AllCount;
                    }
                    table.Rows.Add(UserInfo.U_ID, UserInfo.U_Portrait, UserInfo.U_Name, UserInfo.U_Name + " 应签到 " + Stat.DS_AllCount + " 次", Stat.DS_InTimeCount + " 次",proAl, Stat.DS_ComeLateCount + " 次",proLate , Stat.DS_LeaveEarlyCount + " 次",proEarly , Stat.DS_NoSignInCount + Stat.DS_NoSignOutCount + " 次",proNo , absenteeism, isAbsenteeism);
                }
                gridATdata.Rows.Clear();//清空某日考勤统计列表数据
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
        /// 手机自带返回键，退出页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAttendanceStatMan_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                Close();         //关闭当前页面
            }
        }
        /// <summary>
        /// 左上角返回键，退出页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAttendanceStatMan_TitleImageClick(object sender, EventArgs e)
        {
            Close();
        }

        private void title1_Load(object sender, EventArgs e)
        {

        }
      
    }
}