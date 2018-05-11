using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class frmAttendanceMainLayoutDialog : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerForm generated code "

        public frmAttendanceMainLayoutDialog()
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
            this.lblTitle = new Smobiler.Core.Controls.Label();
            this.txtReason = new Smobiler.Core.Controls.TextBox();
            this.btnCancel = new Smobiler.Core.Controls.Button();
            this.btnConfirm = new Smobiler.Core.Controls.Button();
            // 
            // lblTitle
            // 
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.lblTitle.Size = new System.Drawing.Size(100, 30);
            this.lblTitle.Text = "迟到理由：";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(0, 30);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.txtReason.Size = new System.Drawing.Size(300, 70);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Border = new Smobiler.Core.Controls.Border(1F);
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnCancel.BorderRadius = 4;
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnCancel.Location = new System.Drawing.Point(10, 110);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(135, 40);
            this.btnCancel.Text = "取消";
            this.btnCancel.Press += new System.EventHandler(this.btnCancel_Press);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.White;
            this.btnConfirm.Border = new Smobiler.Core.Controls.Border(1F);
            this.btnConfirm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnConfirm.BorderRadius = 4;
            this.btnConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnConfirm.Location = new System.Drawing.Point(155, 110);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(135, 40);
            this.btnConfirm.Text = "确定";
            this.btnConfirm.Press += new System.EventHandler(this.btnConfirm_Press);
            // 
            // frmAttendanceMainLayoutDialog
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblTitle,
            this.txtReason,
            this.btnCancel,
            this.btnConfirm});
            this.Size = new System.Drawing.Size(300, 160);
            this.Name = "frmAttendanceMainLayoutDialog";

        }
        #endregion
        private Smobiler.Core.Controls.TextBox txtReason;
        private Smobiler.Core.Controls.Button btnCancel;
        private Smobiler.Core.Controls.Button btnConfirm;
        internal Smobiler.Core.Controls.Label lblTitle;
    }
}