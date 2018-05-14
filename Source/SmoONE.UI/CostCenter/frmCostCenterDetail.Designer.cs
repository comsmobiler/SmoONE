using System;
using Smobiler.Core;
namespace SmoONE.UI.CostCenter
{
    partial class frmCostCenterDetail : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmCostCenterDetail()
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
            this.pContent = new Smobiler.Core.Controls.Panel();
            this.Label4 = new Smobiler.Core.Controls.Label();
            this.lblCC_Name = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.lblType = new Smobiler.Core.Controls.Label();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.lblStartDate = new Smobiler.Core.Controls.Label();
            this.lblEndDate = new Smobiler.Core.Controls.Label();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.lblAmount = new Smobiler.Core.Controls.Label();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.label7 = new Smobiler.Core.Controls.Label();
            this.lblLiableMan = new Smobiler.Core.Controls.Label();
            this.lblTemplate = new Smobiler.Core.Controls.Label();
            this.lblDep = new Smobiler.Core.Controls.Label();
            this.label9 = new Smobiler.Core.Controls.Label();
            this.lblActive = new Smobiler.Core.Controls.Label();
            this.label10 = new Smobiler.Core.Controls.Label();
            this.label8 = new Smobiler.Core.Controls.Label();
            this.lblRBAmount = new Smobiler.Core.Controls.Label();
            this.pDown = new Smobiler.Core.Controls.Panel();
            this.btnEdit = new Smobiler.Core.Controls.Button();
            this.btnActive = new Smobiler.Core.Controls.Button();
            this.title1 = new SmoONE.UI.Layout.Title();
            // 
            // pContent
            // 
            this.pContent.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label4,
            this.lblCC_Name,
            this.label3,
            this.lblType,
            this.label1,
            this.lblStartDate,
            this.label2,
            this.lblEndDate,
            this.label5,
            this.lblAmount,
             this.label8,
            this.lblRBAmount,
            this.label6,
             this.lblLiableMan,
              this.label9,
              this.lblDep,
            this.label7,
            this.lblTemplate,
           
            this.lblActive,
            this.label10,
           });
            this.pContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContent.Flex = 10000;
            this.pContent.Name = "pContent";
            this.pContent.Scrollable = true;
            this.pContent.Size = new System.Drawing.Size(300, 400);
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.White;
            this.Label4.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.Label4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label4.Location = new System.Drawing.Point(0, 10);
            this.Label4.Name = "Label4";
            this.Label4.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.Label4.Size = new System.Drawing.Size(66, 35);
            this.Label4.Text = "名称";
            // 
            // lblCC_Name
            // 
            this.lblCC_Name.BackColor = System.Drawing.Color.White;
            this.lblCC_Name.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.lblCC_Name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblCC_Name.FontSize = 12F;
            this.lblCC_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lblCC_Name.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblCC_Name.Location = new System.Drawing.Point(66, 10);
            this.lblCC_Name.Name = "lblCC_Name";
            this.lblCC_Name.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.lblCC_Name.Size = new System.Drawing.Size(234, 35);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.label3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label3.Location = new System.Drawing.Point(0, 55);
            this.label3.Name = "label3";
            this.label3.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label3.Size = new System.Drawing.Size(66, 35);
            this.label3.Text = "类型";
            // 
            // lblType
            // 
            this.lblType.BackColor = System.Drawing.Color.White;
            this.lblType.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.lblType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblType.FontSize = 12F;
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lblType.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblType.Location = new System.Drawing.Point(66, 55);
            this.lblType.Name = "lblType";
            this.lblType.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.lblType.Size = new System.Drawing.Size(234, 35);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label1.Location = new System.Drawing.Point(0, 100);
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label1.Size = new System.Drawing.Size(66, 35);
            this.label1.Text = "开始时间";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label2.Location = new System.Drawing.Point(0, 135);
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label2.Size = new System.Drawing.Size(66, 35);
            this.label2.Text = "结束时间";
            // 
            // lblStartDate
            // 
            this.lblStartDate.BackColor = System.Drawing.Color.White;
            this.lblStartDate.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.lblStartDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblStartDate.FontSize = 12F;
            this.lblStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lblStartDate.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblStartDate.Location = new System.Drawing.Point(66, 100);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.lblStartDate.Size = new System.Drawing.Size(234, 35);
            // 
            // lblEndDate
            // 
            this.lblEndDate.BackColor = System.Drawing.Color.White;
            this.lblEndDate.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.lblEndDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblEndDate.FontSize = 12F;
            this.lblEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lblEndDate.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblEndDate.Location = new System.Drawing.Point(66, 135);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.lblEndDate.Size = new System.Drawing.Size(234, 35);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label5.Location = new System.Drawing.Point(0, 180);
            this.label5.Name = "label5";
            this.label5.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label5.Size = new System.Drawing.Size(66, 35);
            this.label5.Text = "预算金额";
            // 
            // lblAmount
            // 
            this.lblAmount.BackColor = System.Drawing.Color.White;
            this.lblAmount.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.lblAmount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblAmount.FontSize = 12F;
            this.lblAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lblAmount.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblAmount.Location = new System.Drawing.Point(66, 180);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.lblAmount.Size = new System.Drawing.Size(234, 35);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label6.Location = new System.Drawing.Point(0, 260);
            this.label6.Name = "label6";
            this.label6.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label6.Size = new System.Drawing.Size(66, 35);
            this.label6.Text = "责任人";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.label7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label7.Location = new System.Drawing.Point(0, 340);
            this.label7.Name = "label7";
            this.label7.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label7.Size = new System.Drawing.Size(112, 35);
            this.label7.Text = "成本中心类型模板";
            // 
            // lblLiableMan
            // 
            this.lblLiableMan.BackColor = System.Drawing.Color.White;
            this.lblLiableMan.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.lblLiableMan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblLiableMan.FontSize = 12F;
            this.lblLiableMan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lblLiableMan.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblLiableMan.Location = new System.Drawing.Point(66, 260);
            this.lblLiableMan.Name = "lblLiableMan";
            this.lblLiableMan.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.lblLiableMan.Size = new System.Drawing.Size(234, 35);
            // 
            // lblTemplate
            // 
            this.lblTemplate.BackColor = System.Drawing.Color.White;
            this.lblTemplate.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.lblTemplate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblTemplate.FontSize = 12F;
            this.lblTemplate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lblTemplate.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblTemplate.Location = new System.Drawing.Point(112, 340);
            this.lblTemplate.Name = "lblTemplate";
            this.lblTemplate.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.lblTemplate.Size = new System.Drawing.Size(188, 35);
            // 
            // lblDep
            // 
            this.lblDep.BackColor = System.Drawing.Color.White;
            this.lblDep.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.lblDep.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblDep.FontSize = 12F;
            this.lblDep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lblDep.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblDep.Location = new System.Drawing.Point(66, 295);
            this.lblDep.Name = "lblDep";
            this.lblDep.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.lblDep.Size = new System.Drawing.Size(234, 35);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.label9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label9.Location = new System.Drawing.Point(0, 295);
            this.label9.Name = "label9";
            this.label9.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label9.Size = new System.Drawing.Size(66, 35);
            this.label9.Text = "部门";
            // 
            // lblActive
            // 
            this.lblActive.BackColor = System.Drawing.Color.White;
            this.lblActive.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.lblActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblActive.FontSize = 12F;
            this.lblActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lblActive.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblActive.Location = new System.Drawing.Point(66, 385);
            this.lblActive.Name = "lblActive";
            this.lblActive.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.lblActive.Size = new System.Drawing.Size(234, 35);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.label10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label10.Location = new System.Drawing.Point(0, 385);
            this.label10.Name = "label10";
            this.label10.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label10.Size = new System.Drawing.Size(66, 35);
            this.label10.Text = "状态";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.label8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label8.Location = new System.Drawing.Point(0, 215);
            this.label8.Name = "label8";
            this.label8.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label8.Size = new System.Drawing.Size(79, 35);
            this.label8.Text = "已报销金额";
            // 
            // lblRBAmount
            // 
            this.lblRBAmount.BackColor = System.Drawing.Color.White;
            this.lblRBAmount.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.lblRBAmount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblRBAmount.FontSize = 12F;
            this.lblRBAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lblRBAmount.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblRBAmount.Location = new System.Drawing.Point(79, 215);
            this.lblRBAmount.Name = "lblRBAmount";
            this.lblRBAmount.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.lblRBAmount.Size = new System.Drawing.Size(221, 35);
            // 
            // pDown
            // 
            this.pDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pDown.Location = new System.Drawing.Point(144, 475);
            this.pDown.Name = "pDown";
            this.pDown.Size = new System.Drawing.Size(100, 50);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnEdit.FontSize = 17F;
            this.btnEdit.Location = new System.Drawing.Point(10, 10);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(134, 35);
            this.btnEdit.Text = "编辑";
            this.btnEdit.Press += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnActive
            // 
            this.btnActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnActive.FontSize = 17F;
            this.btnActive.Location = new System.Drawing.Point(156, 10);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(134, 35);
            this.btnActive.Text = "激活";
            this.btnActive.Press += new System.EventHandler(this.btnActive_Click);
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
            // frmCostCenterDetail
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.pDown,
            this.pContent});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmCostCenterDetail_KeyDown);
            this.Load += new System.EventHandler(this.frmCostCenterDetail_Load);
            this.Name = "frmCostCenterDetail";

        }
        #endregion

        private Smobiler.Core.Controls.Panel pContent;
        private Smobiler.Core.Controls.Panel pDown;
        private Smobiler.Core.Controls.Button btnEdit;
        private Smobiler.Core.Controls.Button btnActive;
        internal Smobiler.Core.Controls.Label Label4;
        internal Smobiler.Core.Controls.Label lblCC_Name;
        internal Smobiler.Core.Controls.Label label3;
        internal Smobiler.Core.Controls.Label lblType;
        internal Smobiler.Core.Controls.Label label1;
        internal Smobiler.Core.Controls.Label label2;
        internal Smobiler.Core.Controls.Label lblStartDate;
        internal Smobiler.Core.Controls.Label lblEndDate;
        internal Smobiler.Core.Controls.Label label5;
        private Smobiler.Core.Controls.Label lblAmount;
        internal Smobiler.Core.Controls.Label label6;
        internal Smobiler.Core.Controls.Label label7;
        internal Smobiler.Core.Controls.Label lblLiableMan;
        internal Smobiler.Core.Controls.Label lblTemplate;
        internal Smobiler.Core.Controls.Label lblDep;
        internal Smobiler.Core.Controls.Label label9;
        internal Smobiler.Core.Controls.Label lblActive;
        internal Smobiler.Core.Controls.Label label10;
        internal Smobiler.Core.Controls.Label label8;
        private Smobiler.Core.Controls.Label lblRBAmount;
        private SmoONE.UI.Layout.Title title1;
    }
}