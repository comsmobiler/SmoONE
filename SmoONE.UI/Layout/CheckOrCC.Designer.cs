using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class CheckOrCC : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        public CheckOrCC()
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
            this.image1 = new Smobiler.Core.Controls.Image();
            this.label1 = new Smobiler.Core.Controls.Label();
            // 
            // image1
            // 
            this.image1.BorderRadius = 10;
            this.image1.Location = new System.Drawing.Point(7, 0);
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.Size(36, 36);
            this.image1.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Cover;
            // 
            // label1
            // 
            this.label1.Flex = 4;
            this.label1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label1.Location = new System.Drawing.Point(0, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 25);
            // 
            // CheckOrCC
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image1,
            this.label1});
            this.Size = new System.Drawing.Size(50, 60);
            this.Name = "CheckOrCC";

        }
        #endregion

        private Smobiler.Core.Controls.Image image1;
        private Smobiler.Core.Controls.Label label1;
    }
}