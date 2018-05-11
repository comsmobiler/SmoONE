using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class frmRBTypeLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerTouchUserControl generated code "

        public frmRBTypeLayout()
            : base()
        {
            //This call is required by the SmobilerTouchUserControl.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call
        }

        //SmobilerTouchUserControl overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerTouchUserControl
        //It can be modified using the SmobilerTouchUserControl.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.plContent = new Smobiler.Core.Controls.Panel();
            this.image1 = new Smobiler.Core.Controls.Image();
            this.lblTypeName = new Smobiler.Core.Controls.Label();
            // 
            // plContent
            // 
            this.plContent.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image1,
            this.lblTypeName});
            this.plContent.Name = "plContent";
            this.plContent.Size = new System.Drawing.Size(300, 60);
            this.plContent.Touchable = true;
            this.plContent.Press += new System.EventHandler(this.plContent_Press);
            // 
            // image1
            // 
            this.image1.BorderRadius = 18;
            this.image1.DataMember = "TYPE";
            this.image1.DisplayMember = "TYPE";
            this.image1.Location = new System.Drawing.Point(11, 13);
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.Size(35, 35);
            this.image1.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Cover;
            // 
            // lblTypeName
            // 
            this.lblTypeName.DataMember = "TYPE";
            this.lblTypeName.DisplayMember = "TYPENAME";
            this.lblTypeName.Location = new System.Drawing.Point(54, 0);
            this.lblTypeName.Name = "lblTypeName";
            this.lblTypeName.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.lblTypeName.Size = new System.Drawing.Size(246, 60);
            // 
            // frmRBTypeLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plContent});
            this.Size = new System.Drawing.Size(0, 60);
            this.Name = "frmRBTypeLayout";

        }
        #endregion
        private Smobiler.Core.Controls.Panel plContent;
        private Smobiler.Core.Controls.Image image1;
        internal Smobiler.Core.Controls.Label lblTypeName;
    }
}