using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class frmAddUserLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        public frmAddUserLayout()
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
            this.imgPortrait = new Smobiler.Core.Controls.Image();
            this.lblUser = new Smobiler.Core.Controls.Label();
            this.Check = new Smobiler.Core.Controls.CheckBox();
            // 
            // imgPortrait
            // 
            this.imgPortrait.BorderRadius = 10;
            this.imgPortrait.DataMember = "U_Portrait";
            this.imgPortrait.DisplayMember = "U_Portrait";
            this.imgPortrait.Location = new System.Drawing.Point(4, 7);
            this.imgPortrait.Name = "imgPortrait";
            this.imgPortrait.Size = new System.Drawing.Size(35, 35);
            this.imgPortrait.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Cover;
            // 
            // lblUser
            // 
            this.lblUser.DataMember = "U_ID";
            this.lblUser.DisplayMember = "U_Name";
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblUser.Location = new System.Drawing.Point(47, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(219, 50);
            // 
            // Check
            // 
            this.Check.Location = new System.Drawing.Point(274, 15);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(20, 20);
            this.Check.CheckedChanged += new System.EventHandler(this.Check_CheckedChanged);
            // 
            // frmAddUserLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imgPortrait,
            this.lblUser,
            this.Check});
            this.Size = new System.Drawing.Size(300, 50);
            this.Name = "frmAddUserLayout";

        }
        #endregion
        public Smobiler.Core.Controls.Label lblUser;
        public Smobiler.Core.Controls.CheckBox Check;
        public Smobiler.Core.Controls.Image imgPortrait;
    }
}