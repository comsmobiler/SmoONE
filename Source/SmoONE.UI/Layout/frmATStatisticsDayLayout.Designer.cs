using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class frmATStatisticsDayLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerForm generated code "

        public frmATStatisticsDayLayout()
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
            this.lblUser = new Smobiler.Core.Controls.Label();
            this.proLate = new Smobiler.Core.Controls.Progress();
            this.proEarly = new Smobiler.Core.Controls.Progress();
            this.proNo = new Smobiler.Core.Controls.Progress();
            this.label9 = new Smobiler.Core.Controls.Label();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.label7 = new Smobiler.Core.Controls.Label();
            this.label10 = new Smobiler.Core.Controls.Label();
            this.proAl = new Smobiler.Core.Controls.Progress();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.label8 = new Smobiler.Core.Controls.Label();
            this.label11 = new Smobiler.Core.Controls.Label();
            this.lblAbsenteeism = new Smobiler.Core.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblUser,
            this.proLate,
            this.proEarly,
            this.proNo,
            this.label9,
            this.label5,
            this.label7,
            this.label10,
            this.proAl,
            this.label1,
            this.label2,
            this.label4,
            this.label8,
            this.label11,
            this.lblAbsenteeism});
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 165);
            this.panel1.Touchable = true;
            this.panel1.Press += new System.EventHandler(this.panel1_Press);
            // 
            // lblUser
            // 
            this.lblUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.lblUser.DataMember = "U_ID";
            this.lblUser.DisplayMember = "Total";
            this.lblUser.FontSize = 12F;
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblUser.Name = "lblUser";
            this.lblUser.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.lblUser.Size = new System.Drawing.Size(200, 20);
            this.lblUser.ZIndex = 3;
            // 
            // proLate
            // 
            this.proLate.DataMember = "ProLate";
            this.proLate.DisplayMember = "ProLate";
            this.proLate.Location = new System.Drawing.Point(10, 85);
            this.proLate.Name = "proLate";
            this.proLate.ValueColor = System.Drawing.Color.Yellow;
            this.proLate.Size = new System.Drawing.Size(260, 5);
            this.proLate.TrackColor = System.Drawing.Color.LightGray;
            // 
            // proEarly
            // 
            this.proEarly.DataMember = "ProEarly";
            this.proEarly.DisplayMember = "ProEarly";
            this.proEarly.Location = new System.Drawing.Point(10, 120);
            this.proEarly.Name = "proEarly";
            this.proEarly.ValueColor = System.Drawing.Color.Orange;
            this.proEarly.Size = new System.Drawing.Size(260, 5);
            this.proEarly.TrackColor = System.Drawing.Color.LightGray;
            // 
            // proNo
            // 
            this.proNo.DataMember = "ProNo";
            this.proNo.DisplayMember = "ProNo";
            this.proNo.Location = new System.Drawing.Point(10, 155);
            this.proNo.Name = "proNo";
            this.proNo.ValueColor = System.Drawing.Color.Red;
            this.proNo.Size = new System.Drawing.Size(260, 5);
            this.proNo.TrackColor = System.Drawing.Color.LightGray;
            // 
            // label9
            // 
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label9.Location = new System.Drawing.Point(0, 20);
            this.label9.Name = "label9";
            this.label9.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.label9.Size = new System.Drawing.Size(66, 30);
            this.label9.Text = "准时";
            this.label9.ZIndex = 1;
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label5.Location = new System.Drawing.Point(0, 55);
            this.label5.Name = "label5";
            this.label5.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.label5.Size = new System.Drawing.Size(66, 30);
            this.label5.Text = "迟到";
            this.label5.ZIndex = 1;
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label7.Location = new System.Drawing.Point(0, 90);
            this.label7.Name = "label7";
            this.label7.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.label7.Size = new System.Drawing.Size(66, 30);
            this.label7.Text = "早退";
            this.label7.ZIndex = 1;
            // 
            // label10
            // 
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label10.Location = new System.Drawing.Point(0, 125);
            this.label10.Name = "label10";
            this.label10.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.label10.Size = new System.Drawing.Size(66, 30);
            this.label10.Text = "未签";
            this.label10.ZIndex = 1;
            // 
            // proAl
            // 
            this.proAl.DataMember = "ProAl";
            this.proAl.DisplayMember = "ProAl";
            this.proAl.Location = new System.Drawing.Point(10, 50);
            this.proAl.Name = "proAl";
            this.proAl.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(187)))), ((int)(((byte)(91)))));
            this.proAl.Size = new System.Drawing.Size(260, 5);
            this.proAl.TrackColor = System.Drawing.Color.LightGray;
            // 
            // label1
            // 
            this.label1.DataMember = "Al";
            this.label1.DisplayMember = "Al";
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label1.Location = new System.Drawing.Point(66, 20);
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 2F, 0F);
            this.label1.Size = new System.Drawing.Size(204, 30);
            this.label1.Text = "0次";
            this.label1.ZIndex = 3;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label2.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label2.Location = new System.Drawing.Point(270, 20);
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.label2.Size = new System.Drawing.Size(30, 145);
            this.label2.Text = ">";
            this.label2.ZIndex = 3;
            // 
            // label4
            // 
            this.label4.DataMember = "Late";
            this.label4.DisplayMember = "Late";
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label4.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label4.Location = new System.Drawing.Point(66, 55);
            this.label4.Name = "label4";
            this.label4.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 2F, 0F);
            this.label4.Size = new System.Drawing.Size(204, 30);
            this.label4.Text = "0次";
            this.label4.ZIndex = 3;
            // 
            // label8
            // 
            this.label8.DataMember = "Early";
            this.label8.DisplayMember = "Early";
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label8.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label8.Location = new System.Drawing.Point(66, 90);
            this.label8.Name = "label8";
            this.label8.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 2F, 0F);
            this.label8.Size = new System.Drawing.Size(204, 30);
            this.label8.Text = "0次";
            this.label8.ZIndex = 3;
            // 
            // label11
            // 
            this.label11.DataMember = "No";
            this.label11.DisplayMember = "No";
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label11.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label11.Location = new System.Drawing.Point(66, 125);
            this.label11.Name = "label11";
            this.label11.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 2F, 0F);
            this.label11.Size = new System.Drawing.Size(204, 30);
            this.label11.Text = "0次";
            this.label11.ZIndex = 3;
            // 
            // lblAbsenteeism
            // 
            this.lblAbsenteeism.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.lblAbsenteeism.DataMember = "ISAbsenteeism";
            this.lblAbsenteeism.DisplayMember = "Absenteeism";
            this.lblAbsenteeism.FontSize = 12F;
            this.lblAbsenteeism.ForeColor = System.Drawing.Color.Red;
            this.lblAbsenteeism.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblAbsenteeism.Location = new System.Drawing.Point(200, 0);
            this.lblAbsenteeism.Name = "lblAbsenteeism";
            this.lblAbsenteeism.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.lblAbsenteeism.Size = new System.Drawing.Size(100, 20);
            this.lblAbsenteeism.ZIndex = 3;
            // 
            // frmATStatisticsDayLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(300, 165);
            this.Name = "frmATStatisticsDayLayout";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        internal Smobiler.Core.Controls.Label lblUser;
        private Smobiler.Core.Controls.Progress proLate;
        private Smobiler.Core.Controls.Progress proEarly;
        private Smobiler.Core.Controls.Progress proNo;
        internal Smobiler.Core.Controls.Label label9;
        internal Smobiler.Core.Controls.Label label5;
        internal Smobiler.Core.Controls.Label label7;
        internal Smobiler.Core.Controls.Label label10;
        private Smobiler.Core.Controls.Progress proAl;
        internal Smobiler.Core.Controls.Label label1;
        internal Smobiler.Core.Controls.Label label2;
        internal Smobiler.Core.Controls.Label label4;
        internal Smobiler.Core.Controls.Label label8;
        internal Smobiler.Core.Controls.Label label11;
        internal Smobiler.Core.Controls.Label lblAbsenteeism;
    }
}