using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class LeftPage : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        public LeftPage()
            : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call
        }

        //SmobilerUserControl overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerUserControl
        //It can be modified using the SmobilerUserControl.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.plPerson = new Smobiler.Core.Controls.Panel();
            this.fontIcon1 = new Smobiler.Core.Controls.FontIcon();
            this.Label13 = new Smobiler.Core.Controls.Label();
            this.plExit = new Smobiler.Core.Controls.Panel();
            this.Label10 = new Smobiler.Core.Controls.Label();
            this.fontIcon2 = new Smobiler.Core.Controls.FontIcon();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.imgPortrait = new Smobiler.Core.Controls.Image();
            this.lblName = new Smobiler.Core.Controls.Label();
            this.lblPhone = new Smobiler.Core.Controls.Label();
            // 
            // plPerson
            // 
            this.plPerson.BackColor = System.Drawing.Color.White;
            this.plPerson.BorderColor = System.Drawing.Color.White;
            this.plPerson.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.fontIcon1,
            this.Label13});
            this.plPerson.Location = new System.Drawing.Point(0, 195);
            this.plPerson.Name = "plPerson";
            this.plPerson.Size = new System.Drawing.Size(260, 40);
            this.plPerson.Touchable = true;
            this.plPerson.Press += new System.EventHandler(this.plPerson_Press);
            // 
            // fontIcon1
            // 
            this.fontIcon1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.fontIcon1.Location = new System.Drawing.Point(10, 10);
            this.fontIcon1.Name = "fontIcon1";
            this.fontIcon1.ResourceID = "envelope-o";
            this.fontIcon1.Size = new System.Drawing.Size(20, 20);
            // 
            // Label13
            // 
            this.Label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label13.Location = new System.Drawing.Point(31, 0);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(100, 40);
            this.Label13.Text = "账户信息";
            // 
            // plExit
            // 
            this.plExit.BackColor = System.Drawing.Color.White;
            this.plExit.BorderColor = System.Drawing.Color.White;
            this.plExit.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label10,
            this.fontIcon2});
            this.plExit.Location = new System.Drawing.Point(0, 235);
            this.plExit.Name = "plExit";
            this.plExit.Size = new System.Drawing.Size(260, 40);
            this.plExit.Touchable = true;
            this.plExit.Press += new System.EventHandler(this.plExit_Press);
            // 
            // Label10
            // 
            this.Label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label10.Location = new System.Drawing.Point(31, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(100, 40);
            this.Label10.Text = "退出";
            // 
            // fontIcon2
            // 
            this.fontIcon2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.fontIcon2.Location = new System.Drawing.Point(10, 10);
            this.fontIcon2.Name = "fontIcon2";
            this.fontIcon2.ResourceID = "power-off";
            this.fontIcon2.Size = new System.Drawing.Size(20, 20);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(209)))), ((int)(((byte)(247)))));
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imgPortrait,
            this.lblName,
            this.lblPhone});
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 194);
            // 
            // imgPortrait
            // 
            this.imgPortrait.BorderRadius = 40;
            this.imgPortrait.Location = new System.Drawing.Point(90, 45);
            this.imgPortrait.Name = "imgPortrait";
            this.imgPortrait.ResourceID = "6";
            this.imgPortrait.Size = new System.Drawing.Size(80, 80);
            this.imgPortrait.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Cover;
            // 
            // lblName
            // 
            this.lblName.FontSize = 14F;
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.lblName.Location = new System.Drawing.Point(0, 125);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(260, 35);
            // 
            // lblPhone
            // 
            this.lblPhone.FontSize = 14F;
            this.lblPhone.ForeColor = System.Drawing.Color.White;
            this.lblPhone.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.lblPhone.Location = new System.Drawing.Point(0, 160);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(260, 35);
            // 
            // LeftPage
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plPerson,
            this.plExit,
            this.panel1});
            this.Flex = 1;
            this.Size = new System.Drawing.Size(260, 0);
            this.Load += new System.EventHandler(this.LeftPage_Load);
            this.Name = "LeftPage";

        }
        #endregion
        internal Smobiler.Core.Controls.Panel plPerson;
        internal Smobiler.Core.Controls.Panel plExit;
        internal Smobiler.Core.Controls.Label Label10;
        private Smobiler.Core.Controls.FontIcon fontIcon1;
        internal Smobiler.Core.Controls.Label Label13;
        private Smobiler.Core.Controls.FontIcon fontIcon2;
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Image imgPortrait;
        private Smobiler.Core.Controls.Label lblName;
        private Smobiler.Core.Controls.Label lblPhone;
    }
}