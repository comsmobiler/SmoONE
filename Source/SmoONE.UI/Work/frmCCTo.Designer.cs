using System;
using Smobiler.Core;
using SmoONE.UI.Layout;

namespace SmoONE.UI.Work
{
    partial class frmCCTo : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmCCTo()
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
            this.listCCData = new Smobiler.Core.Controls.ListView();
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.title1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title1.Location = new System.Drawing.Point(113, 59);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 50);
            this.title1.TitleText = "³­ËÍÎÒµÄ";
            // 
            // listCCData
            // 
            this.listCCData.BackColor = System.Drawing.Color.White;
            this.listCCData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listCCData.FooterControlName = null;
            this.listCCData.Location = new System.Drawing.Point(82, 144);
            this.listCCData.Name = "listCCData";
            this.listCCData.PageSize = 10;
            this.listCCData.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listCCData.PageSizeTextSize = 11F;
            this.listCCData.ShowSplitLine = true;
            this.listCCData.Size = new System.Drawing.Size(100, 30);
            this.listCCData.SplitLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.listCCData.TemplateControlName = "frmLeaveLayout";
            // 
            // frmCCTo
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.listCCData});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmCCTo_KeyDown);
            this.Load += new System.EventHandler(this.frmCCTo_Load);
            this.Name = "frmCCTo";

        }
        #endregion

        private Title title1;
        private Smobiler.Core.Controls.ListView listCCData;
    }
}