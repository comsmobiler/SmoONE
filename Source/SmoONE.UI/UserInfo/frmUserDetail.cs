using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SmoONE.DTOs;
using SmoONE.UI;

namespace SmoONE.UI.UserInfo
{
    // ******************************************************************
    // 文件版本： SmoONE 2.0
    // Copyright  (c)  2017-2018 Smobiler 
    // 创建时间： 2017/07
    // 主要内容：  用户详情界面
    // ******************************************************************
    partial class frmUserDetail : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        internal string U_ID;//用户编号
        private Sex sex;//性别
        private string email = "";//邮件
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        /// <summary>
        /// 手机自带回退按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmUserDetail_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                Close();
            }
        }
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmUserDetail_Load(object sender, EventArgs e)
        {
            GetUser();
        }
        /// <summary>
        /// 获取用户信息
        /// </summary>
        private void GetUser()
        {
            try
            {
                if (string.IsNullOrEmpty(U_ID) == true)
                {
                    throw new Exception("请输入电话号码！");
                }
                UserDetails userDetails = new UserDetails();
                UserDetailDto user = userDetails.getUser(U_ID);
                if (user != null)
                {
                    imgPortrait.ResourceID = user.U_Portrait;
                    string name = user.U_Name;
                    sex = (Sex)user.U_Sex;
                    switch (sex)
                    {
                        case Sex.男:
                            lblName.Text = name + "  男";
                            break;
                        case Sex.女:
                            lblName.Text = name + "  女";
                            break;

                    }
                    lblTelShow .Text = U_ID;
                    lblBirShow.Text = user.U_Birthday.ToString("yyyy/MM/dd");
                    email = user.U_Email;
                    lblEmailShow .Text = user.U_Email;
                    phoneButton1.PhoneNumber = U_ID;
                }
                else
                {
                    throw new Exception("用户" + U_ID + "不存在，请检查！");
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 打电话
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tpTel_Press(object sender, EventArgs e)
        {
            Client.TelCall(U_ID);
        }
        /// <summary>
        /// 发短信
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tpMes_Press(object sender, EventArgs e)
        {
            Client.SendSMS("", U_ID);
        }
        /// <summary>
        /// 发邮件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tpEmail_Press(object sender, EventArgs e)
        {
            Client.SendEmail("", "", email);
        }
        /// <summary>
        /// 打电话
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void phoneButton1_Press(object sender, EventArgs e)
        {
           
        }
    }
}