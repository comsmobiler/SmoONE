using System;
using Smobiler.Core;
namespace SmoONE.UI.Attendance
{
    partial class frmAttendanceStatSelfDay : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmAttendanceStatSelfDay()
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
            Smobiler.Core.Controls.PopListGroup popListGroup1 = new Smobiler.Core.Controls.PopListGroup();
            Smobiler.Core.Controls.PopListGroup popListGroup2 = new Smobiler.Core.Controls.PopListGroup();
            Smobiler.Core.Controls.PopListItem popListItem1 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem2 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem3 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem4 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem5 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem6 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem7 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem8 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem9 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem10 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem11 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem12 = new Smobiler.Core.Controls.PopListItem();
            this.gridATdata = new Smobiler.Core.Controls.ListView();
            this.popListYear = new Smobiler.Core.Controls.PopList();
            this.popListMonth = new Smobiler.Core.Controls.PopList();
            this.title1 = new SmoONE.UI.Layout.Title();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.btnYear = new Smobiler.Core.Controls.Button();
            this.btnMonth = new Smobiler.Core.Controls.Button();
            this.btnCheck = new Smobiler.Core.Controls.Button();
            // 
            // gridATdata
            // 
            this.gridATdata.BackColor = System.Drawing.Color.White;
            this.gridATdata.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.gridATdata.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.gridATdata.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridATdata.Location = new System.Drawing.Point(0, 85);
            this.gridATdata.Name = "gridATdata";
            this.gridATdata.PageSize = 10;
            this.gridATdata.ShowSplitLine = true;
            this.gridATdata.Size = new System.Drawing.Size(300, 450);
            this.gridATdata.SplitLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.gridATdata.TemplateControlName = "frmAttendanceStatDayLayout";
            // 
            // popListYear
            // 
            popListGroup1.Title = "请选择年份";
            popListGroup1.Value = null;
            this.popListYear.Groups.AddRange(new Smobiler.Core.Controls.PopListGroup[] {
            popListGroup1});
            this.popListYear.Name = "popListYear";
            this.popListYear.Selected += new System.EventHandler(this.popListYear_Selected);
            // 
            // popListMonth
            // 
            popListItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem1.Text = "1";
            popListItem2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem2.Text = "2";
            popListItem3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem3.Text = "3";
            popListItem4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem4.Text = "4";
            popListItem5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem5.Text = "5";
            popListItem6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem6.Text = "6";
            popListItem7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem7.Text = "7";
            popListItem8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem8.Text = "8";
            popListItem9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem9.Text = "9";
            popListItem10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem10.Text = "10";
            popListItem11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem11.Text = "11";
            popListItem12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem12.Text = "12";
            popListGroup2.Items.AddRange(new Smobiler.Core.Controls.PopListItem[] {
            popListItem1,
            popListItem2,
            popListItem3,
            popListItem4,
            popListItem5,
            popListItem6,
            popListItem7,
            popListItem8,
            popListItem9,
            popListItem10,
            popListItem11,
            popListItem12});
            popListGroup2.Title = "请选择月份";
            popListGroup2.Value = null;
            this.popListMonth.Groups.AddRange(new Smobiler.Core.Controls.PopListGroup[] {
            popListGroup2});
            this.popListMonth.Name = "popListMonth";
            this.popListMonth.Selected += new System.EventHandler(this.popListMonth_Selected);
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
            this.btnYear,
            this.btnMonth,
            this.btnCheck});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 35);
            // 
            // btnYear
            // 
            this.btnYear.BackColor = System.Drawing.Color.White;
            this.btnYear.BorderRadius = 0;
            this.btnYear.FontSize = 12F;
            this.btnYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnYear.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnYear.Name = "btnYear";
            this.btnYear.Size = new System.Drawing.Size(145, 35);
            this.btnYear.Text = " ▼ 2017年";
            this.btnYear.Press += new System.EventHandler(this.ButYear_Click);
            // 
            // btnMonth
            // 
            this.btnMonth.BackColor = System.Drawing.Color.White;
            this.btnMonth.BorderRadius = 0;
            this.btnMonth.FontSize = 12F;
            this.btnMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnMonth.Location = new System.Drawing.Point(145, 0);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(42, 35);
            this.btnMonth.Text = "2月▼";
            this.btnMonth.Press += new System.EventHandler(this.ButMonth_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.White;
            this.btnCheck.BorderRadius = 0;
            this.btnCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnCheck.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnCheck.Location = new System.Drawing.Point(187, 0);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.btnCheck.Size = new System.Drawing.Size(113, 35);
            this.btnCheck.Text = ">";
            this.btnCheck.Press += new System.EventHandler(this.ButCheck_Click);
            // 
            // frmAttendanceStatSelfDay
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.popListYear,
            this.popListMonth});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel1,
            this.gridATdata});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmAttendanceStatSelfDay_KeyDown);
            this.Load += new System.EventHandler(this.frmAttendanceStatSelfDay_Load);
            this.Name = "frmAttendanceStatSelfDay";

        }
        #endregion

        private Smobiler.Core.Controls.ListView gridATdata;
        private Smobiler.Core.Controls.PopList popListYear;
        private Smobiler.Core.Controls.PopList popListMonth;
        private SmoONE.UI.Layout.Title title1;
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Button btnYear;
        private Smobiler.Core.Controls.Button btnMonth;
        private Smobiler.Core.Controls.Button btnCheck;
    }
}