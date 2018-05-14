using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class MenuTitle : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        public MenuTitle()
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
            this.lblTitle = new Smobiler.Core.Controls.Label();
            // 
            // lblTitle
            // 
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.lblTitle.Size = new System.Drawing.Size(300, 50);
            // 
            // MenuTitle
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblTitle});
            this.Size = new System.Drawing.Size(0, 50);
            this.Name = "MenuTitle";

        }
        #endregion
        private Smobiler.Core.Controls.Label lblTitle;
    }
}