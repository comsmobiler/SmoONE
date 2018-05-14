using System;
using Smobiler.Core;
namespace SmoONE.UI.Attendance
{
    partial class frmAttendanceStatMonth : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmAttendanceStatMonth()
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
            Smobiler.Core.Controls.PopListGroup popListGroup2 = new Smobiler.Core.Controls.PopListGroup();
            Smobiler.Core.Controls.PopListItem popListItem11 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem12 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem13 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem14 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem15 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem16 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem17 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem18 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem19 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem20 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem21 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem22 = new Smobiler.Core.Controls.PopListItem();
            this.popListYear = new Smobiler.Core.Controls.PopList();
            this.popListMonth = new Smobiler.Core.Controls.PopList();
            this.title1 = new SmoONE.UI.Layout.Title();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.btnYear = new Smobiler.Core.Controls.Button();
            this.lblYear = new Smobiler.Core.Controls.Label();
            this.BtnMonth = new Smobiler.Core.Controls.Button();
            this.lblMonth = new Smobiler.Core.Controls.Label();
            this.label8 = new Smobiler.Core.Controls.Label();
            this.lblID = new Smobiler.Core.Controls.Label();
            this.btnMSAllCount = new Smobiler.Core.Controls.Button();
            this.progress1 = new Smobiler.Core.Controls.Progress();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.btnMSInTimeCount = new Smobiler.Core.Controls.Button();
            this.btnATInTime = new Smobiler.Core.Controls.Button();
            this.proMSInTime = new Smobiler.Core.Controls.Progress();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.btnMSCLateCount = new Smobiler.Core.Controls.Button();
            this.btnATLate = new Smobiler.Core.Controls.Button();
            this.proMSCLate = new Smobiler.Core.Controls.Progress();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.btnMSLEarlyCount = new Smobiler.Core.Controls.Button();
            this.btnLEarly = new Smobiler.Core.Controls.Button();
            this.proMSLEarly = new Smobiler.Core.Controls.Progress();
            this.label9 = new Smobiler.Core.Controls.Label();
            this.label7 = new Smobiler.Core.Controls.Label();
            this.btnMSNoSignCount = new Smobiler.Core.Controls.Button();
            this.btnATNoSign = new Smobiler.Core.Controls.Button();
            this.proMSNoSign = new Smobiler.Core.Controls.Progress();
            this.label12 = new Smobiler.Core.Controls.Label();
            this.label11 = new Smobiler.Core.Controls.Label();
            this.btnATAbsentCount = new Smobiler.Core.Controls.Button();
            this.btnATAbsent = new Smobiler.Core.Controls.Button();
            this.proATAbsent = new Smobiler.Core.Controls.Progress();
            // 
            // popListYear
            // 
            popListItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem1.Text = "2008";
            popListItem2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem2.Text = "2009";
            popListItem3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem3.Text = "2010";
            popListItem4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem4.Text = "2011";
            popListItem5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem5.Text = "2012";
            popListItem6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem6.Text = "2013";
            popListItem7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem7.Text = "2014";
            popListItem8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem8.Text = "2015";
            popListItem9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem9.Text = "2016";
            popListItem10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem10.Text = "2017";
            popListGroup1.Items.AddRange(new Smobiler.Core.Controls.PopListItem[] {
            popListItem1,
            popListItem2,
            popListItem3,
            popListItem4,
            popListItem5,
            popListItem6,
            popListItem7,
            popListItem8,
            popListItem9,
            popListItem10});
            popListGroup1.Title = "请选择年份";
            popListGroup1.Value = null;
            this.popListYear.Groups.AddRange(new Smobiler.Core.Controls.PopListGroup[] {
            popListGroup1});
            this.popListYear.Name = "popListYear";
            this.popListYear.Selected += new System.EventHandler(this.popListYear_Selected);
            // 
            // popListMonth
            // 
            popListItem11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem11.Text = "1";
            popListItem12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem12.Text = "2";
            popListItem13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem13.Text = "3";
            popListItem14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem14.Text = "4";
            popListItem15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem15.Text = "5";
            popListItem16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem16.Text = "6";
            popListItem17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem17.Text = "7";
            popListItem18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem18.Text = "8";
            popListItem19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem19.Text = "9";
            popListItem20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem20.Text = "0";
            popListItem21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem21.Text = "11";
            popListItem22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem22.Text = "12";
            popListGroup2.Items.AddRange(new Smobiler.Core.Controls.PopListItem[] {
            popListItem11,
            popListItem12,
            popListItem13,
            popListItem14,
            popListItem15,
            popListItem16,
            popListItem17,
            popListItem18,
            popListItem19,
            popListItem20,
            popListItem21,
            popListItem22});
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
            this.title1.TitleText = "考勤统计";
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnYear,
            this.lblYear,
            this.BtnMonth,
            this.lblMonth,
            this.label8,
            this.lblID,
            this.btnMSAllCount,
            this.progress1,
            this.label2,
            this.label1,
            this.btnMSInTimeCount,
            this.btnATInTime,
            this.proMSInTime,
            this.label4,
            this.label3,
            this.btnMSCLateCount,
            this.btnATLate,
            this.proMSCLate,
            this.label6,
            this.label5,
            this.btnMSLEarlyCount,
            this.btnLEarly,
            this.proMSLEarly,
            this.label9,
            this.label7,
            this.btnMSNoSignCount,
            this.btnATNoSign,
            this.proMSNoSign,
            this.label12,
            this.label11,
            this.btnATAbsentCount,
            this.btnATAbsent,
            this.proATAbsent});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 145);
            this.panel1.Name = "panel1";
            this.panel1.Scrollable = true;
            this.panel1.Size = new System.Drawing.Size(300, 100);
            // 
            // btnYear
            // 
            this.btnYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnYear.BorderRadius = 0;
            this.btnYear.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnYear.Name = "btnYear";
            this.btnYear.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.btnYear.Size = new System.Drawing.Size(145, 35);
            this.btnYear.Text = "2017";
            // 
            // lblYear
            // 
            this.lblYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblYear.ForeColor = System.Drawing.Color.White;
            this.lblYear.Location = new System.Drawing.Point(145, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(19, 35);
            this.lblYear.Text = "年";
            // 
            // BtnMonth
            // 
            this.BtnMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BtnMonth.BorderRadius = 0;
            this.BtnMonth.Location = new System.Drawing.Point(164, 0);
            this.BtnMonth.Name = "BtnMonth";
            this.BtnMonth.Size = new System.Drawing.Size(20, 35);
            this.BtnMonth.Text = "2";
            // 
            // lblMonth
            // 
            this.lblMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblMonth.ForeColor = System.Drawing.Color.White;
            this.lblMonth.Location = new System.Drawing.Point(184, 0);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(116, 35);
            this.lblMonth.Text = "月  ";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.DataMember = "WorkDate1";
            this.label8.DisplayMember = "WorkDate1";
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label8.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label8.Location = new System.Drawing.Point(0, 35);
            this.label8.Name = "label8";
            this.label8.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.label8.Size = new System.Drawing.Size(300, 40);
            this.label8.ZIndex = 1;
            // 
            // lblID
            // 
            this.lblID.DataMember = "AT_TypeID";
            this.lblID.DisplayMember = "Dep_Name";
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblID.Location = new System.Drawing.Point(0, 35);
            this.lblID.Name = "lblID";
            this.lblID.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.lblID.Size = new System.Drawing.Size(150, 35);
            this.lblID.Text = "应签到";
            this.lblID.ZIndex = 2;
            // 
            // btnMSAllCount
            // 
            this.btnMSAllCount.BackColor = System.Drawing.Color.White;
            this.btnMSAllCount.BorderRadius = 0;
            this.btnMSAllCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.btnMSAllCount.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnMSAllCount.Location = new System.Drawing.Point(80, 35);
            this.btnMSAllCount.Name = "btnMSAllCount";
            this.btnMSAllCount.Size = new System.Drawing.Size(190, 30);
            this.btnMSAllCount.Text = "0人";
            this.btnMSAllCount.ZIndex = 3;
            // 
            // progress1
            // 
            this.progress1.Location = new System.Drawing.Point(10, 65);
            this.progress1.Name = "progress1";
            this.progress1.Size = new System.Drawing.Size(260, 5);
            this.progress1.TrackColor = System.Drawing.Color.LightGray;
            this.progress1.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.progress1.ZIndex = 5;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.DataMember = "WorkDate1";
            this.label2.DisplayMember = "WorkDate1";
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label2.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label2.Location = new System.Drawing.Point(0, 75);
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.label2.Size = new System.Drawing.Size(300, 40);
            this.label2.ZIndex = 6;
            // 
            // label1
            // 
            this.label1.DataMember = "AT_TypeID";
            this.label1.DisplayMember = "Dep_Name";
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(0, 75);
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.label1.Size = new System.Drawing.Size(150, 35);
            this.label1.Text = "准时";
            this.label1.ZIndex = 7;
            // 
            // btnMSInTimeCount
            // 
            this.btnMSInTimeCount.BackColor = System.Drawing.Color.White;
            this.btnMSInTimeCount.BorderRadius = 0;
            this.btnMSInTimeCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.btnMSInTimeCount.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnMSInTimeCount.Location = new System.Drawing.Point(80, 75);
            this.btnMSInTimeCount.Name = "btnMSInTimeCount";
            this.btnMSInTimeCount.Size = new System.Drawing.Size(190, 30);
            this.btnMSInTimeCount.Text = "0人";
            this.btnMSInTimeCount.ZIndex = 8;
            this.btnMSInTimeCount.Press += new System.EventHandler(this.btnATTypeSign_Click);
            // 
            // btnATInTime
            // 
            this.btnATInTime.BackColor = System.Drawing.Color.White;
            this.btnATInTime.BorderRadius = 0;
            this.btnATInTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnATInTime.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnATInTime.Location = new System.Drawing.Point(270, 75);
            this.btnATInTime.Name = "btnATInTime";
            this.btnATInTime.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.btnATInTime.Size = new System.Drawing.Size(30, 30);
            this.btnATInTime.Text = ">";
            this.btnATInTime.ZIndex = 9;
            this.btnATInTime.Press += new System.EventHandler(this.btnATTypeSign_Click);
            // 
            // proMSInTime
            // 
            this.proMSInTime.Location = new System.Drawing.Point(10, 105);
            this.proMSInTime.Name = "proMSInTime";
            this.proMSInTime.Size = new System.Drawing.Size(260, 5);
            this.proMSInTime.TrackColor = System.Drawing.Color.LightGray;
            this.proMSInTime.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(187)))), ((int)(((byte)(91)))));
            this.proMSInTime.ZIndex = 10;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.DataMember = "WorkDate1";
            this.label4.DisplayMember = "WorkDate1";
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label4.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label4.Location = new System.Drawing.Point(0, 115);
            this.label4.Name = "label4";
            this.label4.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.label4.Size = new System.Drawing.Size(300, 40);
            this.label4.ZIndex = 11;
            // 
            // label3
            // 
            this.label3.DataMember = "AT_TypeID";
            this.label3.DisplayMember = "Dep_Name";
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label3.Location = new System.Drawing.Point(0, 115);
            this.label3.Name = "label3";
            this.label3.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.label3.Size = new System.Drawing.Size(150, 35);
            this.label3.Text = "迟到";
            this.label3.ZIndex = 12;
            // 
            // btnMSCLateCount
            // 
            this.btnMSCLateCount.BackColor = System.Drawing.Color.White;
            this.btnMSCLateCount.BorderRadius = 0;
            this.btnMSCLateCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.btnMSCLateCount.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnMSCLateCount.Location = new System.Drawing.Point(80, 115);
            this.btnMSCLateCount.Name = "btnMSCLateCount";
            this.btnMSCLateCount.Size = new System.Drawing.Size(190, 30);
            this.btnMSCLateCount.Text = "0人";
            this.btnMSCLateCount.ZIndex = 13;
            this.btnMSCLateCount.Press += new System.EventHandler(this.btnATTypeSign_Click);
            // 
            // btnATLate
            // 
            this.btnATLate.BackColor = System.Drawing.Color.White;
            this.btnATLate.BorderRadius = 0;
            this.btnATLate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnATLate.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnATLate.Location = new System.Drawing.Point(270, 115);
            this.btnATLate.Name = "btnATLate";
            this.btnATLate.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.btnATLate.Size = new System.Drawing.Size(30, 30);
            this.btnATLate.Text = ">";
            this.btnATLate.ZIndex = 14;
            this.btnATLate.Press += new System.EventHandler(this.btnATTypeSign_Click);
            // 
            // proMSCLate
            // 
            this.proMSCLate.Location = new System.Drawing.Point(10, 145);
            this.proMSCLate.Name = "proMSCLate";
            this.proMSCLate.Size = new System.Drawing.Size(260, 5);
            this.proMSCLate.TrackColor = System.Drawing.Color.LightGray;
            this.proMSCLate.ValueColor = System.Drawing.Color.Yellow;
            this.proMSCLate.ZIndex = 15;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.DataMember = "WorkDate1";
            this.label6.DisplayMember = "WorkDate1";
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label6.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label6.Location = new System.Drawing.Point(0, 155);
            this.label6.Name = "label6";
            this.label6.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.label6.Size = new System.Drawing.Size(300, 40);
            this.label6.ZIndex = 16;
            // 
            // label5
            // 
            this.label5.DataMember = "AT_TypeID";
            this.label5.DisplayMember = "Dep_Name";
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label5.Location = new System.Drawing.Point(0, 155);
            this.label5.Name = "label5";
            this.label5.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.label5.Size = new System.Drawing.Size(150, 35);
            this.label5.Text = "早退";
            this.label5.ZIndex = 17;
            // 
            // btnMSLEarlyCount
            // 
            this.btnMSLEarlyCount.BackColor = System.Drawing.Color.White;
            this.btnMSLEarlyCount.BorderRadius = 0;
            this.btnMSLEarlyCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.btnMSLEarlyCount.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnMSLEarlyCount.Location = new System.Drawing.Point(80, 155);
            this.btnMSLEarlyCount.Name = "btnMSLEarlyCount";
            this.btnMSLEarlyCount.Size = new System.Drawing.Size(190, 30);
            this.btnMSLEarlyCount.Text = "0人";
            this.btnMSLEarlyCount.ZIndex = 18;
            this.btnMSLEarlyCount.Press += new System.EventHandler(this.btnATTypeSign_Click);
            // 
            // btnLEarly
            // 
            this.btnLEarly.BackColor = System.Drawing.Color.White;
            this.btnLEarly.BorderRadius = 0;
            this.btnLEarly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnLEarly.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnLEarly.Location = new System.Drawing.Point(270, 155);
            this.btnLEarly.Name = "btnLEarly";
            this.btnLEarly.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.btnLEarly.Size = new System.Drawing.Size(30, 30);
            this.btnLEarly.Text = ">";
            this.btnLEarly.ZIndex = 19;
            this.btnLEarly.Press += new System.EventHandler(this.btnATTypeSign_Click);
            // 
            // proMSLEarly
            // 
            this.proMSLEarly.Location = new System.Drawing.Point(10, 185);
            this.proMSLEarly.Name = "proMSLEarly";
            this.proMSLEarly.Size = new System.Drawing.Size(260, 5);
            this.proMSLEarly.TrackColor = System.Drawing.Color.LightGray;
            this.proMSLEarly.ValueColor = System.Drawing.Color.Orange;
            this.proMSLEarly.ZIndex = 20;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.DataMember = "WorkDate1";
            this.label9.DisplayMember = "WorkDate1";
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label9.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label9.Location = new System.Drawing.Point(0, 195);
            this.label9.Name = "label9";
            this.label9.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.label9.Size = new System.Drawing.Size(300, 40);
            this.label9.ZIndex = 21;
            // 
            // label7
            // 
            this.label7.DataMember = "AT_TypeID";
            this.label7.DisplayMember = "Dep_Name";
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label7.Location = new System.Drawing.Point(0, 195);
            this.label7.Name = "label7";
            this.label7.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.label7.Size = new System.Drawing.Size(150, 35);
            this.label7.Text = "未签到";
            this.label7.ZIndex = 22;
            // 
            // btnMSNoSignCount
            // 
            this.btnMSNoSignCount.BackColor = System.Drawing.Color.White;
            this.btnMSNoSignCount.BorderRadius = 0;
            this.btnMSNoSignCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.btnMSNoSignCount.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnMSNoSignCount.Location = new System.Drawing.Point(80, 195);
            this.btnMSNoSignCount.Name = "btnMSNoSignCount";
            this.btnMSNoSignCount.Size = new System.Drawing.Size(190, 30);
            this.btnMSNoSignCount.Text = "0人";
            this.btnMSNoSignCount.ZIndex = 23;
            this.btnMSNoSignCount.Press += new System.EventHandler(this.btnATTypeSign_Click);
            // 
            // btnATNoSign
            // 
            this.btnATNoSign.BackColor = System.Drawing.Color.White;
            this.btnATNoSign.BorderRadius = 0;
            this.btnATNoSign.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnATNoSign.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnATNoSign.Location = new System.Drawing.Point(270, 195);
            this.btnATNoSign.Name = "btnATNoSign";
            this.btnATNoSign.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.btnATNoSign.Size = new System.Drawing.Size(30, 30);
            this.btnATNoSign.Text = ">";
            this.btnATNoSign.ZIndex = 24;
            this.btnATNoSign.Press += new System.EventHandler(this.btnATTypeSign_Click);
            // 
            // proMSNoSign
            // 
            this.proMSNoSign.Location = new System.Drawing.Point(10, 225);
            this.proMSNoSign.Name = "proMSNoSign";
            this.proMSNoSign.Size = new System.Drawing.Size(260, 5);
            this.proMSNoSign.TrackColor = System.Drawing.Color.LightGray;
            this.proMSNoSign.ValueColor = System.Drawing.Color.Red;
            this.proMSNoSign.ZIndex = 25;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.DataMember = "WorkDate1";
            this.label12.DisplayMember = "WorkDate1";
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label12.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label12.Location = new System.Drawing.Point(0, 235);
            this.label12.Name = "label12";
            this.label12.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.label12.Size = new System.Drawing.Size(300, 40);
            this.label12.ZIndex = 26;
            // 
            // label11
            // 
            this.label11.DataMember = "AT_TypeID";
            this.label11.DisplayMember = "Dep_Name";
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label11.Location = new System.Drawing.Point(0, 235);
            this.label11.Name = "label11";
            this.label11.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.label11.Size = new System.Drawing.Size(150, 35);
            this.label11.Text = "全天旷工";
            this.label11.ZIndex = 27;
            // 
            // btnATAbsentCount
            // 
            this.btnATAbsentCount.BackColor = System.Drawing.Color.White;
            this.btnATAbsentCount.BorderRadius = 0;
            this.btnATAbsentCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.btnATAbsentCount.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnATAbsentCount.Location = new System.Drawing.Point(80, 235);
            this.btnATAbsentCount.Name = "btnATAbsentCount";
            this.btnATAbsentCount.Size = new System.Drawing.Size(190, 30);
            this.btnATAbsentCount.Text = "0人";
            this.btnATAbsentCount.ZIndex = 28;
            this.btnATAbsentCount.Press += new System.EventHandler(this.btnATTypeSign_Click);
            // 
            // btnATAbsent
            // 
            this.btnATAbsent.BackColor = System.Drawing.Color.White;
            this.btnATAbsent.BorderRadius = 0;
            this.btnATAbsent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnATAbsent.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnATAbsent.Location = new System.Drawing.Point(270, 235);
            this.btnATAbsent.Name = "btnATAbsent";
            this.btnATAbsent.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.btnATAbsent.Size = new System.Drawing.Size(30, 30);
            this.btnATAbsent.Text = ">";
            this.btnATAbsent.ZIndex = 29;
            this.btnATAbsent.Press += new System.EventHandler(this.btnATTypeSign_Click);
            // 
            // proATAbsent
            // 
            this.proATAbsent.Location = new System.Drawing.Point(10, 268);
            this.proATAbsent.Name = "proATAbsent";
            this.proATAbsent.Size = new System.Drawing.Size(260, 5);
            this.proATAbsent.TrackColor = System.Drawing.Color.LightGray;
            this.proATAbsent.ValueColor = System.Drawing.Color.Red;
            this.proATAbsent.ZIndex = 30;
            // 
            // frmAttendanceStatMonth
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.popListYear,
            this.popListMonth});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel1});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmAttendanceStatMonth_KeyDown);
            this.Load += new System.EventHandler(this.frmAttendanceStatMonth_Load);
            this.Name = "frmAttendanceStatMonth";

        }
        #endregion
        private Smobiler.Core.Controls.PopList popListYear;
        private Smobiler.Core.Controls.PopList popListMonth;
        private SmoONE.UI.Layout.Title title1;
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Button btnYear;
        private Smobiler.Core.Controls.Label lblYear;
        private Smobiler.Core.Controls.Button BtnMonth;
        private Smobiler.Core.Controls.Label lblMonth;
        internal Smobiler.Core.Controls.Label label8;
        internal Smobiler.Core.Controls.Label lblID;
        private Smobiler.Core.Controls.Button btnMSAllCount;
        private Smobiler.Core.Controls.Progress progress1;
        internal Smobiler.Core.Controls.Label label2;
        internal Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Button btnMSInTimeCount;
        private Smobiler.Core.Controls.Button btnATInTime;
        private Smobiler.Core.Controls.Progress proMSInTime;
        internal Smobiler.Core.Controls.Label label4;
        internal Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Button btnMSCLateCount;
        private Smobiler.Core.Controls.Button btnATLate;
        private Smobiler.Core.Controls.Progress proMSCLate;
        internal Smobiler.Core.Controls.Label label6;
        internal Smobiler.Core.Controls.Label label5;
        private Smobiler.Core.Controls.Button btnMSLEarlyCount;
        private Smobiler.Core.Controls.Button btnLEarly;
        private Smobiler.Core.Controls.Progress proMSLEarly;
        internal Smobiler.Core.Controls.Label label9;
        internal Smobiler.Core.Controls.Label label7;
        private Smobiler.Core.Controls.Button btnMSNoSignCount;
        private Smobiler.Core.Controls.Button btnATNoSign;
        private Smobiler.Core.Controls.Progress proMSNoSign;
        internal Smobiler.Core.Controls.Label label12;
        internal Smobiler.Core.Controls.Label label11;
        private Smobiler.Core.Controls.Button btnATAbsentCount;
        private Smobiler.Core.Controls.Button btnATAbsent;
        private Smobiler.Core.Controls.Progress proATAbsent;
    }
}