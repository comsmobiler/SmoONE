using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class frmAttendanceMainDetailLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerForm generated code "

        public frmAttendanceMainDetailLayout()
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
            this.lblLocation = new Smobiler.Core.Controls.Label();
            this.lblReason = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.imgLocation = new Smobiler.Core.Controls.Image();
            // 
            // lblLocation
            // 
            this.lblLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lblLocation.Location = new System.Drawing.Point(30, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.lblLocation.Size = new System.Drawing.Size(250, 30);
            this.lblLocation.Text = "签到位置1";
            // 
            // lblReason
            // 
            this.lblReason.Location = new System.Drawing.Point(0, 30);
            this.lblReason.Name = "lblReason";
            this.lblReason.Padding = new Smobiler.Core.Controls.Padding(5F, 5F, 10F, 0F);
            this.lblReason.Size = new System.Drawing.Size(280, 60);
            this.lblReason.VerticalAlignment = Smobiler.Core.Controls.VerticalAlignment.Top;
            // 
            // label2
            // 
            this.label2.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label2.Location = new System.Drawing.Point(0, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 35);
            this.label2.Text = "签到位置";
            // 
            // imgLocation
            // 
            this.imgLocation.Name = "imgLocation";
            this.imgLocation.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.imgLocation.ResourceID = "!\\ue55f255000000";
            this.imgLocation.Size = new System.Drawing.Size(30, 30);
            this.imgLocation.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Cover;
            // 
            // frmAttendanceMainDetailLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblLocation,
            this.lblReason,
            this.imgLocation});
            this.Size = new System.Drawing.Size(280, 90);
            this.Name = "frmAttendanceMainDetailLayout";

        }
        #endregion

        private Smobiler.Core.Controls.Label label2;
        public Smobiler.Core.Controls.Label lblLocation;
        public Smobiler.Core.Controls.Image imgLocation;
        public Smobiler.Core.Controls.Label lblReason;
    }
}