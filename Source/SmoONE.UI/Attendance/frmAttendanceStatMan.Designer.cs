using System;
using Smobiler.Core;
namespace SmoONE.UI.Attendance
{
    partial class frmAttendanceStatMan : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmAttendanceStatMan()
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
            this.gridATdata = new Smobiler.Core.Controls.ListView();
            this.lblDate = new Smobiler.Core.Controls.Label();
            this.title1 = new SmoONE.UI.Layout.Title();
            // 
            // gridATdata
            // 
            this.gridATdata.BackColor = System.Drawing.Color.White;
            this.gridATdata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridATdata.Location = new System.Drawing.Point(0, 85);
            this.gridATdata.Name = "gridATdata";
            this.gridATdata.PageSize = 10;
            this.gridATdata.Size = new System.Drawing.Size(300, 415);
            this.gridATdata.TemplateControlName = "frmATStatisticsDayLayout";
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.lblDate.Location = new System.Drawing.Point(0, 50);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(300, 35);
            this.lblDate.Text = "2017年2月9日";
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.title1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title1.Location = new System.Drawing.Point(111, 36);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 50);
            this.title1.TitleText = "考勤统计";
            this.title1.Load += new System.EventHandler(this.title1_Load);
            // 
            // frmAttendanceStatMan
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.lblDate,
            this.gridATdata});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmAttendanceStatMan_KeyDown);
            this.Load += new System.EventHandler(this.frmAttendanceStatMan_Load);
            this.Name = "frmAttendanceStatMan";

        }
        #endregion

        private Smobiler.Core.Controls.ListView gridATdata;
        private Smobiler.Core.Controls.Label lblDate;
        private SmoONE.UI.Layout.Title title1;
    }
}