using System;
using Smobiler.Core;
namespace SmoONE.UI.Attendance
{
    partial class frmAttendanceStatMonthTypeDay : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmAttendanceStatMonthTypeDay()
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
            this.gridATTypeDaydata = new Smobiler.Core.Controls.ListView();
            this.lblATMonth = new Smobiler.Core.Controls.Label();
            this.title1 = new SmoONE.UI.Layout.Title();
            // 
            // gridATTypeDaydata
            // 
            this.gridATTypeDaydata.BackColor = System.Drawing.Color.White;
            this.gridATTypeDaydata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridATTypeDaydata.FooterControlName = null;
            this.gridATTypeDaydata.HeaderControlName = null;
            this.gridATTypeDaydata.Location = new System.Drawing.Point(0, 85);
            this.gridATTypeDaydata.Name = "gridATTypeDaydata";
            this.gridATTypeDaydata.PageSize = 10;
            this.gridATTypeDaydata.ShowSplitLine = true;
            this.gridATTypeDaydata.Size = new System.Drawing.Size(300, 415);
            this.gridATTypeDaydata.SplitLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.gridATTypeDaydata.TemplateControlName = "frmAttendanceStatDayLayout";
            // 
            // lblATMonth
            // 
            this.lblATMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblATMonth.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblATMonth.ForeColor = System.Drawing.Color.White;
            this.lblATMonth.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.lblATMonth.Location = new System.Drawing.Point(0, 50);
            this.lblATMonth.Name = "lblATMonth";
            this.lblATMonth.Size = new System.Drawing.Size(300, 35);
            this.lblATMonth.Text = "label1";
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.title1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title1.Location = new System.Drawing.Point(111, 36);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 50);
            this.title1.TitleText = "¿¼ÇÚÔÂ±¨±í";
            // 
            // frmAttendanceStatMonthTypeDay
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.lblATMonth,
            this.gridATTypeDaydata});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmAttendanceStatMonthTypeDay_KeyDown);
            this.Load += new System.EventHandler(this.frmAttendanceStatMonthTypeDay_Load);
            this.Name = "frmAttendanceStatMonthTypeDay";

        }
        #endregion

        private Smobiler.Core.Controls.ListView gridATTypeDaydata;
        private Smobiler.Core.Controls.Label lblATMonth;
        private SmoONE.UI.Layout.Title title1;
    }
}