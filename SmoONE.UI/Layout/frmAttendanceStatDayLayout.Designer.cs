using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class frmAttendanceStatDayLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerForm generated code "

        public frmAttendanceStatDayLayout()
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
            this.lblDay = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblDay,
            this.label2});
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 50);
            this.panel1.Touchable = true;
            this.panel1.Press += new System.EventHandler(this.panel1_Press);
            // 
            // lblDay
            // 
            this.lblDay.DisplayMember = "Day";
            this.lblDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblDay.Name = "lblDay";
            this.lblDay.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.lblDay.Size = new System.Drawing.Size(260, 50);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label2.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label2.Location = new System.Drawing.Point(260, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.label2.Size = new System.Drawing.Size(40, 50);
            this.label2.Text = ">";
            // 
            // frmAttendanceStatDayLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(300, 50);
            this.Name = "frmAttendanceStatDayLayout";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Label lblDay;
        private Smobiler.Core.Controls.Label label2;
    }
}