using System;
using Smobiler.Core;
using SmoONE.UI.Layout;

namespace SmoONE.UI.RB
{
    partial class frmRBEdit : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmRBEdit()
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
            this.plRBNO = new Smobiler.Core.Controls.Panel();
            this.Label1 = new Smobiler.Core.Controls.Label();
            this.lblRBNO = new Smobiler.Core.Controls.Label();
            this.plRBCC = new Smobiler.Core.Controls.Panel();
            this.Label4 = new Smobiler.Core.Controls.Label();
            this.btnRBCC = new Smobiler.Core.Controls.Button();
            this.plNote = new Smobiler.Core.Controls.Panel();
            this.lblNote = new Smobiler.Core.Controls.Label();
            this.TxtNote = new Smobiler.Core.Controls.TextBox();
            this.plAll = new Smobiler.Core.Controls.Panel();
            this.Checkall = new Smobiler.Core.Controls.CheckBox();
            this.lblCheckall = new Smobiler.Core.Controls.Label();
            this.Label3 = new Smobiler.Core.Controls.Label();
            this.lblAmount = new Smobiler.Core.Controls.Label();
            this.listRBRowData = new Smobiler.Core.Controls.ListView();
            this.btnSave = new Smobiler.Core.Controls.Button();
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.title1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(300, 50);
            this.title1.TitleText = "报销编辑";
            // 
            // spContent
            // 
            this.spContent.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plRBNO,
            this.plRBCC,
            this.plNote,
            this.plAll,
            this.listRBRowData});
            this.spContent.Flex = 10000;
            this.spContent.Location = new System.Drawing.Point(0, 60);
            this.spContent.Name = "spContent";
            this.spContent.Scrollable = true;
            this.spContent.Size = new System.Drawing.Size(300, 395);
            // 
            // plRBNO
            // 
            this.plRBNO.BackColor = System.Drawing.Color.White;
            this.plRBNO.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.plRBNO.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plRBNO.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label1,
            this.lblRBNO});
            this.plRBNO.Name = "plRBNO";
            this.plRBNO.Size = new System.Drawing.Size(300, 35);
            // 
            // Label1
            // 
            this.Label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(88, 35);
            this.Label1.Text = "报销编号";
            // 
            // lblRBNO
            // 
            this.lblRBNO.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblRBNO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lblRBNO.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblRBNO.Location = new System.Drawing.Point(88, 0);
            this.lblRBNO.Name = "lblRBNO";
            this.lblRBNO.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.lblRBNO.Size = new System.Drawing.Size(213, 35);
            // 
            // plRBCC
            // 
            this.plRBCC.BackColor = System.Drawing.Color.White;
            this.plRBCC.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.plRBCC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plRBCC.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label4,
            this.btnRBCC});
            this.plRBCC.Location = new System.Drawing.Point(0, 45);
            this.plRBCC.Name = "plRBCC";
            this.plRBCC.Size = new System.Drawing.Size(300, 35);
            // 
            // Label4
            // 
            this.Label4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label4.Name = "Label4";
            this.Label4.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.Label4.Size = new System.Drawing.Size(88, 35);
            this.Label4.Text = "成本中心";
            // 
            // btnRBCC
            // 
            this.btnRBCC.BackColor = System.Drawing.Color.Transparent;
            this.btnRBCC.BorderRadius = 0;
            this.btnRBCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnRBCC.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnRBCC.Location = new System.Drawing.Point(88, 0);
            this.btnRBCC.Name = "btnRBCC";
            this.btnRBCC.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.btnRBCC.Size = new System.Drawing.Size(212, 35);
            this.btnRBCC.Text = "选择（必填）   > ";
            this.btnRBCC.Press += new System.EventHandler(this.btnRBCC_Press);
            // 
            // plNote
            // 
            this.plNote.BackColor = System.Drawing.Color.White;
            this.plNote.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.plNote.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plNote.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblNote,
            this.TxtNote});
            this.plNote.Location = new System.Drawing.Point(0, 90);
            this.plNote.Name = "plNote";
            this.plNote.Size = new System.Drawing.Size(300, 100);
            // 
            // lblNote
            // 
            this.lblNote.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblNote.Name = "lblNote";
            this.lblNote.Padding = new Smobiler.Core.Controls.Padding(4F, 5F, 0F, 0F);
            this.lblNote.Size = new System.Drawing.Size(88, 100);
            this.lblNote.Text = "报销备注";
            this.lblNote.VerticalAlignment = Smobiler.Core.Controls.VerticalAlignment.Top;
            // 
            // TxtNote
            // 
            this.TxtNote.BackColor = System.Drawing.Color.Transparent;
            this.TxtNote.Location = new System.Drawing.Point(88, 0);
            this.TxtNote.Multiline = true;
            this.TxtNote.Name = "TxtNote";
            this.TxtNote.Padding = new Smobiler.Core.Controls.Padding(0F, 5F, 4F, 0F);
            this.TxtNote.Size = new System.Drawing.Size(212, 100);
            this.TxtNote.WaterMarkText = "（选填）";
            // 
            // plAll
            // 
            this.plAll.BackColor = System.Drawing.Color.White;
            this.plAll.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Checkall,
            this.lblCheckall,
            this.Label3,
            this.lblAmount});
            this.plAll.Location = new System.Drawing.Point(0, 360);
            this.plAll.Name = "plAll";
            this.plAll.Size = new System.Drawing.Size(300, 35);
            // 
            // Checkall
            // 
            this.Checkall.Location = new System.Drawing.Point(10, 10);
            this.Checkall.Name = "Checkall";
            this.Checkall.Size = new System.Drawing.Size(15, 15);
            this.Checkall.ZIndex = 2;
            this.Checkall.CheckedChanged += new System.EventHandler(this.Checkall_CheckedChanged);
            // 
            // lblCheckall
            // 
            this.lblCheckall.FontSize = 12F;
            this.lblCheckall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblCheckall.Location = new System.Drawing.Point(42, 0);
            this.lblCheckall.Name = "lblCheckall";
            this.lblCheckall.Size = new System.Drawing.Size(40, 35);
            this.lblCheckall.Text = "全选";
            // 
            // Label3
            // 
            this.Label3.Bold = true;
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Label3.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.Label3.Location = new System.Drawing.Point(82, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(85, 35);
            this.Label3.Text = "总计：";
            // 
            // lblAmount
            // 
            this.lblAmount.Bold = true;
            this.lblAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.lblAmount.Location = new System.Drawing.Point(167, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Padding = new Smobiler.Core.Controls.Padding(2F, 0F, 0F, 0F);
            this.lblAmount.Size = new System.Drawing.Size(133, 35);
            this.lblAmount.Text = "￥0";
            // 
            // listRBRowData
            // 
            this.listRBRowData.BackColor = System.Drawing.Color.White;
            this.listRBRowData.FooterControlName = null;
            this.listRBRowData.HeaderControlName = null;
            this.listRBRowData.Location = new System.Drawing.Point(0, 200);
            this.listRBRowData.Name = "listRBRowData";
            this.listRBRowData.ShowSplitLine = true;
            this.listRBRowData.Size = new System.Drawing.Size(300, 160);
            this.listRBRowData.SplitLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.listRBRowData.TemplateControlName = "frmConsumption1Layout";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnSave.BorderRadius = 4;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSave.FontSize = 17F;
            this.btnSave.Location = new System.Drawing.Point(10, 455);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(280, 35);
            this.btnSave.Text = "提交";
            this.btnSave.Press += new System.EventHandler(this.btnSave_Press);
            // 
            // frmRBEdit
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.spContent,
            this.btnSave});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmRBEdit_KeyDown);
            this.Load += new System.EventHandler(this.frmRBEdit_Load);
            this.Name = "frmRBEdit";

        }
        #endregion

        private Title title1;
        private Smobiler.Core.Controls.Panel spContent;
        private Smobiler.Core.Controls.Panel plRBNO;
        internal Smobiler.Core.Controls.Label Label1;
        internal Smobiler.Core.Controls.Label lblRBNO;
        private Smobiler.Core.Controls.Panel plRBCC;
        internal Smobiler.Core.Controls.Label Label4;
        private Smobiler.Core.Controls.Button btnRBCC;
        private Smobiler.Core.Controls.Panel plNote;
        internal Smobiler.Core.Controls.Label lblNote;
        private Smobiler.Core.Controls.TextBox TxtNote;
        private Smobiler.Core.Controls.Panel plAll;
        internal Smobiler.Core.Controls.CheckBox Checkall;
        internal Smobiler.Core.Controls.Label lblCheckall;
        internal Smobiler.Core.Controls.Label Label3;
        internal Smobiler.Core.Controls.Label lblAmount;
        private Smobiler.Core.Controls.ListView listRBRowData;
        private Smobiler.Core.Controls.Button btnSave;
    }
}