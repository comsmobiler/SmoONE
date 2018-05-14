using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SmoONE.UI.Work;
using SmoONE.Domain;
using SmoONE.CommLib;

namespace SmoONE.UI.UserInfo
{
    /// ******************************************************************
    // 文件版本： SmoONE 2.0
    // Copyright  (c)  2017-2018 Smobiler 
    // 创建时间： 2017/07
    // 主要内容：  设置登录信息界面
    // ******************************************************************
    partial class frmRegister : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        public string Tel;//电话号码
        public string VCode;//验证码
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
        /// 初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRegister_Load(object sender, EventArgs e)
        {
            GetRole();
        }
        /// <summary>
        /// 获取所有角色
        /// </summary>
        private void GetRole()
        {
            List<Role> listRole = AutofacConfig.userService.GetAllRoles();
            if (listRole.Count > 0)
            {
                foreach (Role role in listRole)
                {
                    RadioButton rb = new RadioButton();
                    rb.Value = role.R_RoleID;
                    rb.Text = role.R_Name;
                    radioGroup1.Buttons.Add(rb);
                }
                radioGroup1.Buttons[0].Checked = true;
            }
        }
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Press(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text.Trim().Length <= 0)
                {
                    throw new Exception("请输入昵称！");

                }
                if (VCode == null)
                {
                    throw new Exception("请输入手机验证码！");

                }
                string pwd1 = txtPwd1.Text.Trim();
                string pwd2 = txtPwd2.Text.Trim();
                if (pwd1.Length <= 0)
                {
                    throw new Exception("请输入新密码！");
                }
                if (pwd1.Length < 6 || pwd1.Length > 12)
                {
                    throw new Exception("新密码必须为6-12位！");
                }

                if (pwd2.Length <= 0)
                {
                    throw new Exception("请输入确认密码！");
                }
                if (pwd2.Length < 6 || pwd2.Length > 12)
                {
                    throw new Exception("新密码必须为6-12位！");
                }
                if (!pwd1.Equals(pwd2))
                {
                    throw new Exception("两次密码输入不一致，请检查！");
                }

                RadioButton selectRole = radioGroup1.CheckedButton;
                List<string> listrole = new List<string>();
                listrole.Add(selectRole.Value);

                //密码处理,经过加密
                string encryptPwd = AutofacConfig.userService.Encrypt(pwd2);
                ReturnInfo result = AutofacConfig.userService.RegisterByVCode(Tel, encryptPwd, txtName.Text.Trim(), listrole, VCode);
                //如果返回true则注册成功，否则弹出错误
                if (result.IsSuccess == false )
                {
                    throw new Exception(result.ErrorInfo);
                }
                else
                {
                    List<Role> role = AutofacConfig.userService.GetRoleByUserID(Tel);
                    Client.Session["U_ID"] = Tel;
                    Client.Session["Roler"] = role;
                    Close();//关闭当前界面
                    frmWork frmWork = new frmWork();//跳转到工作界面
                    Show(frmWork);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }
        }
    }
}