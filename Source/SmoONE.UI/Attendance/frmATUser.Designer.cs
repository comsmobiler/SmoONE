using System;
using Smobiler.Core;
namespace SmoONE.UI.Attendance
{
    partial class frmATUser : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmATUser()
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
            this.gridATUserData = new Smobiler.Core.Controls.ListView();
            this.title1 = new SmoONE.UI.Layout.Title();
            this.frmATFootLayout1 = new SmoONE.UI.Layout.frmATFootLayout();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.btnAll = new Smobiler.Core.Controls.Button();
            this.checkAll1 = new Smobiler.Core.Controls.CheckBox();
            // 
            // gridATUserData
            // 
            this.gridATUserData.BackColor = System.Drawing.Color.White;
            this.gridATUserData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridATUserData.FooterControlName = null;
            this.gridATUserData.HeaderControlName = null;
            this.gridATUserData.Location = new System.Drawing.Point(0, 85);
            this.gridATUserData.Name = "gridATUserData";
            this.gridATUserData.PageSize = 10;
            this.gridATUserData.ShowSplitLine = true;
            this.gridATUserData.Size = new System.Drawing.Size(300, 415);
            this.gridATUserData.SplitLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.gridATUserData.TemplateControlName = "frmATUserLayout";
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.title1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title1.Location = new System.Drawing.Point(111, 36);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 50);
            this.title1.TitleText = "选择成员";
            // 
            // frmATFootLayout1
            // 
            this.frmATFootLayout1.BackColor = System.Drawing.Color.White;
            this.frmATFootLayout1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.frmATFootLayout1.Location = new System.Drawing.Point(0, 452);
            this.frmATFootLayout1.Name = "frmATFootLayout1";
            this.frmATFootLayout1.Size = new System.Drawing.Size(334, 55);
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnAll,
            this.checkAll1});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 35);
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.Color.White;
            this.btnAll.BorderRadius = 0;
            this.btnAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnAll.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnAll.Name = "btnAll";
            this.btnAll.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 40F, 0F);
            this.btnAll.Size = new System.Drawing.Size(300, 35);
            this.btnAll.Text = "全选";
            this.btnAll.Press += new System.EventHandler(this.btnAll_Click);
            // 
            // checkAll1
            // 
            this.checkAll1.Location = new System.Drawing.Point(274, 8);
            this.checkAll1.Name = "checkAll1";
            this.checkAll1.Size = new System.Drawing.Size(20, 20);
            this.checkAll1.TintColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.checkAll1.CheckedChanged += new System.EventHandler(this.checkAll_CheckChanged);
            // 
            // frmATUser
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel1,
            this.frmATFootLayout1,
            this.gridATUserData});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmATUser_KeyDown);
            this.Load += new System.EventHandler(this.frmATUser_Load);
            this.Name = "frmATUser";

        }
        #endregion

        private SmoONE.UI.Layout.Title title1;
        public Smobiler.Core.Controls.ListView gridATUserData;
        private Layout.frmATFootLayout frmATFootLayout1;
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Button btnAll;
        private Smobiler.Core.Controls.CheckBox checkAll1;
    }
}