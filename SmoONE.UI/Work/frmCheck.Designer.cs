using System;
using Smobiler.Core;
using SmoONE.UI.Layout;

namespace SmoONE.UI.Work
{
    partial class frmCheck : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmCheck()
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
            this.segmentedControl1 = new Smobiler.Core.Controls.SegmentedControl();
            this.title1 = new SmoONE.UI.Layout.Title();
            this.tpSearch = new Smobiler.Core.Controls.Panel();
            this.imgSearch = new Smobiler.Core.Controls.Image();
            this.listCheckData = new Smobiler.Core.Controls.ListView();
            this.popList1 = new Smobiler.Core.Controls.PopList();
            // 
            // segmentedControl1
            // 
            this.segmentedControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.segmentedControl1.Items = new string[] {
        "待我审批的",
        "我已审批的"};
            this.segmentedControl1.Location = new System.Drawing.Point(10, 10);
            this.segmentedControl1.Name = "segmentedControl1";
            this.segmentedControl1.SegmentedBorderRadius = 4;
            this.segmentedControl1.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.segmentedControl1.Size = new System.Drawing.Size(280, 35);
            this.segmentedControl1.SelectedIndexChanged += new System.EventHandler(this.segmentedControl1_SelectedIndexChanged);
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.title1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title1.Location = new System.Drawing.Point(108, 12);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 50);
            this.title1.TitleText = "我审批的";
            // 
            // tpSearch
            // 
            this.tpSearch.BackColor = System.Drawing.Color.White;
            this.tpSearch.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imgSearch});
            this.tpSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.tpSearch.Location = new System.Drawing.Point(250, 55);
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
            // listCheckData
            // 
            this.listCheckData.BackColor = System.Drawing.Color.White;
            this.listCheckData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listCheckData.FooterControlName = null;
            this.listCheckData.HeaderControlName = null;
            this.listCheckData.Location = new System.Drawing.Point(0, 85);
            this.listCheckData.Name = "listCheckData";
            this.listCheckData.PageSize = 10;
            this.listCheckData.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listCheckData.PageSizeTextSize = 11F;
            this.listCheckData.ShowSplitLine = true;
            this.listCheckData.Size = new System.Drawing.Size(300, 415);
            this.listCheckData.SplitLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.listCheckData.TemplateControlName = "frmLeaveLayout";
            // 
            // popList1
            // 
            this.popList1.Name = "popList1";
            this.popList1.Selected += new System.EventHandler(this.popList1_Selected);
            // 
            // frmCheck
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.popList1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.segmentedControl1,
            this.tpSearch,
            this.listCheckData});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmCheck_KeyDown);
            this.Load += new System.EventHandler(this.frmCheck_Load);
            this.Name = "frmCheck";

        }
        #endregion

        private Title title1;
        private Smobiler.Core.Controls.SegmentedControl segmentedControl1;
        private Smobiler.Core.Controls.Panel tpSearch;
        private Smobiler.Core.Controls.Image imgSearch;
        private Smobiler.Core.Controls.ListView listCheckData;
        private Smobiler.Core.Controls.PopList popList1;
    }
}