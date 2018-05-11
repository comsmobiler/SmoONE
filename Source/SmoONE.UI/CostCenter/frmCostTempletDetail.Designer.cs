using System;
using Smobiler.Core;
namespace SmoONE.UI.CostCenter
{
    partial class frmCostTempletDetail : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmCostTempletDetail()
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
            this.title1 = new SmoONE.UI.Layout.Title();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.lblFCheckers = new Smobiler.Core.Controls.Label();
            this.lblAEACheckers = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.btnEdit = new Smobiler.Core.Controls.Button();
            this.lblCTempID = new Smobiler.Core.Controls.Label();
            this.lblType = new Smobiler.Core.Controls.Label();
            this.lblAEACheckers2 = new Smobiler.Core.Controls.Label();
            this.lblFCheckers2 = new Smobiler.Core.Controls.Label();
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
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblFCheckers,
            this.lblAEACheckers,
            this.label3,
            this.label1,
            this.btnEdit,
            this.lblCTempID,
            this.lblType,
            this.lblAEACheckers2,
            this.lblFCheckers2});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 74);
            this.panel1.Name = "panel1";
            this.panel1.Scrollable = true;
            this.panel1.Size = new System.Drawing.Size(300, 100);
            // 
            // lblFCheckers
            // 
            this.lblFCheckers.BackColor = System.Drawing.Color.White;
            this.lblFCheckers.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.lblFCheckers.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblFCheckers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblFCheckers.Location = new System.Drawing.Point(0, 145);
            this.lblFCheckers.Name = "lblFCheckers";
            this.lblFCheckers.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.lblFCheckers.Size = new System.Drawing.Size(300, 35);
            this.lblFCheckers.Text = "财务审批人";
            // 
            // lblAEACheckers
            // 
            this.lblAEACheckers.BackColor = System.Drawing.Color.White;
            this.lblAEACheckers.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.lblAEACheckers.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblAEACheckers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblAEACheckers.Location = new System.Drawing.Point(0, 100);
            this.lblAEACheckers.Name = "lblAEACheckers";
            this.lblAEACheckers.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.lblAEACheckers.Size = new System.Drawing.Size(300, 35);
            this.lblAEACheckers.Text = "行政审批人";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.label3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label3.Location = new System.Drawing.Point(0, 55);
            this.label3.Name = "label3";
            this.label3.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label3.Size = new System.Drawing.Size(66, 35);
            this.label3.Text = "类型";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label1.Location = new System.Drawing.Point(0, 10);
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label1.Size = new System.Drawing.Size(66, 35);
            this.label1.Text = "模板编号";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnEdit.BorderRadius = 4;
            this.btnEdit.FontSize = 17F;
            this.btnEdit.Location = new System.Drawing.Point(13, 190);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(280, 35);
            this.btnEdit.Text = "编辑";
            this.btnEdit.Press += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblCTempID
            // 
            this.lblCTempID.BackColor = System.Drawing.Color.White;
            this.lblCTempID.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.lblCTempID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblCTempID.FontSize = 12F;
            this.lblCTempID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lblCTempID.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblCTempID.Location = new System.Drawing.Point(66, 10);
            this.lblCTempID.Name = "lblCTempID";
            this.lblCTempID.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.lblCTempID.Size = new System.Drawing.Size(234, 35);
            // 
            // lblType
            // 
            this.lblType.BackColor = System.Drawing.Color.White;
            this.lblType.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.lblType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblType.FontSize = 12F;
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lblType.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblType.Location = new System.Drawing.Point(66, 55);
            this.lblType.Name = "lblType";
            this.lblType.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.lblType.Size = new System.Drawing.Size(234, 35);
            // 
            // lblAEACheckers2
            // 
            this.lblAEACheckers2.BackColor = System.Drawing.Color.White;
            this.lblAEACheckers2.BorderColor = System.Drawing.Color.LightGray;
            this.lblAEACheckers2.Location = new System.Drawing.Point(0, 278);
            this.lblAEACheckers2.Name = "lblAEACheckers2";
            this.lblAEACheckers2.Size = new System.Drawing.Size(300, 55);
            this.lblAEACheckers2.Visible = false;
            this.lblAEACheckers2.ZIndex = 6;
            // 
            // lblFCheckers2
            // 
            this.lblFCheckers2.BackColor = System.Drawing.Color.White;
            this.lblFCheckers2.BorderColor = System.Drawing.Color.LightGray;
            this.lblFCheckers2.Location = new System.Drawing.Point(0, 328);
            this.lblFCheckers2.Name = "lblFCheckers2";
            this.lblFCheckers2.Size = new System.Drawing.Size(300, 55);
            this.lblFCheckers2.Visible = false;
            this.lblFCheckers2.ZIndex = 10;
            // 
            // frmCostTempletDetail
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel1});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmCostTempletDetail_KeyDown);
            this.Load += new System.EventHandler(this.frmCostTempletDetail_Load);
            this.Name = "frmCostTempletDetail";

        }
        #endregion
        private SmoONE.UI.Layout.Title title1;
        private Smobiler.Core.Controls.Panel panel1;
        internal Smobiler.Core.Controls.Label lblFCheckers;
        internal Smobiler.Core.Controls.Label lblAEACheckers;
        internal Smobiler.Core.Controls.Label label3;
        internal Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Button btnEdit;
        internal Smobiler.Core.Controls.Label lblCTempID;
        internal Smobiler.Core.Controls.Label lblType;
        private Smobiler.Core.Controls.Label lblAEACheckers2;
        private Smobiler.Core.Controls.Label lblFCheckers2;
    }
}