                                                                                                                                                               using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SmoONE.Domain;
using SmoONE.DTOs;
using SmoONE.UI.UserInfo;

namespace SmoONE.UI.Department
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler 
    // 创建时间： 2016/11
    // 主要内容：  部门列表界面
    // ******************************************************************
    partial class frmDepartment : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        public  DepartmentMode Mode; //客户展示模式
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
      
        /// <summary>
        /// 初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDepartment_Load(object sender, EventArgs e)
        {
            Mode = DepartmentMode.列表;
            Bind();
        }
        /// <summary>
        /// 初始化数据
        /// </summary>
        public  void Bind()
        {
            try
            {
                //获取所有部门数据
                List<DepartmentDto> listDep = AutofacConfig.departmentService.GetAllDepartment();
                switch (Mode)
                {
                    case DepartmentMode.列表:
                        gridDepData.Rows.Clear();//清空部门列表数据
                        btnDMode.Text = DepartmentMode.层级 + "展示";
                        break;
                    case DepartmentMode.层级:
                        treeDepData.Nodes.Clear();//清空部门层级数据
                        btnDMode.Text = DepartmentMode.列表 + "展示";
                        break;
                }

                if (listDep.Count > 0)
                {
                    btnDMode.Visible = true;
             
                    lblInfor.Visible = false ;
                    foreach (DepartmentDto dep in listDep)
                    {
                        if (string.IsNullOrEmpty(dep.Dep_Icon) == true)
                        {
                            dep.Dep_Icon = "bumenicon";
                        }
                      
                    }
                    switch (Mode)
                    {
                        case  DepartmentMode.列表:
                            gridDepData.Visible = true;
                            treeDepData.Visible = false;
                            gridDepData.DataSource = listDep;
                            gridDepData.DataBind();
                            break;
                        case DepartmentMode.层级:
                            gridDepData.Visible = false;
                            treeDepData.Visible = true;
                            foreach (DepartmentDto dep in listDep)
                            {
                                TreeViewNode node = new TreeViewNode(dep.Dep_Name, null, dep.Dep_Icon, (int)TreeMode.dep + "," + dep.Dep_ID);
                               node.TextColor = System.Drawing.Color.FromArgb(45,45,45);
                                List<UserDto> listDepUser = AutofacConfig.userService.GetUserByDepID(dep.Dep_ID);
                                if (listDepUser.Count > 0)
                                {
                                    foreach (UserDto user in listDepUser)
                                    {
                                        string Name="";
                                        if (dep .Dep_Leader .Equals (user.U_ID))
                                        {
                                            Name=user.U_Name+"  负责人";
                                        }
                                        else 
                                        {
                                            Name=user.U_Name;
                                        }
                                        string portrait="";
                                        if (string.IsNullOrEmpty(user.U_Portrait) == true)
                                        {
                                            switch (user.U_Sex)
                                            {
                                                case (int)Sex.男:
                                                    portrait = "boy";
                                                    break;
                                                case (int)Sex.女:
                                                    portrait = "girl";
                                                    break;
                                            }
                                        }
                                        else
                                        {
                                            portrait = user.U_Portrait;
                                        }
                                        TreeViewNode node1 = new TreeViewNode(Name, null, portrait, (int)TreeMode.user + "," + user.U_ID);
                                       node1.TextColor = System.Drawing.Color.FromArgb(145,145,145);
                                        node.Nodes.Add(node1);
                                    }
                                  
                                }
                                treeDepData.Nodes.Add(node);
                            }
                            break;
                    }
                   
                }
                else
                {
                   // btnDMode.Visible = false;
                    lblInfor.Visible = true;
                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        /// <summary>
        /// 手机自带回退按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDepartment_KeyDown(object sender, KeyDownEventArgs e)
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
        private void frmDepartment_TitleImageClick(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// 跳转到创建部门界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmDepartmentCreate frm = new frmDepartmentCreate();
            Show(frm, (MobileForm form, object args) =>
                {
                    if (frm.ShowResult == ShowResult.Yes)
                    {
                        Bind();
                    }
                });
         
        }

        /// <summary>
        /// treeDepData点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeDepData_NodeSelected(object sender, TreeViewClickEventArgs e)
        {
           
           // string ID = treeDepData.SelectedNode.Value;
            string ID = e.Value;
            switch (Convert.ToInt32(ID.Split(',')[0]))
            {
                case (int)TreeMode.dep:
                    frmDepartmentDetail frm = new frmDepartmentDetail();
                    frm.D_ID = ID.Split(',')[1];
                    Show(frm, (MobileForm form, object args) =>
                    {
                        if (frm.ShowResult == ShowResult.Yes)
                        {
                            Mode = DepartmentMode.层级;
                            Bind();
                        }
                    });
                    break;
                case (int)TreeMode.user:
                    frmUserDetail frmUserDetail = new frmUserDetail();
                    frmUserDetail.U_ID = ID.Split(',')[1];
                    Show(frmUserDetail);
                    break;
            }
           
        }
  
        /// <summary>
        /// 部门显示模式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDLayout_Click(object sender, EventArgs e)
        {
            switch (Mode)
            {
                case DepartmentMode.列表:
                    Mode = DepartmentMode.层级;
                    break;
                case DepartmentMode.层级:
                    Mode = DepartmentMode.列表;
                    break;
            }
            Bind();
        }
    }
}