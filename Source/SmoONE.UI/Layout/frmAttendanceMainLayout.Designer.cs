using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class frmAttendanceMainLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerForm generated code "

        public frmAttendanceMainLayout()
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
            this.imgUser = new Smobiler.Core.Controls.Image();
            this.webView1 = new Smobiler.Core.Controls.WebView();
            this.lblType = new Smobiler.Core.Controls.Label();
            this.lblTime = new Smobiler.Core.Controls.Label();
            this.lblInfo = new Smobiler.Core.Controls.Label();
            this.btnCheck = new Smobiler.Core.Controls.Button();
            this.imgReason = new Smobiler.Core.Controls.Image();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imgUser,
            this.webView1,
            this.lblType,
            this.lblTime,
            this.lblInfo,
            this.btnCheck,
            this.imgReason});
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 60);
            this.panel1.Touchable = true;
            this.panel1.Press += new System.EventHandler(this.panel1_Press);
            // 
            // imgUser
            // 
            this.imgUser.BorderRadius = 2;
            this.imgUser.DataMember = "ID";
            this.imgUser.DisplayMember = "Picture";
            this.imgUser.Location = new System.Drawing.Point(8, 6);
            this.imgUser.Name = "imgUser";
            this.imgUser.ResourceID = "1";
            this.imgUser.Size = new System.Drawing.Size(45, 45);
            this.imgUser.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Cover;
            this.imgUser.ZIndex = 3;
            // 
            // webView1
            // 
            this.webView1.Location = new System.Drawing.Point(160, 18);
            this.webView1.Name = "webView1";
            this.webView1.Size = new System.Drawing.Size(1, 1);
            // 
            // lblType
            // 
            this.lblType.DataMember = "ID";
            this.lblType.DisplayMember = "Description";
            this.lblType.Location = new System.Drawing.Point(63, 0);
            this.lblType.Name = "lblType";
            this.lblType.Padding = new Smobiler.Core.Controls.Padding(5F, 10F, 0F, 0F);
            this.lblType.Size = new System.Drawing.Size(105, 30);
            this.lblType.Text = "上午上班";
            this.lblType.VerticalAlignment = Smobiler.Core.Controls.VerticalAlignment.Top;
            this.lblType.ZIndex = 4;
            // 
            // lblTime
            // 
            this.lblTime.DisplayMember = "Time";
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lblTime.Location = new System.Drawing.Point(63, 29);
            this.lblTime.Name = "lblTime";
            this.lblTime.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 10F);
            this.lblTime.Size = new System.Drawing.Size(105, 30);
            this.lblTime.Text = "09：00";
            this.lblTime.ZIndex = 5;
            // 
            // lblInfo
            // 
            this.lblInfo.DisplayMember = "Info";
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lblInfo.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.lblInfo.Location = new System.Drawing.Point(183, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.lblInfo.Size = new System.Drawing.Size(115, 60);
            this.lblInfo.Text = "未开始";
            this.lblInfo.ZIndex = 7;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCheck.BindDisplayValueGone = true;
            this.btnCheck.BorderRadius = 4;
            this.btnCheck.DisplayMember = "Action";
            this.btnCheck.Location = new System.Drawing.Point(208, 13);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(80, 26);
            this.btnCheck.Text = "签到";
            this.btnCheck.ZIndex = 8;
            this.btnCheck.Press += new System.EventHandler(this.btnCheck_Press);
            // 
            // imgReason
            // 
            this.imgReason.DisplayMember = "Img";
            this.imgReason.Location = new System.Drawing.Point(178, 0);
            this.imgReason.Name = "imgReason";
            this.imgReason.ResourceID = "!\\ue85d000146223";
            this.imgReason.Size = new System.Drawing.Size(15, 60);
            // 
            // frmAttendanceMainLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(300, 60);
            this.Name = "frmAttendanceMainLayout";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Image imgUser;
        private Smobiler.Core.Controls.WebView webView1;
        private Smobiler.Core.Controls.Label lblType;
        private Smobiler.Core.Controls.Label lblTime;
        private Smobiler.Core.Controls.Label lblInfo;
        private Smobiler.Core.Controls.Button btnCheck;
        private Smobiler.Core.Controls.Image imgReason;

    }
}