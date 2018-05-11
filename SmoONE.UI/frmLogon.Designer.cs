using System;
using Smobiler.Core;
namespace SmoONE.UI
{
    partial class frmLogon : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmLogon()
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
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.image1 = new Smobiler.Core.Controls.Image();
            this.txtTel = new Smobiler.Core.Controls.TextBox();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.txtPwd = new Smobiler.Core.Controls.TextBox();
            this.btnLogon = new Smobiler.Core.Controls.Button();
            this.btnRegister = new Smobiler.Core.Controls.Button();
            this.btnVerify = new Smobiler.Core.Controls.Button();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.line1 = new Smobiler.Core.Controls.Line();
            this.line2 = new Smobiler.Core.Controls.Line();
            this.chkRememberPwd = new Smobiler.Core.Controls.CheckBox();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.btnGestures = new Smobiler.Core.Controls.Button();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image1,
            this.txtTel,
            this.label1,
            this.label2,
            this.txtPwd,
            this.btnLogon,
            this.btnRegister,
            this.btnVerify,
            this.label3,
            this.line1,
            this.line2,
            this.chkRememberPwd,
            this.label4,
            this.btnGestures});
            this.panel1.Name = "panel1";
            this.panel1.Scrollable = true;
            this.panel1.Size = new System.Drawing.Size(300, 500);
            // 
            // image1
            // 
            this.image1.Location = new System.Drawing.Point(100, 60);
            this.image1.Name = "image1";
            this.image1.ResourceID = "logon1.gif";
            this.image1.Size = new System.Drawing.Size(100, 100);
            // 
            // txtTel
            // 
            this.txtTel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtTel.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.txtTel.Location = new System.Drawing.Point(55, 175);
            this.txtTel.Name = "txtTel";
            this.txtTel.ReturnKeyType = Smobiler.Core.Controls.ReturnKeyType.Done;
            this.txtTel.Size = new System.Drawing.Size(230, 40);
            this.txtTel.WaterMarkText = "请输入手机号码";
            // 
            // label1
            // 
            this.label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label1.Location = new System.Drawing.Point(15, 175);
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label1.Size = new System.Drawing.Size(40, 40);
            this.label1.Text = "+86";
            // 
            // label2
            // 
            this.label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label2.Location = new System.Drawing.Point(15, 215);
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label2.Size = new System.Drawing.Size(40, 40);
            this.label2.Text = "密码";
            // 
            // txtPwd
            // 
            this.txtPwd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtPwd.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.txtPwd.Location = new System.Drawing.Point(55, 215);
            this.txtPwd.MaxLength = 12;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.ReturnKeyType = Smobiler.Core.Controls.ReturnKeyType.Done;
            this.txtPwd.SecurityMode = true;
            this.txtPwd.Size = new System.Drawing.Size(230, 40);
            this.txtPwd.WaterMarkText = "请输入6-12位密码";
            // 
            // btnLogon
            // 
            this.btnLogon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnLogon.BorderRadius = 4;
            this.btnLogon.FontSize = 15F;
            this.btnLogon.Location = new System.Drawing.Point(15, 295);
            this.btnLogon.Name = "btnLogon";
            this.btnLogon.Size = new System.Drawing.Size(270, 40);
            this.btnLogon.Text = "登录";
            this.btnLogon.Press += new System.EventHandler(this.btnLogon_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.White;
            this.btnRegister.BorderRadius = 0;
            this.btnRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnRegister.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Left;
            this.btnRegister.Location = new System.Drawing.Point(15, 376);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.btnRegister.Size = new System.Drawing.Size(91, 24);
            this.btnRegister.Text = "新用户注册";
            this.btnRegister.Press += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.BackColor = System.Drawing.Color.White;
            this.btnVerify.BorderRadius = 0;
            this.btnVerify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnVerify.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnVerify.Location = new System.Drawing.Point(177, 376);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.btnVerify.Size = new System.Drawing.Size(108, 24);
            this.btnVerify.Text = "使用验证码登录";
            this.btnVerify.Press += new System.EventHandler(this.btnVerify_Click);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label3.Location = new System.Drawing.Point(15, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 35);
            this.label3.Text = "登录用户名：13123456789，密码：123456";
            this.label3.Visible = false;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.line1.Location = new System.Drawing.Point(15, 215);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(270, 1);
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.line2.Location = new System.Drawing.Point(15, 254);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(270, 1);
            // 
            // chkRememberPwd
            // 
            this.chkRememberPwd.Location = new System.Drawing.Point(19, 265);
            this.chkRememberPwd.Name = "chkRememberPwd";
            this.chkRememberPwd.Size = new System.Drawing.Size(20, 20);
            this.chkRememberPwd.Style = Smobiler.Core.Controls.CheckBoxStyle.Circular;
            this.chkRememberPwd.TintColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(55, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.Text = "记住密码";
            // 
            // btnGestures
            // 
            this.btnGestures.BackColor = System.Drawing.Color.White;
            this.btnGestures.BorderRadius = 4;
            this.btnGestures.FontSize = 15F;
            this.btnGestures.ForeColor = System.Drawing.Color.Red;
            this.btnGestures.Location = new System.Drawing.Point(15, 335);
            this.btnGestures.Name = "btnGestures";
            this.btnGestures.Size = new System.Drawing.Size(270, 40);
            this.btnGestures.Text = "手势登录";
            this.btnGestures.Press += new System.EventHandler(this.button1_Press);
            // 
            // frmLogon
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.EnableMirrorPattern = false;
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Default, System.Drawing.Color.Transparent, true);
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmLogon_KeyDown);
            this.Load += new System.EventHandler(this.frmLogon_Load);
            this.Name = "frmLogon";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Image image1;
        private Smobiler.Core.Controls.TextBox txtTel;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.TextBox txtPwd;
        private Smobiler.Core.Controls.Button btnLogon;
        private Smobiler.Core.Controls.Button btnRegister;
        private Smobiler.Core.Controls.Button btnVerify;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Line line1;
        private Smobiler.Core.Controls.Line line2;
        private Smobiler.Core.Controls.CheckBox chkRememberPwd;
        private Smobiler.Core.Controls.Label label4;
        private Smobiler.Core.Controls.Button btnGestures;
    }
}