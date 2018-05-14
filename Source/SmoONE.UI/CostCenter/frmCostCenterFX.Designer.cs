using System;
using Smobiler.Core;
namespace SmoONE.UI.CostCenter
{
    partial class frmCostCenterFX : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmCostCenterFX()
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
            this.gridCCData = new Smobiler.Core.Controls.ListView();
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.title1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title1.Location = new System.Drawing.Point(111, 36);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 50);
            this.title1.TitleText = "成本中心分析";
            // 
            // gridCCData
            // 
            this.gridCCData.BackColor = System.Drawing.Color.White;
            this.gridCCData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCCData.FooterControlName = null;
            this.gridCCData.HeaderControlName = null;
            this.gridCCData.Location = new System.Drawing.Point(0, 105);
            this.gridCCData.Name = "gridCCData";
            this.gridCCData.PageSize = 10;
            this.gridCCData.ShowSplitLine = true;
            this.gridCCData.Size = new System.Drawing.Size(300, 395);
            this.gridCCData.SplitLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.gridCCData.TemplateControlName = "frmCostCenterLayout";
            // 
            // frmCostCenterFX
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.gridCCData});
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmCostCenterFX_KeyDown);
            this.Load += new System.EventHandler(this.frmCostCenterFX_Load);
            this.Name = "frmCostCenterFX";

        }
        #endregion

        private Layout.Title title1;
        private Smobiler.Core.Controls.ListView gridCCData;
    }
}