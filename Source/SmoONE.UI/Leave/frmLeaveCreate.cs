using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;
using SmoONE.Application;
using SmoONE.Domain ;
using SmoONE.CommLib;
using SmoONE.DTOs;
using SmoONE.UI.Layout;
using SmoONE.UI.UserInfo;

namespace SmoONE.UI.Leave
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler 
    // 创建时间： 2016/11
    // 主要内容：  请假创建或编辑界面
    // ******************************************************************
    partial class frmLeaveCreate : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        public string LID;//请假编号
        private string type=""; //请假类别

        //private int checkTop = 0;//审阅人top
        private int imgCheckLeft = 0;
        private string addCheckUser = "";//添加审批人
        private List<string> listCheckUsers = new List<string>(); //审阅人
        private List<Panel> listplCheckUsersP = new List<Panel>();//审阅人头像控件

        private int ccTop=0;//抄送人top
        private int imgCCLeft = 0;
        private string addCCUser = "";//添加抄送人
        private List<string> listCCToUsers = new List<string>(); //抄送人
        private List<Panel> listplCCToUsersP = new List<Panel>();//抄送人头像控件
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion

        /// <summary>
        /// 初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLeaveCreate_Load(object sender, EventArgs e)
        {
            //checkTop = lblCheck.Top + lblCheck.Height ;
            //ccTop = lblCCTo.Top + lblCCTo.Height;

            Bind();
        }
        /// <summary>
        /// 初始化方法
        /// </summary>
        private void Bind()
        {
            try
            {
                //当请假编号不为空时，获取请假信息
                if (LID != null)
                {
                    //获取请假信息
                    LeaveDetailDto leave = AutofacConfig.leaveService.GetByID(LID);
                    type = leave.L_TypeID;
                    btnType.Text = AutofacConfig.leaveService.GetTypeNameByID(leave.L_TypeID);
                    dpkStartDate.Value = leave.L_StartDate;
                    dpkEndDate.Value = leave.L_EndDate;
                    txtLday.Text = leave.L_LDay.ToString();
                    txtReason.Text = leave.L_Reason;
                    //获取图片
                    if (string.IsNullOrEmpty(leave.L_Img1) == false)
                    {
                        imgL.ResourceID = leave.L_Img1;
                    }
                   //获取审批人
                    if (leave.L_CheckUsers != null)
                    {
                        string[] CheckUsers = leave.L_CheckUsers.Split(',');
                        foreach (string checkUser in CheckUsers)
                        {
                            UserDetailDto user = AutofacConfig.userService.GetUserByUserID(checkUser);
                            addCheckUser = checkUser + "," + user.U_Name + "," + user.U_Portrait;
                            addCheckusers();
                        }
                    }
                    //获取抄送人
                    if (string.IsNullOrEmpty(leave.L_CCTo)==false )
                    {
                        string[] CCToUsers = leave.L_CCTo.Split(',');
                        foreach (string ccToUser in CCToUsers)
                        {
                            UserDetailDto user = AutofacConfig.userService.GetUserByUserID(ccToUser);
                            addCCUser = ccToUser + "," + user.U_Name + "," + user.U_Portrait;
                            addCCTousers();

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 类别选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btntype_Click(object sender, EventArgs e)
        {
            popType.Groups.Clear();
            PopListGroup poli = new PopListGroup();
            popType.Groups.Add(poli);
            poli.Title = "类别选择";
            //获取类别，并绑定poplist数据
            List <LeaveType >  listLType= AutofacConfig.leaveService.GetAllType ();
            foreach (LeaveType leaveType in listLType)
            {
                poli.AddListItem( leaveType.L_T_Name , leaveType .L_T_ID );
                if (type.Trim().Length > 0)
                {
                    if (type.Trim().Equals(leaveType.L_T_ID))
                    {
                        popType.SetSelections(poli.Items[(poli.Items.Count - 1)]);
                    }
                }
            }

            popType.ShowDialog();
        }


        /// <summary>
        /// 类别赋值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void popType_Selected(object sender, EventArgs e)
        {
            if (popType.Selection != null)
            {
                type = popType.Selection.Value;
                btnType.Text = popType.Selection.Text + "   > ";
            }
        }

        /// <summary>
        /// 标题栏图片按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLeaveCreate_TitleImageClick(object sender, EventArgs e)
        {
            //关闭当前界面
            Close();
        }

        /// <summary>
        /// 手机自带回退按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLeaveCreate_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                Close();         //关闭当前页面
            }
        }

        /// <summary>
        /// 提交事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (type.Trim().Length <=0)
                {
                    throw new Exception("请输入请假类别！");
                }
                if (dpkStartDate.Value > dpkEndDate.Value)
                {
                    throw new Exception("开始时间必须小于结束时间！");
                }
                if (txtLday.Text.Trim().Length <= 0)
                {
                    throw new Exception("请输入请假天数！");
                }
                else
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(txtLday.Text.Trim(), @"^(?!0+(?:\.0+)?$)(?:[1-9]\d*|0)(?:\.\d{1,2})?$") == false)
                    {
                        throw new Exception("请假天数必须为大于0的数字！");
                    }
                }
                if (txtReason.Text.Trim().Length <= 0)
                {
                    throw new Exception("请输入请假事由！");
                }
                if (listCheckUsers.Count <= 0)
                {
                    throw new Exception("请输入审批人！");
                }

               //赋值请假信息
                LeaveInputDto leave = new LeaveInputDto();
                leave.L_TypeID = type;
                leave.L_StartDate = dpkStartDate.Value;
                leave.L_EndDate = dpkEndDate.Value;
                leave.L_LDay =  Convert .ToDecimal (txtLday.Text .Trim());
                leave.L_Reason = txtReason.Text.Trim();
                if (imgL.ResourceID.Trim().Length > 0)
                {
                    leave.L_Img1 = imgL.ResourceID.Trim();
                }
                else
                {
                    leave.L_Img1 = "";
                }
                if (listCheckUsers.Count > 0)
                {
                    string CheckUsers = "";
                    foreach (string checkuser in listCheckUsers)
                    {
                        if (string.IsNullOrWhiteSpace(CheckUsers) == true)
                        {
                            CheckUsers = checkuser;
                        }
                        else
                        {
                            CheckUsers += "," + checkuser;
                        }
                    }
                    leave.L_CheckUsers = CheckUsers;
                }
                string CCToUsers = "";
                if (listCCToUsers.Count > 0)
                {
                   
                    foreach (string user in listCCToUsers)
                    {
                        if (string.IsNullOrWhiteSpace(CCToUsers) == true)
                        {
                            CCToUsers = user;
                        }
                        else
                        {
                            CCToUsers += "," + user;
                        }
                    }
                }
                leave.L_CCTo = CCToUsers;
                 ReturnInfo result;
                 if (string.IsNullOrEmpty(LID) == false)
                 {
                     leave.L_ID = LID;
                     leave.L_UpdateUser  = Client.Session["U_ID"].ToString();
                     //更新请假信息
                     result = AutofacConfig.leaveService.UpdateLeave (leave);
                 }
                 else
                 {
                     //创建请假
                     leave.L_CreateUser = Client.Session["U_ID"].ToString();
                     result = AutofacConfig.leaveService.AddLeave(leave);
                 }
                //如果返回值true表示请假信息创建或更新成功，否则失败并抛出错误
                if (result.IsSuccess == true)
                {
                    ShowResult = ShowResult.Yes;
                    //if (string.IsNullOrEmpty(LID) == true)
                    //{
                        Close();
                    //}
                    Toast("您的请假条已成功提交！", ToastLength.SHORT);
                   
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
        /// 添加审阅人事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imgbtnAddCheck_Click(object sender, EventArgs e)
        {
            if (listCheckUsers.Count >= 4)
            {
                Toast ("最多只能添加4位审批人！", ToastLength.SHORT);
            }
            else
            {
                frmCheckOrCCTo frm = new frmCheckOrCCTo();
                frm.isCheck = true;
                this.Show(frm, (MobileForm form, object args) =>
                    {
                        if (frm.ShowResult == Smobiler.Core.Controls .ShowResult.Yes)
                        {
                            if (string.IsNullOrWhiteSpace(frm.userInfo) == false)
                            {
                                string Check = frm.userInfo;
                                if (listCheckUsers.Contains(Check.Split(',')[0]) == true)
                                {
                                    Toast("该审批人" + Check.Split(',')[1] + "已在列表中！");
                                }
                                else
                                {
                                    //pCheck2.Controls.Remove(imgbtnAddCheck);
                                    //pCheck2.Controls.Add(imgbtnAddCheck);
                                    addCheckUser = Check;
                                    addCheckusers();
                                    
                                }
                            }
                        }
                    });
            }
        }
        /// <summary>
        /// 抄送人
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imgbtnAddCCTo_Click(object sender, EventArgs e)
        {
            if (listCCToUsers.Count >= 4)
            {
                Toast("最多只能添加4位抄送人！", ToastLength.SHORT);
            }
            else
            {
                SmoONE.UI.UserInfo.frmCheckOrCCTo frm = new SmoONE.UI.UserInfo.frmCheckOrCCTo();
                frm.isCCTO = true;
                Show(frm, (MobileForm form, object args) =>
                {
                    if (frm.ShowResult == Smobiler.Core.Controls .ShowResult.Yes)
                    {
                        if (string.IsNullOrWhiteSpace(frm.userInfo) == false)
                        {
                            string CCToUser = frm.userInfo;
                            if (listCCToUsers.Contains(CCToUser.Split(',')[0]) == true)
                            {
                                Toast("该抄送人" + CCToUser.Split(',')[1] + "已在列表中！");
                            }
                            else
                            {
                                //pCCTo2.Controls.Remove(imgbtnAddCCTo);
                                //pCCTo2.Controls.Add(imgbtnAddCCTo);
                                addCCUser = CCToUser;
                                addCCTousers();
                               
                            }
                        }
                    }
                });
            }
        }

        //添加审批人
        private void addCheckusers()
        {
            Panel plCheckMan = new Panel();
            plCheckMan.Touchable = true;
            plCheckMan.Width = 35;
            plCheckMan.Height = 55;
            plCheckMan.Margin = new Margin(0,0,10,0);
            Image img = new Image();
            img.Height = 35;
            img.Width = 35;
            img.Left = 0;
            img.Top = 0;
            Label lbl = new Label();
            lbl.Height = 20;
            lbl.Width = 35;
            lbl.Left = 0;
            lbl.Top = 35;
            plCheckMan.Controls.AddRange(new MobileControl[] { img,lbl});

            if (addCheckUser.Trim().Length > 0 & listCheckUsers.Count <= 4)
            {
                if (listCheckUsers.Contains(addCheckUser) == false)
                {
                    listCheckUsers.Add(addCheckUser.Split(',')[0]);
                    if (string.IsNullOrEmpty(addCheckUser.Split(',')[2]) == true)
                    {
                        UserDetailDto user = AutofacConfig.userService.GetUserByUserID(addCheckUser.Split(',')[0]);
                        switch (user.U_Sex)
                        {
                            case (int)Sex.男:
                                img.ResourceID = "boy";
                                break;
                            case (int)Sex.女:
                                img.ResourceID = "girl";
                                break;
                        }
                    }
                    else
                    {
                        img.ResourceID = addCheckUser.Split(',')[2];
                    }
                    plCheckMan.Name= "plCheckMan" + addCheckUser.Split(',')[0];
                    img.BorderRadius = 12;
                    img.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Stretch;
                    
                    lbl.Text = addCheckUser.Split(',')[1];
                    lbl.HorizontalAlignment = HorizontalAlignment.Center;
                    lbl.BackColor = System.Drawing.Color.White;
                    lbl.ForeColor = System.Drawing.Color.FromArgb(44, 44, 44);
                    lbl.FontSize = 10;
                    lbl.Padding = new Padding(0,0,0,3);
                    plCheckMan.Tag = addCheckUser.Split(',')[0];
                    listplCheckUsersP.Add(plCheckMan);//添加审批人名称控件
                    plCheckMan.Press += btnDelCheckClick;//删除审批人事件
                    pCheck2.Controls.Add(plCheckMan);                 
                }
                addCheckUser = "";
            }
            CheckusersSort();
        }
        /// <summary>
        /// 添加抄送人
        /// </summary>
        private void addCCTousers()
        {
            Panel plCCToMan = new Panel();
            plCCToMan.Touchable = true;
            plCCToMan.Width = 35;
            plCCToMan.Height = 55;
            plCCToMan.Margin = new Margin(0, 0, 10, 0);
            Image img = new Image();
            img.Height = 35;
            img.Width = 35;
            img.Left = 0;
            img.Top = 0;
            Label lbl = new Label();
            lbl.Height = 20;
            lbl.Width = 35;
            lbl.Left = 0;
            lbl.Top = 35;
            lbl.Padding = new Padding(0, 0, 0, 3);
            plCCToMan.Controls.AddRange(new MobileControl[] { img, lbl });

            if (addCCUser.Trim().Length > 0 & listCCToUsers.Count <= 4)
            {
                if (listCCToUsers.Contains(addCCUser) == false)
                {
                    listCCToUsers.Add(addCCUser.Split(',')[0]);
                    if (string.IsNullOrEmpty(addCCUser.Split(',')[2]) == true)
                    {
                        UserDetailDto user = AutofacConfig.userService.GetUserByUserID(addCCUser.Split(',')[0]);
                        switch (user.U_Sex)
                        {
                            case (int)Sex.男:
                                img.ResourceID = "boy";
                                break;
                            case (int)Sex.女:
                                img.ResourceID = "girl";
                                break;
                        }
                    }
                    else
                    {
                        img.ResourceID = addCCUser.Split(',')[2];
                    }
                    plCCToMan.Name= "plCCToMan" + addCCUser.Split(',')[0];
                    img.BorderRadius = 12;
                    img.SizeMode =ImageSizeMode.Stretch;

                    lbl.HorizontalAlignment = HorizontalAlignment.Center;
                    lbl.Text = addCCUser.Split(',')[1];
                    lbl.Height = 20;
                    lbl.BackColor = System.Drawing.Color.White;
                    lbl.ForeColor = System.Drawing.Color.FromArgb(44, 44, 44);
                    lbl.FontSize = 10;
                    plCCToMan.Tag = addCCUser.Split(',')[0];
                    plCCToMan.Press += btnDelCCToClick;//删除抄送人事件
                    listplCCToUsersP.Add(plCCToMan);//添加抄送人名称控件
                    pCCTo2.Controls.Add(plCCToMan);                 
                }

                addCCUser = "";

            }
            CCToUsersSort();
        }

        /// <summary>
        /// 点击删除请假审批人事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void btnDelCheckClick(object sender, EventArgs e)
        {
            try
            {
                object checkUser = ((MobileControl)sender).Tag;//获取财务审批人头像
                if (checkUser != null)
                {
                    listCheckUsers.Remove(checkUser.ToString());//删除财务审批人
                    foreach (Panel plCheckMan in listplCheckUsersP)
                    {
                        if (plCheckMan.Name.Equals("plCheckMan" + checkUser))
                        {
                            listplCheckUsersP.Remove(plCheckMan);//删除财务审批头像控件
                            pCheck2.Controls.Remove((MobileControl)plCheckMan);//删除界面中财务审批头像控件
                            break;
                        }

                    }

                    //checkTop = lblCheck.Top + lblCheck.Height;
                    CheckusersSort();//审批人相关控件排序
                    checkUser = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// 点击删除请假抄送人事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void btnDelCCToClick(object sender, EventArgs e)
        {
            try
            {
                object CCUser = ((MobileControl)sender).Tag;//获取抄送人头像
                if (CCUser != null)
                {
                    listCCToUsers.Remove(CCUser.ToString());//删除抄送人
                    foreach (Panel plCCToMan in listplCCToUsersP)
                    {
                        if (plCCToMan.Name.Equals("plCCToMan" + CCUser))
                        {
                            listplCCToUsersP.Remove(plCCToMan);//删除抄送人头像控件
                            pCCTo2.Controls.Remove((MobileControl)plCCToMan);//删除界面中抄送人头像控件
                            break;
                        }

                    }
                    CCToUsersSort();//抄送人相关控件排序
                    CCUser = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// 审阅人控件排序
        /// </summary>
        private void CheckusersSort()
        {
            if (listCheckUsers.Count > 0 & listCheckUsers.Count <= 4)
            {
                //如果已经添加了4位审批人，则隐藏添加抄送人控件，否则显示
                if (listCheckUsers.Count == 4)
                {
                    imgbtnAddCheck.Visible = false;
                }
                else
                {

                    switch (listCheckUsers.Count)
                    {
                        case 1:
                            imgbtnAddCheck.Left = 70;
                            break;
                        case 2:
                            imgbtnAddCheck.Left = 120;
                            break;
                        case 3:
                            imgbtnAddCheck.Left = 180;
                            break;
                    }
                    imgbtnAddCheck.Visible = true;
                }
            }
            else
            {
                imgbtnAddCheck.Left = 0;
            }
        }

        /// <summary>
        /// 抄送人控件排序
        /// </summary>
        private void CCToUsersSort()
        {
            if (listCCToUsers.Count > 0 & listCCToUsers.Count <= 4)
            {
                //如果已经添加了4位抄送人，则隐藏添加抄送人控件，否则显示
                if (listCCToUsers.Count == 4)
                {

                    imgbtnAddCCTo.Visible = false;
                }
                else
                {
                    switch  (listCCToUsers.Count)
                        {
                        case 1:
                            imgbtnAddCCTo.Left = 70;
                            break;
                        case 2:
                            imgbtnAddCCTo.Left = 120;
                            break;
                        case 3:
                            imgbtnAddCCTo.Left = 180;
                            break;
                      }
                   
                    
                    imgbtnAddCCTo.Visible = true;
                }
            }
            else
            {
                imgbtnAddCCTo.Left = 0;
            }
        }
        
        /// <summary>
        /// 拍照上传
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnupPhoto_Click(object sender, EventArgs e)
        {
            camera1.GetPhoto();
        }
        /// <summary>
        /// 删除图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btndelPhoto_Click(object sender, EventArgs e)
        {
            if (imgL.ResourceID.Length > 0)
            {
                MessageBox.Show("是否确定删除图片？", "删除", MessageBoxButtons.YesNo, (Object s, MessageBoxHandlerArgs args) =>
                {
                    if (args.Result == Smobiler.Core.Controls .ShowResult.Yes)
                    {
                        imgL.ResourceID = "";
                        imgL.Refresh();
                    }
                }
                       );
            }
            else
            {
                Toast("您没有上传图片，不能删除！",ToastLength.SHORT);
            }
        }
        /// <summary>
        /// 保存图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void camera1_ImageCaptured(object sender, BinaryResultArgs e)
        {
            if (string.IsNullOrEmpty(e.error ))
            {

                if (imgL.ResourceID.Trim().Length > 0)
                {
                    e.SaveFile(imgL.ResourceID);//保存图片文件到本地运行项目的image文件夹中
                    imgL.Refresh();//当图片上传文件名相同时，刷新界面图片内容
                }
                else
                {
                    e.SaveFile(e.ResourceID);//保存图片文件到本地运行项目的image文件夹中
                    imgL.ResourceID = e.ResourceID;
                }
            }
        }
    }
}