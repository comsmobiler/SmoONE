using System;
using Smobiler.Core;
using SmoONE.UI.Layout;

namespace SmoONE.UI.Work
{
    partial class frmCreated : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmCreated()
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
            this.listCrateData = new Smobiler.Core.Controls.ListView();
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.title1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.title1.Dock = System.Windows.Forms.DockStyle.Top;
            
            this.title1.Location = new System.Drawing.Point(166, 96);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 50);
            this.title1.TitleText = "我发起的";
            // 
            // listCrateData
            // 
            this.listCrateData.BackColor = System.Drawing.Color.White;
            this.listCrateData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listCrateData.FooterControlName = null;
            this.listCrateData.HeaderControlName = null;
            this.listCrateData.Location = new System.Drawing.Point(84, 114);
            this.listCrateData.Name = "listCrateData";
            this.listCrateData.PageSize = 10;
            this.listCrateData.ShowSplitLine = true;
            this.listCrateData.Size = new System.Drawing.Size(100, 30);
            this.listCrateData.SplitLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.listCrateData.TemplateControlName = "frmLeaveLayout";
            // 
            // frmCreated
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.listCrateData});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmCreated_KeyDown);
            this.Load += new System.EventHandler(this.frmCreated_Load);
            this.Name = "frmCreated";

        }
        #endregion

        private Title title1;
        private Smobiler.Core.Controls.ListView listCrateData;
    }
}