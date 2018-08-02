using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;
using SmoONE.DTOs;
using SmoONE.UI;
using SmoONE.CommLib;
using SmoONE.UI.Layout;

namespace SmoONE.UI.UserInfo
{
    // ******************************************************************
    // 文件版本： SmoONE 2.0
    // Copyright  (c)  2017-2018 Smobiler 
    // 创建时间： 2017/07
    // 主要内容：  当前用户详情界面
    // ******************************************************************
    partial class frmUser : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        internal string toolbarItemName = "";
        private int eInfo;
        private Sex sex;//性别
        private DateTime toasttime;//toast时间
        public EditUserInfoLayout EditUserInfo = new EditUserInfoLayout();   //信息编辑弹出框
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        /// <summary>
        /// 上传头像
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUp_Press(object sender, EventArgs e)
        {
            cameraPortrait.GetPhoto();
        }
        /// <summary>
        /// 修改昵称
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnName_Press(object sender, EventArgs e)
        {
            eInfo = (int)EuserInfo.修改昵称;
            ShowlayoutDialog();
        }
        /// <summary>
        /// 选择性别
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSex_Press(object sender, EventArgs e)
        {
            popSex.Groups.Clear();
            PopListGroup poli = new PopListGroup();
            popSex.Groups.Add(poli);
            poli.Title = "性别选择";
            UserSex UserSex = new UserSex();
            DataTable table = UserSex.GetSex();
            foreach (DataRow row in table.Rows)
            {
                poli.Items.Add(new PopListItem(row["SexName"].ToString(), row["SexID"].ToString()));
                if (((int)sex).Equals(row["SexID"]))
                {
                    popSex.SetSelections(poli.Items[(poli.Items.Count - 1)]);
                }
            }
            popSex.ShowDialog();
        }
        /// <summary>
        /// 修改出生日期
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dpkBirthday_DateChanged(object sender, EventArgs e)
        {
            UserDetailDto user = AutofacConfig.userService.GetUserByUserID(Client.Session["U_ID"].ToString());
            if (user != null)
            {
                UserInputDto upuser = new UserInputDto();
                upuser.U_ID = Client.Session["U_ID"].ToString();
                upuser.U_Birthday = dpkBirthday.Value;
                ReturnInfo result = AutofacConfig.userService.UpdateUser(upuser);
                //返回结果如果为false，则修改失败
                if (result.IsSuccess == false)
                {
                    dpkBirthday.Value = (DateTime)upuser.U_Birthday;
                    Toast(result.ErrorInfo, ToastLength.SHORT);
                }
            }
        }
        /// <summary>
        /// 修改Email
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEmail_Press(object sender, EventArgs e)
        {
            eInfo = (int)EuserInfo.修改邮件;
            ShowlayoutDialog();
        }
        /// <summary>
        /// 修改登录密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPwd_Press(object sender, EventArgs e)
        {
            eInfo = (int)EuserInfo.修改登录密码;
            ShowlayoutDialog();
        }
        /// <summary>
        /// 显示layoutDialog
        /// </summary>
        private void ShowlayoutDialog()
        {
            EditUserInfo.eInfo = eInfo;

            string editLbltxt;
            if (eInfo == (int)EuserInfo.修改登录密码)
            {
                editLbltxt = "修改密码前请填写原密码";
            }
            else
            {
                editLbltxt = ((EuserInfo)Enum.ToObject(typeof(EuserInfo), eInfo)).ToString();
            }
            EditUserInfo. lblEditInfo.Text = editLbltxt;
            switch (eInfo)
            {
                case (int)EuserInfo.修改昵称:
                    if (((frmUser)(this.Form)).btnName.Text.Trim().Length > 0)
                    {
                        EditUserInfo. txtEditInfo.Text = btnName.Text.Trim();

                    }
                    else
                    {
                        EditUserInfo. txtEditInfo.Text = "";
                    }
                    break;
                case (int)EuserInfo.修改邮件:
                    if (((frmUser)(this.Form)).btnEmail.Text.Trim().Length > 0)
                    {
                        EditUserInfo. txtEditInfo.Text = btnEmail.Text.Trim();
                    }
                    else
                    {
                        EditUserInfo. txtEditInfo.Text = "";
                    }
                    break;
                case (int)EuserInfo.修改登录密码:
                    EditUserInfo. txtEditInfo.Text = "";
                    break;

            }
            ShowDialog(EditUserInfo);
        }
        /// <summary>
        /// 退出登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Press(object sender, EventArgs e)
        {
            MessageBox.Show("是否退出当前系统？", MessageBoxButtons.YesNo, (object o, MessageBoxHandlerArgs args) =>
            {
                try
                {
                    if (args.Result == ShowResult.Yes)
                    {
                        this.Close();
                        //frmLogon frmLogon = new frmLogon();
                        //Show(frmLogon);
                        ////退出客户端
                        //this.Client.Exit();
                    }
                }
                catch (Exception ex)
                {
                    Toast(ex.Message, ToastLength.SHORT);
                }
            });
        }
        /// <summary>
        /// 手机自带回退按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmUser_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                Close();
            }
        }
        /// <summary>
        /// 初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmUser_Load(object sender, EventArgs e)
        {
            GetUser();
        }
        /// <summary>
        /// 获取用户信息
        /// </summary>
        public void GetUser()
        {
            try
            {
                UserDetails userDetails = new UserDetails();
                UserDetailDto user = userDetails.getUser(Client.Session["U_ID"].ToString());       

                if (user != null)
                {
                   // imgPortrait.ResourceID = user.U_Portrait;
                    cameraButton1.ResourceID = user.U_Portrait;
                    btnName.Text = user.U_Name;
                    sex = (Sex)user.U_Sex;
                    switch (sex)
                    {
                        case Sex.男:
                            btnSex.Text = "男";
                            break;
                        case Sex.女:
                            btnSex.Text = "女";
                            break;
                    }
                    dpkBirthday.Value = user.U_Birthday;
                    btnEmail.Text = user.U_Email;
                }
                else
                {
                    throw new Exception("用户" + Client.Session["U_ID"].ToString() + "不存在，请检查！");
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// Toolbar点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolBar_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            if (!e.Name.Equals("Me"))
            {
                toolbarItemName = e.Name;
                Close();
            }
        }
        /// <summary>
        /// 修改用户头像
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cameraPortrait_ImageCaptured(object sender, BinaryResultArgs e)
        {
            if (e.isError == false)
            {
                UserInputDto upuser = new UserInputDto();
                upuser.U_ID = Client.Session["U_ID"].ToString();
                upuser.U_Portrait = e.ResourceID;
                ReturnInfo result = AutofacConfig.userService.UpdateUser(upuser);
                if (result.IsSuccess == false)
                {
                    Toast(result.ErrorInfo, ToastLength.SHORT);
                }
                else
                {
                    e.SaveFile(e.ResourceID);
                    
                    //imgPortrait.ResourceID = e.ResourceID;
                   
                    //imgPortrait.Refresh();
                    cameraButton1.ResourceID= e.ResourceID;
                   
                }
            }
        }
        /// <summary>
        /// 修改性别
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void popSex_Selected(object sender, EventArgs e)
        {
            if (popSex.Selection != null)
            {
                UserInputDto upuser = new UserInputDto();
                upuser.U_ID = Client.Session["U_ID"].ToString();
                upuser.U_Sex = (Sex)Convert.ToInt32(popSex.Selection.Value);
                ReturnInfo result = AutofacConfig.userService.UpdateUser(upuser);
                if (result.IsSuccess == true)
                {
                    sex = (Sex)Convert.ToInt32(popSex.Selection.Value);
                    //btnSex.Text = popSex.Selection.Text;
                    GetUser();
                }
                else
                {
                    Toast(result.ErrorInfo, ToastLength.SHORT);
                }
            }
        }
    }
}