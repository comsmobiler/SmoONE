using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SmoONE.Domain;
using SmoONE.DTOs;

namespace SmoONE.UI.CostCenter
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2016/11
    // 主要内容：  成本中心详情界面
    // ******************************************************************
    partial class frmCostTempletDetail : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        public string CTempID;//模板编号
        private int AEACheckTop;//行政审批人top
        private int imgCheckLeft = 0;
        private string addAEACheck = "";
        private List<string> listAEAChecks = new List<string>(); //行政审批人
        private List<Image> listimgAEAChecksP = new List<Image>();//行政审批人头像控件
        private List<Label> listlblAEAChecks = new List<Label>();//行政审批人名称控件

        private int FCheckTop;//财务审批人top
        private int imgFCheckLeft = 0;
        private string addFCheck = "";
        private List<string> listFCheckers = new List<string>(); //财务审批人
        private List<Image> listimgFCheckersP = new List<Image>();//财务审批人头像控件
        private List<Label> listlblFCheckers = new List<Label>();//财务审批人名称控件
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion

        /// <summary>
        /// 添加行政审阅人
        /// </summary>
        private void addAEACheckers()
        {
            if (addAEACheck.Trim().Length > 0)
            {
                if (listAEAChecks.Contains(addAEACheck.Split(',')[0]) == false)
                {
                    listAEAChecks.Add(addAEACheck.Split(',')[0]);
                    int imgCheckWSize = 35;

                    Image imgAEACheckP = new Image();
                    if (string.IsNullOrEmpty(addAEACheck.Split(',')[2]) == true)
                    {
                        UserDetailDto user = AutofacConfig.userService.GetUserByUserID(addAEACheck.Split(',')[0]);
                        switch (user.U_Sex)
                        {
                            case (int)Sex.男:
                                imgAEACheckP.ResourceID = "boy";
                                break;
                            case (int)Sex.女:
                                imgAEACheckP.ResourceID = "girl";
                                break;
                        }
                    }
                    else
                    {
                        imgAEACheckP.ResourceID = addAEACheck.Split(',')[2];
                    }


                    imgAEACheckP.Width = imgCheckWSize;
                    imgAEACheckP.Height = imgCheckWSize;
                    imgAEACheckP.ZIndex = (Controls.Count + 1)+10;
                    imgAEACheckP.BorderRadius = 13;
                    imgAEACheckP.Name = "imgAEACheck" + addAEACheck.Split(',')[0];
                    imgAEACheckP.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Stretch;
                    imgAEACheckP.Left = imgFCheckLeft;
                    this.panel1 .Controls.Add(imgAEACheckP);//界面添加行政审批人头像控件
                    listimgAEAChecksP.Add(imgAEACheckP);//添加行政审批人头像控件

                    Label lblAEACheckName = new Label();
                    lblAEACheckName.Text = addAEACheck.Split(',')[1];
                    lblAEACheckName.Name = "lblAEACheck" + addAEACheck.Split(',')[0];
                    lblAEACheckName.Width = imgCheckWSize;
                    lblAEACheckName.Height = 20;
                    lblAEACheckName.BackColor = System.Drawing.Color.White;
                    lblAEACheckName.ForeColor = System.Drawing.Color.FromArgb(44, 44, 44);
                    lblAEACheckName.FontSize = 10;
                    lblAEACheckName.ZIndex = (Controls.Count + 1) + 10;
                    this.panel1.Controls.Add(lblAEACheckName);//界面添加行政审批人名称控件
                    listlblAEAChecks.Add(lblAEACheckName);//添加行政审批人名称控件
                }

                addAEACheck = "";

            }
            AEAChecksSort();
        }

        /// <summary>
        /// 添加财务审批人
        /// </summary>
        private void addFCheckers()
        {

            if (addFCheck.Trim().Length > 0)
            {
                if (listFCheckers.Contains(addFCheck.Split(',')[0]) == false)
                {
                    listFCheckers.Add(addFCheck.Split(',')[0]);
                    int imgFCWSize = 35;

                    Image imgFCheckP = new Image();
                    if (string.IsNullOrEmpty(addFCheck.Split(',')[2]) == true)
                    {
                        UserDetailDto user = AutofacConfig.userService.GetUserByUserID(addFCheck.Split(',')[0]);
                        switch (user.U_Sex)
                        {
                            case (int)Sex.男:
                                imgFCheckP.ResourceID = "boy";
                                break;
                            case (int)Sex.女:
                                imgFCheckP.ResourceID = "girl";
                                break;
                        }
                    }
                    else
                    {
                        imgFCheckP.ResourceID = addFCheck.Split(',')[2];
                    }

                    imgFCheckP.Width = imgFCWSize;
                    imgFCheckP.Height = imgFCWSize;
                    imgFCheckP.ZIndex = (Controls.Count + 1) + 10;
                    imgFCheckP.BorderRadius = 13;
                    imgFCheckP.Name = "imgFCheck" + addFCheck.Split(',')[0];
                    imgFCheckP.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Stretch;
                    this.panel1 .Controls.Add(imgFCheckP);//界面添加财务审批人头像控件
                    listimgFCheckersP.Add(imgFCheckP);//添加财务审批人头像控件

                    Label lblFCheckName = new Label();
                    lblFCheckName.Text = addFCheck.Split(',')[1];
                    lblFCheckName.Name = "lblFCheck" + addFCheck.Split(',')[0];
                    lblFCheckName.Width = imgFCWSize;
                    lblFCheckName.Height = 20;
                    lblFCheckName.BackColor = System.Drawing.Color.White;
                    lblFCheckName.ForeColor = System.Drawing.Color.FromArgb(44, 44, 44);
                    lblFCheckName.FontSize = 10;
                    lblFCheckName.ZIndex = (Controls.Count + 1) + 10;
                    this.panel1 .Controls.Add(lblFCheckName);//界面添加财务审批人名称控件
                    listlblFCheckers.Add(lblFCheckName);//添加财务审批人名称控件
                }

                addFCheck = "";

            }
            FCheckersSort();
        }

        /// <summary>
        /// 行政审批人控件排序
        /// </summary>
        private void AEAChecksSort()
        {
            int imgCheckWSize = 35;
            int imgCheckHSize = 55;
            imgCheckLeft = 65;
            if (listAEAChecks.Count > 0)
            {
                foreach (string checkuser in listAEAChecks)
                {
                    foreach (Label  lblAEACheck in listlblAEAChecks)
                    {
                        if (lblAEACheck.Name.Equals("lblAEACheck" + checkuser))
                        {
                                if ((imgCheckLeft + imgCheckWSize) > 300)
                                {
                                    imgCheckLeft = 0;
                                    AEACheckTop = AEACheckTop + imgCheckHSize;
                                    if (AEACheckTop > Height)
                                    {
                                        Height = Height + imgCheckHSize;
                                    }
                                }
                              
                                foreach (Image imgAEACheck in listimgAEAChecksP)
                                {
                                    if (imgAEACheck.Name.Equals("imgAEACheck" + checkuser))
                                    {
                                        imgAEACheck.Left = imgCheckLeft;
                                        imgAEACheck.Top = AEACheckTop;

                                        lblAEACheck.Left = imgCheckLeft;
                                        lblAEACheck.Top = imgAEACheck.Top + imgAEACheck.Height;
                                        imgCheckLeft += (imgCheckWSize + 10);
                                        break;
                                    }
                                }
                            continue;
                        }
                    }
                }
                lblAEACheckers2.Visible = true;
                lblAEACheckers2.Top = lblAEACheckers.Top + lblAEACheckers.Height;
                lblAEACheckers2.Height = imgCheckHSize;
            }
            lblFCheckers.Top = AEACheckTop + 10 + imgCheckHSize;
            FCheckTop = lblFCheckers.Top + lblFCheckers.Height;
            FCheckersSort();
        }

        /// <summary>
        /// 财务审批人控件排序
        /// </summary>
        private void FCheckersSort()
        {
            int imgFCheckWSize = 35;
            int imgFCheckHSize = 55;
            imgFCheckLeft = 65;
            if (listFCheckers.Count > 0)
            {
                foreach (string ccToUser in listFCheckers)
                {
                    foreach (Label  lblFChecker in listlblFCheckers)
                    {
                        if (lblFChecker.Name.Equals("lblFCheck" + ccToUser))
                        {
                            if ((imgFCheckLeft + imgFCheckWSize) > 300)
                            {
                                imgFCheckLeft = 0;
                                FCheckTop = FCheckTop + imgFCheckHSize;
                                if (FCheckTop > Height)
                                {
                                    Height = Height + imgFCheckHSize;
                                }
                            }
                            
                            foreach (Image imgFCCheck in listimgFCheckersP)
                            {
                                if (imgFCCheck.Name.Equals("imgFCheck" + ccToUser))
                                {
                                    imgFCCheck.Left = imgFCheckLeft;
                                    imgFCCheck.Top = FCheckTop;

                                    lblFChecker.Left = imgFCheckLeft;
                                    lblFChecker.Top = imgFCCheck.Top + imgFCCheck.Height;
                                    imgFCheckLeft += (imgFCheckWSize + 10);
                                    break;
                                }
                            }
                            continue;
                        }
                    }
                }
                lblFCheckers2.Visible = true;
                lblFCheckers2.Top = lblFCheckers.Top + lblFCheckers.Height;
                lblFCheckers2.Height = imgFCheckHSize;
            }

            btnEdit.Top = FCheckTop + 40 + imgFCheckHSize;
            if (Height < (btnEdit.Top + btnEdit.Height))
            {
                Height = btnEdit.Top + btnEdit.Height;
            }
        }


        /// <summary>
        /// 初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCostTempletDetail_Load(object sender, EventArgs e)
        {
            AEACheckTop = lblAEACheckers.Top + lblAEACheckers.Height;
            FCheckTop = lblFCheckers.Top + lblFCheckers.Height;
            Bind();
        }

        /// <summary>
        /// 初始化方法
        /// </summary>
        private void Bind()
        {
            try
            {
                //根据成本中心模板编号获取成本中心模板数据
                CC_Type_TemplateDto ccTemplate = AutofacConfig.costCenterService.GetTemplateByID(CTempID);
                lblCTempID.Text = CTempID;
                lblType.Text = ccTemplate.CC_TT_TypeName;
                addAEACheck = "";
                listAEAChecks.Clear ();
                listlblAEAChecks.Clear();
                addFCheck = "";
                listFCheckers.Clear();
                listlblFCheckers.Clear();
                if (string.IsNullOrEmpty(ccTemplate.CC_TT_AEACheckers)==false )
                {
                    string[] CheckUsers = ccTemplate.CC_TT_AEACheckers.Split(',');
                    foreach (string checkUser in CheckUsers)
                    {
                        UserDetailDto user = AutofacConfig.userService.GetUserByUserID(checkUser);
                        addAEACheck = checkUser + "," + user.U_Name + "," + user.U_Portrait;
                        addAEACheckers();
                    }
                }
                if (string.IsNullOrEmpty(ccTemplate.CC_TT_FinancialCheckers) == false)
                {
                    string[] CCToUsers = ccTemplate.CC_TT_FinancialCheckers.Split(',');
                    foreach (string ccToUser in CCToUsers)
                    {
                        UserDetailDto user = AutofacConfig.userService.GetUserByUserID(ccToUser);
                        addFCheck = ccToUser + "," + user.U_Name + "," + user.U_Portrait;
                        addFCheckers();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 标题栏图片按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCostTempletDetail_TitleImageClick(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// 手机自带回退键按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCostTempletDetail_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                Close();         //关闭当前页面
            }
        }
        /// <summary>
        /// 跳转到模板编辑界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmCostTempletCreate frm = new frmCostTempletCreate();
            frm.CTempID = CTempID;
            Show(frm, (MobileForm form, object args) =>
            {
                if (frm.ShowResult == ShowResult.Yes)
                {
                    ShowResult = ShowResult.Yes;
                    lblAEACheckers.Top = 100;
                    lblFCheckers.Top = 145;
                    AEACheckTop = lblAEACheckers.Top + lblAEACheckers.Height;
                    FCheckTop = lblFCheckers.Top + lblFCheckers.Height;
                    if (listAEAChecks.Count > 0)
                    {
                        if (listimgAEAChecksP.Count > 0)
                        {
                            foreach (Image imgAEACheckP in listimgAEAChecksP)
                            {

                                this.panel1.Controls.Remove((Image)imgAEACheckP);
                            }
                        }
                        if (listlblAEAChecks.Count > 0)
                        {
                            foreach (Label lblAEACheckName in listlblAEAChecks)
                            {


                                this.panel1.Controls.Remove((Label)lblAEACheckName);
                            }
                        }
                        listAEAChecks.Clear();
                        listimgAEAChecksP.Clear();
                        listlblAEAChecks.Clear();
                    }
                    if (listFCheckers.Count > 0)
                    {
                        if (listimgFCheckersP.Count > 0)
                        {
                            foreach (Image imgFCheckP in listimgFCheckersP)
                            {

                                this.panel1.Controls.Remove((Image)imgFCheckP);
                            }
                        }
                        if (listlblFCheckers.Count > 0)
                        {
                            foreach (Label lblFCheckName in listlblFCheckers)
                            {
                                this.panel1.Controls.Remove((Label)lblFCheckName);
                            }
                        }
                        listFCheckers.Clear();
                        listimgFCheckersP.Clear();
                        listlblFCheckers.Clear();
                    }
                    Bind();
                }
            });
        }
       
    }
}