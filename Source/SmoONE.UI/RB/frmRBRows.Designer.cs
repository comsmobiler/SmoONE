using System;
using Smobiler.Core;
using SmoONE.UI.Layout;

namespace SmoONE.UI.RB
{
    partial class frmRBRows : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmRBRows()
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
            this.listRBRowData = new Smobiler.Core.Controls.ListView();
            this.lblInfor = new Smobiler.Core.Controls.Label();
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.title1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(300, 50);
            this.title1.TitleText = "消费记录";
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
            this.btnCreate.Text = "创建消费记录";
            this.btnCreate.Press += new System.EventHandler(this.btnCreate_Press);
            // 
            // listRBRowData
            // 
            this.listRBRowData.BackColor = System.Drawing.Color.White;
            this.listRBRowData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listRBRowData.FooterControlName = null;
            this.listRBRowData.HeaderControlName = null;
            this.listRBRowData.Location = new System.Drawing.Point(0, 100);
            this.listRBRowData.Margin = new Smobiler.Core.Controls.Margin(0F, 20F, 0F, 0F);
            this.listRBRowData.Name = "listRBRowData";
            this.listRBRowData.PageSize = 10;
            this.listRBRowData.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listRBRowData.PageSizeTextSize = 11F;
            this.listRBRowData.ShowSplitLine = true;
            this.listRBRowData.Size = new System.Drawing.Size(300, 30);
            this.listRBRowData.SplitLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.listRBRowData.TemplateControlName = "frmConsumptionLayout";
            // 
            // lblInfor
            // 
            this.lblInfor.ForeColor = System.Drawing.Color.Silver;
            this.lblInfor.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.lblInfor.Location = new System.Drawing.Point(0, 180);
            this.lblInfor.Name = "lblInfor";
            this.lblInfor.Size = new System.Drawing.Size(300, 30);
            this.lblInfor.Text = "当前暂无消费记录，请创建！";
            this.lblInfor.Visible = false;
            // 
            // frmRBRows
            // 
            this.ActionButton.MainButton.ButtonCorlor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ActionButton.MainButton.ResourceID = "plus";
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.btnCreate,
            this.listRBRowData,
            this.lblInfor});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmRBRows_KeyDown);
            this.Load += new System.EventHandler(this.frmRBRows_Load);
            this.Name = "frmRBRows";

        }
        #endregion

        private Title title1;
        private Smobiler.Core.Controls.Button btnCreate;
        private Smobiler.Core.Controls.ListView listRBRowData;
        private Smobiler.Core.Controls.Label lblInfor;
    }
}