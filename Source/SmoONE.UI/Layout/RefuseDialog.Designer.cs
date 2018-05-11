using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class RefuseDialog : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerDialogUserControl generated code "

        public RefuseDialog()
            : base()
        {
            //This call is required by the SmobilerDialogUserControl.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call
        }

        //SmobilerDialogUserControl overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerDialogUserControl
        //It can be modified using the SmobilerDialogUserControl.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.txtReason = new Smobiler.Core.Controls.TextBox();
            this.btnCancel = new Smobiler.Core.Controls.Button();
            this.btnOK = new Smobiler.Core.Controls.Button();
            // 
            // txtReason
            // 
            this.txtReason.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.txtReason.BorderColor = System.Drawing.Color.LightGray;
            this.txtReason.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.txtReason.MaxLength = 400;
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Padding = new Smobiler.Core.Controls.Padding(0F, 5F, 0F, 0F);
            this.txtReason.Size = new System.Drawing.Size(300, 90);
            this.txtReason.WaterMarkText = "请输入1-200字的拒绝理由";
            // 
            // btnCancel
            // 
            this.btnCancel.Border = new Smobiler.Core.Controls.Border(1F);
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnCancel.Location = new System.Drawing.Point(10, 100);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(135, 40);
            this.btnCancel.Text = "取消";
            this.btnCancel.Press += new System.EventHandler(this.btnCancel_Press);
            // 
            // btnOK
            // 
            this.btnOK.Border = new Smobiler.Core.Controls.Border(1F);
            this.btnOK.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnOK.Location = new System.Drawing.Point(154, 100);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(135, 40);
            this.btnOK.Text = "确定";
            this.btnOK.Press += new System.EventHandler(this.btnOK_Press);
            // 
            // RefuseDialog
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.txtReason,
            this.btnCancel,
            this.btnOK});
            this.Size = new System.Drawing.Size(300, 150);
            this.Name = "RefuseDialog";

        }
        #endregion

        internal Smobiler.Core.Controls.TextBox txtReason;
        internal Smobiler.Core.Controls.Button btnCancel;
        private Smobiler.Core.Controls.Button btnOK;
    }
}