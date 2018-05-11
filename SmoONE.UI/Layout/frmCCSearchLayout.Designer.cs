using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class frmCCSearchLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerForm generated code "

        public frmCCSearchLayout()
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
            this.Label1 = new Smobiler.Core.Controls.Label();
            this.Label2 = new Smobiler.Core.Controls.Label();
            this.btnccuser = new Smobiler.Core.Controls.Button();
            this.btnccuser1 = new Smobiler.Core.Controls.Button();
            this.btncurrentUser = new Smobiler.Core.Controls.ImageButton();
            this.txtCCName = new Smobiler.Core.Controls.TextBox();
            this.btnCancel = new Smobiler.Core.Controls.Button();
            this.btnOK = new Smobiler.Core.Controls.Button();
            // 
            // Label1
            // 
            this.Label1.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.Label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label1.Name = "Label1";
            this.Label1.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.Label1.Size = new System.Drawing.Size(66, 35);
            this.Label1.Text = "责任人";
            this.Label1.ZIndex = 2;
            // 
            // Label2
            // 
            this.Label2.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.Label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label2.Location = new System.Drawing.Point(0, 35);
            this.Label2.Name = "Label2";
            this.Label2.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.Label2.Size = new System.Drawing.Size(66, 35);
            this.Label2.Text = "成本中心";
            this.Label2.ZIndex = 7;
            // 
            // btnccuser
            // 
            this.btnccuser.BackColor = System.Drawing.Color.Transparent;
            this.btnccuser.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.btnccuser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnccuser.BorderRadius = 0;
            this.btnccuser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnccuser.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnccuser.Location = new System.Drawing.Point(66, 0);
            this.btnccuser.Name = "btnccuser";
            this.btnccuser.Size = new System.Drawing.Size(144, 35);
            this.btnccuser.ZIndex = 3;
            this.btnccuser.Press += new System.EventHandler(this.btnccuser_Press);
            // 
            // btnccuser1
            // 
            this.btnccuser1.BackColor = System.Drawing.Color.Transparent;
            this.btnccuser1.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.btnccuser1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnccuser1.BorderRadius = 0;
            this.btnccuser1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnccuser1.Location = new System.Drawing.Point(210, 0);
            this.btnccuser1.Name = "btnccuser1";
            this.btnccuser1.Size = new System.Drawing.Size(25, 35);
            this.btnccuser1.Text = ">";
            this.btnccuser1.ZIndex = 4;
            this.btnccuser1.Press += new System.EventHandler(this.btnccuser_Press);
            // 
            // btncurrentUser
            // 
            this.btncurrentUser.BindDisplayValue = "user";
            this.btncurrentUser.BindTextMember = "我";
            this.btncurrentUser.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.btncurrentUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btncurrentUser.FontSize = 8F;
            this.btncurrentUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btncurrentUser.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btncurrentUser.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.btncurrentUser.Location = new System.Drawing.Point(235, 0);
            this.btncurrentUser.Name = "btncurrentUser";
            this.btncurrentUser.Padding = new Smobiler.Core.Controls.Padding(0F, 2F, 0F, 2F);
            this.btncurrentUser.ResourceID = "user";
            this.btncurrentUser.Size = new System.Drawing.Size(35, 35);
            this.btncurrentUser.Text = "我";
            this.btncurrentUser.ZIndex = 5;
            this.btncurrentUser.Press += new System.EventHandler(this.btncurrentUser_Press);
            // 
            // txtCCName
            // 
            this.txtCCName.BackColor = System.Drawing.Color.Transparent;
            this.txtCCName.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.txtCCName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtCCName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtCCName.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtCCName.Location = new System.Drawing.Point(66, 35);
            this.txtCCName.Name = "txtCCName";
            this.txtCCName.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.txtCCName.Size = new System.Drawing.Size(204, 35);
            this.txtCCName.ZIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Border = new Smobiler.Core.Controls.Border(0F, 1F, 1F, 0F);
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnCancel.BorderRadius = 0;
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnCancel.Location = new System.Drawing.Point(0, 85);
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
            this.btnOK.Location = new System.Drawing.Point(135, 85);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(135, 40);
            this.btnOK.Text = "确定";
            this.btnOK.Press += new System.EventHandler(this.btnOK_Press);
            // 
            // frmCCSearchLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnCancel,
            this.btnOK,
            this.Label1,
            this.btnccuser,
            this.btnccuser1,
            this.btncurrentUser,
            this.Label2,
            this.txtCCName});
            this.Size = new System.Drawing.Size(270, 125);
            this.Name = "frmCCSearchLayout";

        }
        internal Smobiler.Core.Controls.Label Label1;
        internal Smobiler.Core.Controls.Label Label2;
        internal Smobiler.Core.Controls.Button btnccuser;
        internal Smobiler.Core.Controls.Button btnccuser1;
        internal Smobiler.Core.Controls.ImageButton  btncurrentUser;
        internal Smobiler.Core.Controls.TextBox txtCCName;

        #endregion
        private Smobiler.Core.Controls.Button btnCancel;
        private Smobiler.Core.Controls.Button btnOK;
    }
}
