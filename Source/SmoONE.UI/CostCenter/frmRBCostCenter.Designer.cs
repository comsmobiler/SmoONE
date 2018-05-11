using System;
using Smobiler.Core;
namespace SmoONE.UI.CostCenter
{
    partial class frmRBCostCenter : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmRBCostCenter()
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
            this.popList1 = new Smobiler.Core.Controls.PopList();
            this.title1 = new SmoONE.UI.Layout.Title();
            this.tpSearch = new Smobiler.Core.Controls.Panel();
            this.imgSearch = new Smobiler.Core.Controls.Image();
            this.gridCCData = new Smobiler.Core.Controls.ListView();
            // 
            // popList1
            // 
            this.popList1.Name = "popList1";
            this.popList1.Selected += new System.EventHandler(this.popList1_Selected);
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.title1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title1.Location = new System.Drawing.Point(15, 25);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 50);
            this.title1.TitleText = "成本中心";
            // 
            // tpSearch
            // 
            this.tpSearch.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imgSearch});
            this.tpSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.tpSearch.Location = new System.Drawing.Point(250, 50);
            this.tpSearch.Name = "tpSearch";
            this.tpSearch.Size = new System.Drawing.Size(40, 30);
            this.tpSearch.Touchable = true;
            this.tpSearch.Press += new System.EventHandler(this.tpSearch_Press);
            // 
            // imgSearch
            // 
            this.imgSearch.Location = new System.Drawing.Point(250, 0);
            this.imgSearch.Name = "imgSearch";
            this.imgSearch.ResourceID = "search";
            this.imgSearch.Size = new System.Drawing.Size(40, 30);
            // 
            // gridCCData
            // 
            this.gridCCData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCCData.Location = new System.Drawing.Point(0, 100);
            this.gridCCData.Name = "gridCCData";
            this.gridCCData.PageSize = 10;
            this.gridCCData.ShowSplitLine = true;
            this.gridCCData.Size = new System.Drawing.Size(300, 420);
            this.gridCCData.SplitLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.gridCCData.TemplateControlName = "frmCostCenterLayout";
            // 
            // frmRBCostCenter
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.popList1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.tpSearch,
            this.gridCCData});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmRBCostCenter_KeyDown);
            this.Load += new System.EventHandler(this.frmCostCenter_Load);
            this.Name = "frmRBCostCenter";

        }
        #endregion
        public Smobiler.Core.Controls.PopList popList1;
        private Layout.Title title1;
        private Smobiler.Core.Controls.Panel tpSearch;
        private Smobiler.Core.Controls.Image imgSearch;
        private Smobiler.Core.Controls.ListView gridCCData;
    }
}