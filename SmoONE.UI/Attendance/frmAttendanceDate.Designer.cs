using System;
using Smobiler.Core;
namespace SmoONE.UI.Attendance
{
    partial class frmAttendanceDate : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmAttendanceDate()
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
            Smobiler.Core.Controls.RadioButton radioButton1 = new Smobiler.Core.Controls.RadioButton();
            Smobiler.Core.Controls.RadioButton radioButton2 = new Smobiler.Core.Controls.RadioButton();
            Smobiler.Core.Controls.RadioButton radioButton3 = new Smobiler.Core.Controls.RadioButton();
            Smobiler.Core.Controls.RadioButton radioButton4 = new Smobiler.Core.Controls.RadioButton();
            Smobiler.Core.Controls.RadioButton radioButton5 = new Smobiler.Core.Controls.RadioButton();
            Smobiler.Core.Controls.RadioButton radioButton6 = new Smobiler.Core.Controls.RadioButton();
            Smobiler.Core.Controls.RadioButton radioButton7 = new Smobiler.Core.Controls.RadioButton();
            this.title1 = new SmoONE.UI.Layout.Title();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.radioDate = new Smobiler.Core.Controls.RadioGroup();
            this.lblADeviation = new Smobiler.Core.Controls.Label();
            this.pCalendar = new Smobiler.Core.Controls.Panel();
            this.fontIcon1 = new Smobiler.Core.Controls.FontIcon();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.title1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title1.Location = new System.Drawing.Point(111, 36);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 50);
            this.title1.TitleText = "日期";
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.radioDate,
            this.lblADeviation,
            this.pCalendar});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 95);
            this.panel1.Name = "panel1";
            this.panel1.Scrollable = true;
            this.panel1.Size = new System.Drawing.Size(300, 100);
            // 
            // radioDate
            // 
            this.radioDate.BackColor = System.Drawing.Color.White;
            radioButton1.ID = "1";
            radioButton1.Text = "星期一";
            radioButton1.Value = "1";
            radioButton2.ID = "2";
            radioButton2.Text = "星期二";
            radioButton2.Value = "2";
            radioButton3.ID = "3";
            radioButton3.Text = "星期三";
            radioButton3.Value = "3";
            radioButton4.ID = "4";
            radioButton4.Text = "星期四";
            radioButton4.Value = "4";
            radioButton5.ID = "5";
            radioButton5.Text = "星期五";
            radioButton5.Value = "5";
            radioButton6.ID = "6";
            radioButton6.Text = "星期六";
            radioButton6.Value = "6";
            radioButton7.ID = "7";
            radioButton7.Text = "星期日";
            radioButton7.Value = "7";
            this.radioDate.Buttons.AddRange(new Smobiler.Core.Controls.RadioButton[] {
            radioButton1,
            radioButton2,
            radioButton3,
            radioButton4,
            radioButton5,
            radioButton6,
            radioButton7});
            this.radioDate.Location = new System.Drawing.Point(0, 10);
            this.radioDate.MultiSelect = true;
            this.radioDate.Name = "radioDate";
            this.radioDate.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 4F, 0F);
            this.radioDate.Size = new System.Drawing.Size(300, 245);
            this.radioDate.ButtonPress += new Smobiler.Core.Controls.RadioButtonPressEventHandler(this.radioDate_ButtonPress);
            // 
            // lblADeviation
            // 
            this.lblADeviation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.lblADeviation.FontSize = 12F;
            this.lblADeviation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lblADeviation.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblADeviation.Location = new System.Drawing.Point(0, 300);
            this.lblADeviation.Name = "lblADeviation";
            this.lblADeviation.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.lblADeviation.Size = new System.Drawing.Size(300, 20);
            this.lblADeviation.Text = "可单独设置某一天的考勤时间";
            this.lblADeviation.ZIndex = 1;
            // 
            // pCalendar
            // 
            this.pCalendar.BackColor = System.Drawing.Color.White;
            this.pCalendar.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.fontIcon1,
            this.label1,
            this.label2});
            this.pCalendar.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.pCalendar.Location = new System.Drawing.Point(0, 265);
            this.pCalendar.Name = "pCalendar";
            this.pCalendar.Size = new System.Drawing.Size(307, 35);
            this.pCalendar.Touchable = true;
            this.pCalendar.Press += new System.EventHandler(this.pCalendar_Press);
            // 
            // fontIcon1
            // 
            this.fontIcon1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.fontIcon1.Margin = new Smobiler.Core.Controls.Margin(4F, 0F, 0F, 0F);
            this.fontIcon1.Name = "fontIcon1";
            this.fontIcon1.Padding = new Smobiler.Core.Controls.Padding(0F, 4F, 0F, 4F);
            this.fontIcon1.ResourceID = "calendar";
            this.fontIcon1.Size = new System.Drawing.Size(35, 35);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(39, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 35);
            this.label1.Text = "自定义日期";
            // 
            // label2
            // 
            this.label2.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label2.Location = new System.Drawing.Point(275, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.label2.Size = new System.Drawing.Size(25, 35);
            this.label2.Text = ">";
            // 
            // frmAttendanceDate
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel1});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmAttendanceDate_KeyDown);
            this.Load += new System.EventHandler(this.frmAttendanceDate_Load);
            this.Name = "frmAttendanceDate";

        }
        #endregion
        private SmoONE.UI.Layout.Title title1;
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.RadioGroup radioDate;
        private Smobiler.Core.Controls.Label lblADeviation;
        private Smobiler.Core.Controls.Panel pCalendar;
        private Smobiler.Core.Controls.FontIcon fontIcon1;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label label2;
    }
}