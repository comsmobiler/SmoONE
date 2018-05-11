using System;
using Smobiler.Core;
using SmoONE.UI.Layout;

namespace SmoONE.UI.RB
{
    partial class frmRBDetail : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmRBDetail()
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
            this.btnAgreed = new Smobiler.Core.Controls.Button();
            this.btnRefuse = new Smobiler.Core.Controls.Button();
            this.btnEdit = new Smobiler.Core.Controls.Button();
            this.title1 = new SmoONE.UI.Layout.Title();
            this.plButton = new Smobiler.Core.Controls.Panel();
            this.spContent = new Smobiler.Core.Controls.Panel();
            this.plUser = new Smobiler.Core.Controls.Panel();
            this.imgPortrait = new Smobiler.Core.Controls.Image();
            this.lblUserName = new Smobiler.Core.Controls.Label();
            this.lblRBState = new Smobiler.Core.Controls.Label();
            this.plDetail = new Smobiler.Core.Controls.Panel();
            this.Label8 = new Smobiler.Core.Controls.Label();
            this.lblRBNO = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.lblCreateTime = new Smobiler.Core.Controls.Label();
            this.Label2 = new Smobiler.Core.Controls.Label();
            this.lblRBCC = new Smobiler.Core.Controls.Label();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.lblAmount = new Smobiler.Core.Controls.Label();
            this.lblnote1 = new Smobiler.Core.Controls.Label();
            this.lblnote = new Smobiler.Core.Controls.Label();
            this.lblReason1 = new Smobiler.Core.Controls.Label();
            this.lblReason = new Smobiler.Core.Controls.Label();
            this.listRBRowData = new Smobiler.Core.Controls.ListView();
            // 
            // btnAgreed
            // 
            this.btnAgreed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(187)))), ((int)(((byte)(91)))));
            this.btnAgreed.BorderRadius = 4;
            this.btnAgreed.FontSize = 15F;
            this.btnAgreed.Location = new System.Drawing.Point(10, 10);
            this.btnAgreed.Name = "btnAgreed";
            this.btnAgreed.Size = new System.Drawing.Size(85, 35);
            this.btnAgreed.Text = "同意";
            this.btnAgreed.Press += new System.EventHandler(this.btnAgreed_Press);
            // 
            // btnRefuse
            // 
            this.btnRefuse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(158)))), ((int)(((byte)(38)))));
            this.btnRefuse.BorderRadius = 4;
            this.btnRefuse.FontSize = 15F;
            this.btnRefuse.Location = new System.Drawing.Point(108, 10);
            this.btnRefuse.Name = "btnRefuse";
            this.btnRefuse.Size = new System.Drawing.Size(85, 35);
            this.btnRefuse.Text = "拒绝";
            this.btnRefuse.Press += new System.EventHandler(this.btnRefuse_Press);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnEdit.BorderRadius = 4;
            this.btnEdit.FontSize = 15F;
            this.btnEdit.Location = new System.Drawing.Point(205, 10);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 35);
            this.btnEdit.Text = "编辑";
            this.btnEdit.Press += new System.EventHandler(this.btnEdit_Press);
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.title1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(300, 50);
            this.title1.TitleText = "报销详情";
            // 
            // plButton
            // 
            this.plButton.BackColor = System.Drawing.Color.White;
            this.plButton.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.plButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plButton.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnAgreed,
            this.btnRefuse,
            this.btnEdit});
            this.plButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plButton.Location = new System.Drawing.Point(0, 445);
            this.plButton.Name = "plButton";
            this.plButton.Size = new System.Drawing.Size(300, 55);
            // 
            // spContent
            // 
            this.spContent.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plUser,
            this.plDetail});
            this.spContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spContent.Flex = 10000;
            this.spContent.Location = new System.Drawing.Point(0, 50);
            this.spContent.Name = "spContent";
            this.spContent.Scrollable = true;
            this.spContent.Size = new System.Drawing.Size(300, 405);
            // 
            // plUser
            // 
            this.plUser.BackColor = System.Drawing.Color.White;
            this.plUser.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plUser.BorderColor = System.Drawing.Color.LightGray;
            this.plUser.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imgPortrait,
            this.lblUserName,
            this.lblRBState});
            this.plUser.Name = "plUser";
            this.plUser.Size = new System.Drawing.Size(300, 60);
            // 
            // imgPortrait
            // 
            this.imgPortrait.BorderRadius = 25;
            this.imgPortrait.DataMember = "U_Portrait";
            this.imgPortrait.DisplayMember = "U_Portrait";
            this.imgPortrait.Location = new System.Drawing.Point(10, 5);
            this.imgPortrait.Name = "imgPortrait";
            this.imgPortrait.ResourceID = "Tou";
            this.imgPortrait.Size = new System.Drawing.Size(55, 55);
            // 
            // lblUserName
            // 
            this.lblUserName.FontSize = 15F;
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblUserName.Location = new System.Drawing.Point(70, 5);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(219, 29);
            // 
            // lblRBState
            // 
            this.lblRBState.FontSize = 12F;
            this.lblRBState.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblRBState.Location = new System.Drawing.Point(70, 40);
            this.lblRBState.Name = "lblRBState";
            this.lblRBState.Size = new System.Drawing.Size(219, 19);
            this.lblRBState.VerticalAlignment = Smobiler.Core.Controls.VerticalAlignment.Top;
            // 
            // plDetail
            // 
            this.plDetail.BackColor = System.Drawing.Color.White;
            this.plDetail.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label8,
            this.lblRBNO,
            this.label3,
            this.lblCreateTime,
            this.Label2,
            this.lblRBCC,
            this.label1,
            this.lblAmount,
            this.lblnote1,
            this.lblnote,
            this.lblReason1,
            this.lblReason,
            this.listRBRowData});
            this.plDetail.Flex = 10000;
            this.plDetail.Location = new System.Drawing.Point(0, 60);
            this.plDetail.Name = "plDetail";
            this.plDetail.Scrollable = true;
            this.plDetail.Size = new System.Drawing.Size(300, 335);
            // 
            // Label8
            // 
            this.Label8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label8.FontSize = 10F;
            this.Label8.ForeColor = System.Drawing.Color.Gray;
            this.Label8.Location = new System.Drawing.Point(10, 7);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(55, 25);
            this.Label8.Text = "报销编号：";
            // 
            // lblRBNO
            // 
            this.lblRBNO.FontSize = 10F;
            this.lblRBNO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblRBNO.Location = new System.Drawing.Point(71, 7);
            this.lblRBNO.Name = "lblRBNO";
            this.lblRBNO.Size = new System.Drawing.Size(219, 25);
            // 
            // label3
            // 
            this.label3.FontSize = 10F;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(10, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 25);
            this.label3.Text = "创建时间：";
            // 
            // lblCreateTime
            // 
            this.lblCreateTime.FontSize = 10F;
            this.lblCreateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblCreateTime.Location = new System.Drawing.Point(71, 32);
            this.lblCreateTime.Name = "lblCreateTime";
            this.lblCreateTime.Size = new System.Drawing.Size(219, 25);
            // 
            // Label2
            // 
            this.Label2.FontSize = 10F;
            this.Label2.ForeColor = System.Drawing.Color.Gray;
            this.Label2.Location = new System.Drawing.Point(10, 57);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(55, 25);
            this.Label2.Text = "成本中心：";
            // 
            // lblRBCC
            // 
            this.lblRBCC.FontSize = 10F;
            this.lblRBCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblRBCC.Location = new System.Drawing.Point(71, 57);
            this.lblRBCC.Name = "lblRBCC";
            this.lblRBCC.Size = new System.Drawing.Size(219, 25);
            // 
            // label1
            // 
            this.label1.FontSize = 10F;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(10, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.Text = "总金额：";
            // 
            // lblAmount
            // 
            this.lblAmount.FontSize = 10F;
            this.lblAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblAmount.Location = new System.Drawing.Point(71, 82);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(219, 25);
            // 
            // lblnote1
            // 
            this.lblnote1.FontSize = 10F;
            this.lblnote1.ForeColor = System.Drawing.Color.Gray;
            this.lblnote1.Location = new System.Drawing.Point(10, 107);
            this.lblnote1.Name = "lblnote1";
            this.lblnote1.Size = new System.Drawing.Size(55, 25);
            this.lblnote1.Text = "报销备注：";
            // 
            // lblnote
            // 
            this.lblnote.FontSize = 10F;
            this.lblnote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblnote.Location = new System.Drawing.Point(71, 107);
            this.lblnote.Name = "lblnote";
            this.lblnote.Size = new System.Drawing.Size(219, 25);
            // 
            // lblReason1
            // 
            this.lblReason1.FontSize = 10F;
            this.lblReason1.ForeColor = System.Drawing.Color.Gray;
            this.lblReason1.Location = new System.Drawing.Point(10, 132);
            this.lblReason1.Name = "lblReason1";
            this.lblReason1.Padding = new Smobiler.Core.Controls.Padding(0F, 5F, 0F, 0F);
            this.lblReason1.Size = new System.Drawing.Size(55, 50);
            this.lblReason1.Text = "拒绝理由：";
            this.lblReason1.VerticalAlignment = Smobiler.Core.Controls.VerticalAlignment.Top;
            // 
            // lblReason
            // 
            this.lblReason.FontSize = 10F;
            this.lblReason.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblReason.Location = new System.Drawing.Point(71, 132);
            this.lblReason.Name = "lblReason";
            this.lblReason.Padding = new Smobiler.Core.Controls.Padding(0F, 5F, 0F, 0F);
            this.lblReason.Size = new System.Drawing.Size(219, 50);
            this.lblReason.VerticalAlignment = Smobiler.Core.Controls.VerticalAlignment.Top;
            // 
            // listRBRowData
            // 
            this.listRBRowData.BackColor = System.Drawing.Color.White;
            this.listRBRowData.FooterControlName = null;
            this.listRBRowData.HeaderControlName = null;
            this.listRBRowData.Location = new System.Drawing.Point(0, 192);
            this.listRBRowData.Name = "listRBRowData";
            this.listRBRowData.ShowSplitLine = true;
            this.listRBRowData.Size = new System.Drawing.Size(300, 153);
            this.listRBRowData.SplitLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.listRBRowData.TemplateControlName = "frmRBRowLayout";
            // 
            // frmRBDetail
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.plButton,
            this.spContent});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmRBDetail_KeyDown);
            this.Load += new System.EventHandler(this.frmRBDetail_Load);
            this.Name = "frmRBDetail";

        }
        #endregion

        private Title title1;
        private Smobiler.Core.Controls.Panel plButton;
        private Smobiler.Core.Controls.Button btnAgreed;
        private Smobiler.Core.Controls.Button btnRefuse;
        private Smobiler.Core.Controls.Button btnEdit;
        private Smobiler.Core.Controls.Panel spContent;
        private Smobiler.Core.Controls.Panel plUser;
        private Smobiler.Core.Controls.Image imgPortrait;
        internal Smobiler.Core.Controls.Label lblUserName;
        internal Smobiler.Core.Controls.Label lblRBState;
        private Smobiler.Core.Controls.Panel plDetail;
        internal Smobiler.Core.Controls.Label Label8;
        private Smobiler.Core.Controls.Label lblRBNO;
        internal Smobiler.Core.Controls.Label label3;
        internal Smobiler.Core.Controls.Label lblCreateTime;
        internal Smobiler.Core.Controls.Label Label2;
        internal Smobiler.Core.Controls.Label lblRBCC;
        internal Smobiler.Core.Controls.Label label1;
        internal Smobiler.Core.Controls.Label lblAmount;
        internal Smobiler.Core.Controls.Label lblnote1;
        internal Smobiler.Core.Controls.Label lblnote;
        internal Smobiler.Core.Controls.Label lblReason1;
        internal Smobiler.Core.Controls.Label lblReason;
        private Smobiler.Core.Controls.ListView listRBRowData;
    }
}