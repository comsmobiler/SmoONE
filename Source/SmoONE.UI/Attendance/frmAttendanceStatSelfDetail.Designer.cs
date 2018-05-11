using System;
using Smobiler.Core;
namespace SmoONE.UI.Attendance
{
    partial class frmAttendanceStatSelfDetail : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmAttendanceStatSelfDetail()
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
            this.listView1 = new Smobiler.Core.Controls.ListView();
            this.title1 = new SmoONE.UI.Layout.Title();
            this.listView2 = new Smobiler.Core.Controls.ListView();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Name = "listView1";
            this.listView1.PageSize = 10;
            this.listView1.Size = new System.Drawing.Size(300, 450);
            this.listView1.TemplateControlName = "frmATStatSelfDetailDayLayout";
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.title1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title1.Location = new System.Drawing.Point(111, 36);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 50);
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.Color.White;
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.Name = "listView2";
            this.listView2.PageSize = 10;
            this.listView2.ShowSplitLine = true;
            this.listView2.Size = new System.Drawing.Size(300, 450);
            this.listView2.SplitLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.listView2.TemplateControlName = "frmATStatSelfDetailTypeLayout";
            // 
            // frmAttendanceStatSelfDetail
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.listView1,
            this.listView2});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmAttendanceStatSelfDetail_KeyDown);
            this.Load += new System.EventHandler(this.frmAttendanceStatSelfDetail_Load);
            this.Name = "frmAttendanceStatSelfDetail";

        }
        #endregion

        private Smobiler.Core.Controls.ListView listView1;
        private SmoONE.UI.Layout.Title title1;
        private Smobiler.Core.Controls.ListView listView2;
    }
}