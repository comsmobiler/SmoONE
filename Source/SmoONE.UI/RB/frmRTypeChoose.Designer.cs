using System;
using Smobiler.Core;
using SmoONE.UI.Layout;

namespace SmoONE.UI.RB
{
    partial class frmRTypeChoose : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmRTypeChoose()
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
            this.title = new SmoONE.UI.Layout.Title();
            this.listRBRowTypeData = new Smobiler.Core.Controls.ListView();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.title.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.title.Dock = System.Windows.Forms.DockStyle.Top;
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(300, 50);
            this.title.TitleText = "消费类型选择";
            // 
            // listRBRowTypeData
            // 
            this.listRBRowTypeData.BackColor = System.Drawing.Color.White;
            this.listRBRowTypeData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listRBRowTypeData.FooterControlName = null;
            this.listRBRowTypeData.HeaderControlName = null;
            this.listRBRowTypeData.Location = new System.Drawing.Point(114, 104);
            this.listRBRowTypeData.Name = "listRBRowTypeData";
            this.listRBRowTypeData.ShowSplitLine = true;
            this.listRBRowTypeData.Size = new System.Drawing.Size(100, 30);
            this.listRBRowTypeData.SplitLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.listRBRowTypeData.TemplateControlName = "frmRBTypeLayout";
            // 
            // frmRTypeChoose
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title,
            this.listRBRowTypeData});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmRTypeChoose_KeyDown);
            this.Load += new System.EventHandler(this.frmRTypeChoose_Load);
            this.Name = "frmRTypeChoose";

        }
        #endregion

        private Title title;
        private Smobiler.Core.Controls.ListView listRBRowTypeData;
    }
}