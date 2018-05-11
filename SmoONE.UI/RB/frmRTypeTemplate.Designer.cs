using System;
using Smobiler.Core;
using SmoONE.UI.Layout;

namespace SmoONE.UI.RB
{
    partial class frmRTypeTemplate : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmRTypeTemplate()
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
            this.btnCreate = new Smobiler.Core.Controls.Button();
            this.listRBModelData = new Smobiler.Core.Controls.ListView();
            this.lblInfor = new Smobiler.Core.Controls.Label();
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.title1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title1.Location = new System.Drawing.Point(87, 108);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 50);
            this.title1.TitleText = "消费模板列表";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnCreate.BorderRadius = 4;
            this.btnCreate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreate.FontSize = 15F;
            this.btnCreate.Location = new System.Drawing.Point(10, 60);
            this.btnCreate.Margin = new Smobiler.Core.Controls.Margin(10F, 10F, 10F, 0F);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(280, 35);
            this.btnCreate.Text = "创建消费模板";
            this.btnCreate.Press += new System.EventHandler(this.btnCreate_Press);
            // 
            // listRBModelData
            // 
            this.listRBModelData.BackColor = System.Drawing.Color.White;
            this.listRBModelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listRBModelData.FooterControlName = null;
            this.listRBModelData.HeaderControlName = null;
            this.listRBModelData.Location = new System.Drawing.Point(17, 262);
            this.listRBModelData.Margin = new Smobiler.Core.Controls.Margin(0F, 20F, 0F, 0F);
            this.listRBModelData.Name = "listRBModelData";
            this.listRBModelData.PageSize = 10;
            this.listRBModelData.ShowSplitLine = true;
            this.listRBModelData.Size = new System.Drawing.Size(100, 30);
            this.listRBModelData.SplitLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.listRBModelData.TemplateControlName = "frmRBModelLayout";
            // 
            // lblInfor
            // 
            this.lblInfor.ForeColor = System.Drawing.Color.Silver;
            this.lblInfor.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.lblInfor.Location = new System.Drawing.Point(0, 180);
            this.lblInfor.Name = "lblInfor";
            this.lblInfor.Size = new System.Drawing.Size(300, 30);
            this.lblInfor.Text = "当前暂无消费模板，请创建！";
            // 
            // frmRTypeTemplate
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.btnCreate,
            this.listRBModelData,
            this.lblInfor});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmRTypeTemplate_KeyDown);
            this.Load += new System.EventHandler(this.frmRTypeTemplate_Load);
            this.Name = "frmRTypeTemplate";

        }
        #endregion

        private Title title1;
        private Smobiler.Core.Controls.Button btnCreate;
        private Smobiler.Core.Controls.ListView listRBModelData;
        private Smobiler.Core.Controls.Label lblInfor;
    }
}