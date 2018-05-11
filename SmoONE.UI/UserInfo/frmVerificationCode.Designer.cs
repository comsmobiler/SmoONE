using System;
using Smobiler.Core;
using SmoONE.UI.Layout;

namespace SmoONE.UI.UserInfo
{
    partial class frmVerificationCode : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmVerificationCode()
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
            this.title1 = new SmoONE.UI.Layout.Title();
            this.spContent = new Smobiler.Core.Controls.Panel();
            this.lblTel = new Smobiler.Core.Controls.Label();
            this.txtVcode1 = new Smobiler.Core.Controls.TextBox();
            this.lblHint = new Smobiler.Core.Controls.Label();
            this.btnSave = new Smobiler.Core.Controls.Button();
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.title1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.title1.Dock = System.Windows.Forms.DockStyle.Top;
            
            
            this.title1.Location = new System.Drawing.Point(63, 80);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 50);
            this.title1.TitleText = "填写验证码";
            // 
            // spContent
            // 
            this.spContent.BackColor = System.Drawing.Color.White;
            this.spContent.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblTel,
            this.txtVcode1,
            this.lblHint,
            this.btnSave});
            this.spContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spContent.Flex = 10000;
            this.spContent.Location = new System.Drawing.Point(58, 140);
            this.spContent.Name = "spContent";
            this.spContent.Scrollable = true;
            this.spContent.Size = new System.Drawing.Size(100, 30);
            // 
            // lblTel
            // 
            this.lblTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblTel.Location = new System.Drawing.Point(20, 10);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(260, 30);
            this.lblTel.Text = "验证码已发送至手机：";
            // 
            // txtVcode1
            // 
            this.txtVcode1.Border = new Smobiler.Core.Controls.Border(1F);
            this.txtVcode1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtVcode1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtVcode1.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.txtVcode1.Location = new System.Drawing.Point(20, 50);
            this.txtVcode1.MaxLength = 4;
            this.txtVcode1.Name = "txtVcode1";
            this.txtVcode1.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.txtVcode1.Size = new System.Drawing.Size(260, 45);
            this.txtVcode1.WaterMarkText = "请输入验证码";
            // 
            // lblHint
            // 
            this.lblHint.ForeColor = System.Drawing.Color.Red;
            this.lblHint.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblHint.Location = new System.Drawing.Point(20, 95);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(260, 30);
            this.lblHint.Text = "使用验证码登录：1234";
            this.lblHint.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnSave.BorderRadius = 4;
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnSave.Location = new System.Drawing.Point(10, 125);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(280, 35);
            this.btnSave.Text = "完成";
            this.btnSave.Press += new System.EventHandler(this.btnSave_Press);
            // 
            // frmVerificationCode
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.spContent});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmVerificationCode_KeyDown);
            this.Load += new System.EventHandler(this.frmVerificationCode_Load);
            this.Name = "frmVerificationCode";

        }
        #endregion

        private Title title1;
        private Smobiler.Core.Controls.Panel spContent;
        private Smobiler.Core.Controls.Label lblTel;
        private Smobiler.Core.Controls.TextBox txtVcode1;
        private Smobiler.Core.Controls.Label lblHint;
        private Smobiler.Core.Controls.Button btnSave;
    }
}