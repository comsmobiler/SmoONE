using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class SwipeDeleteControl : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        public SwipeDeleteControl()
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
            this.btnDelRow = new Smobiler.Core.Controls.Button();
            // 
            // btnDelRow
            // 
            this.btnDelRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnDelRow.BorderRadius = 0;
            this.btnDelRow.Name = "btnDelRow";
            this.btnDelRow.Size = new System.Drawing.Size(50, 60);
            this.btnDelRow.Text = "É¾³ý";
            this.btnDelRow.Press += new System.EventHandler(this.btnDelRow_Press);
            // 
            // SwipeDeleteControl
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnDelRow});
            this.Size = new System.Drawing.Size(50, 60);
            this.Name = "SwipeDeleteControl";

        }
        #endregion

        private Smobiler.Core.Controls.Button btnDelRow;
    }
}