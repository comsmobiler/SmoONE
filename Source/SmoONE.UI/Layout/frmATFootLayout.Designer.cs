using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class frmATFootLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerForm generated code "

        public frmATFootLayout()
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
            this.lblDesc = new Smobiler.Core.Controls.Label();
            this.btnSave = new Smobiler.Core.Controls.Button();
            // 
            // lblDesc
            // 
            this.lblDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.lblDesc.Size = new System.Drawing.Size(196, 55);
            this.lblDesc.Text = "已选中 0 人";
            this.lblDesc.ZIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnSave.BorderRadius = 4;
            this.btnSave.FontSize = 17F;
            this.btnSave.Location = new System.Drawing.Point(205, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 35);
            this.btnSave.Text = "确定";
            this.btnSave.Press += new System.EventHandler(this.btnSave_Press);
            // 
            // frmATFootLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblDesc,
            this.btnSave});
            this.Size = new System.Drawing.Size(300, 55);
            this.Name = "frmATFootLayout";

        }
        #endregion

        public Smobiler.Core.Controls.Label lblDesc;
        public Smobiler.Core.Controls.Button btnSave;

    }
}