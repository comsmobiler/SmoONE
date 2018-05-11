using System;
using Smobiler.Core;
namespace SmoONE.UI.CostCenter
{
    partial class frmCostTempletCreate : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmCostTempletCreate()
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
            this.popType = new Smobiler.Core.Controls.PopList();
            this.title1 = new SmoONE.UI.Layout.Title();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.btnSave = new Smobiler.Core.Controls.Button();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.btnType = new Smobiler.Core.Controls.Button();
            this.lblAEACheckers = new Smobiler.Core.Controls.Label();
            this.lblAEACheckers1 = new Smobiler.Core.Controls.Label();
            this.lblAEACheckers2 = new Smobiler.Core.Controls.Label();
            this.imgbtnAEACheckers = new Smobiler.Core.Controls.ImageButton();
            this.lblFCheckers = new Smobiler.Core.Controls.Label();
            this.lblFCheckers1 = new Smobiler.Core.Controls.Label();
            this.lblFCheckers2 = new Smobiler.Core.Controls.Label();
            this.imgbtnFCheckers = new Smobiler.Core.Controls.ImageButton();
            // 
            // popType
            // 
            this.popType.Name = "popType";
            this.popType.Selected += new System.EventHandler(this.popType_Selected);
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.title1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title1.Location = new System.Drawing.Point(111, 36);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 50);
            this.title1.TitleText = "成本中心类型模板";
            this.title1.Load += new System.EventHandler(this.title1_Load);
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnSave,
            this.label3,
            this.btnType,
            this.lblAEACheckers,
            this.lblAEACheckers1,
            this.lblAEACheckers2,
            this.imgbtnAEACheckers,
            this.lblFCheckers,
            this.lblFCheckers1,
            this.lblFCheckers2,
            this.imgbtnFCheckers});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 82);
            this.panel1.Name = "panel1";
            this.panel1.Scrollable = true;
            this.panel1.Size = new System.Drawing.Size(300, 100);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnSave.BorderRadius = 4;
            this.btnSave.FontSize = 17F;
            this.btnSave.Location = new System.Drawing.Point(10, 255);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(280, 35);
            this.btnSave.Text = "提交";
            this.btnSave.Press += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.label3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label3.Location = new System.Drawing.Point(0, 10);
            this.label3.Name = "label3";
            this.label3.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label3.Size = new System.Drawing.Size(66, 35);
            this.label3.Text = "类型";
            this.label3.ZIndex = 1;
            // 
            // btnType
            // 
            this.btnType.BackColor = System.Drawing.Color.White;
            this.btnType.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.btnType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnType.BorderRadius = 0;
            this.btnType.FontSize = 12F;
            this.btnType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnType.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnType.Location = new System.Drawing.Point(66, 10);
            this.btnType.Name = "btnType";
            this.btnType.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.btnType.Size = new System.Drawing.Size(234, 35);
            this.btnType.Text = "选择（必填）   > ";
            this.btnType.ZIndex = 2;
            this.btnType.Press += new System.EventHandler(this.btntype_Click);
            // 
            // lblAEACheckers
            // 
            this.lblAEACheckers.BackColor = System.Drawing.Color.White;
            this.lblAEACheckers.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.lblAEACheckers.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblAEACheckers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblAEACheckers.Location = new System.Drawing.Point(0, 55);
            this.lblAEACheckers.Name = "lblAEACheckers";
            this.lblAEACheckers.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.lblAEACheckers.Size = new System.Drawing.Size(75, 35);
            this.lblAEACheckers.Text = "行政审批人";
            this.lblAEACheckers.ZIndex = 4;
            // 
            // lblAEACheckers1
            // 
            this.lblAEACheckers1.BackColor = System.Drawing.Color.White;
            this.lblAEACheckers1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.lblAEACheckers1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblAEACheckers1.ForeColor = System.Drawing.Color.Silver;
            this.lblAEACheckers1.Location = new System.Drawing.Point(75, 55);
            this.lblAEACheckers1.Name = "lblAEACheckers1";
            this.lblAEACheckers1.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.lblAEACheckers1.Size = new System.Drawing.Size(225, 35);
            this.lblAEACheckers1.Text = "（添加1-4位审批人，点击头像可删除）";
            this.lblAEACheckers1.ZIndex = 5;
            // 
            // lblAEACheckers2
            // 
            this.lblAEACheckers2.BackColor = System.Drawing.Color.White;
            this.lblAEACheckers2.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.lblAEACheckers2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblAEACheckers2.Location = new System.Drawing.Point(0, 90);
            this.lblAEACheckers2.Name = "lblAEACheckers2";
            this.lblAEACheckers2.Size = new System.Drawing.Size(300, 55);
            this.lblAEACheckers2.ZIndex = 6;
            // 
            // imgbtnAEACheckers
            // 
            this.imgbtnAEACheckers.BackColor = System.Drawing.Color.White;
            this.imgbtnAEACheckers.Location = new System.Drawing.Point(65, 90);
            this.imgbtnAEACheckers.Name = "imgbtnAEACheckers";
            this.imgbtnAEACheckers.ResourceID = "add";
            this.imgbtnAEACheckers.Size = new System.Drawing.Size(35, 35);
            this.imgbtnAEACheckers.ZIndex = 7;
            this.imgbtnAEACheckers.Press += new System.EventHandler(this.imgbtnAEACheckers_Click);
            // 
            // lblFCheckers
            // 
            this.lblFCheckers.BackColor = System.Drawing.Color.White;
            this.lblFCheckers.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.lblFCheckers.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblFCheckers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblFCheckers.Location = new System.Drawing.Point(0, 155);
            this.lblFCheckers.Name = "lblFCheckers";
            this.lblFCheckers.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.lblFCheckers.Size = new System.Drawing.Size(75, 35);
            this.lblFCheckers.Text = "财务审批人";
            this.lblFCheckers.ZIndex = 8;
            // 
            // lblFCheckers1
            // 
            this.lblFCheckers1.BackColor = System.Drawing.Color.White;
            this.lblFCheckers1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.lblFCheckers1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblFCheckers1.ForeColor = System.Drawing.Color.Silver;
            this.lblFCheckers1.Location = new System.Drawing.Point(75, 155);
            this.lblFCheckers1.Name = "lblFCheckers1";
            this.lblFCheckers1.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.lblFCheckers1.Size = new System.Drawing.Size(225, 35);
            this.lblFCheckers1.Text = "（添加1-4位审批人，点击头像可删除）";
            this.lblFCheckers1.ZIndex = 9;
            // 
            // lblFCheckers2
            // 
            this.lblFCheckers2.BackColor = System.Drawing.Color.White;
            this.lblFCheckers2.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.lblFCheckers2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblFCheckers2.Location = new System.Drawing.Point(0, 190);
            this.lblFCheckers2.Name = "lblFCheckers2";
            this.lblFCheckers2.Size = new System.Drawing.Size(300, 55);
            this.lblFCheckers2.ZIndex = 10;
            // 
            // imgbtnFCheckers
            // 
            this.imgbtnFCheckers.BackColor = System.Drawing.Color.White;
            this.imgbtnFCheckers.Location = new System.Drawing.Point(65, 190);
            this.imgbtnFCheckers.Name = "imgbtnFCheckers";
            this.imgbtnFCheckers.ResourceID = "add";
            this.imgbtnFCheckers.Size = new System.Drawing.Size(35, 35);
            this.imgbtnFCheckers.ZIndex = 11;
            this.imgbtnFCheckers.Press += new System.EventHandler(this.imgbtnFCheckers_Click);
            // 
            // frmCostTempletCreate
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.popType});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel1});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmCostTempletCreate_KeyDown);
            this.Load += new System.EventHandler(this.frmCostTempletCreate_Load);
            this.Name = "frmCostTempletCreate";

        }
        #endregion
        private Smobiler.Core.Controls.PopList popType;
        private SmoONE.UI.Layout.Title title1;
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Button btnSave;
        internal Smobiler.Core.Controls.Label label3;
        internal Smobiler.Core.Controls.Button btnType;
        internal Smobiler.Core.Controls.Label lblAEACheckers;
        private Smobiler.Core.Controls.Label lblAEACheckers1;
        private Smobiler.Core.Controls.Label lblAEACheckers2;
        private Smobiler.Core.Controls.ImageButton imgbtnAEACheckers;
        internal Smobiler.Core.Controls.Label lblFCheckers;
        private Smobiler.Core.Controls.Label lblFCheckers1;
        private Smobiler.Core.Controls.Label lblFCheckers2;
        private Smobiler.Core.Controls.ImageButton imgbtnFCheckers;
    }
}