using System;
using Smobiler.Core;
namespace SmoONE.UI.CostCenter
{
    partial class frmCostCenter : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmCostCenter()
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
            this.gridCCData = new Smobiler.Core.Controls.ListView();
            this.lblInfor = new Smobiler.Core.Controls.Label();
            this.btnCreate = new Smobiler.Core.Controls.Button();
            this.title1 = new SmoONE.UI.Layout.Title();
            // 
            // gridCCData
            // 
            this.gridCCData.BackColor = System.Drawing.Color.White;
            this.gridCCData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCCData.FooterControlName = null;
            this.gridCCData.HeaderControlName = null;
            this.gridCCData.Location = new System.Drawing.Point(0, 105);
            this.gridCCData.Margin = new Smobiler.Core.Controls.Margin(0F, 20F, 0F, 0F);
            this.gridCCData.Name = "gridCCData";
            this.gridCCData.PageSize = 10;
            this.gridCCData.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.gridCCData.PageSizeTextSize = 11F;
            this.gridCCData.ShowSplitLine = true;
            this.gridCCData.Size = new System.Drawing.Size(300, 395);
            this.gridCCData.SplitLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.gridCCData.TemplateControlName = "frmCostCenterLayout";
            // 
            // lblInfor
            // 
            this.lblInfor.ForeColor = System.Drawing.Color.Silver;
            this.lblInfor.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.lblInfor.Location = new System.Drawing.Point(0, 180);
            this.lblInfor.Name = "lblInfor";
            this.lblInfor.Size = new System.Drawing.Size(300, 30);
            this.lblInfor.Text = "当前暂无成本中心，请创建！";
            this.lblInfor.Visible = false;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnCreate.BorderRadius = 4;
            this.btnCreate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreate.FontSize = 17F;
            this.btnCreate.Margin = new Smobiler.Core.Controls.Margin(10F, 10F, 10F, 0F);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(280, 35);
            this.btnCreate.Text = "创建成本中心";
            this.btnCreate.Press += new System.EventHandler(this.btnCreate_Click);
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.title1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title1.Location = new System.Drawing.Point(111, 36);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 50);
            this.title1.TitleText = "成本中心";
            this.title1.Load += new System.EventHandler(this.title1_Load);
            // 
            // frmCostCenter
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.btnCreate,
            this.gridCCData,
            this.lblInfor});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmCostCenter_KeyDown);
            this.Load += new System.EventHandler(this.frmCostCenter_Load);
            this.Name = "frmCostCenter";

        }
        #endregion

        private Smobiler.Core.Controls.ListView gridCCData;
        private Smobiler.Core.Controls.Label lblInfor;
        private Smobiler.Core.Controls.Button btnCreate;
        private SmoONE.UI.Layout.Title title1;
    }
}