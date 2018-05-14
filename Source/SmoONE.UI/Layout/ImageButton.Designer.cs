using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class ImageButton : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerTouchUserControl generated code "

        public ImageButton()
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
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.imageEx1 = new Smobiler.Core.Controls.ImageEx();
            this.label1 = new Smobiler.Core.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imageEx1,
            this.label1});
            this.panel1.Flex = 1;
            this.panel1.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.Touchable = true;
            this.panel1.Press += new System.EventHandler(this.panel1_Press);
            // 
            // imageEx1
            // 
            this.imageEx1.BindDisplayValue = null;
            this.imageEx1.BorderRadius = 10;
            this.imageEx1.DataMember = null;
            this.imageEx1.DisplayMember = null;
            this.imageEx1.Flex = 6;
            this.imageEx1.Name = "imageEx1";
            this.imageEx1.ResourceID = null;
           
            this.imageEx1.Size = new System.Drawing.Size(0, 0);
            this.imageEx1.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Cover;
            // 
            // label1
            // 
            this.label1.Flex = 4;
            this.label1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 0);
            // 
            // ImageButton
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Size = new System.Drawing.Size(45, 45);
            this.Name = "ImageButton";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.ImageEx imageEx1;
        private Smobiler.Core.Controls.Label label1;
    }
}