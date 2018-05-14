using System;
using Smobiler.Core;
using SmoONE.UI.Layout;

namespace SmoONE.UI.UserInfo
{
    partial class frmRegisterTel : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmRegisterTel()
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
            this.plTel = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.txtTel = new Smobiler.Core.Controls.TextBox();
            this.btnSave = new Smobiler.Core.Controls.Button();
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.title1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title1.Location = new System.Drawing.Point(27, 86);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 50);
            this.title1.TitleText = "新用户注册";
            // 
            // plTel
            // 
            this.plTel.BackColor = System.Drawing.Color.White;
            this.plTel.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.plTel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plTel.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.txtTel});
            this.plTel.Location = new System.Drawing.Point(0, 60);
            this.plTel.Name = "plTel";
            this.plTel.Size = new System.Drawing.Size(300, 35);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label1.Size = new System.Drawing.Size(66, 35);
            this.label1.Text = "手机号码";
            // 
            // txtTel
            // 
            this.txtTel.BackColor = System.Drawing.Color.Transparent;
            this.txtTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtTel.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.txtTel.Location = new System.Drawing.Point(66, 0);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(234, 35);
            this.txtTel.WaterMarkText = "请输入手机号码";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnSave.FontSize = 15F;
            this.btnSave.Location = new System.Drawing.Point(10, 105);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(280, 35);
            this.btnSave.Text = "下一步";
            this.btnSave.Press += new System.EventHandler(this.btnSave_Press);
            // 
            // frmRegisterTel
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.plTel,
            this.btnSave});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmRegisterTel_KeyDown);
            this.Name = "frmRegisterTel";

        }
        #endregion

        private Title title1;
        private Smobiler.Core.Controls.Panel plTel;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.TextBox txtTel;
        private Smobiler.Core.Controls.Button btnSave;
    }
}