using System;
using Smobiler.Core;
namespace SmoONE.UI.Attendance
{
    partial class frmATGPSEdit : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmATGPSEdit()
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
            this.mapTrimView1 = new Smobiler.Plugins.MapTrimView();
            this.title1 = new SmoONE.UI.Layout.Title();
            // 
            // mapTrimView1
            // 
            this.mapTrimView1.Location = new System.Drawing.Point(0, 50);
            this.mapTrimView1.Name = "mapTrimView1";
            this.mapTrimView1.Size = new System.Drawing.Size(300, 450);
            this.mapTrimView1.LocationChanged += new Smobiler.Plugins.MapTrimViewLocationChanged(this.mapTrimView1_LocationChanged);
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.title1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title1.Location = new System.Drawing.Point(111, 36);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 50);
            this.title1.TitleText = "¿¼ÇÚµØµã";
            // 
            // frmATGPSEdit
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.mapTrimView1,
            this.title1});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmSignGPSEdit_KeyDown);
            this.Load += new System.EventHandler(this.frmSignGPSEdit_Load);
            this.Name = "frmATGPSEdit";

        }
        #endregion

        private Smobiler.Plugins.MapTrimView mapTrimView1;
        private SmoONE.UI.Layout.Title title1;
    }
}