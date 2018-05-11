using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    public partial class Title : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        public Title()
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
            this.Panel1 = new Smobiler.Core.Controls.Panel();
            this.FontIcon1 = new Smobiler.Core.Controls.FontIcon();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            // 
            // Panel1
            // 
            this.Panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.FontIcon1});
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(40, 50);
            this.Panel1.Touchable = true;
            this.Panel1.Press += new System.EventHandler(this.Panel1_Press);
            // 
            // FontIcon1
            // 
            this.FontIcon1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.FontIcon1.Margin = new Smobiler.Core.Controls.Margin(0F, 10F, 0F, 0F);
            this.FontIcon1.Name = "FontIcon1";
            this.FontIcon1.ResourceID = "angle-left";
            this.FontIcon1.Size = new System.Drawing.Size(40, 30);
            // 
            // label1
            // 
            this.label1.FontSize = 15F;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label1.Location = new System.Drawing.Point(40, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 50);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(260, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 50);
            // 
            // Title
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Panel1,
            this.label1,
            this.label2});
            this.DesignSize = new System.Drawing.Size(300, 50);
            this.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.Name = "Title";

        }
        #endregion

        private Smobiler.Core.Controls.Panel Panel1;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.FontIcon FontIcon1;
    }
}