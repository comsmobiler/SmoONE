using System;
using Smobiler.Core;
using SmoONE.UI.Layout;

namespace SmoONE.UI.RB
{
    partial class frmRTypeTempChoose : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmRTypeTempChoose()
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
            this.listRBModel = new Smobiler.Core.Controls.ListView();
            this.lblInfor = new Smobiler.Core.Controls.Label();
            this.btnCreate = new Smobiler.Core.Controls.Button();
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.title1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title1.Location = new System.Drawing.Point(59, 80);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 50);
            this.title1.TitleText = "消费模板选择";
            this.title1.Load += new System.EventHandler(this.title1_Load);
            // 
            // listRBModel
            // 
            this.listRBModel.BackColor = System.Drawing.Color.White;
            this.listRBModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listRBModel.FooterControlName = null;
            this.listRBModel.HeaderControlName = null;
            this.listRBModel.Location = new System.Drawing.Point(102, 275);
            this.listRBModel.Name = "listRBModel";
            this.listRBModel.PageSize = 10;
            this.listRBModel.ShowSplitLine = true;
            this.listRBModel.Size = new System.Drawing.Size(100, 30);
            this.listRBModel.SplitLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.listRBModel.TemplateControlName = "frmRBModelLayout";
            // 
            // lblInfor
            // 
            this.lblInfor.ForeColor = System.Drawing.Color.Silver;
            this.lblInfor.Location = new System.Drawing.Point(42, 180);
            this.lblInfor.Name = "lblInfor";
            this.lblInfor.Size = new System.Drawing.Size(145, 30);
            this.lblInfor.Text = "当前暂无消费模板，请";
            this.lblInfor.ZIndex = 1;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Transparent;
            this.btnCreate.BorderRadius = 0;
            this.btnCreate.FontSize = 15F;
            this.btnCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnCreate.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Left;
            this.btnCreate.Location = new System.Drawing.Point(187, 180);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.btnCreate.Size = new System.Drawing.Size(70, 30);
            this.btnCreate.Text = "创建！";
            this.btnCreate.Press += new System.EventHandler(this.btnCreate_Press);
            // 
            // frmRTypeTempChoose
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.listRBModel,
            this.lblInfor,
            this.btnCreate});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmRTypeTempChoose_KeyDown);
            this.Load += new System.EventHandler(this.frmRTypeTempChoose_Load);
            this.Name = "frmRTypeTempChoose";

        }
        #endregion

        private Title title1;
        private Smobiler.Core.Controls.ListView listRBModel;
        private Smobiler.Core.Controls.Label lblInfor;
        private Smobiler.Core.Controls.Button btnCreate;
    }
}