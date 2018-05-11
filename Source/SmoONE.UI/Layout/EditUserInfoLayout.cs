using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SmoONE.UI.UserInfo;
using SmoONE.DTOs;
using SmoONE.CommLib;

namespace SmoONE.UI.Layout
{
    partial class EditUserInfoLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "definition"
        public int eInfo;
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        /// <summary>
        /// 初始化数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditUserInfo_Load(object sender, EventArgs e)
        {

            //string editLbltxt;
            //if (eInfo == (int)EuserInfo.修改登录密码)
            //{
            //    editLbltxt = "修改密码前请填写原密码";
            //}
            //else
            //{
            //    editLbltxt = ((EuserInfo)Enum.ToObject(typeof(EuserInfo), eInfo)).ToString();
            //}
            //lblEditInfo.Text = editLbltxt;
            //switch (eInfo)
            //{
            //    case (int)EuserInfo.修改昵称:
            //        if (((frmUser)(this.Form)).btnName.Text.Trim().Length > 0)
            //        {
            //            txtEditInfo.Text = ((frmUser)(this.Form)).btnName.Text.Trim();

            //        }
            //        else
            //        {
            //            txtEditInfo.Text = "";
            //        }
            //        break;
            //    case (int)EuserInfo.修改邮件:
            //        if (((frmUser)(this.Form)).btnEmail.Text.Trim().Length > 0)
            //        {
            //            txtEditInfo.Text = ((frmUser)(this.Form)).btnEmail.Text.Trim();
            //        }
            //        else
            //        {
            //            txtEditInfo.Text = "";
            //        }
            //        break;
            //    case (int)EuserInfo.修改登录密码:
            //        txtEditInfo.Text = "";
            //        break;

            //}
        }

      
        /// <summary>
        /// 取消操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Press(object sender, EventArgs e)
        {
            ((frmUser)(this.Form)).EditUserInfo.Close();
        }
        /// <summary>
        /// 提交操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Press(object sender, EventArgs e)
        {
            try
            {
            string errinfo;
            if (eInfo == (int)EuserInfo.修改登录密码)
            {
                errinfo = "原密码";
            }
            else
            {
                errinfo = ((EuserInfo)Enum.ToObject(typeof(EuserInfo), eInfo)).ToString();
            }
            if (txtEditInfo.Text.Trim().Length <= 0)
            {
                throw new Exception("请输入" + errinfo);
            }

            if (eInfo == (int)EuserInfo.修改登录密码)
            {
                //判断用户密码是否正确
                string Pwd = txtEditInfo.Text.Trim();
                string encryptPwd = AutofacConfig.userService.Encrypt(Pwd);
                bool result = AutofacConfig.userService.IsPwd(Client.Session["U_ID"].ToString(), encryptPwd);
                if (result == false)
                {
                    txtEditInfo.Text = "";
                    throw new Exception("你输入的原密码不正确，请重新输入！");
                }
                else
                {
                    frmChangePWD frmChangePWD = new frmChangePWD();
                    frmChangePWD.oldPwd = encryptPwd;
                    this.Form.Show(frmChangePWD, (MobileForm form, object args) =>
                    {
                        this.Close();
                    });
                }
            }
            else
            {
                UserInputDto upuser = new UserInputDto();
                upuser.U_ID = Client.Session["U_ID"].ToString();
                switch (eInfo)
                {
                    case (int)EuserInfo.修改昵称:
                        upuser.U_Name = txtEditInfo.Text.Trim();
                        break;
                    case (int)EuserInfo.修改邮件:
                        upuser.U_Email = txtEditInfo.Text.Trim();
                        break;
                }

                ReturnInfo result = AutofacConfig.userService.UpdateUser(upuser);

                if (result.IsSuccess == false)
                {
                    throw new Exception(result.ErrorInfo);
                }
                else
                {
                    this.Close();
                    ((frmUser)(this.Form)).GetUser();
                }
            }
            }
            catch(Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }
        }
    }
}