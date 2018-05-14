using Smobiler.Core;

namespace SmoONE.UI.Attendance
{
    partial class frmAttendanceCreate : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm Designer generated code "

        public frmAttendanceCreate()
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
            Smobiler.Core.Controls.PopListGroup popListGroup1 = new Smobiler.Core.Controls.PopListGroup();
            Smobiler.Core.Controls.PopListItem popListItem1 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem2 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem3 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem4 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem5 = new Smobiler.Core.Controls.PopListItem();
            this.gps1 = new Smobiler.Core.Controls.GPS();
            this.popList1 = new Smobiler.Core.Controls.PopList();
            this.btnSave = new Smobiler.Core.Controls.Button();
            this.btnDelete = new Smobiler.Core.Controls.Button();
            this.lblName = new Smobiler.Core.Controls.Label();
            this.lblEndWork = new Smobiler.Core.Controls.Label();
            this.lblPMStartWork = new Smobiler.Core.Controls.Label();
            this.lblPMEndWork = new Smobiler.Core.Controls.Label();
            this.lblDate1 = new Smobiler.Core.Controls.Label();
            this.btnDate = new Smobiler.Core.Controls.Button();
            this.btnATMode = new Smobiler.Core.Controls.Button();
            this.lblStartWork = new Smobiler.Core.Controls.Label();
            this.txtName = new Smobiler.Core.Controls.TextBox();
            this.lblException = new Smobiler.Core.Controls.Label();
            this.btnUser = new Smobiler.Core.Controls.Button();
            this.lblAddress1 = new Smobiler.Core.Controls.Label();
            this.btnAddress2 = new Smobiler.Core.Controls.Button();
            this.txtADeviation = new Smobiler.Core.Controls.TextBox();
            this.lblAllowableDeviation = new Smobiler.Core.Controls.Label();
            this.btnAllowableDeviation2 = new Smobiler.Core.Controls.Label();
            this.dpStartWork = new Smobiler.Core.Controls.DatePicker();
            this.dpEndWork = new Smobiler.Core.Controls.DatePicker();
            this.dpPMStartWork = new Smobiler.Core.Controls.DatePicker();
            this.dpPMEndWork = new Smobiler.Core.Controls.DatePicker();
            this.lblADeviation = new Smobiler.Core.Controls.Label();
            this.dpAMStartWork = new Smobiler.Core.Controls.DatePicker();
            this.dpAMEndWork = new Smobiler.Core.Controls.DatePicker();
            this.pAddress = new Smobiler.Core.Controls.Panel();
            this.lblAddress = new Smobiler.Core.Controls.Label();
            this.title1 = new SmoONE.UI.Layout.Title();
            this.pPost = new Smobiler.Core.Controls.Panel();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            // 
            // gps1
            // 
            this.gps1.AmapKey = "8f960360ba094ef27da07c4cb5c615fc";
            this.gps1.Name = "gps1";
            this.gps1.RequestLocation = true;
            this.gps1.GotLocation += new Smobiler.Core.Controls.GpsCallBackHandler(this.gps1_GotLocation);
            // 
            // popList1
            // 
            popListItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem1.Text = "300米";
            popListItem1.Value = "300";
            popListItem2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem2.Text = "500米";
            popListItem2.Value = "500";
            popListItem3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem3.Text = "800米";
            popListItem3.Value = "800";
            popListItem4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem4.Text = "1000米";
            popListItem4.Value = "1000";
            popListItem5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem5.Text = "自定义（300~5000）米";
            popListItem5.Value = "definition";
            popListGroup1.Items.AddRange(new Smobiler.Core.Controls.PopListItem[] {
            popListItem1,
            popListItem2,
            popListItem3,
            popListItem4,
            popListItem5});
            popListGroup1.Value = null;
            this.popList1.Groups.AddRange(new Smobiler.Core.Controls.PopListGroup[] {
            popListGroup1});
            this.popList1.Name = "popList1";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnSave.BorderRadius = 4;
            this.btnSave.FontSize = 17F;
            this.btnSave.Location = new System.Drawing.Point(10, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(280, 35);
            this.btnSave.Text = "提交";
            this.btnSave.Press += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(158)))), ((int)(((byte)(38)))));
            this.btnDelete.BorderRadius = 4;
            this.btnDelete.FontSize = 17F;
            this.btnDelete.Location = new System.Drawing.Point(156, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(134, 35);
            this.btnDelete.Text = "删除";
            this.btnDelete.Visible = false;
            this.btnDelete.Press += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.lblName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblName.Location = new System.Drawing.Point(0, 10);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.lblName.Size = new System.Drawing.Size(125, 35);
            this.lblName.Text = "名称";
            // 
            // lblEndWork
            // 
            this.lblEndWork.BackColor = System.Drawing.Color.White;
            this.lblEndWork.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.lblEndWork.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblEndWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblEndWork.Location = new System.Drawing.Point(0, 80);
            this.lblEndWork.Name = "lblEndWork";
            this.lblEndWork.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.lblEndWork.Size = new System.Drawing.Size(100, 35);
            this.lblEndWork.Text = "下班时间";
            // 
            // lblPMStartWork
            // 
            this.lblPMStartWork.BackColor = System.Drawing.Color.White;
            this.lblPMStartWork.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.lblPMStartWork.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblPMStartWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblPMStartWork.Location = new System.Drawing.Point(0, 115);
            this.lblPMStartWork.Name = "lblPMStartWork";
            this.lblPMStartWork.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.lblPMStartWork.Size = new System.Drawing.Size(100, 35);
            this.lblPMStartWork.Text = "下午上班";
            // 
            // lblPMEndWork
            // 
            this.lblPMEndWork.BackColor = System.Drawing.Color.White;
            this.lblPMEndWork.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.lblPMEndWork.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblPMEndWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblPMEndWork.Location = new System.Drawing.Point(0, 150);
            this.lblPMEndWork.Name = "lblPMEndWork";
            this.lblPMEndWork.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.lblPMEndWork.Size = new System.Drawing.Size(100, 35);
            this.lblPMEndWork.Text = "下午下班";
            // 
            // lblDate1
            // 
            this.lblDate1.BackColor = System.Drawing.Color.White;
            this.lblDate1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.lblDate1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblDate1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblDate1.Location = new System.Drawing.Point(0, 185);
            this.lblDate1.Name = "lblDate1";
            this.lblDate1.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.lblDate1.Size = new System.Drawing.Size(100, 35);
            this.lblDate1.Text = "日期";
            // 
            // btnDate
            // 
            this.btnDate.BackColor = System.Drawing.Color.White;
            this.btnDate.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.btnDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnDate.BorderRadius = 0;
            this.btnDate.FontSize = 12F;
            this.btnDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnDate.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnDate.Location = new System.Drawing.Point(100, 185);
            this.btnDate.Name = "btnDate";
            this.btnDate.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.btnDate.Size = new System.Drawing.Size(200, 35);
            this.btnDate.Text = "工作日   > ";
            this.btnDate.Press += new System.EventHandler(this.btnDate_Click);
            // 
            // btnATMode
            // 
            this.btnATMode.BackColor = System.Drawing.Color.White;
            this.btnATMode.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.btnATMode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnATMode.BorderRadius = 0;
            this.btnATMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnATMode.Location = new System.Drawing.Point(0, 220);
            this.btnATMode.Name = "btnATMode";
            this.btnATMode.Size = new System.Drawing.Size(300, 35);
            this.btnATMode.Text = "切换到一天两次上下班";
            this.btnATMode.Press += new System.EventHandler(this.btnATMode_Click);
            // 
            // lblStartWork
            // 
            this.lblStartWork.BackColor = System.Drawing.Color.White;
            this.lblStartWork.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.lblStartWork.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblStartWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblStartWork.Location = new System.Drawing.Point(0, 45);
            this.lblStartWork.Name = "lblStartWork";
            this.lblStartWork.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.lblStartWork.Size = new System.Drawing.Size(100, 35);
            this.lblStartWork.Text = "上班时间";
            // 
            // txtName
            // 
            this.txtName.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtName.FontSize = 12F;
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtName.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtName.Location = new System.Drawing.Point(125, 10);
            this.txtName.Name = "txtName";
            this.txtName.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.txtName.ReturnKeyType = Smobiler.Core.Controls.ReturnKeyType.Done;
            this.txtName.Size = new System.Drawing.Size(175, 35);
            this.txtName.WaterMarkText = "（必输）";
            // 
            // lblException
            // 
            this.lblException.BackColor = System.Drawing.Color.White;
            this.lblException.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.lblException.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblException.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblException.Location = new System.Drawing.Point(0, 265);
            this.lblException.Name = "lblException";
            this.lblException.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.lblException.Size = new System.Drawing.Size(125, 35);
            this.lblException.Text = "考勤成员";
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.White;
            this.btnUser.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.btnUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnUser.BorderRadius = 0;
            this.btnUser.FontSize = 12F;
            this.btnUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnUser.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnUser.Location = new System.Drawing.Point(125, 265);
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.btnUser.Size = new System.Drawing.Size(175, 35);
            this.btnUser.Text = "0人   > ";
            this.btnUser.Press += new System.EventHandler(this.btnUser_Click);
            // 
            // lblAddress1
            // 
            this.lblAddress1.BackColor = System.Drawing.Color.White;
            this.lblAddress1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.lblAddress1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblAddress1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblAddress1.Location = new System.Drawing.Point(0, 300);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Padding = new Smobiler.Core.Controls.Padding(4F, 5F, 0F, 0F);
            this.lblAddress1.Size = new System.Drawing.Size(125, 80);
            this.lblAddress1.Text = "考勤地点";
            this.lblAddress1.VerticalAlignment = Smobiler.Core.Controls.VerticalAlignment.Top;
            // 
            // btnAddress2
            // 
            this.btnAddress2.BackColor = System.Drawing.Color.White;
            this.btnAddress2.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.btnAddress2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnAddress2.BorderRadius = 0;
            this.btnAddress2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnAddress2.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnAddress2.Location = new System.Drawing.Point(275, 300);
            this.btnAddress2.Name = "btnAddress2";
            this.btnAddress2.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.btnAddress2.Size = new System.Drawing.Size(25, 80);
            this.btnAddress2.Text = ">";
            this.btnAddress2.Press += new System.EventHandler(this.btnAddress1_Click);
            // 
            // txtADeviation
            // 
            this.txtADeviation.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.txtADeviation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtADeviation.FontSize = 12F;
            this.txtADeviation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtADeviation.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtADeviation.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.txtADeviation.Location = new System.Drawing.Point(125, 380);
            this.txtADeviation.Name = "txtADeviation";
            this.txtADeviation.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 2F, 0F);
            this.txtADeviation.Size = new System.Drawing.Size(150, 35);
            this.txtADeviation.Text = "300";
            this.txtADeviation.TextChanged += new System.EventHandler(this.txtADeviation_TextChanged);
            // 
            // lblAllowableDeviation
            // 
            this.lblAllowableDeviation.BackColor = System.Drawing.Color.White;
            this.lblAllowableDeviation.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.lblAllowableDeviation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblAllowableDeviation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblAllowableDeviation.Location = new System.Drawing.Point(0, 380);
            this.lblAllowableDeviation.Name = "lblAllowableDeviation";
            this.lblAllowableDeviation.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.lblAllowableDeviation.Size = new System.Drawing.Size(125, 35);
            this.lblAllowableDeviation.Text = "允许偏差";
            // 
            // btnAllowableDeviation2
            // 
            this.btnAllowableDeviation2.BackColor = System.Drawing.Color.White;
            this.btnAllowableDeviation2.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.btnAllowableDeviation2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnAllowableDeviation2.FontSize = 12F;
            this.btnAllowableDeviation2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnAllowableDeviation2.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnAllowableDeviation2.Location = new System.Drawing.Point(275, 380);
            this.btnAllowableDeviation2.Name = "btnAllowableDeviation2";
            this.btnAllowableDeviation2.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.btnAllowableDeviation2.Size = new System.Drawing.Size(25, 35);
            this.btnAllowableDeviation2.Text = "米";
            // 
            // dpStartWork
            // 
            this.dpStartWork.BackColor = System.Drawing.Color.White;
            this.dpStartWork.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.dpStartWork.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dpStartWork.FontSize = 12F;
            this.dpStartWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.dpStartWork.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.dpStartWork.Location = new System.Drawing.Point(100, 45);
            this.dpStartWork.Mode = Smobiler.Core.Controls.DatePickerMode.Time;
            this.dpStartWork.Name = "dpStartWork";
            this.dpStartWork.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.dpStartWork.Size = new System.Drawing.Size(200, 35);
            this.dpStartWork.ValueChanged += new System.EventHandler(this.dpStartWork_DatePicked);
            // 
            // dpEndWork
            // 
            this.dpEndWork.BackColor = System.Drawing.Color.White;
            this.dpEndWork.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.dpEndWork.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dpEndWork.FontSize = 12F;
            this.dpEndWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.dpEndWork.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.dpEndWork.Location = new System.Drawing.Point(100, 80);
            this.dpEndWork.Mode = Smobiler.Core.Controls.DatePickerMode.Time;
            this.dpEndWork.Name = "dpEndWork";
            this.dpEndWork.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.dpEndWork.Size = new System.Drawing.Size(200, 35);
            this.dpEndWork.ValueChanged += new System.EventHandler(this.dpEndWork_DatePicked);
            // 
            // dpPMStartWork
            // 
            this.dpPMStartWork.BackColor = System.Drawing.Color.White;
            this.dpPMStartWork.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.dpPMStartWork.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dpPMStartWork.FontSize = 12F;
            this.dpPMStartWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.dpPMStartWork.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.dpPMStartWork.Location = new System.Drawing.Point(100, 115);
            this.dpPMStartWork.Mode = Smobiler.Core.Controls.DatePickerMode.Time;
            this.dpPMStartWork.Name = "dpPMStartWork";
            this.dpPMStartWork.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.dpPMStartWork.Size = new System.Drawing.Size(200, 35);
            this.dpPMStartWork.ValueChanged += new System.EventHandler(this.dpPMStartWork_DatePicked);
            // 
            // dpPMEndWork
            // 
            this.dpPMEndWork.BackColor = System.Drawing.Color.White;
            this.dpPMEndWork.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.dpPMEndWork.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dpPMEndWork.FontSize = 12F;
            this.dpPMEndWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.dpPMEndWork.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.dpPMEndWork.Location = new System.Drawing.Point(100, 150);
            this.dpPMEndWork.Mode = Smobiler.Core.Controls.DatePickerMode.Time;
            this.dpPMEndWork.Name = "dpPMEndWork";
            this.dpPMEndWork.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.dpPMEndWork.Size = new System.Drawing.Size(200, 35);
            this.dpPMEndWork.ValueChanged += new System.EventHandler(this.dpPMEndWork_DatePicked);
            // 
            // lblADeviation
            // 
            this.lblADeviation.FontSize = 12F;
            this.lblADeviation.ForeColor = System.Drawing.Color.Red;
            this.lblADeviation.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblADeviation.Location = new System.Drawing.Point(0, 415);
            this.lblADeviation.Name = "lblADeviation";
            this.lblADeviation.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.lblADeviation.Size = new System.Drawing.Size(300, 20);
            this.lblADeviation.Text = "偏差值300-5000米";
            this.lblADeviation.ZIndex = 1;
            // 
            // dpAMStartWork
            // 
            this.dpAMStartWork.BackColor = System.Drawing.Color.White;
            this.dpAMStartWork.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.dpAMStartWork.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dpAMStartWork.FontSize = 12F;
            this.dpAMStartWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.dpAMStartWork.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.dpAMStartWork.Location = new System.Drawing.Point(100, 45);
            this.dpAMStartWork.Mode = Smobiler.Core.Controls.DatePickerMode.Time;
            this.dpAMStartWork.Name = "dpAMStartWork";
            this.dpAMStartWork.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.dpAMStartWork.Size = new System.Drawing.Size(200, 35);
            this.dpAMStartWork.ValueChanged += new System.EventHandler(this.dpAMStartWork_DatePicked);
            // 
            // dpAMEndWork
            // 
            this.dpAMEndWork.BackColor = System.Drawing.Color.White;
            this.dpAMEndWork.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.dpAMEndWork.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dpAMEndWork.FontSize = 12F;
            this.dpAMEndWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.dpAMEndWork.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.dpAMEndWork.Location = new System.Drawing.Point(100, 80);
            this.dpAMEndWork.Mode = Smobiler.Core.Controls.DatePickerMode.Time;
            this.dpAMEndWork.Name = "dpAMEndWork";
            this.dpAMEndWork.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.dpAMEndWork.Size = new System.Drawing.Size(200, 35);
            this.dpAMEndWork.ValueChanged += new System.EventHandler(this.dpAMEndWork_DatePicked);
            // 
            // pAddress
            // 
            this.pAddress.BackColor = System.Drawing.Color.White;
            this.pAddress.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.pAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pAddress.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblAddress});
            this.pAddress.Location = new System.Drawing.Point(125, 300);
            this.pAddress.Name = "pAddress";
            this.pAddress.Size = new System.Drawing.Size(150, 80);
            this.pAddress.Touchable = true;
            this.pAddress.Press += new System.EventHandler(this.btnAddress1_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.BackColor = System.Drawing.Color.White;
            this.lblAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblAddress.FontSize = 12F;
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Padding = new Smobiler.Core.Controls.Padding(0F, 5F, 2F, 0F);
            this.lblAddress.Size = new System.Drawing.Size(150, 80);
            this.lblAddress.VerticalAlignment = Smobiler.Core.Controls.VerticalAlignment.Top;
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.title1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title1.Location = new System.Drawing.Point(111, 36);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 50);
            this.title1.TitleText = "考勤";
            // 
            // pPost
            // 
            this.pPost.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnSave,
            this.btnDelete});
            this.pPost.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pPost.Flex = 10000;
            this.pPost.Location = new System.Drawing.Point(0, 529);
            this.pPost.Name = "pPost";
            this.pPost.Size = new System.Drawing.Size(300, 50);
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblName,
            this.txtName,
            this.lblStartWork,
            this.dpStartWork,
            this.dpAMStartWork,
            this.lblEndWork,
            this.dpEndWork,
            this.dpAMEndWork,
            this.lblPMStartWork,
            this.dpPMStartWork,
            this.lblPMEndWork,
            this.dpPMEndWork,
            this.lblDate1,
            this.btnDate,
            this.btnATMode,
            this.lblException,
            this.btnUser,
            this.lblAddress1,
            this.pAddress,
            this.btnAddress2,
            this.txtADeviation,
            this.lblAllowableDeviation,
            this.btnAllowableDeviation2,
            this.lblADeviation});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Flex = 10000;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Scrollable = true;
            this.panel1.Size = new System.Drawing.Size(300, 20);
            // 
            // frmAttendanceCreate
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.gps1,
            this.popList1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.pPost,
            this.panel1});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmAttendanceCreate_KeyDown);
            this.Load += new System.EventHandler(this.frmAttendanceCreate_Load);
            this.Name = "frmAttendanceCreate";

        }
        #endregion

        private Smobiler.Core.Controls.GPS gps1;
        private Smobiler.Core.Controls.PopList popList1;
        private SmoONE.UI.Layout.Title title1;
        private Smobiler.Core.Controls.Panel pPost;
        private Smobiler.Core.Controls.Button btnSave;
        private Smobiler.Core.Controls.Button btnDelete;
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Label lblName;
        private Smobiler.Core.Controls.Label lblEndWork;
        private Smobiler.Core.Controls.Label lblPMStartWork;
        private Smobiler.Core.Controls.Label lblPMEndWork;
        private Smobiler.Core.Controls.Label lblDate1;
        private Smobiler.Core.Controls.Button btnDate;
        private Smobiler.Core.Controls.Button btnATMode;
        private Smobiler.Core.Controls.Label lblStartWork;
        private Smobiler.Core.Controls.TextBox txtName;
        private Smobiler.Core.Controls.Label lblException;
        private Smobiler.Core.Controls.Button btnUser;
        private Smobiler.Core.Controls.Label lblAddress1;
        private Smobiler.Core.Controls.Button btnAddress2;
        private Smobiler.Core.Controls.TextBox txtADeviation;
        private Smobiler.Core.Controls.Label lblAllowableDeviation;
        private Smobiler.Core.Controls.Label btnAllowableDeviation2;
        private Smobiler.Core.Controls.DatePicker dpStartWork;
        private Smobiler.Core.Controls.DatePicker dpEndWork;
        private Smobiler.Core.Controls.DatePicker dpPMStartWork;
        private Smobiler.Core.Controls.DatePicker dpPMEndWork;
        private Smobiler.Core.Controls.Label lblADeviation;
        private Smobiler.Core.Controls.DatePicker dpAMStartWork;
        private Smobiler.Core.Controls.DatePicker dpAMEndWork;
        private Smobiler.Core.Controls.Panel pAddress;
        private Smobiler.Core.Controls.Label lblAddress;
    }
}
