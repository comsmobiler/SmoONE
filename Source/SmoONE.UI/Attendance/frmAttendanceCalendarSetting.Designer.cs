using System;
using Smobiler.Core;
namespace SmoONE.UI.Attendance
{
    partial class frmAttendanceCalendarSetting : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmAttendanceCalendarSetting()
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
            this.calendar1 = new Smobiler.Core.Controls.Calendar();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.title1 = new SmoONE.UI.Layout.Title();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.lblStartWork = new Smobiler.Core.Controls.Label();
            this.lblRest = new Smobiler.Core.Controls.Label();
            this.btnCDType = new Smobiler.Core.Controls.Button();
            this.lblEndWork = new Smobiler.Core.Controls.Label();
            this.lblPMStartWork = new Smobiler.Core.Controls.Label();
            this.lblPMEndWork = new Smobiler.Core.Controls.Label();
            this.dpPMEndWork = new Smobiler.Core.Controls.DatePicker();
            this.dpPMStartWork = new Smobiler.Core.Controls.DatePicker();
            this.dpAMEndWork = new Smobiler.Core.Controls.DatePicker();
            this.dpAMStartWork = new Smobiler.Core.Controls.DatePicker();
            this.dpStartWork = new Smobiler.Core.Controls.DatePicker();
            this.dpEndWork = new Smobiler.Core.Controls.DatePicker();
            // 
            // calendar1
            // 
            this.calendar1.BackColor = System.Drawing.Color.White;
            this.calendar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.calendar1.Name = "calendar1";
            this.calendar1.Size = new System.Drawing.Size(300, 270);
            this.calendar1.DateChanged += new System.EventHandler(this.calendar1_DateChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblStartWork,
            this.lblRest,
            this.btnCDType,
            this.lblEndWork,
            this.lblPMStartWork,
            this.lblPMEndWork,
            this.dpPMEndWork,
            this.dpPMStartWork,
            this.dpAMEndWork,
            this.dpAMStartWork,
            this.dpStartWork,
            this.dpEndWork});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 250);
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.title1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 50);
            this.title1.TitleText = "日历设置";
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.calendar1,
            this.panel1});
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 350);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 200);
            // 
            // lblStartWork
            // 
            this.lblStartWork.BackColor = System.Drawing.Color.White;
            this.lblStartWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblStartWork.Name = "lblStartWork";
            this.lblStartWork.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.lblStartWork.Size = new System.Drawing.Size(100, 35);
            this.lblStartWork.Text = "上班时间";
            // 
            // lblRest
            // 
            this.lblRest.BackColor = System.Drawing.Color.White;
            this.lblRest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lblRest.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.lblRest.Name = "lblRest";
            this.lblRest.Size = new System.Drawing.Size(300, 35);
            this.lblRest.Text = "休息";
            // 
            // btnCDType
            // 
            this.btnCDType.BackColor = System.Drawing.Color.White;
            this.btnCDType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnCDType.BorderRadius = 0;
            this.btnCDType.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCDType.Location = new System.Drawing.Point(0, 140);
            this.btnCDType.Name = "btnCDType";
            this.btnCDType.Size = new System.Drawing.Size(300, 35);
            this.btnCDType.Text = "设置为休息";
            this.btnCDType.Press += new System.EventHandler(this.btnATMode_Click);
            // 
            // lblEndWork
            // 
            this.lblEndWork.BackColor = System.Drawing.Color.White;
            this.lblEndWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblEndWork.Location = new System.Drawing.Point(0, 35);
            this.lblEndWork.Name = "lblEndWork";
            this.lblEndWork.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.lblEndWork.Size = new System.Drawing.Size(100, 35);
            this.lblEndWork.Text = "下班时间";
            // 
            // lblPMStartWork
            // 
            this.lblPMStartWork.BackColor = System.Drawing.Color.White;
            this.lblPMStartWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblPMStartWork.Location = new System.Drawing.Point(0, 70);
            this.lblPMStartWork.Name = "lblPMStartWork";
            this.lblPMStartWork.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.lblPMStartWork.Size = new System.Drawing.Size(100, 35);
            this.lblPMStartWork.Text = "下午上班";
            // 
            // lblPMEndWork
            // 
            this.lblPMEndWork.BackColor = System.Drawing.Color.White;
            this.lblPMEndWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblPMEndWork.Location = new System.Drawing.Point(0, 105);
            this.lblPMEndWork.Name = "lblPMEndWork";
            this.lblPMEndWork.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.lblPMEndWork.Size = new System.Drawing.Size(100, 35);
            this.lblPMEndWork.Text = "下午下班";
            // 
            // dpPMEndWork
            // 
            this.dpPMEndWork.BackColor = System.Drawing.Color.White;
            this.dpPMEndWork.FontSize = 12F;
            this.dpPMEndWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.dpPMEndWork.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.dpPMEndWork.Location = new System.Drawing.Point(100, 105);
            this.dpPMEndWork.Mode = Smobiler.Core.Controls.DatePickerMode.Time;
            this.dpPMEndWork.Name = "dpPMEndWork";
            this.dpPMEndWork.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.dpPMEndWork.Size = new System.Drawing.Size(200, 35);
            this.dpPMEndWork.Value = new System.DateTime(2017, 8, 9, 14, 7, 50, 207);
            this.dpPMEndWork.ValueChanged += new System.EventHandler(this.dpPMEndWork_DatePicked);
            // 
            // dpPMStartWork
            // 
            this.dpPMStartWork.BackColor = System.Drawing.Color.White;
            this.dpPMStartWork.FontSize = 12F;
            this.dpPMStartWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.dpPMStartWork.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.dpPMStartWork.Location = new System.Drawing.Point(100, 70);
            this.dpPMStartWork.Mode = Smobiler.Core.Controls.DatePickerMode.Time;
            this.dpPMStartWork.Name = "dpPMStartWork";
            this.dpPMStartWork.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.dpPMStartWork.Size = new System.Drawing.Size(200, 35);
            this.dpPMStartWork.Value = new System.DateTime(2017, 8, 9, 14, 7, 50, 209);
            this.dpPMStartWork.ValueChanged += new System.EventHandler(this.dpPMStartWork_DatePicked);
            // 
            // dpAMEndWork
            // 
            this.dpAMEndWork.BackColor = System.Drawing.Color.White;
            this.dpAMEndWork.FontSize = 12F;
            this.dpAMEndWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.dpAMEndWork.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.dpAMEndWork.Location = new System.Drawing.Point(100, 35);
            this.dpAMEndWork.Mode = Smobiler.Core.Controls.DatePickerMode.Time;
            this.dpAMEndWork.Name = "dpAMEndWork";
            this.dpAMEndWork.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.dpAMEndWork.Size = new System.Drawing.Size(200, 35);
            this.dpAMEndWork.Value = new System.DateTime(2017, 8, 9, 14, 7, 50, 212);
            this.dpAMEndWork.ValueChanged += new System.EventHandler(this.dpAMEndWork_DatePicked);
            // 
            // dpAMStartWork
            // 
            this.dpAMStartWork.BackColor = System.Drawing.Color.White;
            this.dpAMStartWork.FontSize = 12F;
            this.dpAMStartWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.dpAMStartWork.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.dpAMStartWork.Location = new System.Drawing.Point(100, 0);
            this.dpAMStartWork.Mode = Smobiler.Core.Controls.DatePickerMode.Time;
            this.dpAMStartWork.Name = "dpAMStartWork";
            this.dpAMStartWork.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.dpAMStartWork.Size = new System.Drawing.Size(200, 35);
            this.dpAMStartWork.Value = new System.DateTime(2017, 1, 19, 10, 21, 0, 0);
            this.dpAMStartWork.ValueChanged += new System.EventHandler(this.dpAMStartWork_DatePicked);
            // 
            // dpStartWork
            // 
            this.dpStartWork.BackColor = System.Drawing.Color.White;
            this.dpStartWork.FontSize = 12F;
            this.dpStartWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.dpStartWork.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.dpStartWork.Location = new System.Drawing.Point(100, 0);
            this.dpStartWork.Mode = Smobiler.Core.Controls.DatePickerMode.Time;
            this.dpStartWork.Name = "dpStartWork";
            this.dpStartWork.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.dpStartWork.Size = new System.Drawing.Size(200, 35);
            this.dpStartWork.Value = new System.DateTime(2017, 8, 9, 14, 7, 50, 216);
            this.dpStartWork.ValueChanged += new System.EventHandler(this.dpStartWork_DatePicked);
            // 
            // dpEndWork
            // 
            this.dpEndWork.BackColor = System.Drawing.Color.White;
            this.dpEndWork.FontSize = 12F;
            this.dpEndWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.dpEndWork.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.dpEndWork.Location = new System.Drawing.Point(100, 35);
            this.dpEndWork.Mode = Smobiler.Core.Controls.DatePickerMode.Time;
            this.dpEndWork.Name = "dpEndWork";
            this.dpEndWork.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.dpEndWork.Size = new System.Drawing.Size(200, 35);
            this.dpEndWork.Value = new System.DateTime(2017, 8, 9, 14, 7, 50, 218);
            this.dpEndWork.ValueChanged += new System.EventHandler(this.dpEndWork_DatePicked);
            // 
            // frmAttendanceCalendarSetting
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel2});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmAttendanceCalendarSetting_KeyDown);
            this.Load += new System.EventHandler(this.frmAttendanceCalendarSetting_Load);
            this.Name = "frmAttendanceCalendarSetting";

        }
        #endregion

        private SmoONE.UI.Layout.Title title1;
        private Smobiler.Core.Controls.Panel panel2;
        private Smobiler.Core.Controls.Calendar calendar1;
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Label lblStartWork;
        private Smobiler.Core.Controls.Label lblRest;
        private Smobiler.Core.Controls.Button btnCDType;
        private Smobiler.Core.Controls.Label lblEndWork;
        private Smobiler.Core.Controls.Label lblPMStartWork;
        private Smobiler.Core.Controls.Label lblPMEndWork;
        private Smobiler.Core.Controls.DatePicker dpPMEndWork;
        private Smobiler.Core.Controls.DatePicker dpPMStartWork;
        private Smobiler.Core.Controls.DatePicker dpAMEndWork;
        private Smobiler.Core.Controls.DatePicker dpAMStartWork;
        private Smobiler.Core.Controls.DatePicker dpStartWork;
        private Smobiler.Core.Controls.DatePicker dpEndWork;
    }
}