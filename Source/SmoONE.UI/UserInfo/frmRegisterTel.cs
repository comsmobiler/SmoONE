using System;
using Smobiler.Core.Controls;
using SmoONE.UI.UserInfo;

namespace SmoONE.UI.UserInfo
{
    // ******************************************************************
    // 文件版本： SmoONE 2.0
    // Copyright  (c)  2017-2018 Smobiler 
    // 创建时间： 2017/07
    // 主要内容：  注册界面
    // ******************************************************************
    partial class frmRegisterTel : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        /// <summary>
        /// 手机自带回退按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRegisterTel_KeyDown(object sender, KeyDownEventArgs e)
        {
            if(e.KeyCode==KeyCode.Back)
            {
                Close();
            }
        }
        /// <summary>
        /// 下一步
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Press(object sender, EventArgs e)
        {
            try
            {
                if (txtTel.Text.Trim().Length <= 0)
                {
                    throw new Exception("请输入电话号码！");

                }
                else
                {
                    System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"^1(3[0-9]|4[57]|5[0-35-9]|7[0135678]|8[0-9])\d{8}$");
                    if (regex.IsMatch(txtTel.Text.Trim()) == false)
                    {
                        throw new Exception("手机号码格式不正确！");
                    }
                }
                //验证电话号码是否已经注册，当返回值为true时，表示已注册
                bool isRegister = AutofacConfig.userService.IsExists(txtTel.Text.Trim());
                if (isRegister == true)
                {
                    throw new Exception("电话号码" + txtTel.Text.Trim() + "已注册！");
                }
                //判断设备是否恶意注册，当返回值为true时，表示已恶意注册
                bool isMalicious = AutofacConfig.userService.IsMalicious(Client.DeviceID);
                if (isMalicious == true)
                {
                    throw new Exception("不能恶意注册！");
                }
                frmVerificationCode frmVerificationCode = new frmVerificationCode();
                frmVerificationCode.Tel = txtTel.Text.Trim();
               // frmVerificationCode.isVerifyLogon = true;
                Show(frmVerificationCode);
            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }
        }
    }
}