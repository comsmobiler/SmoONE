using System;
using Smobiler.Core;
using SmoONE.UI.Layout;

namespace SmoONE.UI.RB
{
    partial class frmRowsCreate : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmRowsCreate()
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
            this.title = new SmoONE.UI.Layout.Title();
            this.spContent = new Smobiler.Core.Controls.Panel();
            this.plRBModel = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.btnRBModel = new Smobiler.Core.Controls.Button();
            this.plMoney = new Smobiler.Core.Controls.Panel();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.txtMoney = new Smobiler.Core.Controls.TextBox();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.plRBType = new Smobiler.Core.Controls.Panel();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.btnRBType = new Smobiler.Core.Controls.Button();
            this.plDate = new Smobiler.Core.Controls.Panel();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.DatePicker = new Smobiler.Core.Controls.DatePicker();
            this.plNote = new Smobiler.Core.Controls.Panel();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.txtNote = new Smobiler.Core.Controls.TextBox();
            this.label7 = new Smobiler.Core.Controls.Label();
            this.btnSave = new Smobiler.Core.Controls.Button();
            this.btnDelete = new Smobiler.Core.Controls.Button();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.title.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.title.Dock = System.Windows.Forms.DockStyle.Top;
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(300, 50);
            this.title.TitleText = "添加消费记录";
            // 
            // spContent
            // 
            this.spContent.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plRBModel,
            this.plMoney,
            this.plRBType,
            this.plDate,
            this.plNote,
            this.label7,
            this.btnSave,
            this.btnDelete});
            this.spContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spContent.Flex = 10000;
            this.spContent.Location = new System.Drawing.Point(73, 223);
            this.spContent.Margin = new Smobiler.Core.Controls.Margin(0F, 10F, 0F, 0F);
            this.spContent.Name = "spContent";
            this.spContent.Scrollable = true;
            this.spContent.Size = new System.Drawing.Size(100, 30);
            // 
            // plRBModel
            // 
            this.plRBModel.BackColor = System.Drawing.Color.White;
            this.plRBModel.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.plRBModel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plRBModel.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.btnRBModel});
            this.plRBModel.Name = "plRBModel";
            this.plRBModel.Size = new System.Drawing.Size(300, 35);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label1.Size = new System.Drawing.Size(88, 35);
            this.label1.Text = "消费模板";
            // 
            // btnRBModel
            // 
            this.btnRBModel.BackColor = System.Drawing.Color.Transparent;
            this.btnRBModel.BorderRadius = 0;
            this.btnRBModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnRBModel.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnRBModel.Location = new System.Drawing.Point(88, 0);
            this.btnRBModel.Name = "btnRBModel";
            this.btnRBModel.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.btnRBModel.Size = new System.Drawing.Size(212, 35);
            this.btnRBModel.Text = "选择（选填）   > ";
            this.btnRBModel.Press += new System.EventHandler(this.btnRBModel_Press);
            // 
            // plMoney
            // 
            this.plMoney.BackColor = System.Drawing.Color.White;
            this.plMoney.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.plMoney.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plMoney.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label2,
            this.txtMoney,
            this.label3});
            this.plMoney.Location = new System.Drawing.Point(0, 45);
            this.plMoney.Name = "plMoney";
            this.plMoney.Size = new System.Drawing.Size(300, 35);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label2.Size = new System.Drawing.Size(88, 35);
            this.label2.Text = "消费金额";
            // 
            // txtMoney
            // 
            this.txtMoney.BackColor = System.Drawing.Color.Transparent;
            this.txtMoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtMoney.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtMoney.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.txtMoney.Location = new System.Drawing.Point(88, 0);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(182, 35);
            this.txtMoney.WaterMarkText = "0.00";
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label3.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label3.Location = new System.Drawing.Point(270, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.label3.Size = new System.Drawing.Size(30, 35);
            this.label3.Text = "元";
            // 
            // plRBType
            // 
            this.plRBType.BackColor = System.Drawing.Color.White;
            this.plRBType.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.plRBType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plRBType.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label4,
            this.btnRBType});
            this.plRBType.Location = new System.Drawing.Point(0, 90);
            this.plRBType.Name = "plRBType";
            this.plRBType.Size = new System.Drawing.Size(300, 35);
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label4.Name = "label4";
            this.label4.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label4.Size = new System.Drawing.Size(88, 35);
            this.label4.Text = "消费类别";
            // 
            // btnRBType
            // 
            this.btnRBType.BackColor = System.Drawing.Color.Transparent;
            this.btnRBType.BorderRadius = 0;
            this.btnRBType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnRBType.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnRBType.Location = new System.Drawing.Point(88, 0);
            this.btnRBType.Name = "btnRBType";
            this.btnRBType.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.btnRBType.Size = new System.Drawing.Size(212, 35);
            this.btnRBType.Text = "选择（必填）   > ";
            this.btnRBType.Press += new System.EventHandler(this.btnRBType_Press);
            // 
            // plDate
            // 
            this.plDate.BackColor = System.Drawing.Color.White;
            this.plDate.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plDate.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label5,
            this.DatePicker});
            this.plDate.Location = new System.Drawing.Point(0, 125);
            this.plDate.Name = "plDate";
            this.plDate.Size = new System.Drawing.Size(300, 35);
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label5.Name = "label5";
            this.label5.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label5.Size = new System.Drawing.Size(88, 35);
            this.label5.Text = "消费日期";
            // 
            // DatePicker
            // 
            this.DatePicker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.DatePicker.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.DatePicker.Location = new System.Drawing.Point(88, 0);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.DatePicker.Size = new System.Drawing.Size(212, 35);
            // 
            // plNote
            // 
            this.plNote.BackColor = System.Drawing.Color.White;
            this.plNote.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.plNote.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plNote.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label6,
            this.txtNote});
            this.plNote.Location = new System.Drawing.Point(0, 170);
            this.plNote.Name = "plNote";
            this.plNote.Size = new System.Drawing.Size(300, 100);
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label6.Name = "label6";
            this.label6.Padding = new Smobiler.Core.Controls.Padding(4F, 5F, 0F, 0F);
            this.label6.Size = new System.Drawing.Size(88, 100);
            this.label6.Text = "备注";
            this.label6.VerticalAlignment = Smobiler.Core.Controls.VerticalAlignment.Top;
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.Color.Transparent;
            this.txtNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtNote.Location = new System.Drawing.Point(88, 0);
            this.txtNote.MaxLength = 200;
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Padding = new Smobiler.Core.Controls.Padding(0F, 5F, 4F, 0F);
            this.txtNote.Size = new System.Drawing.Size(212, 100);
            this.txtNote.WaterMarkText = "（必填）";
            // 
            // label7
            // 
            this.label7.FontSize = 12F;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label7.Location = new System.Drawing.Point(0, 270);
            this.label7.Name = "label7";
            this.label7.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.label7.Size = new System.Drawing.Size(300, 25);
            this.label7.Text = "备注长度不能超过200！";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnSave.BorderRadius = 4;
            this.btnSave.FontSize = 15F;
            this.btnSave.Location = new System.Drawing.Point(10, 305);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 35);
            this.btnSave.Text = "提交";
            this.btnSave.Press += new System.EventHandler(this.btnSave_Press);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(158)))), ((int)(((byte)(38)))));
            this.btnDelete.BorderRadius = 4;
            this.btnDelete.FontSize = 15F;
            this.btnDelete.Location = new System.Drawing.Point(156, 305);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(134, 35);
            this.btnDelete.Text = "删除";
            this.btnDelete.Press += new System.EventHandler(this.btnDelete_Press);
            // 
            // frmRowsCreate
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title,
            this.spContent});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmRowsCreate_KeyDown);
            this.Load += new System.EventHandler(this.frmRowsCreate_Load);
            this.Name = "frmRowsCreate";

        }
        #endregion

        private Title title;
        private Smobiler.Core.Controls.Panel spContent;
        private Smobiler.Core.Controls.Panel plRBModel;
        private Smobiler.Core.Controls.Label label1;
        internal Smobiler.Core.Controls.Button btnRBModel;
        private Smobiler.Core.Controls.Panel plMoney;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.TextBox txtMoney;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Panel plRBType;
        internal Smobiler.Core.Controls.Label label4;
        internal Smobiler.Core.Controls.Button btnRBType;
        private Smobiler.Core.Controls.Panel plDate;
        private Smobiler.Core.Controls.Label label5;
        private Smobiler.Core.Controls.DatePicker DatePicker;
        private Smobiler.Core.Controls.Panel plNote;
        private Smobiler.Core.Controls.Label label6;
        private Smobiler.Core.Controls.TextBox txtNote;
        private Smobiler.Core.Controls.Label label7;
        private Smobiler.Core.Controls.Button btnSave;
        private Smobiler.Core.Controls.Button btnDelete;
    }
}