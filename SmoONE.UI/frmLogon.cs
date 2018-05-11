using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SmoONE.CommLib;
using SmoONE.Domain;
using SmoONE.UI.UserInfo;
using SmoONE.DTOs;

namespace SmoONE.UI
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler 
    // 创建时间： 2016/11
    // 主要内容：  登录界面
    // ******************************************************************
    partial class frmLogon : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogon_Click(object sender, EventArgs e)
        {
            try
            {
                
                string userID = txtTel.Text.Trim();
                string pwd = txtPwd.Text.Trim();
                if (userID.Length <= 0)
                {
                    throw new Exception("请输入手机号码！");
                }
                if (pwd.Length <= 0)
                {
                    throw new Exception("请输入密码！");
                }
                if (pwd.Length < 6 || pwd.Length > 12)
                {
                    throw new Exception("密码必须为6-12位！");
                }
                LoadClientData(MobileServer.ServerID + "user", userID);
                if (chkRememberPwd.Checked == true)
                {
                    //记住密码
                    LoadClientData(MobileServer.ServerID + "pwd", pwd);
                }
                else
                {
                    //删除客户端数据
                    RemoveClientData(MobileServer.ServerID + "pwd", (object s, ClientDataResultHandlerArgs args) => txtPwd.Text = "");
                }
                //密码处理,经过加密
                string encryptPwd = AutofacConfig.userService.Encrypt(DateTime.Now.ToString("yyyyMMddHHmmss") + pwd);
                ReturnInfo result = AutofacConfig.userService.Login(userID, encryptPwd);

                if (result.IsSuccess == true)
                {
                    List<Role> role = AutofacConfig.userService.GetRoleByUserID(userID);
                    Client.Session["U_ID"] = userID;
                    Client.Session["Roler"] = role;
                    SmoONE.UI.Work.frmWork frmWork = new SmoONE.UI.Work.frmWork();
                    Show (frmWork);
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
        /// 退出客户端
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLogon_KeyDown(object sender, KeyDownEventArgs e)
        {
            Client.Exit();
        }

        /// <summary>
        /// 跳转到注册界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegisterTel frmRegister = new frmRegisterTel();
            Show (frmRegister);
        }
        /// <summary>
        /// 验证登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVerify_Click(object sender, EventArgs e)
        {
            try
            {
                string userID = txtTel.Text.Trim();
                if (userID.Length <= 0)
                {
                    throw new Exception("请输入手机号码！");
                }

                frmVerificationCode frmVerificationCode = new frmVerificationCode();
                frmVerificationCode.isVerifyLogon = true;
                frmVerificationCode.Tel = userID;
                Show(frmVerificationCode);
            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }
        }
        /// <summary>
        /// 数据加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLogon_Load(object sender, EventArgs e)
        {
            Smobiler.Core.Controls.RongIM.IM im = new Smobiler.Core.Controls.RongIM.IM();
            this.Components.Add(im);
            im.Logout();
            ReadClientData(MobileServer.ServerID + "user", (object s, ClientDataResultHandlerArgs args) =>
            {
                try
                {
                    if (string.IsNullOrEmpty(args.error))
                    {
                        txtTel.Text = args.Value;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            });
            ReadClientData(MobileServer.ServerID + "pwd", (object s, ClientDataResultHandlerArgs args) =>
            {
                if (string.IsNullOrEmpty(args.error))
                {
                    txtPwd.Text = args.Value;
                    if (txtPwd.Text.Length > 0)
                    {
                        chkRememberPwd.Checked = true;
                    }
                }
            });


        }

        /// <summary>
        /// 手势验证
        /// </summary>
        private void ScreenGestures()
        {
            this.Client.Pattern.Password = null;
            string userID = txtTel.Text.Trim();
            if (userID.Length <=0) Toast("请输入手机号！", ToastLength.SHORT);
            UserDetailDto user = AutofacConfig.userService.GetUserByUserID(userID);
            if (user != null  )
            {
                if (string.IsNullOrEmpty(user.U_Gestures) == false)
                { 
                this.Client.Pattern.Password = user.U_Gestures;
                }
            }
            else
            {
                Toast("用户" + userID + "不存在！", ToastLength.SHORT);
            }

            if (string.IsNullOrEmpty(this.Client.Pattern.Password) == false)
            {
                this.Client.Pattern.VerifyLocal((object s, Smobiler.Core.RPC.PatternLocalVerifiedEventArgs eee) =>
                {
                    if (eee.isError == false)
                    {
                        //使用模拟验证码登录
                        ReturnInfo result = AutofacConfig.userService.GesturesLogin(userID, Client.Pattern.Password);
                        if (result.IsSuccess == true)
                        {
                            List<Role> role = AutofacConfig.userService.GetRoleByUserID(userID);
                            Client.Session["U_ID"] = userID;
                            Client.Session["Roler"] = role;
                            //跳转到菜单界面
                            SmoONE.UI.Work.frmWork frmWork = new SmoONE.UI.Work.frmWork();
                            Show(frmWork);
                        }
                        else
                        {
                            Toast(result.ErrorInfo, ToastLength.SHORT);
                        }
                    }
                });
            }

            else
            {
                Toast("您没有手势，请先用密码登录！",ToastLength.SHORT);
            }

        }
        /// <summary>
        /// 手势登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Press(object sender, EventArgs e)
        {
            ScreenGestures();
        }

    }
}