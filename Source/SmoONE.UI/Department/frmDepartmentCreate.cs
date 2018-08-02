using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SmoONE.CommLib;
using SmoONE.DTOs;
using SmoONE.Domain;

namespace SmoONE.UI.Department
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2016/11
    // 主要内容：  部门创建或编辑界面
    // ******************************************************************
    partial class frmDepartmentCreate : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        public string D_ID;//部门编号
        string leader="";//责任人
        string D_Portrait="";//部门头像
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion

        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDep_Name.Text .Trim ().Length <= 0)
                {
                    throw new Exception("请输入部门名称！");
                }
              
                if (leader.Length <= 0)
                {
                    throw new Exception("请输入责任人！");
                }
                DepInputDto department = new DepInputDto();
                department.Dep_Name = txtDep_Name.Text;
                department.Dep_UpdateUser = Client.Session["U_ID"].ToString();
                department.Dep_Leader = leader;
                if (string.IsNullOrEmpty(D_Portrait) == false)
                {
                    department.Dep_Icon = D_Portrait;
                }
                else
                {
                    department.Dep_Icon = "";
                }
                if (string.IsNullOrEmpty(D_ID) == false)
                {
                    department.Dep_ID = D_ID;
                    List<UserDto> listuserDto=  AutofacConfig .userService  .GetUserByDepID(D_ID);
                    List <string > listUser=new List<string> ();
                    foreach (UserDto user in listuserDto)
                    {
                        listUser.Add (user.U_ID);
                    }
                    department.UserIDs=listUser;
                    ReturnInfo result = AutofacConfig.departmentService.UpdateDepartment(department);
                    if (result.IsSuccess == false)
                    {
                        throw new Exception(result.ErrorInfo);
                    }
                    else
                    {
                        ShowResult = ShowResult.Yes;
                        Close();
                        Toast("部门提交成功！", ToastLength.SHORT);
                    }
                }
                else
                {
                    //ShowResult = ShowResult.Yes;
                  
                    frmDepAssignUser frmDepAssignUser = new frmDepAssignUser();
                    frmDepAssignUser.department = department;
                    //Show(frmDepAssignUser);
                    Show(frmDepAssignUser, (MobileForm form, object args) =>
                        {
                            if (frmDepAssignUser.ShowResult == ShowResult.Yes)
                            {
                                ShowResult = ShowResult.Yes;
                                Close();
                            }
                        });
                }
                
            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }
        }
        /// <summary>
        /// 获取责任人
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLeader_Click(object sender, EventArgs e)
        {
            popLeader.Groups.Clear();
            PopListGroup poli = new PopListGroup();
            popLeader.Groups.Add(poli);
            poli.Title = "责任人选择";
            List<UserDto> listuser = AutofacConfig.userService.GetAllUsers();
            foreach (UserDto user in listuser)
            {
                poli.AddListItem(user.U_Name, user.U_ID);
                if (leader.Trim().Length > 0)
                {
                    if (leader.Trim().Equals(user.U_ID))
                    {
                        popLeader.SetSelections(poli.Items[(poli.Items.Count - 1)]);
                    }
                }
            }
            popLeader.Show();
        }
        /// <summary>
        /// 初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDepartmentCreate_Load(object sender, EventArgs e)
        {
            Bind();
        }

        /// <summary>
        /// 初始化事件
        /// </summary>
        private void Bind()
        {
            try 
            {
                if (D_ID != null)
                {
                    DepDetailDto dep = AutofacConfig.departmentService.GetDepartmentByDepID(D_ID);
                    if (dep == null)
                    {
                        throw new Exception("部门" + D_ID + "不存在，请检查！");
                    }
                    txtDep_Name.Text = dep.Dep_Name;
                    leader = dep.Dep_Leader;
                    if (string.IsNullOrEmpty(dep.Dep_Icon) == false)
                    {
                        D_Portrait = dep.Dep_Icon;
                        imgPortrait.ResourceID = dep.Dep_Icon;
                    }
                    else
                    {
                        imgPortrait.ResourceID = "bumenicon";
                    }
                    UserDetailDto userinfo = AutofacConfig.userService.GetUserByUserID(leader);
                    btnLeader.Text = userinfo.U_Name;
                    btnSave.Text = "提交";
                    btnAssignUser.Visible = true;
                   // btnSave.Top = 190;
                    btnAssignUser.Top = btnLeader.Top + btnLeader.Height + 10;
                    btnSave.Top = btnAssignUser.Top + btnAssignUser.Height + 10;
                }
                else
                {
                    btnAssignUser.Visible =false ;
                   // btnSave.Top = 145;
                    btnSave.Top = btnLeader.Top + btnLeader.Height + 10;
                }
            }
                catch (Exception ex)
            {
                    MessageBox .Show (ex.Message );
             }
        }
        /// <summary>
        /// 责任人赋值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void popLeader_Selected(object sender, EventArgs e)
        {
            try
            {
                if (popLeader.Selection != null)
                {
                    //查询该选中的用户是否已经是部门责任人
                    bool isLeader=AutofacConfig.departmentService.IsLeader(popLeader.Selection.Value);
                    //如果该选中责任人已是部门责任人，则报错
                    if (isLeader == true )
                    {
                        throw new Exception (popLeader.Selection.Text + "已是部门责任人，请先解散部门！");
                    }
                    //
                  UserDepDto userdep=  AutofacConfig.userService.GetUseDepByUserID(popLeader.Selection.Value);
                  //如果选中用户已是部门成员且不是部门责任人，则进行选择是否确认为部门责任人，若确认则为该部门负责人
                    if ( userdep !=null & string.IsNullOrEmpty (userdep.Dep_ID)==false & isLeader== false )
                    //if (AutofacConfig.userService.GetAllUsers().Count > 0 & isLeader== false)
                    //{
                        MessageBox.Show(popLeader.Selection.Text+"已是部门成员，是否确定为该部门责任人？", MessageBoxButtons.YesNo, (Object s1, MessageBoxHandlerArgs args) =>
                        {
                            //此委托为异步委托事件
                            if (args.Result == Smobiler.Core.Controls .ShowResult.Yes)
                            {
                                leader = popLeader.Selection.Value;
                                btnLeader.Text = popLeader.Selection.Text + "   > ";
                            }
                        });
                    //}
                    //如果选中用户不是部门责任人且不是部门成员，则为该部门负责人
                   if (isLeader == false & userdep != null & string.IsNullOrEmpty(userdep.Dep_ID) == true )
                   {
                       leader = popLeader.Selection.Value;
                       btnLeader.Text = popLeader.Selection.Text + "   > ";
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
        private void frmDepartmentCreate_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                Close();         //关闭当前页面
            }
        }
        /// <summary>
        /// 标题栏图片按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDepartmentCreate_TitleImageClick(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// 上传部门头像
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUp_Click(object sender, EventArgs e)
        {
            cameraPortrait.GetPhoto();
        }
        /// <summary>
        /// 保存并赋值头像
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cameraPortrait_ImageCaptured(object sender, BinaryResultArgs e)
        {
            if (string.IsNullOrEmpty(e.error ))
            {
                if (imgPortrait.ResourceID.Trim().Length > 0 & string.IsNullOrEmpty(D_Portrait)==false )
                {
                    e.SaveFile(D_Portrait);
                    imgPortrait.ResourceID = D_Portrait;
                    imgPortrait.Refresh();
                }
                else
                {
                    e.SaveFile(e.ResourceID);
                    D_Portrait = e.ResourceID;
                    imgPortrait.ResourceID = e.ResourceID;
                    imgPortrait.Refresh();
                }
            }
        }
        /// <summary>
        /// 跳转到分配部门界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAssignUser_Click(object sender, EventArgs e)
        {
            if (D_ID != null)
            {
                DepDetailDto dep = AutofacConfig.departmentService.GetDepartmentByDepID(D_ID);
                if (dep != null)
                {
                    DepInputDto department = new DepInputDto();
                    department.Dep_ID = dep.Dep_ID;
                    department.Dep_Name = dep.Dep_Name;
                    department.Dep_Leader = dep.Dep_Leader;
                    department.Dep_Icon = dep.Dep_Icon;
                    frmDepAssignUser frmDepAssignUser = new frmDepAssignUser();
                    frmDepAssignUser.department = department;
                    Show(frmDepAssignUser, (MobileForm form, object args) =>
                    {
                        if (frmDepAssignUser.ShowResult == ShowResult.Yes)
                        {
                            ShowResult = ShowResult.Yes;
                            Close();
                        }
                    });
                }

            }
        }
    }
}