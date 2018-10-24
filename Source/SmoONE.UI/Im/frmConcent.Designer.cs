using System;
using Smobiler.Core;
namespace SmoONE.UI.Im
{
    partial class frmConcent : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmConcent()
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
            this.title1 = new SmoONE.UI.Layout.Title();
            this.segmentedControl1 = new Smobiler.Core.Controls.SegmentedControl();
            this.listContact = new Smobiler.Core.Controls.ListView();
            this.listGroup = new Smobiler.Core.Controls.ListView();
            this.pAdd = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.lblAdd = new Smobiler.Core.Controls.Label();
            this.toolBar1 = new Smobiler.Core.Controls.ToolBar();
            this.tabPageView1 = new Smobiler.Core.Controls.TabPageView();
            this.im1 = new Smobiler.Plugins.RongIM.IM();
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.title1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 50);
            this.title1.TitleText = "IM";
            // 
            // segmentedControl1
            // 
            this.segmentedControl1.Items = new string[] {
        "联系人",
        "群组"};
            this.segmentedControl1.Location = new System.Drawing.Point(0, 50);
            this.segmentedControl1.Name = "segmentedControl1";
            this.segmentedControl1.SegmentedBorderRadius = 0;
            this.segmentedControl1.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.segmentedControl1.SelectedColor = System.Drawing.Color.White;
            this.segmentedControl1.Size = new System.Drawing.Size(300, 35);
            this.segmentedControl1.UnSelectedBackColor = System.Drawing.Color.White;
            this.segmentedControl1.UnSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.segmentedControl1.SelectedIndexChanged += new System.EventHandler(this.segmentedControl1_SelectedIndexChanged);
            // 
            // listContact
            // 
            this.listContact.BackColor = System.Drawing.Color.White;
            this.listContact.Name = "listContact";
            this.listContact.PageSize = 8;
            this.listContact.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listContact.PageSizeTextSize = 11F;
            this.listContact.ShowSplitLine = true;
            this.listContact.Size = new System.Drawing.Size(300, 355);
            this.listContact.SplitLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.listContact.TemplateControlName = "frmUserLayout1";
            // 
            // listGroup
            // 
            this.listGroup.BackColor = System.Drawing.Color.White;
            this.listGroup.Name = "listGroup";
            this.listGroup.PageSize = 8;
            this.listGroup.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listGroup.PageSizeTextSize = 11F;
            this.listGroup.ShowSplitLine = true;
            this.listGroup.Size = new System.Drawing.Size(300, 355);
            this.listGroup.SplitLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.listGroup.TemplateControlName = "frmGroupLayout";
            // 
            // pAdd
            // 
            this.pAdd.BackColor = System.Drawing.Color.White;
            this.pAdd.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.pAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pAdd.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.lblAdd});
            this.pAdd.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.pAdd.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.pAdd.Location = new System.Drawing.Point(0, 85);
            this.pAdd.Name = "pAdd";
            this.pAdd.Size = new System.Drawing.Size(300, 35);
            this.pAdd.Touchable = true;
            this.pAdd.Press += new System.EventHandler(this.pAdd_Press);
            // 
            // label1
            // 
            this.label1.Bold = true;
            this.label1.FontSize = 30F;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label1.Size = new System.Drawing.Size(30, 0);
            this.label1.Text = "+";
            // 
            // lblAdd
            // 
            this.lblAdd.Flex = 1;
            this.lblAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(0, 0);
            this.lblAdd.Text = "添加联系人";
            // 
            // toolBar1
            // 
            this.toolBar1.BackColor = System.Drawing.Color.White;
            toolBarItem1.IconID = "lianxiren";
            toolBarItem1.Name = "contact";
            toolBarItem1.SelectIconID = "lianxiren";
            toolBarItem2.IconID = "xiaoxi";
            toolBarItem2.Name = "msg";
            toolBarItem2.SelectIconID = "xiaoxi";
            this.toolBar1.Items.AddRange(new Smobiler.Core.Controls.ToolBarItem[] {
            toolBarItem1,
            toolBarItem2});
            this.toolBar1.Location = new System.Drawing.Point(0, 457);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.SelectBackColor = System.Drawing.Color.White;
            this.toolBar1.SelectedIndex = 0;
            this.toolBar1.SelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.toolBar1.Size = new System.Drawing.Size(100, 50);
            this.toolBar1.ToolbarItemClick += new Smobiler.Core.Controls.ToolbarItemClickEventHandler(this.toolBar1_ToolbarItemClick);
            // 
            // tabPageView1
            // 
            this.tabPageView1.BackColor = System.Drawing.Color.White;
            this.tabPageView1.Location = new System.Drawing.Point(0, 120);
            this.tabPageView1.Name = "tabPageView1";
            this.tabPageView1.Size = new System.Drawing.Size(300, 330);
            this.tabPageView1.PageIndexChanged += new System.EventHandler(this.tabPageView1_PageIndexChanged);
            // 
            // im1
            // 
            this.im1.Name = "im1";
            this.im1.LoadUserInfo += new Smobiler.Plugins.RongIM.IMLoadUserInfoHandler(this.im1_LoadUserInfo);
            this.im1.LoadGroupInfo += new Smobiler.Plugins.RongIM.IMLoadGroupInfoHandler(this.im1_LoadGroupInfo);
            this.im1.LoadGroupMembers += new Smobiler.Plugins.RongIM.IMLoadGroupMembersHandler(this.im1_LoadGroupMembers);
            this.im1.TokenExpired += new Smobiler.Plugins.RongIM.IMTokenExpiredHandler(this.im1_TokenExpired);
            this.im1.UnReadMessage += new Smobiler.Plugins.RongIM.IMUnReadMessageHandler(this.im1_UnReadMessage);
            // 
            // frmConcent
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.im1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.segmentedControl1,
            this.pAdd,
            this.toolBar1,
            this.tabPageView1});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.Load += new System.EventHandler(this.frmConcent_Load);
            this.Name = "frmConcent";

        }
        #endregion

        private Layout.Title title1;
        private Smobiler.Core.Controls.SegmentedControl segmentedControl1;
        private Smobiler.Core.Controls.ListView listContact;
        private Smobiler.Core.Controls.ListView listGroup;
        private Smobiler.Core.Controls.Panel pAdd;
        private Smobiler.Core.Controls.ToolBar toolBar1;
        private Smobiler.Core.Controls.TabPageView tabPageView1;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label lblAdd;
        public Smobiler.Plugins.RongIM.IM im1;
    }
}