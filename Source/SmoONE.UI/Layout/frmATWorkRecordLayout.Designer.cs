using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class frmATWorkRecordLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerForm generated code "

        public frmATWorkRecordLayout()
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
            this.imgPortrait = new Smobiler.Core.Controls.Image();
            this.lblUser = new Smobiler.Core.Controls.Label();
            this.lblDep = new Smobiler.Core.Controls.Label();
            this.lblDate = new Smobiler.Core.Controls.Label();
            this.image1 = new Smobiler.Core.Controls.Image();
            this.lblAddress = new Smobiler.Core.Controls.Label();
            this.label1 = new Smobiler.Core.Controls.Label();
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
            this.lblUser.Size = new System.Drawing.Size(178, 30);
            // 
            // lblDep
            // 
            this.lblDep.DataMember = "Dep_Name";
            this.lblDep.DisplayMember = "Dep_Name";
            this.lblDep.FontSize = 12F;
            this.lblDep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lblDep.Location = new System.Drawing.Point(47, 30);
            this.lblDep.Name = "lblDep";
            this.lblDep.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 0F, 10F);
            this.lblDep.Size = new System.Drawing.Size(253, 20);
            this.lblDep.ZIndex = 4;
            // 
            // lblDate
            // 
            this.lblDate.DataMember = "WorkDate";
            this.lblDate.DisplayMember = "WorkDate";
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lblDate.Location = new System.Drawing.Point(225, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 0F, 10F);
            this.lblDate.Size = new System.Drawing.Size(75, 30);
            this.lblDate.ZIndex = 4;
            // 
            // image1
            // 
            this.image1.Location = new System.Drawing.Point(4, 50);
            this.image1.Name = "image1";
            this.image1.ResourceID = "!\\ue0c8145145145";
            this.image1.Size = new System.Drawing.Size(20, 20);
            // 
            // lblAddress
            // 
            this.lblAddress.DataMember = "Address";
            this.lblAddress.DisplayMember = "Address";
            this.lblAddress.FontSize = 12F;
            this.lblAddress.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblAddress.Location = new System.Drawing.Point(24, 50);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.lblAddress.Size = new System.Drawing.Size(276, 20);
            this.lblAddress.ZIndex = 4;
            // 
            // label1
            // 
            this.label1.DataMember = "AL_Reason";
            this.label1.DisplayMember = "AL_Reason";
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(4, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 30);
            // 
            // frmATWorkRecordLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imgPortrait,
            this.lblUser,
            this.image1,
            this.lblDep,
            this.lblDate,
            this.lblAddress,
            this.label1});
            this.Size = new System.Drawing.Size(300, 100);
            this.Name = "frmATWorkRecordLayout";

        }
        #endregion

        private Smobiler.Core.Controls.Image imgPortrait;
        private Smobiler.Core.Controls.Label lblUser;
        internal Smobiler.Core.Controls.Label lblDep;
        internal Smobiler.Core.Controls.Label lblDate;
        private Smobiler.Core.Controls.Image image1;
        internal Smobiler.Core.Controls.Label lblAddress;
        private Smobiler.Core.Controls.Label label1;
    }
}