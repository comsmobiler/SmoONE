using System;
using Smobiler.Core;
namespace SmoONE.UI.Attendance
{
    partial class frmAttendanceStatDay : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmAttendanceStatDay()
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
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.btnDate = new Smobiler.Core.Controls.Button();
            this.gridATdata = new Smobiler.Core.Controls.ListView();
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.title1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title1.Location = new System.Drawing.Point(111, 36);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 50);
            this.title1.TitleText = "¿¼ÇÚ¹ÜÀí";
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnDate,
            this.gridATdata});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 358);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 200);
            // 
            // btnDate
            // 
            this.btnDate.BackColor = System.Drawing.Color.White;
            this.btnDate.BorderRadius = 0;
            this.btnDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDate.FontSize = 12F;
            this.btnDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(300, 35);
            this.btnDate.Press += new System.EventHandler(this.ButDate_Click);
            // 
            // gridATdata
            // 
            this.gridATdata.BackColor = System.Drawing.Color.White;
            this.gridATdata.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridATdata.Location = new System.Drawing.Point(0, 35);
            this.gridATdata.Name = "gridATdata";
            this.gridATdata.PageSize = 10;
            this.gridATdata.ShowSplitLine = true;
            this.gridATdata.Size = new System.Drawing.Size(300, 415);
            this.gridATdata.SplitLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.gridATdata.TemplateControlName = "frmAttendanceStatDayLayout";
            // 
            // frmAttendanceStatDay
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel1});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmAttendanceStatDay_KeyDown);
            this.Load += new System.EventHandler(this.frmAttendanceStatDay_Load);
            this.Name = "frmAttendanceStatDay";

        }
        #endregion

        private SmoONE.UI.Layout.Title title1;
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Button btnDate;
        private Smobiler.Core.Controls.ListView gridATdata;
    }
}