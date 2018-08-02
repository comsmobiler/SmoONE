using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SmoONE.DTOs;
using SmoONE.CommLib;
using SmoONE.Domain;
using SmoONE.UI.Layout;

namespace SmoONE.UI.Department
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler 
    // 创建时间： 2016/11
    // 主要内容：  部门人员分配界面
    // ******************************************************************
    partial class frmDepAssignUser : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        int selectUserQty = 0;//选中人员数
         public DepInputDto department;//部门信息
         AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
      
        /// <summary>
        /// 手机自带回退键按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDepAssignUser_KeyDown(object sender, KeyDownEventArgs e)
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
        private void frmDepAssignUser_TitleImageClick(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// 初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDepAssignUser_Load(object sender, EventArgs e)
        {
            Bind();
           
        }
        /// <summary>
        /// 初始化方法
        /// </summary>
        private void Bind()
        {
            try
            {
                if (department != null)
                {
                    txtDepName.Text = department.Dep_Name;
                    if (string.IsNullOrEmpty(department.Dep_Icon) == false)
                    {
                        imgPortrait.ResourceID = department.Dep_Icon;
                        imgPortrait.Refresh();
                    }
                    btnLeader.Text = AutofacConfig.userService.GetUserByUserID(department.Dep_Leader).U_Name;
                    List<DataGridviewbyUser> listUser = new List<DataGridviewbyUser>();
                    List<UserDto> listDepUser = AutofacConfig.userService.GetAllUsers();//获取分配部门人员
                    //部门创建时ListView绑定数据
                    if (string.IsNullOrEmpty(department.Dep_ID) == true )
                    {
                        if (listDepUser.Count > 0)
                        { 
                            //将未分配部门且不是当前部门责任人的用户，添加到listUser中
                            foreach (UserDto user in listDepUser)
                            {
                                if ((string.IsNullOrEmpty(user.U_DepID) == true) & (!department.Dep_Leader .Equals(user.U_ID)))
                                {
                                    DataGridviewbyUser depUser = new DataGridviewbyUser();
                                    depUser.U_ID = user.U_ID;
                                    depUser.U_Name = user.U_Name;
                                    if (string.IsNullOrEmpty(user.U_Portrait) == true)
                                    {
                                        switch (user.U_Sex)
                                        {
                                            case (int)Sex.男:
                                                depUser.U_Portrait = "boy";
                                                break;
                                            case (int)Sex.女:
                                                depUser.U_Portrait = "girl";
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        depUser.U_Portrait = user.U_Portrait;
                                    }
                                    depUser.U_DepID = "";
                                    depUser.U_DepName = "";
                                    depUser.SelectCheck = false;
                                    listUser.Add(depUser);
                                }
                            }
                            //将已分配部门且不是当前部门责任人的用户，添加到listUser中
                            foreach (UserDto user in listDepUser)
                            {
                                if ((string.IsNullOrEmpty(user.U_DepID) == false) & (!department.Dep_Leader.Equals(user.U_ID)))
                                {
                                    DataGridviewbyUser depUser = new DataGridviewbyUser();
                                    depUser.U_ID = user.U_ID;
                                    depUser.U_Name = user.U_Name;
                                    if (string.IsNullOrEmpty(user.U_Portrait) == true)
                                    {
                                        switch (user.U_Sex)
                                        {
                                            case (int)Sex.男:
                                                depUser.U_Portrait = "boy";
                                                break;
                                            case (int)Sex.女:
                                                depUser.U_Portrait = "girl";
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        depUser.U_Portrait = user.U_Portrait;
                                    }
                                    depUser.U_DepID = user.U_DepID;
                                    string DepName = "";
                                    if (AutofacConfig.departmentService.GetDepartmentByDepID(user.U_DepID) != null)
                                    {
                                        DepName = AutofacConfig.departmentService.GetDepartmentByDepID(user.U_DepID).Dep_Name;
                                    }      
                                    depUser.U_DepName = DepName;
                                    depUser.SelectCheck = false;
                                    listUser.Add(depUser);
                                }
                            }
                        }
                    }
                    //部门编辑时ListView绑定数据
                    if (string.IsNullOrEmpty(department.Dep_ID) == false )
                    {
                        if (listDepUser.Count > 0)
                        {
                            //将当前部门且不是当前部门责任人的用户，添加到listUser中
                            foreach (UserDto user in listDepUser)
                            {
                                if ((string.IsNullOrEmpty(user.U_DepID) == false) & (department.Dep_ID.Equals(user.U_DepID)) & (!department.Dep_Leader.Equals(user.U_ID)))
                                {
                                    DataGridviewbyUser depUser = new DataGridviewbyUser();
                                    depUser.U_ID = user.U_ID;
                                    depUser.U_Name = user.U_Name;
                                    if (string.IsNullOrEmpty(user.U_Portrait) == true)
                                    {
                                        switch (user.U_Sex)
                                        {
                                            case (int)Sex.男:
                                                depUser.U_Portrait = "boy";
                                                break;
                                            case (int)Sex.女:
                                                depUser.U_Portrait = "girl";
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        depUser.U_Portrait = user.U_Portrait;
                                    }
                                    depUser.U_DepID = department .Dep_ID ;
                                    depUser.U_DepName =department .Dep_Name ;
                                    depUser.SelectCheck = true ;
                                    listUser.Add(depUser);
                                }
                            }
                            //将未分配部门且不是当前部门责任人的用户，添加到listUser中
                            foreach (UserDto user in listDepUser)
                            {
                                if ((string.IsNullOrEmpty(user.U_DepID) == true) & (!department.Dep_Leader.Equals(user.U_ID)))
                                {
                                    DataGridviewbyUser depUser = new DataGridviewbyUser();
                                    depUser.U_ID = user.U_ID;
                                    depUser.U_Name = user.U_Name;
                                    if (string.IsNullOrEmpty(user.U_Portrait) == true)
                                    {
                                        switch (user.U_Sex)
                                        {
                                            case (int)Sex.男:
                                                depUser.U_Portrait = "boy";
                                                break;
                                            case (int)Sex.女:
                                                depUser.U_Portrait = "girl";
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        depUser.U_Portrait = user.U_Portrait;
                                    }
                                    depUser.U_DepID = "";
                                    depUser.U_DepName = "";
                                    depUser.SelectCheck = false;
                                    listUser.Add(depUser);
                                }
                            }
                            //将已分配部门且不是当前部门的用户，添加到listUser中
                            foreach (UserDto user in listDepUser)
                            {
                                if ((string.IsNullOrEmpty(user.U_DepID) == false) & (!department.Dep_ID.Equals(user.U_DepID)) & (!department.Dep_Leader.Equals(user.U_ID)))
                                {
                                    DataGridviewbyUser depUser = new DataGridviewbyUser();
                                    depUser.U_ID = user.U_ID;
                                    depUser.U_Name = user.U_Name;
                                    if (string.IsNullOrEmpty(user.U_Portrait) == true)
                                    {
                                        switch (user.U_Sex)
                                        {
                                            case (int)Sex.男:
                                                depUser.U_Portrait = "boy";
                                                break;
                                            case (int)Sex.女:
                                                depUser.U_Portrait = "girl";
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        depUser.U_Portrait = user.U_Portrait;
                                    }
                                    depUser.U_DepID = user.U_DepID;
                                    string DepName = AutofacConfig.departmentService.GetDepartmentByDepID(user.U_DepID).Dep_Name;
                                    depUser.U_DepName = DepName;
                                    depUser.SelectCheck = false;
                                    listUser.Add(depUser);
                                }
                            }
                         }
                    }
                   
                    gridUserData.Rows.Clear();//清空人员列表数据
                    if (listUser.Count > 0)
                    {
                        gridUserData.DataSource = listUser; //绑定ListView数据
                        gridUserData.DataBind();
                        upCheckState();
                    }
                   
                }
                else
                {
                    throw new Exception("请输入部门信息！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
      
        /// <summary>
        /// 全选
        /// </summary>
        private void Checkall()
        {
            switch (checkAll .Checked )
            {
                case true:
                    foreach (ListViewRow rows in gridUserData.Rows)
                    {
                        //rows.Cell.Items["Check"].DefaultValue = true;
                        ((frmDepAssignUserLayout)(rows.Control)).Check.BindDisplayValue = true;

                    }
                    selectUserQty = gridUserData.Rows.Count;
                    break;
                case false:
                    foreach (ListViewRow rows in gridUserData.Rows)
                    {
                        //rows.Cell.Items["Check"].DefaultValue = false;
                        ((frmDepAssignUserLayout)(rows.Control)).Check.BindDisplayValue = false;

                    }
                    selectUserQty = 0;
                    break;
            }
        }
        /// <summary>
        /// 分配部门人员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> listUser = new List<string>(); //用户集合
                string assignUser = "";//已分配部门用户
                string depLeader = "";//部门责任人用户
                department.Dep_Name = txtDepName.Text.Trim();
                listUser.Add(department.Dep_Leader);//添加当前部门负责人
                
               // //获取责任人的部门
               // UserDetailDto leader = AutofacConfig.userService.GetUserByUserID(department.Dep_Leader);
               ////如果部门编号不为空且不等于当前部门时，将当前责任人添加到当前部门的已分配部门人员中
               // if (string.IsNullOrEmpty(leader.U_DepID) == false)
               // {   
               //     if (string.IsNullOrEmpty(department.Dep_ID) == false)
               //     {
               //         if (!department.Dep_ID.Equals(leader.U_DepID))
               //         {
               //             assignUser = btnLeader.Text.Trim();
               //         }
               //     }
               // }
                string depuser = null;//选中用户中且已分配部门的用户
                List<string > listselectuserdep =new List<string> ();//获取选中用户的且是已分配部门中，用户的部门
                foreach (ListViewRow rows in gridUserData.Rows)
                {

                    if ((Convert.ToBoolean(((frmDepAssignUserLayout)(rows.Control)).Check.BindDisplayValue) == true) & (!department.Dep_Leader.Equals(((frmDepAssignUserLayout)(rows.Control)).lblUser.BindDataValue.ToString())))
                    {      
                        string user =((frmDepAssignUserLayout)(rows.Control)).lblUser.BindDataValue.ToString();
                        listUser.Add(user);
                       //获取选中用户中的已分配部门的用户                      
                        if (string.IsNullOrEmpty(((frmDepAssignUserLayout)(rows.Control)).lblDep.BindDisplayValue.ToString())==false )
                        {
                            if (string .IsNullOrEmpty(depuser)==true  )
                            {
                                depuser = ((frmDepAssignUserLayout)(rows.Control)).lblUser.BindDataValue.ToString();
                            }
                            else
                            {
                                depuser += "," + ((frmDepAssignUserLayout)(rows.Control)).lblUser.BindDataValue.ToString();
                            }
                            if (listselectuserdep.Count <= 0)
                            {
                                listselectuserdep.Add(((frmDepAssignUserLayout)(rows.Control)).lblDep.BindDisplayValue.ToString());//添加选中用户的部门
                            }
                            else
                            {
                                if (listselectuserdep.Contains(((frmDepAssignUserLayout)(rows.Control)).lblDep.BindDisplayValue.ToString()) == false)
                                {
                                    listselectuserdep.Add(((frmDepAssignUserLayout)(rows.Control)).lblDep.BindDisplayValue.ToString());//添加选中用户的部门
                                }
                            }
                        }
                           
                          
                            //    //if (string.IsNullOrEmpty(department.Dep_ID) == false & !department.Dep_ID.Equals(((frmDepAssignUserLayout)(rows.Control)).lblDep.BindDisplayValue.ToString()))
                            //    //{
                            //    //    if (!department.Dep_ID.Equals(((frmDepAssignUserLayout)(rows.Control)).lblDep.BindDisplayValue.ToString()))
                            //    //    {
                            //            //如果是部门责任人，则添加到部门责任人用户depLeader中，否则添加到已分配部门用户assignUser中
                            //            if (AutofacConfig.departmentService.IsLeader(                         ((frmDepAssignUserLayout)(rows.Control)).lblUser.BindDisplayValue.ToString()) == true)
                            //            {
                            //                if (string.IsNullOrEmpty(depLeader) == true)
                            //                {
                            //                    depLeader = rows.Cell.Items["lblUser"].Text;
                            //                }
                            //                else
                            //                {
                            //                    depLeader += "," + rows.Cell.Items["lblUser"].Text;
                            //                }

                            //            }
                            //            else
                            //            {
                            //                if (string.IsNullOrEmpty(assignUser) == true)
                            //                {
                            //                    assignUser = rows.Cell.Items["lblUser"].Text;
                            //                }
                            //                else
                            //                {
                            //                    assignUser += "," + rows.Cell.Items["lblUser"].Text;
                            //                }
                            //            }

                            //    //    }
                            //    //}
                            ////}
                        //}
                    }
                }
                //如果已分配部门的用户不为空时
                if (string.IsNullOrEmpty(depuser) == false)
                {
                    string[] depusers = depuser.Split(',');
                    //创建部门时，判断选中用户是否为部门责任人和是否为已分配部门成员
                    if (string.IsNullOrEmpty(department.Dep_ID) == true)
                    {
                        foreach (string user in depusers)
                         {   
                             //如果是部门责任人，则添加到部门责任人用户depLeader中，否则添加到已分配部门用户assignUser中
                             if (AutofacConfig.departmentService.IsLeader(user) == true)
                             {
                                 UserDetailDto userd = AutofacConfig.userService.GetUserByUserID(user);
                                 if (string.IsNullOrEmpty(depLeader) == true)
                                 {                  
                                     depLeader = userd.U_Name ;
                                 }
                                 else
                                 {
                                     depLeader += "," + userd.U_Name;
                                 }

                             }
                             else
                             {
                                 if (string.IsNullOrEmpty(assignUser) == true)
                                 {
                                     assignUser = user;
                                 }
                                 else
                                 {
                                     assignUser += "," + user;
                                 }
                             }
                         }
                     }
                    //编辑部门时，判断选中用户是否为部门责任人和是否为已分配部门成员
                    if (string.IsNullOrEmpty(department.Dep_ID) == false )
                    {
                        foreach (string user in depusers)
                        {    
                            UserDetailDto userd = AutofacConfig.userService.GetUserByUserID(user);
                            if (!department.Dep_ID.Equals(userd.U_DepID))
                            {
                                //如果是部门责任人，则添加到部门责任人用户depLeader中，否则添加到已分配部门用户assignUser中
                                if (AutofacConfig.departmentService.IsLeader(user) == true)
                                {

                                    if (string.IsNullOrEmpty(depLeader) == true)
                                    {
                                        depLeader = userd.U_Name;
                                    }
                                    else
                                    {
                                        depLeader += "," + userd.U_Name;
                                   }
                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(assignUser) == true)
                                    {
                                        assignUser = user;
                                    }
                                    else
                                    {
                                        assignUser += "," + user;
                                    }
                                }
                            }
                      }
                    }
                    if (listselectuserdep.Count >0 & string.IsNullOrEmpty(assignUser) == false)
                    {

                        string[] assignUsers = assignUser.Split(',');
                        string assignUser1 = "";
                        foreach (string depNO in listselectuserdep)
                        {
                            string assignU = "";
                            foreach (string user in assignUsers)
                           {
                               UserDetailDto userd = AutofacConfig.userService.GetUserByUserID(user);
                               if (user != null)
                               {
                                   if (userd.U_DepID.Equals(depNO))
                                   {
                                       if (string.IsNullOrEmpty(assignU) == true)
                                       {
                                           assignU = userd.U_Name ;
                                       }
                                       else
                                       {
                                           assignU += "," + userd.U_Name;
                                       }
                                   }
                               }
                           }
                            if (string.IsNullOrEmpty(assignU) == false)
                            {
                                if (string.IsNullOrEmpty(assignU) == false)
                                {
                                    assignUser1 = assignU + "已是" + AutofacConfig.departmentService.GetDepartmentByDepID(depNO).Dep_Name + "部门成员";
                                }
                                else
                                {
                                    assignUser1 +="；"+ assignU + "已是" + AutofacConfig.departmentService.GetDepartmentByDepID(depNO).Dep_Name + "部门成员";
                                }
                            }
                        }
                        assignUser = assignUser1;
                    }
                }
                if (string.IsNullOrEmpty(depLeader) == false)
                {
                    throw new Exception(depLeader+"已是部门责任人，请先解散部门！");
                }
                //bool isUPdateDep = false; //是否更新部门人员
                ReturnInfo result;
                if (string.IsNullOrEmpty(assignUser) == false)
                {
                    MessageBox.Show(assignUser+"是否分配？", "分配人员", MessageBoxButtons.YesNo, (Object s, MessageBoxHandlerArgs args) =>
                    {
                        if (args.Result ==  Smobiler.Core.Controls .ShowResult.Yes)
                        {
                            //isUPdateDep = true;
                            department.UserIDs = listUser;
                            if (department.Dep_ID != null)
                            {
                              
                                result = AutofacConfig.departmentService.UpdateDepartment(department);
                            }
                            else
                            {
                              
                                result = AutofacConfig.departmentService.AddDepartment(department);
                            }
                            if (result.IsSuccess == false)
                            {
                                throw new Exception(result.ErrorInfo);
                            }
                            else
                            {
                                ShowResult = ShowResult.Yes;
                                Close();
                                Toast("部门人员分配成功！", ToastLength.SHORT);
                            }
                        }
                    }
                      );
                }
                else
                {
                 
                    department.UserIDs = listUser;
                    if (department.Dep_ID != null)
                    {
                     
                        result = AutofacConfig.departmentService.UpdateDepartment(department);
                    }
                    else
                    {
                     
                        result = AutofacConfig.departmentService.AddDepartment(department);
                    }
                    if (result.IsSuccess == false)
                    {
                        throw new Exception(result.ErrorInfo);
                    }
                    else
                    {
                        ShowResult = ShowResult.Yes;
                        Close();
                        Toast("部门人员分配成功！", ToastLength.SHORT);
                    }
                }
              
            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }
        }
       
        /// <summary>
        /// 全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAll_Click(object sender, EventArgs e)
        {
            if (checkAll.Checked)
            {
                checkAll.Checked = false;
            }
            else
            {
                checkAll.Checked = true ;
            }
            Checkall();
        }
        /// <summary>
        /// 全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkAll_CheckChanged(object sender, EventArgs e)
        {
            Checkall();
        }
        ///// <summary>
        ///// ListView点击事件
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void gridView1_ItemClick(object sender, GridViewCellItemEventArgs e)
        //{
        //    upCheckState();
        //}
        /// <summary>
        /// 更新全选状态
        /// </summary>
        private void upCheckState()
        {
             selectUserQty = 0;
            foreach (ListViewRow rows in gridUserData.Rows)
            {
                if (Convert.ToBoolean(((frmDepAssignUserLayout)(rows.Control)).Check.BindDisplayValue) == true)
                {
                    selectUserQty += 1;
                }
            }
            //当ListView行项选中条数等于ListView行数时，为全选状态，否则为不选状态。
            if (selectUserQty == gridUserData.Rows.Count)
            {
                checkAll.Checked = true;
            }
            else
            {
                checkAll.Checked = false;
            }
        }
        ///// <summary>
        ///// ListView点击事件
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void gridView1_CellClick(object sender, GridViewCellEventArgs e)
        //{
        //    switch (Convert .ToBoolean (e.Cell.Items["Check"].DefaultValue))
        //    {
        //        case true :
        //            e.Cell.Items["Check"].DefaultValue = false;
        //            break;
        //        case false :
        //            e.Cell.Items["Check"].DefaultValue = true;
        //            break;
        //    }
        //    upCheckState();
        //}

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
                if (string .IsNullOrEmpty (department .Dep_Leader)==false )
                {
                    if (department.Dep_Leader.Trim().Equals(user.U_ID))
                    {
                        popLeader.SetSelections(poli.Items[(poli.Items.Count - 1)]);
                    }
                }
            }
            popLeader.Show();
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
                    bool isLeader = AutofacConfig.departmentService.IsLeader(popLeader.Selection.Value);
                    //如果该选中责任人已是部门责任人，则报错
                    if (isLeader == true)
                    {
                        throw new Exception(popLeader.Selection.Text + "已是部门责任人，请先解散部门！");
                    }
                    //
                    UserDepDto userdep = AutofacConfig.userService.GetUseDepByUserID(popLeader.Selection.Value);
                    //如果选中用户已是部门成员且不是部门责任人，则进行选择是否确认为部门责任人，若确认则为该部门负责人
                    if (userdep != null & string.IsNullOrEmpty(userdep.Dep_ID) == false & isLeader == false)
                        //if (AutofacConfig.userService.GetAllUsers().Count > 0 & isLeader== false)
                        //{
                        MessageBox.Show(popLeader.Selection.Text + "已是部门成员，是否确定为该部门责任人？", MessageBoxButtons.YesNo, (Object s1, MessageBoxHandlerArgs args) =>
                        {
                            //此委托为异步委托事件
                            if (args.Result == Smobiler.Core.Controls .ShowResult.Yes)
                            {
                                department.Dep_Leader = popLeader.Selection.Value;
                                btnLeader.Text = popLeader.Selection.Text + "   > ";
                            }
                        });
                    //}
                    //如果选中用户不是部门责任人且不是部门成员，则为该部门负责人
                    if (isLeader == false & userdep != null & string.IsNullOrEmpty(userdep.Dep_ID) == true)
                    {
                        department.Dep_Leader = popLeader.Selection.Value;
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
        /// 保存并赋值头像
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cameraPortrait_ImageCaptured(object sender, BinaryResultArgs e)
        {
            if (string.IsNullOrEmpty(e.error))
            {

                if (imgPortrait.ResourceID.Trim().Length > 0 & string.IsNullOrEmpty(department.Dep_Icon) == false)
                {
                    e.SaveFile(department.Dep_Icon);
                    imgPortrait.ResourceID = department.Dep_Icon;
                    imgPortrait.Refresh();
                }
                else
                {
                    e.SaveFile(e.ResourceID);
                    department.Dep_Icon = e.ResourceID;
                    imgPortrait.ResourceID = e.ResourceID;
                    imgPortrait.Refresh();
                }
            }
        }

        private void title1_Load(object sender, EventArgs e)
        {

        }
    }
}