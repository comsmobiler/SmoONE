using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class frmDetailFootbarLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerForm generated code "

        public frmDetailFootbarLayout()
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
            this.btnEdit = new Smobiler.Core.Controls.Button();
            this.btnAgreed = new Smobiler.Core.Controls.Button();
            this.btnRefuse = new Smobiler.Core.Controls.Button();
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnEdit.BorderRadius = 4;
            this.btnEdit.FontSize = 17F;
            this.btnEdit.Location = new System.Drawing.Point(205, 10);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 35);
            this.btnEdit.Text = "±à¼­";
            this.btnEdit.Press += new System.EventHandler(this.btnEdit_Press);
            // 
            // btnAgreed
            // 
            this.btnAgreed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(187)))), ((int)(((byte)(91)))));
            this.btnAgreed.BorderRadius = 4;
            this.btnAgreed.FontSize = 17F;
            this.btnAgreed.Location = new System.Drawing.Point(10, 10);
            this.btnAgreed.Name = "btnAgreed";
            this.btnAgreed.Size = new System.Drawing.Size(85, 35);
            this.btnAgreed.Text = "Í¬Òâ";
            this.btnAgreed.Press += new System.EventHandler(this.btnAgreed_Press);
            // 
            // btnRefuse
            // 
            this.btnRefuse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(158)))), ((int)(((byte)(38)))));
            this.btnRefuse.BorderRadius = 4;
            this.btnRefuse.FontSize = 17F;
            this.btnRefuse.Location = new System.Drawing.Point(108, 10);
            this.btnRefuse.Name = "btnRefuse";
            this.btnRefuse.Size = new System.Drawing.Size(85, 35);
            this.btnRefuse.Text = "¾Ü¾ø";
            this.btnRefuse.Press += new System.EventHandler(this.btnRefuse_Press);
            // 
            // frmDetailFootbarLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnEdit,
            this.btnAgreed,
            this.btnRefuse});
            this.Size = new System.Drawing.Size(300, 55);
            this.Name = "frmDetailFootbarLayout";

        }
        #endregion

        public Smobiler.Core.Controls.Button btnEdit;
        public Smobiler.Core.Controls.Button btnAgreed;
        public Smobiler.Core.Controls.Button btnRefuse;

    }
}