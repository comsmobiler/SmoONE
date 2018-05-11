using System;
using Smobiler.Core;
namespace SmoONE.UI.CostCenter
{
    partial class frmCostTemplet : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmCostTemplet()
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
            this.gridCCTempletData = new Smobiler.Core.Controls.GridView();
            this.lblInfor = new Smobiler.Core.Controls.Label();
            this.title1 = new SmoONE.UI.Layout.Title();
            this.btnCreate = new Smobiler.Core.Controls.Button();
            // 
            // gridCCTempletData
            // 
            this.gridCCTempletData.BackColor = System.Drawing.Color.White;
            this.gridCCTempletData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCCTempletData.FooterControlName = null;
            this.gridCCTempletData.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.gridCCTempletData.HeaderControlName = null;
            this.gridCCTempletData.Location = new System.Drawing.Point(0, 105);
            this.gridCCTempletData.Margin = new Smobiler.Core.Controls.Margin(0F, 20F, 0F, 0F);
            this.gridCCTempletData.Name = "gridCCTempletData";
            this.gridCCTempletData.PageSize = 10;
            this.gridCCTempletData.ShowGridLine = true;
            this.gridCCTempletData.Size = new System.Drawing.Size(300, 395);
            this.gridCCTempletData.TemplateControlName = "frmCostTempletLayout";
            // 
            // lblInfor
            // 
            this.lblInfor.ForeColor = System.Drawing.Color.Silver;
            this.lblInfor.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.lblInfor.Location = new System.Drawing.Point(0, 210);
            this.lblInfor.Name = "lblInfor";
            this.lblInfor.Size = new System.Drawing.Size(300, 30);
            this.lblInfor.Text = "当前暂无成本中心模板，请创建！";
            this.lblInfor.Visible = false;
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
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnCreate.BorderRadius = 4;
            this.btnCreate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreate.FontSize = 17F;
            this.btnCreate.Location = new System.Drawing.Point(10, 60);
            this.btnCreate.Margin = new Smobiler.Core.Controls.Margin(10F, 10F, 10F, 0F);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(280, 35);
            this.btnCreate.Text = "创建模板";
            this.btnCreate.Press += new System.EventHandler(this.btnCreate_Click);
            // 
            // frmCostTemplet
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.btnCreate,
            this.gridCCTempletData,
            this.lblInfor});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmCostTemplet_KeyDown);
            this.Load += new System.EventHandler(this.frmCostTemplet_Load);
            this.Name = "frmCostTemplet";

        }
        #endregion

        private Smobiler.Core.Controls.GridView gridCCTempletData;
        private Smobiler.Core.Controls.Label lblInfor;
        private SmoONE.UI.Layout.Title title1;
        private Smobiler.Core.Controls.Button btnCreate;

    }
}