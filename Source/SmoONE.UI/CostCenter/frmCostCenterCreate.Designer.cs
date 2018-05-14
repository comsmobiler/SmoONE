using System;
using Smobiler.Core;
namespace SmoONE.UI.CostCenter
{
    partial class frmCostCenterCreate : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmCostCenterCreate()
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
            this.popType = new Smobiler.Core.Controls.PopList();
            this.btnSave = new Smobiler.Core.Controls.Button();
            this.popLiable = new Smobiler.Core.Controls.PopList();
            this.title1 = new SmoONE.UI.Layout.Title();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.Label4 = new Smobiler.Core.Controls.Label();
            this.txtCC_Name = new Smobiler.Core.Controls.TextBox();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.btnType = new Smobiler.Core.Controls.Button();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.dpkStartDate = new Smobiler.Core.Controls.DatePicker();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.dpkEndDate = new Smobiler.Core.Controls.DatePicker();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.txtAmount = new Smobiler.Core.Controls.TextBox();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.btnLiableMan = new Smobiler.Core.Controls.Button();
            this.label9 = new Smobiler.Core.Controls.Label();
            this.lblDep = new Smobiler.Core.Controls.Label();
            this.label7 = new Smobiler.Core.Controls.Label();
            this.btnTemplate = new Smobiler.Core.Controls.Button();
            // 
            // popType
            // 
            this.popType.Name = "popType";
            this.popType.Selected += new System.EventHandler(this.popType_Selected);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnSave.BorderRadius = 4;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSave.FontSize = 17F;
            this.btnSave.Location = new System.Drawing.Point(10, 400);
            this.btnSave.Margin = new Smobiler.Core.Controls.Margin(10F);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(280, 35);
            this.btnSave.Text = "提交";
            this.btnSave.Press += new System.EventHandler(this.btnSave_Click);
            // 
            // popLiable
            // 
            this.popLiable.Name = "popLiable";
            this.popLiable.Selected += new System.EventHandler(this.popLiable_Selected);
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.title1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title1.Location = new System.Drawing.Point(111, 36);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 50);
            this.title1.TitleText = "成本中心";
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label4,
            this.txtCC_Name,
            this.label3,
            this.btnType,
            this.label1,
            this.dpkStartDate,
            this.label2,
            this.dpkEndDate,
            this.label5,
            this.txtAmount,
            this.label6,
            this.btnLiableMan,
            this.label9,
            this.lblDep,
            this.label7,
            this.btnTemplate});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Scrollable = true;
            this.panel1.Size = new System.Drawing.Size(300, 363);
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.White;
            this.Label4.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.Label4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label4.Location = new System.Drawing.Point(0, 12);
            this.Label4.Name = "Label4";
            this.Label4.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.Label4.Size = new System.Drawing.Size(66, 35);
            this.Label4.Text = "名称";
            // 
            // txtCC_Name
            // 
            this.txtCC_Name.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.txtCC_Name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtCC_Name.FontSize = 12F;
            this.txtCC_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtCC_Name.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtCC_Name.Location = new System.Drawing.Point(66, 12);
            this.txtCC_Name.Name = "txtCC_Name";
            this.txtCC_Name.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.txtCC_Name.ReturnKeyType = Smobiler.Core.Controls.ReturnKeyType.Done;
            this.txtCC_Name.Size = new System.Drawing.Size(234, 35);
            this.txtCC_Name.WaterMarkText = "（必填）";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.label3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label3.Location = new System.Drawing.Point(0, 57);
            this.label3.Name = "label3";
            this.label3.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label3.Size = new System.Drawing.Size(66, 35);
            this.label3.Text = "类型";
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
            this.btnType.Location = new System.Drawing.Point(66, 57);
            this.btnType.Name = "btnType";
            this.btnType.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.btnType.Size = new System.Drawing.Size(234, 35);
            this.btnType.Text = "选择（必填）   > ";
            this.btnType.Press += new System.EventHandler(this.btntype_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label1.Location = new System.Drawing.Point(0, 102);
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label1.Size = new System.Drawing.Size(66, 35);
            this.label1.Text = "开始时间";
            // 
            // dpkStartDate
            // 
            this.dpkStartDate.BackColor = System.Drawing.Color.White;
            this.dpkStartDate.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.dpkStartDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dpkStartDate.FontSize = 12F;
            this.dpkStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.dpkStartDate.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.dpkStartDate.Location = new System.Drawing.Point(66, 102);
            this.dpkStartDate.Name = "dpkStartDate";
            this.dpkStartDate.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.dpkStartDate.Size = new System.Drawing.Size(234, 35);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label2.Location = new System.Drawing.Point(0, 137);
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label2.Size = new System.Drawing.Size(66, 35);
            this.label2.Text = "结束时间";
            // 
            // dpkEndDate
            // 
            this.dpkEndDate.BackColor = System.Drawing.Color.White;
            this.dpkEndDate.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.dpkEndDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dpkEndDate.FontSize = 12F;
            this.dpkEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.dpkEndDate.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.dpkEndDate.Location = new System.Drawing.Point(66, 137);
            this.dpkEndDate.Name = "dpkEndDate";
            this.dpkEndDate.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.dpkEndDate.Size = new System.Drawing.Size(234, 35);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.label5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label5.Location = new System.Drawing.Point(0, 182);
            this.label5.Name = "label5";
            this.label5.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label5.Size = new System.Drawing.Size(66, 35);
            this.label5.Text = "金额";
            // 
            // txtAmount
            // 
            this.txtAmount.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.txtAmount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtAmount.FontSize = 12F;
            this.txtAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtAmount.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtAmount.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.txtAmount.Location = new System.Drawing.Point(66, 182);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.txtAmount.Size = new System.Drawing.Size(234, 35);
            this.txtAmount.WaterMarkText = "（必输）";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label6.Location = new System.Drawing.Point(0, 227);
            this.label6.Name = "label6";
            this.label6.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label6.Size = new System.Drawing.Size(66, 35);
            this.label6.Text = "责任人";
            // 
            // btnLiableMan
            // 
            this.btnLiableMan.BackColor = System.Drawing.Color.White;
            this.btnLiableMan.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.btnLiableMan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnLiableMan.BorderRadius = 0;
            this.btnLiableMan.FontSize = 12F;
            this.btnLiableMan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnLiableMan.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnLiableMan.Location = new System.Drawing.Point(66, 227);
            this.btnLiableMan.Name = "btnLiableMan";
            this.btnLiableMan.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.btnLiableMan.Size = new System.Drawing.Size(234, 35);
            this.btnLiableMan.Text = "选择（必填）   > ";
            this.btnLiableMan.Press += new System.EventHandler(this.btnLiableMan_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.label9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label9.Location = new System.Drawing.Point(0, 262);
            this.label9.Name = "label9";
            this.label9.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label9.Size = new System.Drawing.Size(66, 35);
            this.label9.Text = "部门";
            // 
            // lblDep
            // 
            this.lblDep.BackColor = System.Drawing.Color.White;
            this.lblDep.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.lblDep.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblDep.FontSize = 12F;
            this.lblDep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lblDep.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblDep.Location = new System.Drawing.Point(66, 262);
            this.lblDep.Name = "lblDep";
            this.lblDep.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.lblDep.Size = new System.Drawing.Size(234, 35);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.label7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label7.Location = new System.Drawing.Point(0, 307);
            this.label7.Name = "label7";
            this.label7.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label7.Size = new System.Drawing.Size(112, 35);
            this.label7.Text = "成本中心类型模板";
            // 
            // btnTemplate
            // 
            this.btnTemplate.BackColor = System.Drawing.Color.White;
            this.btnTemplate.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.btnTemplate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnTemplate.BorderRadius = 0;
            this.btnTemplate.FontSize = 12F;
            this.btnTemplate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnTemplate.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnTemplate.Location = new System.Drawing.Point(112, 307);
            this.btnTemplate.Name = "btnTemplate";
            this.btnTemplate.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.btnTemplate.Size = new System.Drawing.Size(188, 35);
            this.btnTemplate.Text = "选择（必填）   > ";
            this.btnTemplate.Press += new System.EventHandler(this.btnTemplate_Click);
            // 
            // frmCostCenterCreate
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.popType,
            this.popLiable});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.btnSave,
            this.panel1});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmCostCenterCreate_KeyDown);
            this.Load += new System.EventHandler(this.frmCostCenterCreate_Load);
            this.Name = "frmCostCenterCreate";

        }
        #endregion

        private Smobiler.Core.Controls.PopList popType;
        private Smobiler.Core.Controls.Button btnSave;
        private Smobiler.Core.Controls.PopList popLiable;
        private SmoONE.UI.Layout.Title title1;
        private Smobiler.Core.Controls.Panel panel1;
        internal Smobiler.Core.Controls.Label Label4;
        internal Smobiler.Core.Controls.TextBox txtCC_Name;
        internal Smobiler.Core.Controls.Label label3;
        internal Smobiler.Core.Controls.Button btnType;
        internal Smobiler.Core.Controls.Label label1;
        internal Smobiler.Core.Controls.Label label2;
        internal Smobiler.Core.Controls.DatePicker dpkStartDate;
        internal Smobiler.Core.Controls.DatePicker dpkEndDate;
        internal Smobiler.Core.Controls.Label label5;
        private Smobiler.Core.Controls.TextBox txtAmount;
        internal Smobiler.Core.Controls.Label label6;
        internal Smobiler.Core.Controls.Label label7;
        internal Smobiler.Core.Controls.Button btnLiableMan;
        internal Smobiler.Core.Controls.Button btnTemplate;
        internal Smobiler.Core.Controls.Label label9;
        internal Smobiler.Core.Controls.Label lblDep;
       
    }
}