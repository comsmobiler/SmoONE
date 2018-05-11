using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class frmAttendanceStatSelfLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerForm generated code "

        public frmAttendanceStatSelfLayout()
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
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.lblID = new Smobiler.Core.Controls.Label();
            this.lblNumber = new Smobiler.Core.Controls.Label();
            this.lblDetail = new Smobiler.Core.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblID,
            this.lblNumber,
            this.lblDetail});
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 50);
            this.panel1.Touchable = true;
            this.panel1.Press += new System.EventHandler(this.panel1_Press);
            // 
            // lblID
            // 
            this.lblID.DisplayMember = "AttendType";
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblID.Name = "lblID";
            this.lblID.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.lblID.Size = new System.Drawing.Size(80, 50);
            this.lblID.Text = "ÒÑÇ©µ½";
            // 
            // lblNumber
            // 
            this.lblNumber.DataMember = "Number";
            this.lblNumber.DisplayMember = "AttendNumber";
            this.lblNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblNumber.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblNumber.Location = new System.Drawing.Point(80, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(180, 50);
            this.lblNumber.Text = "0´Î";
            // 
            // lblDetail
            // 
            this.lblDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblDetail.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblDetail.Location = new System.Drawing.Point(260, 0);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.lblDetail.Size = new System.Drawing.Size(40, 50);
            this.lblDetail.Text = ">";
            // 
            // frmAttendanceStatSelfLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(300, 50);
            this.Name = "frmAttendanceStatSelfLayout";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Label lblID;
        private Smobiler.Core.Controls.Label lblNumber;
        private Smobiler.Core.Controls.Label lblDetail;
    }
}