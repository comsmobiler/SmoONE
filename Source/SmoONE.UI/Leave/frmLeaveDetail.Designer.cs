using System;
using Smobiler.Core;
namespace SmoONE.UI.Leave
{
    partial class frmLeaveDetail : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmLeaveDetail()
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
            this.imgPortrait = new Smobiler.Core.Controls.Image();
            this.lblUserName = new Smobiler.Core.Controls.Label();
            this.lblStateNote = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.lblLId = new Smobiler.Core.Controls.Label();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.lblLType = new Smobiler.Core.Controls.Label();
            this.label7 = new Smobiler.Core.Controls.Label();
            this.lblStartDate = new Smobiler.Core.Controls.Label();
            this.label9 = new Smobiler.Core.Controls.Label();
            this.lblEndDate = new Smobiler.Core.Controls.Label();
            this.label11 = new Smobiler.Core.Controls.Label();
            this.lblReson = new Smobiler.Core.Controls.Label();
            this.label13 = new Smobiler.Core.Controls.Label();
            this.nodeStateDate = new Smobiler.Core.Controls.NodeView();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.lblLDay = new Smobiler.Core.Controls.Label();
            this.imgL = new Smobiler.Core.Controls.Image();
            this.title1 = new SmoONE.UI.Layout.Title();
            this.frmDetailFootbarLayout1 = new SmoONE.UI.Layout.frmDetailFootbarLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imgPortrait,
            this.lblUserName,
            this.lblStateNote,
            this.label3,
            this.lblLId,
            this.label5,
            this.lblLType,
            this.label7,
            this.lblStartDate,
            this.label9,
            this.lblEndDate,
            this.label11,
            this.lblReson,
            this.label13,
            this.nodeStateDate,
            this.label1,
            this.lblLDay,
            this.imgL});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Flex = 10000;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Scrollable = true;
            this.panel1.Size = new System.Drawing.Size(300, 450);
            // 
            // imgPortrait
            // 
            this.imgPortrait.BorderRadius = 10;
            this.imgPortrait.DataMember = "U_Portrait";
            this.imgPortrait.DisplayMember = "U_Portrait";
            this.imgPortrait.Location = new System.Drawing.Point(9, 10);
            this.imgPortrait.Name = "imgPortrait";
            this.imgPortrait.Size = new System.Drawing.Size(55, 55);
            // 
            // lblUserName
            // 
            this.lblUserName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblUserName.FontSize = 17F;
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblUserName.Location = new System.Drawing.Point(70, 10);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(219, 29);
            // 
            // lblStateNote
            // 
            this.lblStateNote.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblStateNote.FontSize = 14F;
            this.lblStateNote.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblStateNote.Location = new System.Drawing.Point(70, 39);
            this.lblStateNote.Name = "lblStateNote";
            this.lblStateNote.Size = new System.Drawing.Size(219, 19);
            this.lblStateNote.VerticalAlignment = Smobiler.Core.Controls.VerticalAlignment.Top;
            // 
            // label3
            // 
            this.label3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label3.FontSize = 10F;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(9, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 25);
            this.label3.Text = "请假编号：";
            // 
            // lblLId
            // 
            this.lblLId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblLId.FontSize = 10F;
            this.lblLId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblLId.Location = new System.Drawing.Point(70, 72);
            this.lblLId.Name = "lblLId";
            this.lblLId.Size = new System.Drawing.Size(219, 25);
            // 
            // label5
            // 
            this.label5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label5.FontSize = 10F;
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(9, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 25);
            this.label5.Text = "请假类型：";
            // 
            // lblLType
            // 
            this.lblLType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblLType.FontSize = 10F;
            this.lblLType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblLType.Location = new System.Drawing.Point(70, 97);
            this.lblLType.Name = "lblLType";
            this.lblLType.Size = new System.Drawing.Size(219, 25);
            // 
            // label7
            // 
            this.label7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label7.FontSize = 10F;
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(9, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 25);
            this.label7.Text = "开始时间：";
            // 
            // lblStartDate
            // 
            this.lblStartDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblStartDate.FontSize = 10F;
            this.lblStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblStartDate.Location = new System.Drawing.Point(70, 122);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(219, 25);
            // 
            // label9
            // 
            this.label9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label9.FontSize = 10F;
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(9, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 25);
            this.label9.Text = "结束时间：";
            // 
            // lblEndDate
            // 
            this.lblEndDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblEndDate.FontSize = 10F;
            this.lblEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblEndDate.Location = new System.Drawing.Point(70, 147);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(219, 25);
            // 
            // label11
            // 
            this.label11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label11.FontSize = 10F;
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(9, 197);
            this.label11.Name = "label11";
            this.label11.Padding = new Smobiler.Core.Controls.Padding(0F, 5F, 0F, 0F);
            this.label11.Size = new System.Drawing.Size(55, 50);
            this.label11.Text = "请假事由：";
            this.label11.VerticalAlignment = Smobiler.Core.Controls.VerticalAlignment.Top;
            // 
            // lblReson
            // 
            this.lblReson.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblReson.FontSize = 10F;
            this.lblReson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblReson.Location = new System.Drawing.Point(70, 197);
            this.lblReson.Name = "lblReson";
            this.lblReson.Padding = new Smobiler.Core.Controls.Padding(0F, 5F, 0F, 0F);
            this.lblReson.Size = new System.Drawing.Size(219, 50);
            this.lblReson.VerticalAlignment = Smobiler.Core.Controls.VerticalAlignment.Top;
            // 
            // label13
            // 
            this.label13.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label13.FontSize = 10F;
            this.label13.ForeColor = System.Drawing.Color.Gray;
            this.label13.Location = new System.Drawing.Point(9, 247);
            this.label13.Name = "label13";
            this.label13.Padding = new Smobiler.Core.Controls.Padding(0F, 5F, 0F, 0F);
            this.label13.Size = new System.Drawing.Size(55, 50);
            this.label13.Text = "图片：";
            this.label13.VerticalAlignment = Smobiler.Core.Controls.VerticalAlignment.Top;
            // 
            // nodeStateDate
            // 
            this.nodeStateDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.nodeStateDate.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.nodeStateDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.nodeStateDate.Location = new System.Drawing.Point(0, 320);
            this.nodeStateDate.Name = "nodeStateDate";
            this.nodeStateDate.Size = new System.Drawing.Size(300, 227);
            // 
            // label1
            // 
            this.label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label1.FontSize = 10F;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(9, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.Text = "请假天数：";
            // 
            // lblLDay
            // 
            this.lblLDay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblLDay.FontSize = 10F;
            this.lblLDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblLDay.Location = new System.Drawing.Point(70, 172);
            this.lblLDay.Name = "lblLDay";
            this.lblLDay.Size = new System.Drawing.Size(219, 25);
            // 
            // imgL
            // 
            this.imgL.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.imgL.Location = new System.Drawing.Point(70, 247);
            this.imgL.Name = "imgL";
            this.imgL.Size = new System.Drawing.Size(40, 50);
            this.imgL.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Stretch;
            this.imgL.ZIndex = 13;
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
            // frmDetailFootbarLayout1
            // 
            this.frmDetailFootbarLayout1.BackColor = System.Drawing.Color.White;
            this.frmDetailFootbarLayout1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.frmDetailFootbarLayout1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.frmDetailFootbarLayout1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.frmDetailFootbarLayout1.Location = new System.Drawing.Point(0, 13);
            this.frmDetailFootbarLayout1.Name = "frmDetailFootbarLayout1";
            this.frmDetailFootbarLayout1.Size = new System.Drawing.Size(300, 55);
            // 
            // frmLeaveDetail
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.frmDetailFootbarLayout1,
            this.panel1});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmLeaveDef_KeyDown);
            this.Load += new System.EventHandler(this.frmLeaveDef_Load);
            this.Name = "frmLeaveDetail";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Image imgPortrait;
        internal Smobiler.Core.Controls.Label lblUserName;
        internal Smobiler.Core.Controls.Label lblStateNote;
        internal Smobiler.Core.Controls.Label label3;
        internal Smobiler.Core.Controls.Label lblLId;
        internal Smobiler.Core.Controls.Label label5;
        internal Smobiler.Core.Controls.Label lblLType;
        internal Smobiler.Core.Controls.Label label7;
        internal Smobiler.Core.Controls.Label lblStartDate;
        internal Smobiler.Core.Controls.Label label9;
        internal Smobiler.Core.Controls.Label lblEndDate;
        internal Smobiler.Core.Controls.Label label11;
        internal Smobiler.Core.Controls.Label lblReson;
        internal Smobiler.Core.Controls.Label label13;
        private Smobiler.Core.Controls.NodeView nodeStateDate;
        internal Smobiler.Core.Controls.Label label1;
        internal Smobiler.Core.Controls.Label lblLDay;
        internal Smobiler.Core.Controls.Image imgL;
        private SmoONE.UI.Layout.Title title1;
        private Layout.frmDetailFootbarLayout frmDetailFootbarLayout1;
    }
}