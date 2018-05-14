using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class frmAttendanceStatisticsLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerForm generated code "

        public frmAttendanceStatisticsLayout()
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
            this.image1 = new Smobiler.Core.Controls.Image();
            this.lblTotal = new Smobiler.Core.Controls.Label();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.lblLate = new Smobiler.Core.Controls.Label();
            this.label = new Smobiler.Core.Controls.Label();
            this.lblEarly = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.lblNo = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.lblAl = new Smobiler.Core.Controls.Label();
            this.lbl3 = new Smobiler.Core.Controls.Label();
            this.lblID = new Smobiler.Core.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image1,
            this.lblTotal,
            this.label1,
            this.lblLate,
            this.label,
            this.lblEarly,
            this.label3,
            this.lblNo,
            this.label2,
            this.lblAl,
            this.lbl3,
            this.lblID});
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 60);
            this.panel1.Touchable = true;
            this.panel1.Press += new System.EventHandler(this.panel1_Press);
            // 
            // image1
            // 
            this.image1.BorderRadius = 10;
            this.image1.DataMember = "ID";
            this.image1.DisplayMember = "Pict";
            this.image1.Location = new System.Drawing.Point(10, 10);
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.Size(30, 30);
            this.image1.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Cover;
            // 
            // lblTotal
            // 
            this.lblTotal.DisplayMember = "Total";
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblTotal.Location = new System.Drawing.Point(106, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Padding = new Smobiler.Core.Controls.Padding(2F, 0F, 0F, 0F);
            this.lblTotal.Size = new System.Drawing.Size(75, 30);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label1.Location = new System.Drawing.Point(59, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 30);
            this.label1.Text = "迟到";
            // 
            // lblLate
            // 
            this.lblLate.DisplayMember = "Late";
            this.lblLate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lblLate.Location = new System.Drawing.Point(89, 30);
            this.lblLate.Name = "lblLate";
            this.lblLate.Padding = new Smobiler.Core.Controls.Padding(2F, 0F, 0F, 0F);
            this.lblLate.Size = new System.Drawing.Size(50, 30);
            // 
            // label
            // 
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label.Location = new System.Drawing.Point(139, 30);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(30, 30);
            this.label.Text = "早退";
            // 
            // lblEarly
            // 
            this.lblEarly.DisplayMember = "Early";
            this.lblEarly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lblEarly.Location = new System.Drawing.Point(169, 30);
            this.lblEarly.Name = "lblEarly";
            this.lblEarly.Padding = new Smobiler.Core.Controls.Padding(2F, 0F, 0F, 0F);
            this.lblEarly.Size = new System.Drawing.Size(50, 30);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label3.Location = new System.Drawing.Point(221, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 30);
            this.label3.Text = "未签";
            // 
            // lblNo
            // 
            this.lblNo.DisplayMember = "No";
            this.lblNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lblNo.Location = new System.Drawing.Point(250, 30);
            this.lblNo.Name = "lblNo";
            this.lblNo.Padding = new Smobiler.Core.Controls.Padding(2F, 0F, 0F, 0F);
            this.lblNo.Size = new System.Drawing.Size(50, 30);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label2.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label2.Location = new System.Drawing.Point(181, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 30);
            this.label2.Text = "准时";
            // 
            // lblAl
            // 
            this.lblAl.DisplayMember = "Al";
            this.lblAl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblAl.Location = new System.Drawing.Point(225, 0);
            this.lblAl.Name = "lblAl";
            this.lblAl.Padding = new Smobiler.Core.Controls.Padding(2F, 0F, 0F, 0F);
            this.lblAl.Size = new System.Drawing.Size(75, 30);
            // 
            // lbl3
            // 
            this.lbl3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lbl3.Location = new System.Drawing.Point(60, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(45, 30);
            this.lbl3.Text = "应签到";
            // 
            // lblID
            // 
            this.lblID.DisplayMember = "Name";
            this.lblID.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.lblID.Location = new System.Drawing.Point(0, 40);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(60, 20);
            this.lblID.Text = "Steven";
            this.lblID.ZIndex = 1;
            // 
            // frmAttendanceStatisticsLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(300, 60);
            this.Name = "frmAttendanceStatisticsLayout";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Image image1;
        private Smobiler.Core.Controls.Label lblTotal;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label lblLate;
        private Smobiler.Core.Controls.Label label;
        private Smobiler.Core.Controls.Label lblEarly;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Label lblNo;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Label lblAl;
        private Smobiler.Core.Controls.Label lbl3;
        internal Smobiler.Core.Controls.Label lblID;
    }
}