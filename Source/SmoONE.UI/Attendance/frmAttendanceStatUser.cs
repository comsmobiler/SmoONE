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
    // 主要内容： 用户考勤日志类型人员统计界面
    // ******************************************************************
    partial class frmAttendanceStatUser : Smobiler.Core.Controls.MobileForm
    {

        #region "definition"
        public  string atType;         //类型
        public string atDate;//考勤月份
        public string atTypeUser;//用户
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        /// <summary>
        /// 初始化页面加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAttendanceStatUser_Load(object sender, EventArgs e)
        {
            lblATMonth.Text = Convert.ToDateTime(atDate).ToString("yyyy年  M月");
            GetATUser();
        }
        /// <summary>
        /// 获取用户
        /// </summary>
        private void GetATUser()
        {
            try
            {
                gridATUserData.Rows.Clear();//清空人员列表数据
                //如果有考勤选中用户，则添加到考勤用户集合listATUser，并默认用户状态为选中
                if (string.IsNullOrEmpty(atType) == false )
                {
                        if (string.IsNullOrEmpty(atTypeUser ) == false)
                        {
                             List<UserDto> listUser = new List<UserDto> ();
                             string[] atTypeUsers = atTypeUser.Split(',');
                             foreach (string user in atTypeUsers)
                            {
                                UserDetails userDetails = new UserDetails();
                                UserDetailDto userDetailDto = userDetails.getUser(user);
                                if (userDetailDto != null)
                                {
                                    UserDto userDto = new UserDto();
                                    userDto.U_ID = userDetailDto.U_ID;
                                    userDto.U_Name = userDetailDto.U_Name;
                                    userDto.U_Portrait = userDetailDto.U_Portrait;
                                    listUser.Add(userDto);
                                }
                            }
                            gridATUserData.DataSource = listUser; //绑定ListView数据
                            gridATUserData.DataBind();
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
      
        
      

        /// <summary>
        /// 手机自带返回键，退出页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAttendanceStatUser_KeyDown(object sender, KeyDownEventArgs e)
        {

            if (e.KeyCode == KeyCode.Back)
            {
                Close();
            }
        }

        /// <summary>
        /// 左上角按钮，退出页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAttendanceStatUser_TitleImageClick(object sender, EventArgs e)
        {
            Close();
        }

      
    }
}