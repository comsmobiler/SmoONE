using Smobiler.Core;

namespace SmoONE.UI.Leave
{
    partial class frmLeaveCreate : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm Designer generated code "

        public frmLeaveCreate()
            : base()
        {
            //This call is required by the SmobilerForm Designer.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call
        }

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm Designer
        //It can be modified using the SmobilerForm Designer.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.popType = new Smobiler.Core.Controls.PopList();
            this.camera1 = new Smobiler.Core.Controls.Camera();
            this.pContent = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.btnType = new Smobiler.Core.Controls.Button();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.dpkStartDate = new Smobiler.Core.Controls.DatePicker();
            this.Label3 = new Smobiler.Core.Controls.Label();
            this.dpkEndDate = new Smobiler.Core.Controls.DatePicker();
            this.Label4 = new Smobiler.Core.Controls.Label();
            this.txtLday = new Smobiler.Core.Controls.TextBox();
            this.Label5 = new Smobiler.Core.Controls.Label();
            this.txtReason = new Smobiler.Core.Controls.TextBox();
            this.lblImg = new Smobiler.Core.Controls.Label();
            this.Label9 = new Smobiler.Core.Controls.Label();
            this.btnupPhoto = new Smobiler.Core.Controls.Button();
            this.btndelPhoto = new Smobiler.Core.Controls.Button();
            this.lblCheck = new Smobiler.Core.Controls.Label();
            this.lblCheck1 = new Smobiler.Core.Controls.Label();
            this.pCheck2 = new Smobiler.Core.Controls.Panel();
            this.imgbtnAddCheck = new SmoONE.UI.Layout.ImageButton();
            this.lblCCTo = new Smobiler.Core.Controls.Label();
            this.lblCCTo1 = new Smobiler.Core.Controls.Label();
            this.pCCTo2 = new Smobiler.Core.Controls.Panel();
            this.imgbtnAddCCTo = new SmoONE.UI.Layout.ImageButton();
            this.btnSave = new Smobiler.Core.Controls.Button();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.imgL = new Smobiler.Core.Controls.Image();
            this.title1 = new SmoONE.UI.Layout.Title();
            // 
            // popType
            // 
            this.popType.Name = "popType";
            this.popType.Selected += new System.EventHandler(this.popType_Selected);
            // 
            // camera1
            // 
            this.camera1.Name = "camera1";
            this.camera1.ImageCaptured += new Smobiler.Core.Controls.CameraOnlineCallBackHandler(this.camera1_ImageCaptured);
            // 
            // pContent
            // 
            this.pContent.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.btnType,
            this.label2,
            this.dpkStartDate,
            this.Label3,
            this.dpkEndDate,
            this.Label4,
            this.txtLday,
            this.Label5,
            this.txtReason,
            this.lblImg,
            this.Label9,
            this.btnupPhoto,
            this.btndelPhoto,
            this.lblCheck,
            this.lblCheck1,
            this.pCheck2,
            this.lblCCTo,
            this.lblCCTo1,
            this.pCCTo2,
            this.btnSave,
            this.panel1});
            this.pContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContent.Flex = 10000;
            this.pContent.Location = new System.Drawing.Point(0, 50);
            this.pContent.Name = "pContent";
            this.pContent.Scrollable = true;
            this.pContent.Size = new System.Drawing.Size(300, 450);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label1.Location = new System.Drawing.Point(0, 10);
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label1.Size = new System.Drawing.Size(66, 35);
            this.label1.Text = "请假类型";
            this.label1.ZIndex = 1;
            // 
            // btnType
            // 
            this.btnType.BackColor = System.Drawing.Color.White;
            this.btnType.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.btnType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnType.BorderRadius = 0;
            this.btnType.FontSize = 12F;
            this.btnType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnType.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnType.Location = new System.Drawing.Point(66, 10);
            this.btnType.Name = "btnType";
            this.btnType.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.btnType.Size = new System.Drawing.Size(234, 35);
            this.btnType.Text = "选择（必填）   > ";
            this.btnType.ZIndex = 2;
            this.btnType.Press += new System.EventHandler(this.btntype_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label2.Location = new System.Drawing.Point(0, 55);
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label2.Size = new System.Drawing.Size(66, 35);
            this.label2.Text = "开始时间";
            this.label2.ZIndex = 4;
            // 
            // dpkStartDate
            // 
            this.dpkStartDate.BackColor = System.Drawing.Color.White;
            this.dpkStartDate.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.dpkStartDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dpkStartDate.FontSize = 12F;
            this.dpkStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.dpkStartDate.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.dpkStartDate.Location = new System.Drawing.Point(66, 55);
            this.dpkStartDate.Name = "dpkStartDate";
            this.dpkStartDate.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.dpkStartDate.Size = new System.Drawing.Size(234, 35);
            this.dpkStartDate.ZIndex = 5;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.White;
            this.Label3.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.Label3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label3.Location = new System.Drawing.Point(0, 90);
            this.Label3.Name = "Label3";
            this.Label3.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.Label3.Size = new System.Drawing.Size(66, 35);
            this.Label3.Text = "结束时间";
            this.Label3.ZIndex = 6;
            // 
            // dpkEndDate
            // 
            this.dpkEndDate.BackColor = System.Drawing.Color.White;
            this.dpkEndDate.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.dpkEndDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dpkEndDate.FontSize = 12F;
            this.dpkEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.dpkEndDate.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.dpkEndDate.Location = new System.Drawing.Point(66, 90);
            this.dpkEndDate.Name = "dpkEndDate";
            this.dpkEndDate.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.dpkEndDate.Size = new System.Drawing.Size(234, 35);
            this.dpkEndDate.ZIndex = 7;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.White;
            this.Label4.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.Label4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label4.Location = new System.Drawing.Point(0, 135);
            this.Label4.Name = "Label4";
            this.Label4.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.Label4.Size = new System.Drawing.Size(66, 35);
            this.Label4.Text = "请假天数";
            this.Label4.ZIndex = 8;
            // 
            // txtLday
            // 
            this.txtLday.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.txtLday.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtLday.FontSize = 12F;
            this.txtLday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtLday.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtLday.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.txtLday.Location = new System.Drawing.Point(66, 135);
            this.txtLday.Name = "txtLday";
            this.txtLday.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.txtLday.Size = new System.Drawing.Size(234, 35);
            this.txtLday.WaterMarkText = "（必填）";
            this.txtLday.ZIndex = 9;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.White;
            this.Label5.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.Label5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label5.Location = new System.Drawing.Point(0, 180);
            this.Label5.Name = "Label5";
            this.Label5.Padding = new Smobiler.Core.Controls.Padding(4F, 5F, 0F, 0F);
            this.Label5.Size = new System.Drawing.Size(66, 80);
            this.Label5.Text = "请假事由";
            this.Label5.VerticalAlignment = Smobiler.Core.Controls.VerticalAlignment.Top;
            this.Label5.ZIndex = 10;
            // 
            // txtReason
            // 
            this.txtReason.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.txtReason.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtReason.FontSize = 12F;
            this.txtReason.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtReason.Location = new System.Drawing.Point(66, 180);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Padding = new Smobiler.Core.Controls.Padding(0F, 5F, 4F, 0F);
            this.txtReason.Size = new System.Drawing.Size(235, 80);
            this.txtReason.WaterMarkText = "（必填）";
            this.txtReason.ZIndex = 11;
            // 
            // lblImg
            // 
            this.lblImg.BackColor = System.Drawing.Color.White;
            this.lblImg.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.lblImg.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblImg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblImg.Location = new System.Drawing.Point(0, 270);
            this.lblImg.Name = "lblImg";
            this.lblImg.Padding = new Smobiler.Core.Controls.Padding(4F, 5F, 0F, 0F);
            this.lblImg.Size = new System.Drawing.Size(66, 80);
            this.lblImg.Text = "图片";
            this.lblImg.VerticalAlignment = Smobiler.Core.Controls.VerticalAlignment.Top;
            this.lblImg.ZIndex = 12;
            // 
            // Label9
            // 
            this.Label9.BackColor = System.Drawing.Color.White;
            this.Label9.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.Label9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label9.Location = new System.Drawing.Point(66, 320);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(235, 30);
            this.Label9.ZIndex = 14;
            // 
            // btnupPhoto
            // 
            this.btnupPhoto.BackColor = System.Drawing.Color.White;
            this.btnupPhoto.Border = new Smobiler.Core.Controls.Border(1F);
            this.btnupPhoto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnupPhoto.BorderRadius = 4;
            this.btnupPhoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnupPhoto.Location = new System.Drawing.Point(114, 322);
            this.btnupPhoto.Name = "btnupPhoto";
            this.btnupPhoto.Size = new System.Drawing.Size(65, 20);
            this.btnupPhoto.Text = "上传";
            this.btnupPhoto.ZIndex = 15;
            this.btnupPhoto.Press += new System.EventHandler(this.btnupPhoto_Click);
            // 
            // btndelPhoto
            // 
            this.btndelPhoto.BackColor = System.Drawing.Color.White;
            this.btndelPhoto.Border = new Smobiler.Core.Controls.Border(1F);
            this.btndelPhoto.BorderColor = System.Drawing.Color.Red;
            this.btndelPhoto.BorderRadius = 4;
            this.btndelPhoto.ForeColor = System.Drawing.Color.Red;
            this.btndelPhoto.Location = new System.Drawing.Point(189, 322);
            this.btndelPhoto.Name = "btndelPhoto";
            this.btndelPhoto.Size = new System.Drawing.Size(65, 20);
            this.btndelPhoto.Text = "删除";
            this.btndelPhoto.ZIndex = 16;
            this.btndelPhoto.Press += new System.EventHandler(this.btndelPhoto_Click);
            // 
            // lblCheck
            // 
            this.lblCheck.BackColor = System.Drawing.Color.White;
            this.lblCheck.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.lblCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblCheck.Location = new System.Drawing.Point(0, 360);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.lblCheck.Size = new System.Drawing.Size(66, 35);
            this.lblCheck.Text = "审批人";
            this.lblCheck.ZIndex = 17;
            // 
            // lblCheck1
            // 
            this.lblCheck1.BackColor = System.Drawing.Color.White;
            this.lblCheck1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.lblCheck1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblCheck1.ForeColor = System.Drawing.Color.Silver;
            this.lblCheck1.Location = new System.Drawing.Point(66, 360);
            this.lblCheck1.Name = "lblCheck1";
            this.lblCheck1.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.lblCheck1.Size = new System.Drawing.Size(234, 35);
            this.lblCheck1.Text = "（添加1-4位审批人，点击头像可删除）";
            this.lblCheck1.ZIndex = 18;
            // 
            // pCheck2
            // 
            this.pCheck2.BackColor = System.Drawing.Color.White;
            this.pCheck2.BorderColor = System.Drawing.Color.LightGray;
            this.pCheck2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imgbtnAddCheck});
            this.pCheck2.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.pCheck2.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.pCheck2.Location = new System.Drawing.Point(0, 395);
            this.pCheck2.Name = "pCheck2";
            this.pCheck2.Padding = new Smobiler.Core.Controls.Padding(65F, 0F, 0F, 0F);
            this.pCheck2.Size = new System.Drawing.Size(300, 55);
            this.pCheck2.ZIndex = 19;
            // 
            // imgbtnAddCheck
            // 
            this.imgbtnAddCheck.BackColor = System.Drawing.Color.White;
            this.imgbtnAddCheck.FontSize = 13F;
            this.imgbtnAddCheck.ForeColor = System.Drawing.Color.Black;
            this.imgbtnAddCheck.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.imgbtnAddCheck.IconColor = System.Drawing.Color.Black;
            this.imgbtnAddCheck.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.Image;
            this.imgbtnAddCheck.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.imgbtnAddCheck.Name = "imgbtnAddCheck";
            this.imgbtnAddCheck.ResourceID = "add";
            this.imgbtnAddCheck.Size = new System.Drawing.Size(35, 35);
            this.imgbtnAddCheck.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Zoom;
            this.imgbtnAddCheck.ZIndex = 20;
            this.imgbtnAddCheck.Press += new System.EventHandler(this.imgbtnAddCheck_Click);
            // 
            // lblCCTo
            // 
            this.lblCCTo.BackColor = System.Drawing.Color.White;
            this.lblCCTo.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.lblCCTo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblCCTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblCCTo.Location = new System.Drawing.Point(0, 460);
            this.lblCCTo.Name = "lblCCTo";
            this.lblCCTo.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.lblCCTo.Size = new System.Drawing.Size(66, 35);
            this.lblCCTo.Text = "抄送人";
            this.lblCCTo.ZIndex = 21;
            // 
            // lblCCTo1
            // 
            this.lblCCTo1.BackColor = System.Drawing.Color.White;
            this.lblCCTo1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.lblCCTo1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblCCTo1.ForeColor = System.Drawing.Color.Silver;
            this.lblCCTo1.Location = new System.Drawing.Point(66, 460);
            this.lblCCTo1.Name = "lblCCTo1";
            this.lblCCTo1.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.lblCCTo1.Size = new System.Drawing.Size(234, 35);
            this.lblCCTo1.Text = "（添加0-4位抄送人，点击头像可删除）";
            this.lblCCTo1.ZIndex = 22;
            // 
            // pCCTo2
            // 
            this.pCCTo2.BackColor = System.Drawing.Color.White;
            this.pCCTo2.BorderColor = System.Drawing.Color.LightGray;
            this.pCCTo2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imgbtnAddCCTo});
            this.pCCTo2.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.pCCTo2.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.pCCTo2.Location = new System.Drawing.Point(0, 495);
            this.pCCTo2.Name = "pCCTo2";
            this.pCCTo2.Padding = new Smobiler.Core.Controls.Padding(65F, 0F, 0F, 0F);
            this.pCCTo2.Size = new System.Drawing.Size(300, 55);
            this.pCCTo2.ZIndex = 23;
            // 
            // imgbtnAddCCTo
            // 
            this.imgbtnAddCCTo.BackColor = System.Drawing.Color.White;
            this.imgbtnAddCCTo.FontSize = 13F;
            this.imgbtnAddCCTo.ForeColor = System.Drawing.Color.Black;
            this.imgbtnAddCCTo.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.imgbtnAddCCTo.IconColor = System.Drawing.Color.Black;
            this.imgbtnAddCCTo.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.Image;
            this.imgbtnAddCCTo.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.imgbtnAddCCTo.Name = "imgbtnAddCCTo";
            this.imgbtnAddCCTo.ResourceID = "add";
            this.imgbtnAddCCTo.Size = new System.Drawing.Size(35, 35);
            this.imgbtnAddCCTo.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Zoom;
            this.imgbtnAddCCTo.ZIndex = 24;
            this.imgbtnAddCCTo.Press += new System.EventHandler(this.imgbtnAddCCTo_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnSave.FontSize = 17F;
            this.btnSave.Location = new System.Drawing.Point(10, 560);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(280, 35);
            this.btnSave.Text = "提交";
            this.btnSave.Press += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imgL});
            this.panel1.Location = new System.Drawing.Point(66, 270);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 50);
            // 
            // imgL
            // 
            this.imgL.BackColor = System.Drawing.Color.White;
            this.imgL.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.imgL.Margin = new Smobiler.Core.Controls.Margin(0F, 1F, 0F, 0F);
            this.imgL.Name = "imgL";
            this.imgL.Size = new System.Drawing.Size(235, 48);
            this.imgL.ZIndex = 13;
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.title1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title1.Location = new System.Drawing.Point(111, 36);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 50);
            this.title1.TitleText = "请假";
            // 
            // frmLeaveCreate
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.popType,
            this.camera1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.pContent});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmLeaveCreate_KeyDown);
            this.Load += new System.EventHandler(this.frmLeaveCreate_Load);
            this.Name = "frmLeaveCreate";

        }
        #endregion

        private Smobiler.Core.Controls.PopList popType;
        private Smobiler.Core.Controls.Camera camera1;
        private Smobiler.Core.Controls.Panel pContent;
        internal Smobiler.Core.Controls.Label label1;
        internal Smobiler.Core.Controls.Button btnType;
        internal Smobiler.Core.Controls.Label label2;
        internal Smobiler.Core.Controls.DatePicker dpkStartDate;
        internal Smobiler.Core.Controls.Label Label3;
        internal Smobiler.Core.Controls.DatePicker dpkEndDate;
        internal Smobiler.Core.Controls.Label Label4;
        internal Smobiler.Core.Controls.TextBox txtLday;
        internal Smobiler.Core.Controls.Label Label5;
        internal Smobiler.Core.Controls.TextBox txtReason;
        internal Smobiler.Core.Controls.Label lblImg;
        internal Smobiler.Core.Controls.Label Label9;
        internal Smobiler.Core.Controls.Button btnupPhoto;
        internal Smobiler.Core.Controls.Button btndelPhoto;
        internal Smobiler.Core.Controls.Label lblCheck;
        private Smobiler.Core.Controls.Label lblCheck1;
        private Smobiler.Core.Controls.Panel pCheck2;
        internal Smobiler.Core.Controls.Label lblCCTo;
        private Smobiler.Core.Controls.Label lblCCTo1;
        private Smobiler.Core.Controls.Panel pCCTo2;
        private SmoONE.UI.Layout.Title title1;
        private Layout.ImageButton imgbtnAddCheck;
        private Layout.ImageButton imgbtnAddCCTo;
        private Smobiler.Core.Controls.Button btnSave;
        private Smobiler.Core.Controls.Panel panel1;
        internal Smobiler.Core.Controls.Image imgL;
    }
}