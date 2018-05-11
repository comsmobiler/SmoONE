using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SmoONE.DTOs;
using SmoONE.UI.Attendance;
using SmoONE.UI.Layout;

namespace SmoONE.UI.Attendance
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2016/11
    // 主要内容： 考勤用户选中界面
    // ******************************************************************
    partial class frmATUser : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        public  int selectUserQty = 0;//选中人员数
        public string ATNo;//考勤模板编号
        public string  selectUser;//选中人员
        #endregion
        /// <summary>
        /// ListView点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void gridATData_CellClick(object sender, GridViewCellEventArgs e)
        //{
        //    switch (Convert.ToBoolean(e.Cell.Items["Check"].DefaultValue))
        //    {
        //        case true:
        //            e.Cell.Items["Check"].DefaultValue = false;
        //            break;
        //        case false:
        //            e.Cell.Items["Check"].DefaultValue = true;
        //            break;
        //    }
        //    upCheckState();
        //}
        /// <summary>
        /// 获取用户
        /// </summary>
        private void GetATUser()
        {
            try
            {         
                List<DataGridviewbyUser> listATUser = new List<DataGridviewbyUser>();//考勤用户集合
                //如果有考勤选中用户，则添加到考勤用户集合listATUser，并默认用户状态为选中
                if (string.IsNullOrEmpty(selectUser) == false)
                {
                    string[] selectUsers = selectUser.Split(',');
                    foreach (string user in selectUsers)
                    {
                        //UserDetailDto userdto = AutofacConfig.userService.GetUserByUserID(user);
                        UserDetails userDetails = new UserDetails();
                        UserDetailDto userdto = userDetails.getUser(user);
                        if (userdto != null)
                        {
                            DataGridviewbyUser atUser = new DataGridviewbyUser();
                            atUser.U_ID = userdto.U_ID;
                            atUser.U_Name = userdto.U_Name;
                            atUser.U_Portrait = userdto.U_Portrait;
                            string depID = "";
                            string depName = "";
                            if (string.IsNullOrEmpty(userdto.U_DepID))
                            {
                                DepDetailDto department = AutofacConfig.departmentService.GetDepartmentByDepID(userdto.U_DepID);
                                if (department != null)
                                {
                                    depID = department.Dep_ID;
                                    depID = department.Dep_Name;
                                }
                            }
                            atUser.U_DepID = depID;
                            atUser.U_DepName = depName;
                            atUser.SelectCheck = true;
                            listATUser.Add(atUser);
                        }
                    }
                }
              
                //编辑考勤模板且现考勤选中用户不包含当前考勤成员时，添加考勤用户到集合listATUser，并将用户状态默认为未选中
                if (string.IsNullOrEmpty(ATNo) == false)
                {
                    List<UserDto> listUser = AutofacConfig.attendanceService.GetATUser(ATNo);
                    if (listUser.Count > 0)
                    {
                        foreach (UserDto user in listUser)
                        {
                            if (!(string.IsNullOrEmpty(selectUser) == false & selectUser.Split(',').Contains(user.U_ID) == true))
                            {
                           
                                DataGridviewbyUser atUser = new DataGridviewbyUser();
                                atUser.U_ID = user.U_ID;
                                atUser.U_Name = user.U_Name;
                                if (string.IsNullOrEmpty(user.U_Portrait) == true)
                                {
                                    switch (user.U_Sex)
                                    {
                                        case (int)Sex.男:
                                            atUser.U_Portrait = "boy";
                                            break;
                                        case (int)Sex.女:
                                            atUser.U_Portrait = "girl";
                                            break;
                                    }
                                }
                                else
                                {
                                    atUser.U_Portrait = user.U_Portrait;
                                }
                                string depID = "";
                                string depName = "";
                                if (string.IsNullOrEmpty(user.U_DepID))
                                {
                                    DepDetailDto department = AutofacConfig.departmentService.GetDepartmentByDepID(user.U_DepID);
                                    if (department != null)
                                    {
                                        depID = department.Dep_ID;
                                        depID = department.Dep_Name;
                                    }
                                }
                                atUser.U_DepID = depID;
                                atUser.U_DepName = depName;
                                atUser.SelectCheck = false;
                                listATUser.Add(atUser);
                            }
                        }
                    }
                }
               

                //如果未分配考勤模板的用户大于0时，添加到考勤用户集合listATUser     
                List<UserDto> listNoATUser = AutofacConfig.attendanceService.GetNoATUser();
                if (listNoATUser.Count > 0)
                {
                    foreach (UserDto user in listNoATUser)
                    {
                        if ((string.IsNullOrEmpty(selectUser) == true )|| (string.IsNullOrEmpty(selectUser) == false & selectUser.Split(',').Contains(user.U_ID)==false ))
                        {
                            DataGridviewbyUser atUser = new DataGridviewbyUser();
                            atUser.U_ID = user.U_ID;
                            atUser.U_Name = user.U_Name;
                            if (string.IsNullOrEmpty(user.U_Portrait) == true)
                            {
                                switch (user.U_Sex)
                                {
                                    case (int)Sex.男:
                                        atUser.U_Portrait = "boy";
                                        break;
                                    case (int)Sex.女:
                                        atUser.U_Portrait = "girl";
                                        break;
                                }
                            }
                            else
                            {
                                atUser.U_Portrait = user.U_Portrait;
                            }
                            string depID = "";
                            string depName = "";
                            if (string.IsNullOrEmpty(user.U_DepID))
                            {
                                DepDetailDto department = AutofacConfig.departmentService.GetDepartmentByDepID(user.U_DepID);
                                if (department != null)
                                {
                                    depID = department.Dep_ID;
                                    depID = department.Dep_Name;
                                }
                            }
                            atUser.U_DepID = depID;
                            atUser.U_DepName = depName;
                            atUser.SelectCheck = false;
                            listATUser.Add(atUser);
                        }
                    }
                }
                gridATUserData.Rows.Clear();//清空人员列表数据
                if (listATUser.Count > 0)
                {
                   
                    gridATUserData.DataSource = listATUser; //绑定ListView数据
                    gridATUserData.DataBind();
                    upCheckState();
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAll_Click(object sender, EventArgs e)
        {
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
        /// <summary>
        /// 全选方法
        /// </summary>
        private void Checkall()
        {
            switch (checkAll1.Checked)
            {
                case true:
                    foreach (ListViewRow rows in gridATUserData.Rows)
                    {
                       // rows.Cell.Items["Check"].DefaultValue = true;
                        ((frmATUserLayout)(rows.Control)).Check.BindDisplayValue = true;

                    }
                    selectUserQty = gridATUserData.Rows.Count;
                    break;
                case false:
                    foreach (ListViewRow rows in gridATUserData.Rows)
                    {
                      //  rows.Cell.Items["Check"].DefaultValue = false;
                        ((frmATUserLayout)(rows.Control)).Check.BindDisplayValue =false ;

                    }
                    selectUserQty = 0;
                    break;
            }
            //更新选中人员数描述
            upSelectUserFoot();
        }
        /// <summary>
        /// 更新全选状态
        /// </summary>
        public  void upCheckState()
        {
            selectUserQty = 0;
            foreach (ListViewRow rows in gridATUserData.Rows)
            {


                if (Convert.ToBoolean(((frmATUserLayout)(rows.Control)).Check.BindDisplayValue) == true)
                {
                    selectUserQty += 1;
                }
            }
            //当ListView行项选中条数等于ListView行数时，为全选状态，否则为不选状态。
            if (selectUserQty == gridATUserData.Rows.Count)
            {
                checkAll1.Checked = true;
            }
            else
            {
                checkAll1.Checked = false;
            }
            //更新选中人员数描述
            upSelectUserFoot();
        }
        /// <summary>
        /// 更新选中人员数描述
        /// </summary>
        private void upSelectUserFoot()
        {
            try
            {
                if (selectUserQty > 0)
                {
                   // FooterBarLayoutData.Items["btnSave"].BackColor = System.Drawing.Color.FromArgb(43, 146, 223);
                    //FooterBarLayoutData.Items["btnSave"].Enabled = true;
                    frmATFootLayout1.btnSave.BackColor = System.Drawing.Color.FromArgb(43, 146, 223);
                    frmATFootLayout1.btnSave.Enabled = true;

                }
                else
                {
                   // FooterBarLayoutData.Items["btnSave"].BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
                   // FooterBarLayoutData.Items["btnSave"].Enabled = false;

                    frmATFootLayout1.btnSave.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
                    frmATFootLayout1.btnSave.Enabled = false;
                }
                //FooterBarLayoutData.Items["lblDesc"].DefaultValue = "已选中 " + selectUserQty.ToString() + " 人";
                frmATFootLayout1.lblDesc.Text = "已选中 " + selectUserQty.ToString() + " 人";

            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }
        }
        /////// <summary>
        /////// ListView点击事件
        /////// </summary>
        /////// <param name="sender"></param>
        /////// <param name="e"></param>
        ////private void gridATData_ItemClick(object sender, GridViewCellItemEventArgs e)
        ////{
        ////    upCheckState();
        ////}

      
        /// <summary>
        /// 初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmATUser_Load(object sender, EventArgs e)
        {
            GetATUser();
        }

        private void frmATUser_KeyDown(object sender, KeyDownEventArgs e)
        {
            Close();
        }

        private void frmATUser_TitleImageClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}