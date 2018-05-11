using System;
using Smobiler.Core;
using SmoONE.UI.Layout;

namespace SmoONE.UI.UserInfo
{
    partial class frmUser : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmUser()
            : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call
        }

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm
        //It can be modified using the SmobilerForm.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            Smobiler.Core.Controls.ToolBarItem toolBarItem1 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem2 = new Smobiler.Core.Controls.ToolBarItem();
            this.cameraPortrait = new Smobiler.Core.Controls.Camera();
            this.popSex = new Smobiler.Core.Controls.PopList();
            this.plPortrait = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.imgPortrait = new Smobiler.Core.Controls.Image();
            this.cameraButton1 = new Smobiler.Core.Controls.CameraButton();
            this.plName = new Smobiler.Core.Controls.Panel();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.btnName = new Smobiler.Core.Controls.Button();
            this.btnName1 = new Smobiler.Core.Controls.Button();
            this.plSex = new Smobiler.Core.Controls.Panel();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.btnSex = new Smobiler.Core.Controls.Button();
            this.btnSex1 = new Smobiler.Core.Controls.Button();
            this.plBirthday = new Smobiler.Core.Controls.Panel();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.dpkBirthday = new Smobiler.Core.Controls.DatePicker();
            this.plEmail = new Smobiler.Core.Controls.Panel();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.btnEmail = new Smobiler.Core.Controls.Button();
            this.btnEmail1 = new Smobiler.Core.Controls.Button();
            this.btnPwd = new Smobiler.Core.Controls.Button();
            this.btnExit = new Smobiler.Core.Controls.Button();
            this.menuTitle1 = new SmoONE.UI.Layout.MenuTitle();
            this.spContent = new Smobiler.Core.Controls.Panel();
            this.toolBar = new Smobiler.Core.Controls.ToolBar();
            // 
            // cameraPortrait
            // 
            this.cameraPortrait.Name = "cameraPortrait";
            this.cameraPortrait.ImageCaptured += new Smobiler.Core.Controls.CameraOnlineCallBackHandler(this.cameraPortrait_ImageCaptured);
            // 
            // popSex
            // 
            this.popSex.Name = "popSex";
            this.popSex.Selected += new System.EventHandler(this.popSex_Selected);
            // 
            // plPortrait
            // 
            this.plPortrait.BackColor = System.Drawing.Color.White;
            this.plPortrait.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.plPortrait.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plPortrait.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.imgPortrait,
            this.cameraButton1});
            this.plPortrait.Name = "plPortrait";
            this.plPortrait.Size = new System.Drawing.Size(300, 45);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label1.Size = new System.Drawing.Size(265, 45);
            this.label1.Text = "头像";
            // 
            // imgPortrait
            // 
            this.imgPortrait.BorderRadius = 20;
            this.imgPortrait.Location = new System.Drawing.Point(224, 0);
            this.imgPortrait.Name = "imgPortrait";
            this.imgPortrait.Size = new System.Drawing.Size(40, 40);
            this.imgPortrait.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Cover;
            this.imgPortrait.Visible = false;
            this.imgPortrait.Zooming = true;
            // 
            // cameraButton1
            // 
            this.cameraButton1.AllowEdit = true;
            this.cameraButton1.DataMember = null;
            this.cameraButton1.DisplayFormat = null;
            this.cameraButton1.DisplayMember = null;
            this.cameraButton1.ImageBorderRadius = 18;
            this.cameraButton1.Location = new System.Drawing.Point(254, 4);
            this.cameraButton1.Name = "cameraButton1";
            this.cameraButton1.ResourceID = "Camera";
            this.cameraButton1.Size = new System.Drawing.Size(36, 36);
            this.cameraButton1.ImageCaptured += new Smobiler.Core.Controls.CameraOnlineCallBackHandler(this.cameraPortrait_ImageCaptured);
            // 
            // plName
            // 
            this.plName.BackColor = System.Drawing.Color.White;
            this.plName.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plName.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label2,
            this.btnName,
            this.btnName1});
            this.plName.Location = new System.Drawing.Point(0, 45);
            this.plName.Name = "plName";
            this.plName.Size = new System.Drawing.Size(300, 45);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label2.Size = new System.Drawing.Size(265, 20);
            this.label2.Text = "昵称";
            // 
            // btnName
            // 
            this.btnName.BackColor = System.Drawing.Color.Transparent;
            this.btnName.BorderRadius = 0;
            this.btnName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnName.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Left;
            this.btnName.Location = new System.Drawing.Point(0, 20);
            this.btnName.Name = "btnName";
            this.btnName.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.btnName.Size = new System.Drawing.Size(265, 25);
            this.btnName.Press += new System.EventHandler(this.btnName_Press);
            // 
            // btnName1
            // 
            this.btnName1.BackColor = System.Drawing.Color.Transparent;
            this.btnName1.BorderRadius = 0;
            this.btnName1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnName1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnName1.Location = new System.Drawing.Point(265, 0);
            this.btnName1.Name = "btnName1";
            this.btnName1.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.btnName1.Size = new System.Drawing.Size(35, 45);
            this.btnName1.Text = ">";
            this.btnName1.Press += new System.EventHandler(this.btnName_Press);
            // 
            // plSex
            // 
            this.plSex.BackColor = System.Drawing.Color.White;
            this.plSex.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plSex.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plSex.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label3,
            this.btnSex,
            this.btnSex1});
            this.plSex.Location = new System.Drawing.Point(0, 90);
            this.plSex.Name = "plSex";
            this.plSex.Size = new System.Drawing.Size(300, 45);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Name = "label3";
            this.label3.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label3.Size = new System.Drawing.Size(265, 20);
            this.label3.Text = "性别";
            // 
            // btnSex
            // 
            this.btnSex.BackColor = System.Drawing.Color.Transparent;
            this.btnSex.BorderRadius = 0;
            this.btnSex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnSex.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Left;
            this.btnSex.Location = new System.Drawing.Point(0, 20);
            this.btnSex.Name = "btnSex";
            this.btnSex.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.btnSex.Size = new System.Drawing.Size(265, 25);
            this.btnSex.Press += new System.EventHandler(this.btnSex_Press);
            // 
            // btnSex1
            // 
            this.btnSex1.BackColor = System.Drawing.Color.Transparent;
            this.btnSex1.BorderRadius = 0;
            this.btnSex1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnSex1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnSex1.Location = new System.Drawing.Point(265, 0);
            this.btnSex1.Name = "btnSex1";
            this.btnSex1.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.btnSex1.Size = new System.Drawing.Size(35, 45);
            this.btnSex1.Text = ">";
            this.btnSex1.Press += new System.EventHandler(this.btnSex_Press);
            // 
            // plBirthday
            // 
            this.plBirthday.BackColor = System.Drawing.Color.White;
            this.plBirthday.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plBirthday.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plBirthday.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label4,
            this.dpkBirthday});
            this.plBirthday.Location = new System.Drawing.Point(0, 135);
            this.plBirthday.Name = "plBirthday";
            this.plBirthday.Size = new System.Drawing.Size(300, 45);
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Name = "label4";
            this.label4.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label4.Size = new System.Drawing.Size(300, 20);
            this.label4.Text = "生日";
            // 
            // dpkBirthday
            // 
            this.dpkBirthday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.dpkBirthday.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Left;
            this.dpkBirthday.Location = new System.Drawing.Point(0, 20);
            this.dpkBirthday.Name = "dpkBirthday";
            this.dpkBirthday.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 4F, 0F);
            this.dpkBirthday.Size = new System.Drawing.Size(300, 25);
            this.dpkBirthday.Value = new System.DateTime(2017, 8, 10, 14, 32, 56, 666);
            this.dpkBirthday.ValueChanged += new System.EventHandler(this.dpkBirthday_DateChanged);
            // 
            // plEmail
            // 
            this.plEmail.BackColor = System.Drawing.Color.White;
            this.plEmail.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plEmail.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label5,
            this.btnEmail,
            this.btnEmail1});
            this.plEmail.Location = new System.Drawing.Point(0, 180);
            this.plEmail.Name = "plEmail";
            this.plEmail.Size = new System.Drawing.Size(300, 45);
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Name = "label5";
            this.label5.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label5.Size = new System.Drawing.Size(265, 20);
            this.label5.Text = "邮件";
            // 
            // btnEmail
            // 
            this.btnEmail.BackColor = System.Drawing.Color.Transparent;
            this.btnEmail.BorderRadius = 0;
            this.btnEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnEmail.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Left;
            this.btnEmail.Location = new System.Drawing.Point(0, 20);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.btnEmail.Size = new System.Drawing.Size(265, 25);
            this.btnEmail.Press += new System.EventHandler(this.btnEmail_Press);
            // 
            // btnEmail1
            // 
            this.btnEmail1.BackColor = System.Drawing.Color.Transparent;
            this.btnEmail1.BorderRadius = 0;
            this.btnEmail1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnEmail1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnEmail1.Location = new System.Drawing.Point(265, 0);
            this.btnEmail1.Name = "btnEmail1";
            this.btnEmail1.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.btnEmail1.Size = new System.Drawing.Size(35, 45);
            this.btnEmail1.Text = ">";
            this.btnEmail1.Press += new System.EventHandler(this.btnEmail_Press);
            // 
            // btnPwd
            // 
            this.btnPwd.BackColor = System.Drawing.Color.White;
            this.btnPwd.BorderColor = System.Drawing.Color.LightGray;
            this.btnPwd.BorderRadius = 0;
            this.btnPwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnPwd.Location = new System.Drawing.Point(0, 235);
            this.btnPwd.Name = "btnPwd";
            this.btnPwd.Size = new System.Drawing.Size(300, 35);
            this.btnPwd.Text = "登录密码修改";
            this.btnPwd.Press += new System.EventHandler(this.btnPwd_Press);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.BorderRadius = 0;
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(0, 280);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(300, 35);
            this.btnExit.Text = "退出";
            this.btnExit.Press += new System.EventHandler(this.btnExit_Press);
            // 
            // menuTitle1
            // 
            this.menuTitle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.menuTitle1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.menuTitle1.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuTitle1.Location = new System.Drawing.Point(75, 67);
            this.menuTitle1.Name = "menuTitle1";
            this.menuTitle1.Size = new System.Drawing.Size(100, 50);
            this.menuTitle1.TitleText = "我的";
            // 
            // spContent
            // 
            this.spContent.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plPortrait,
            this.plName,
            this.plSex,
            this.plBirthday,
            this.plEmail,
            this.btnPwd,
            this.btnExit});
            this.spContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spContent.Location = new System.Drawing.Point(138, 123);
            this.spContent.Margin = new Smobiler.Core.Controls.Margin(0F, 10F, 0F, 0F);
            this.spContent.Name = "spContent";
            this.spContent.Scrollable = true;
            this.spContent.Size = new System.Drawing.Size(100, 30);
            // 
            // toolBar
            // 
            this.toolBar.BackColor = System.Drawing.Color.White;
            toolBarItem1.IconID = "work";
            toolBarItem1.Name = "Work";
            toolBarItem1.SelectIconID = "work";
            toolBarItem2.IconID = "me2";
            toolBarItem2.Name = "Me";
            toolBarItem2.SelectIconID = "me2";
            this.toolBar.Items.AddRange(new Smobiler.Core.Controls.ToolBarItem[] {
            toolBarItem1,
            toolBarItem2});
            this.toolBar.Location = new System.Drawing.Point(98, 285);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(100, 50);
            this.toolBar.ToolbarItemClick += new Smobiler.Core.Controls.ToolbarItemClickEventHandler(this.toolBar_ToolbarItemClick);
            // 
            // frmUser
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.cameraPortrait,
            this.popSex});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.menuTitle1,
            this.spContent,
            this.toolBar});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmUser_KeyDown);
            this.Load += new System.EventHandler(this.frmUser_Load);
            this.Name = "frmUser";

        }
        #endregion
        private Smobiler.Core.Controls.Camera cameraPortrait;
        private Smobiler.Core.Controls.PopList popSex;
        private MenuTitle menuTitle1;
        private Smobiler.Core.Controls.Panel spContent;
        private Smobiler.Core.Controls.Panel plPortrait;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Image imgPortrait;
        private Smobiler.Core.Controls.Panel plName;
        private Smobiler.Core.Controls.Label label2;
        internal Smobiler.Core.Controls.Button btnName;
        private Smobiler.Core.Controls.Button btnName1;
        private Smobiler.Core.Controls.Panel plSex;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Button btnSex;
        private Smobiler.Core.Controls.Button btnSex1;
        private Smobiler.Core.Controls.Panel plBirthday;
        private Smobiler.Core.Controls.Label label4;
        private Smobiler.Core.Controls.DatePicker dpkBirthday;
        private Smobiler.Core.Controls.Panel plEmail;
        private Smobiler.Core.Controls.Label label5;
        internal Smobiler.Core.Controls.Button btnEmail;
        private Smobiler.Core.Controls.Button btnEmail1;
        private Smobiler.Core.Controls.Button btnPwd;
        private Smobiler.Core.Controls.Button btnExit;
        private Smobiler.Core.Controls.ToolBar toolBar;
        private Smobiler.Core.Controls.CameraButton cameraButton1;
    }
}