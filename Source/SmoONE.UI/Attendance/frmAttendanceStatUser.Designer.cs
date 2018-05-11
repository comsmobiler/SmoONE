using System;
using Smobiler.Core;
namespace SmoONE.UI.Attendance
{
    partial class frmAttendanceStatUser : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmAttendanceStatUser()
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
            this.gridATUserData = new Smobiler.Core.Controls.ListView();
            this.lblATMonth = new Smobiler.Core.Controls.Label();
            this.title1 = new SmoONE.UI.Layout.Title();
            // 
            // gridATUserData
            // 
            this.gridATUserData.BackColor = System.Drawing.Color.White;
            this.gridATUserData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridATUserData.Name = "gridATUserData";
            this.gridATUserData.PageSize = 10;
            this.gridATUserData.ShowSplitLine = true;
            this.gridATUserData.Size = new System.Drawing.Size(300, 415);
            this.gridATUserData.TemplateControlName = "frmUserLayout";
            // 
            // lblATMonth
            // 
            this.lblATMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblATMonth.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblATMonth.ForeColor = System.Drawing.Color.White;
            this.lblATMonth.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.lblATMonth.Name = "lblATMonth";
            this.lblATMonth.Size = new System.Drawing.Size(300, 35);
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
            // frmAttendanceStatUser
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.lblATMonth,
            this.gridATUserData});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmAttendanceStatUser_KeyDown);
            this.Load += new System.EventHandler(this.frmAttendanceStatUser_Load);
            this.Name = "frmAttendanceStatUser";

        }
        #endregion

        private Smobiler.Core.Controls.ListView gridATUserData;
        private Smobiler.Core.Controls.Label lblATMonth;
        private SmoONE.UI.Layout.Title title1;
    }
}