using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class frmGroupLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        public frmGroupLayout()
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
            this.tpUser = new Smobiler.Core.Controls.Panel();
            this.imgPortrait = new Smobiler.Core.Controls.Image();
            this.lblGroup = new Smobiler.Core.Controls.Label();
            // 
            // tpUser
            // 
            this.tpUser.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imgPortrait,
            this.lblGroup});
            this.tpUser.Name = "tpUser";
            this.tpUser.Size = new System.Drawing.Size(300, 50);
            this.tpUser.Touchable = true;
            this.tpUser.Press += new System.EventHandler(this.tpUser_Press);
            // 
            // imgPortrait
            // 
            this.imgPortrait.BorderRadius = 18;
            this.imgPortrait.Location = new System.Drawing.Point(4, 7);
            this.imgPortrait.Name = "imgPortrait";
            this.imgPortrait.ResourceID = "group";
            this.imgPortrait.Size = new System.Drawing.Size(36, 36);
            this.imgPortrait.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Cover;
            // 
            // lblGroup
            // 
            this.lblGroup.DataMember = "G_ID";
            this.lblGroup.DisplayMember = "G_NAME";
            this.lblGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblGroup.Location = new System.Drawing.Point(47, 0);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(253, 50);
            // 
            // frmGroupLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.tpUser});
            this.Size = new System.Drawing.Size(0, 50);
            this.Name = "frmGroupLayout";

        }
        #endregion

        private Smobiler.Core.Controls.Panel tpUser;
        private Smobiler.Core.Controls.Image imgPortrait;
        private Smobiler.Core.Controls.Label lblGroup;
    }
}