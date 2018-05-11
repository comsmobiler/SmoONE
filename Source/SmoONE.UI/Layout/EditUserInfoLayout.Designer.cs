using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class EditUserInfoLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerForm generated code "

        public EditUserInfoLayout()
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
            this.lblEditInfo = new Smobiler.Core.Controls.Label();
            this.txtEditInfo = new Smobiler.Core.Controls.TextBox();
            this.btnCancel = new Smobiler.Core.Controls.Button();
            this.btnOK = new Smobiler.Core.Controls.Button();
            // 
            // lblEditInfo
            // 
            this.lblEditInfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblEditInfo.FontSize = 19F;
            this.lblEditInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.lblEditInfo.Name = "lblEditInfo";
            this.lblEditInfo.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.lblEditInfo.Size = new System.Drawing.Size(270, 45);
            this.lblEditInfo.Text = "修改昵称";
            this.lblEditInfo.ZIndex = 1;
            // 
            // txtEditInfo
            // 
            this.txtEditInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.txtEditInfo.Location = new System.Drawing.Point(5, 46);
            this.txtEditInfo.Name = "txtEditInfo";
            this.txtEditInfo.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.txtEditInfo.Size = new System.Drawing.Size(260, 30);
            this.txtEditInfo.WaterMarkText = "（必输）";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Border = new Smobiler.Core.Controls.Border(0F, 1F, 1F, 0F);
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnCancel.BorderRadius = 0;
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnCancel.Location = new System.Drawing.Point(0, 95);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(135, 40);
            this.btnCancel.Text = "取消";
            this.btnCancel.Press += new System.EventHandler(this.btnCancel_Press);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.White;
            this.btnOK.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.btnOK.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnOK.BorderRadius = 0;
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnOK.Location = new System.Drawing.Point(135, 95);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(135, 40);
            this.btnOK.Text = "确定";
            this.btnOK.Press += new System.EventHandler(this.btnOK_Press);
            // 
            // EditUserInfoLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblEditInfo,
            this.txtEditInfo,
            this.btnCancel,
            this.btnOK});
            this.Size = new System.Drawing.Size(270, 135);
            this.Load += new System.EventHandler(this.EditUserInfo_Load);
            this.Name = "EditUserInfoLayout";

        }
        #endregion

        internal Smobiler.Core.Controls.Label lblEditInfo;
        private Smobiler.Core.Controls.Button btnCancel;
        private Smobiler.Core.Controls.Button btnOK;
        internal Smobiler.Core.Controls.TextBox txtEditInfo;
    }
}