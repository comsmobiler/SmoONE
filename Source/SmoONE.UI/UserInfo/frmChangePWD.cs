using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SmoONE.CommLib;
using SmoONE.UI;

namespace SmoONE.UI.UserInfo
{
    /// ******************************************************************
    // 文件版本： SmoONE 2.0
    // Copyright  (c)  2017-2018 Smobiler 
    // 创建时间： 2017/07
    // 主要内容：  密码修改界面
    // ******************************************************************
    partial class frmChangePWD : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        public string oldPwd;//修改密码
        bool isPwdC1 = true; //新密码是否显示密码字符变量
        bool isPwdC2 = true;//确认密码是否显示密码字符变量
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        /// <summary>
        /// 新密码是否显示密码字符事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tpPwd1_Press(object sender, EventArgs e)
        {
            if (isPwdC1 == false)
            {
                txtPwd1.SecurityMode = true;//设置textbox为密码字符
                fontPwd1.ResourceID = "eye-slash";
                isPwdC1 = true;
            }
            else
            {
                txtPwd1.SecurityMode = false;//textbox密码字符为空时，显示明文
                fontPwd1.ResourceID = "eye";
                isPwdC1 = false;
            }
        }
        /// <summary>
        /// 确认密码是否显示密码字符事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tpPwd2_Press(object sender, EventArgs e)
        {
            if (isPwdC2 == false)
            {
                txtPwd2.SecurityMode = true;//设置textbox为密码字符
                fontPwd2.ResourceID = "eye-slash";
                isPwdC2 = true;
            }
            else
            {
                txtPwd2.SecurityMode = false;//textbox密码字符为空时，显示明文
                fontPwd2.ResourceID = "eye";
                isPwdC2 = false;
            }
        }
        /// <summary>
        /// 保存修改密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Press(object sender, EventArgs e)
        {
            try
            {
                string pwd1 = txtPwd1.Text.Trim();
                string pwd2 = txtPwd2.Text.Trim();
                if (string.IsNullOrEmpty(oldPwd) == true )
                {
                    throw new Exception("请输入原密码！");
                }
                if (pwd1.Length <= 0)
                {
                    throw new Exception("请输入新密码！");
                }

                if (pwd2.Length <= 0)
                {
                    throw new Exception("请输入确认密码！");
                }
                if (!pwd1.Equals(pwd2))
                {
                    throw new Exception("两次密码输入不一致，请检查！");
                }
                if (pwd1.Length < 6 || pwd1.Length > 12)
                {
                    throw new Exception("新密码必须为6-12位！");
                }
                if (pwd2.Length < 6 || pwd2.Length > 12)
                {
                    throw new Exception("确认密码必须为6-12位！");
                }
               
                if (oldPwd != null)
                {
                    //新密码处理,经过加密
                    string encryptPwd = AutofacConfig.userService.Encrypt(pwd2);
                    if (oldPwd.Equals(encryptPwd))
                    {
                        throw new Exception("您输入新密码和原密码密码一致，请重新输入！");
                    }
                    //更改密码
                    ReturnInfo result = AutofacConfig.userService.ChangePwd(Client.Session["U_ID"].ToString(), oldPwd, encryptPwd);
                    //如果返回true则修改成功，否则弹出错误
                    if (result.IsSuccess == true)
                    {
                        Close();
                        Toast("密码修改成功！", ToastLength.SHORT);
                    }
                    else
                    {
                        throw new Exception(result.ErrorInfo);
                    }
                }

            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }
        }
        /// <summary>
        /// 手机自带回退按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmChangePWD_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                Close();
            }
        }
    }
}