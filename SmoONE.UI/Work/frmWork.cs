using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SmoONE.UI;
using SmoONE.Domain;
using SmoONE.UI.UserInfo;
using SmoONE.DTOs;

namespace SmoONE.UI.Work
{
    // ******************************************************************
    // 文件版本： SmoONE 2.0
    // Copyright  (c)  2017-2018 Smobiler 
    // 创建时间： 2017/07
    // 主要内容：  工作界面
    // ******************************************************************
    partial class frmWork : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        /// <summary>
        /// 菜单组字典
        /// </summary>
        /// <remarks></remarks>
        private Dictionary<string, IconMenuViewGroup> MenuGroupDict;//二级菜单
        private DateTime toasttime;//toast时间
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion

        /// <summary>
        /// IconMenuDate点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iconMenuData_ItemPress(object sender, IconMenuViewItemPressEventArgs e)
        {
            MenuItem(e.Item.ID);
           
        }
        /// <summary>
        /// 菜单点击事件方法
        /// </summary>
        /// <param name="id"></param>
        private void MenuItem(string id)
        {
            if (MenuGroupDict.ContainsKey(id) == true)
            {
                //显示当前菜单的二级菜单
                this.iconMenuData.ShowDialogMenu(MenuGroupDict[id]);
            }
            else
            {
                switch (id)
                {
                    //创建请假
                    case "Leave":
                        Leave.frmLeaveCreate frmLeaveCreate = new Leave.frmLeaveCreate();
                        //请假创建界面添加侧滑关闭功能，在Show中将设置moveClose为True
                        Show(frmLeaveCreate,true);
                        break;
                    //创建报销
                    case "Reimbursement":
                        RB.frmRBCreate frmRBCreate = new RB.frmRBCreate();
                        Show(frmRBCreate);
                        break;
                    //创建消费记录
                    case "RB_Rows":
                        RB.frmRBRows frmRBRows = new RB.frmRBRows();
                        Show(frmRBRows);
                        break;
                    //创建消费记录模板
                    case "RB_RType_Template":
                        RB.frmRTypeTemplate frmRTypeTemplate = new RB.frmRTypeTemplate();
                        Show(frmRTypeTemplate);
                        break;
                    //创建部门
                    case "Department":
                        Department.frmDepartment frmDepartment = new Department.frmDepartment();
                        Show(frmDepartment);
                        break;
                    //创建成本中心
                    case "CostCenter":
                        CostCenter.frmCostCenter frmCostCenter = new CostCenter.frmCostCenter();
                        Show(frmCostCenter);
                        break;
                        //成本中心分析
                    case "CCFX":
                        CostCenter.frmCostCenterFX frmCostCenterFX = new CostCenter.frmCostCenterFX();
                        Show(frmCostCenterFX);
                        break;
                    //创建成本中心模板
                    case "CC_Type_Template":
                        CostCenter.frmCostTemplet frmCostTemplet = new CostCenter.frmCostTemplet();
                        Show(frmCostTemplet);
                        break;
                    //考勤管理模板
                    case "AttendanceManagement":
                        Attendance.frmAttendanceManager frmAttendanceManager = new Attendance.frmAttendanceManager();
                        Show(frmAttendanceManager);
                        break;
                    //考勤
                    case "AttendanceInfo":
                        Attendance.frmAttendanceMain frmAttendanceMain = new Attendance.frmAttendanceMain();
                        frmAttendanceMain.enter = (int)Enum.Parse(typeof(ATMainState), ATMainState.考勤签到.ToString());
                        Show(frmAttendanceMain);
                        break;
                    //我的考勤历史
                    case "MyAttendanceHistory":
                        Attendance.frmAttendanceStatSelfDay frmAttendanceStatSelfDay = new Attendance.frmAttendanceStatSelfDay();
                        Show(frmAttendanceStatSelfDay);
                        break;
                    //考勤统计
                    case "AttendanceStatistics":
                        Attendance.frmAttendanceStatistics frmAttendanceStatistics = new Attendance.frmAttendanceStatistics();
                        Show(frmAttendanceStatistics);
                        break;
                    //IM
                    case "IM":
                        SmoONE.UI.Im.frmConcent frmConcent = new SmoONE.UI.Im.frmConcent();
                        Show(frmConcent);
                        break;
                    //文件上传
                    case "FileUp":
                        SmoONE.UI.FileUp.frmFile frmFile = new SmoONE.UI.FileUp.frmFile ();
                        Show(frmFile);
                        break;
                }
            }
        }
        /// <summary>
        /// Toolbar方法
        /// </summary>
        /// <param name="toolbarItemName"></param>
        private void ProcessToolbarFormName(string toolbarItemName)
        {
            try
            {
                switch (toolbarItemName)
                {
                    case "":
                        this.Close();
                        break;
                    case "Me":
                        frmUser frm = new frmUser();
                        this.Show(frm, (MobileForm sender1, object args) =>
                        {
                            ProcessToolbarFormName(frm.toolbarItemName);
                            UI.Layout.LeftPage lp = this.Drawer as UI.Layout.LeftPage;
                            lp.getUser();
                        }
                        );
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Toolbar点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolBar1_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            ProcessToolbarFormName(e.Name);
            
        }
        /// <summary>
        /// 手机自带回退按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmWork_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                HandleToast();
            }
        }
        /// <summary>
        /// Toast
        /// </summary>
        private void HandleToast()
        {
            if (toasttime.AddSeconds(3) >= DateTime.Now)
            {
                this.Client.Exit();
            }
            else
            {
                toasttime = DateTime.Now;
                this.Toast("再按一次退出系统", ToastLength.SHORT);
            }
        }
        /// <summary>
        /// 初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmWork_Load(object sender, EventArgs e)
        {
           
          //  this.DrawerWidth = (int)Math.Floor(260 * (float)((this.Client.ScreenSize.Width / this.Client.ScreenDensity) / this.Width));
            MenuGroupDict = new Dictionary<string, IconMenuViewGroup>();
            //获取菜单
            MenuGroup();
           CreateScreenGestures();
        }
        /// <summary>
        ///获取菜单
        /// </summary>
        private void MenuGroup()
        {
            try
            {
                List<Menu> listmenu = AutofacConfig.userService.GetMenuByUserID(Client.Session["U_ID"].ToString());
                this.iconMenuData.Groups.Clear();
                MenuGroupDict.Clear();
                IconMenuViewGroup grp = new IconMenuViewGroup("");
                //获取所有菜单组
                foreach (Menu menu in listmenu)
                {
                    if (string.IsNullOrWhiteSpace(menu.M_ParentID) == true)
                    {
                        //添加一级菜单
                        grp.Items.Add(new IconMenuViewItem(menu.M_MenuID, menu.M_Portrait, menu.M_Description, menu.M_MenuID));
                        //添加二级菜单
                        List<Menu> listsecondMenu = AutofacConfig.userService.GetSubMenuByUserID(Client.Session["U_ID"].ToString(), menu.M_MenuID);
                        if (listsecondMenu.Count > 0)
                        {
                            Menu menuItem = AutofacConfig.userService.GetMenuByMenuID(menu.M_MenuID);
                            IconMenuViewGroup mvGroupItem = new IconMenuViewGroup(menuItem.M_Description);
                            foreach (Menu secondMenu in listsecondMenu)
                            {
                                mvGroupItem.Items.Add(new IconMenuViewItem(secondMenu.M_MenuID, secondMenu.M_Portrait, secondMenu.M_Description, secondMenu.M_MenuID));
                                if (MenuGroupDict.ContainsKey(menu.M_MenuID) == false)
                                    MenuGroupDict.Add(menu.M_MenuID, mvGroupItem);
                            }
                        }
                    }
                }
                this.iconMenuData.Groups.Add(grp);
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void plShenPi_Press(object sender, EventArgs e)
        {
            frmCheck frmCheck = new frmCheck();
            Show(frmCheck);
        }

        private void plFaQi_Press(object sender, EventArgs e)
        {
            frmCreated frmCreated = new frmCreated();
            Show(frmCreated);
        }

        private void plChaoSong_Press(object sender, EventArgs e)
        {
            frmCCTo frmCCTo = new frmCCTo();
            Show(frmCCTo);
        }


        /// <summary>
        /// 创建手势
        /// </summary>
        /// <remarks></remarks>
        private void CreateScreenGestures()
        {
            this.Client.Pattern.Password = null;
            UserDetailDto user = AutofacConfig.userService.GetUserByUserID(Client.Session["U_ID"].ToString());
            if (user != null)
            {
                if (string.IsNullOrEmpty(user.U_Gestures) == false)
                {
                    this.Client.Pattern.Password = user.U_Gestures;
                }
            }
            else
            {
                Toast("用户" + Client.Session["U_ID"].ToString() + "不存在！", ToastLength.SHORT);
            }


            if (string .IsNullOrEmpty (this.Client.Pattern.Password ) == true || string.IsNullOrWhiteSpace(this.Client.Pattern.Password) == true)
            {
                this.Client.Pattern.Create((object s1, Smobiler.Core.RPC .PatternCreatedEventArgs ee) =>
                {
                    if (ee.isError == true)
                    {
                        Toast (ee.error,ToastLength.SHORT);
                    }
                    else
                    {
                        if (string.IsNullOrWhiteSpace(ee.Password) == false)
                        {
                            try
                            {
                                this.Client.Pattern.Password = ee.Password;
                                //数据库赋值
                                UserInputDto upuser = new UserInputDto();
                                upuser.U_ID = Client.Session["U_ID"].ToString();
                                upuser.U_Gestures = Client.Pattern.Password;
                                CommLib.ReturnInfo result = AutofacConfig.userService.UpdateUser(upuser);
                                if (result.IsSuccess == false )
                                {
                                    Toast(result.ErrorInfo, ToastLength.SHORT);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                        }
                    }
                });
            }
           
        }
        /// <summary>
        /// 显示侧边栏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void title1_ImagePress(object sender, EventArgs e)
        {
            OpenDrawer();
        }
        /// <summary>
        /// action事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmWork_ActionButtonPress(object sender, ActionButtonPressEventArgs e)
        {
            try
            {
                switch (e.Index )
                {
                    //创建请假
                    case 0:
                        Leave.frmLeaveCreate frmLeaveCreate = new Leave.frmLeaveCreate();
                        Show(frmLeaveCreate);
                        break;
                    //创建消费记录
                    case 1:
                        RB.frmRBRows frmRBRows = new RB.frmRBRows();
                        Show(frmRBRows);
                        break;
                    //创建报销
                    case 2:
                        RB.frmRBCreate frmRBCreate = new RB.frmRBCreate();
                        Show(frmRBCreate);
                        break;                   
                  
                }
            }
            catch(Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }
        }
    }
}