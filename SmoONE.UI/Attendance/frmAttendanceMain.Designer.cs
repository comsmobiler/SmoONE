using System;
using Smobiler.Core;
namespace SmoONE.UI.Attendance
{
    partial class frmAttendanceMain : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmAttendanceMain()
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
            this.gps1 = new Smobiler.Core.Controls.GPS();
            this.lblWeekDay = new Smobiler.Core.Controls.Label();
            this.lblInfo = new Smobiler.Core.Controls.Label();
            this.lblDate = new Smobiler.Core.Controls.Label();
            this.gridATdata = new Smobiler.Core.Controls.ListView();
            this.title1 = new SmoONE.UI.Layout.Title();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            // 
            // gps1
            // 
            this.gps1.AmapKey = "8f960360ba094ef27da07c4cb5c615fc";
            this.gps1.Name = "gps1";
            this.gps1.RequestLocation = true;
            this.gps1.TimeOut = 6000;
            // 
            // lblWeekDay
            // 
            this.lblWeekDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.lblWeekDay.Bold = true;
            this.lblWeekDay.FontSize = 35F;
            this.lblWeekDay.ForeColor = System.Drawing.Color.White;
            this.lblWeekDay.Name = "lblWeekDay";
            this.lblWeekDay.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.lblWeekDay.Size = new System.Drawing.Size(300, 60);
            this.lblWeekDay.Text = "星期二";
            // 
            // lblInfo
            // 
            this.lblInfo.BorderColor = System.Drawing.Color.Gray;
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lblInfo.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.lblInfo.Location = new System.Drawing.Point(10, 164);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.lblInfo.Size = new System.Drawing.Size(280, 30);
            this.lblInfo.Text = "目前暂无考勤模板！";
            this.lblInfo.Visible = false;
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.lblDate.Bold = true;
            this.lblDate.FontSize = 16F;
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(0, 60);
            this.lblDate.Name = "lblDate";
            this.lblDate.Padding = new Smobiler.Core.Controls.Padding(10F, 5F, 0F, 0F);
            this.lblDate.Size = new System.Drawing.Size(300, 35);
            this.lblDate.Text = "2012年7月26日";
            this.lblDate.VerticalAlignment = Smobiler.Core.Controls.VerticalAlignment.Top;
            this.lblDate.ZIndex = 1;
            // 
            // gridATdata
            // 
            this.gridATdata.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridATdata.Location = new System.Drawing.Point(0, 95);
            this.gridATdata.Name = "gridATdata";
            this.gridATdata.ShowSplitLine = true;
            this.gridATdata.Size = new System.Drawing.Size(300, 355);
            this.gridATdata.SplitLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.gridATdata.TemplateControlName = "frmAttendanceMainLayout";
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.title1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title1.Location = new System.Drawing.Point(111, 36);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 50);
            this.title1.TitleText = "考勤";
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblWeekDay,
            this.lblInfo,
            this.lblDate,
            this.gridATdata});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 500);
            this.panel1.Name = "panel1";
            this.panel1.Scrollable = true;
            this.panel1.Size = new System.Drawing.Size(300, 424);
            // 
            // frmAttendanceMain
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.gps1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel1});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmAttendanceMain_KeyDown);
            this.Load += new System.EventHandler(this.frmAttendanceMain_Load);
            this.Name = "frmAttendanceMain";

        }
        #endregion

        private Smobiler.Core.Controls.GPS gps1;
        private SmoONE.UI.Layout.Title title1;
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Label lblWeekDay;
        private Smobiler.Core.Controls.Label lblInfo;
        private Smobiler.Core.Controls.Label lblDate;
        private Smobiler.Core.Controls.ListView gridATdata;
    }
}
