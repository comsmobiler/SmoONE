using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class frmCostTempletLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerForm generated code "

        public frmCostTempletLayout()
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
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.lblID = new Smobiler.Core.Controls.Label();
            this.lblType = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.panel3 = new Smobiler.Core.Controls.Panel();
            this.panel7 = new Smobiler.Core.Controls.Panel();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.lblAEACheckers = new Smobiler.Core.Controls.Label();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.lblFCheckers = new Smobiler.Core.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblID,
            this.lblType,
            this.label2,
            this.panel3,
            this.panel7,
            this.label6,
            this.lblAEACheckers,
            this.label5,
            this.label4,
            this.lblFCheckers});
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 85);
            this.panel1.Touchable = true;
            this.panel1.Press += new System.EventHandler(this.panel1_Press);
            // 
            // lblID
            // 
            this.lblID.DataMember = "CC_TT_TemplateID";
            this.lblID.DisplayMember = "CC_TT_TemplateID";
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblID.Name = "lblID";
            this.lblID.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.lblID.Size = new System.Drawing.Size(186, 20);
            this.lblID.ZIndex = 1;
            // 
            // lblType
            // 
            this.lblType.DataMember = "CC_TT_TypeName";
            this.lblType.DisplayMember = "CC_TT_TypeName";
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblType.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblType.Location = new System.Drawing.Point(185, 0);
            this.lblType.Name = "lblType";
            this.lblType.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.lblType.Size = new System.Drawing.Size(114, 20);
            this.lblType.ZIndex = 2;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label2.Location = new System.Drawing.Point(0, 20);
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 10F, 0F);
            this.label2.Size = new System.Drawing.Size(300, 20);
            this.label2.Text = "审批流程：";
            this.label2.ZIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.panel3.BorderRadius = 2;
            this.panel3.Location = new System.Drawing.Point(4, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(130, 40);
            this.panel3.ZIndex = 4;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.panel7.BorderRadius = 2;
            this.panel7.Location = new System.Drawing.Point(154, 40);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(130, 40);
            this.panel7.ZIndex = 5;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.label6.FontSize = 12F;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label6.Location = new System.Drawing.Point(6, 40);
            this.label6.Name = "label6";
            this.label6.Padding = new Smobiler.Core.Controls.Padding(2F, 7F, 0F, 0F);
            this.label6.Size = new System.Drawing.Size(126, 20);
            this.label6.Text = "行政审批";
            this.label6.ZIndex = 6;
            // 
            // lblAEACheckers
            // 
            this.lblAEACheckers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.lblAEACheckers.DataMember = "CC_TT_AEACheckers";
            this.lblAEACheckers.DisplayMember = "CC_TT_AEACheckers";
            this.lblAEACheckers.FontSize = 12F;
            this.lblAEACheckers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lblAEACheckers.Location = new System.Drawing.Point(6, 60);
            this.lblAEACheckers.Name = "lblAEACheckers";
            this.lblAEACheckers.Padding = new Smobiler.Core.Controls.Padding(2F, 0F, 0F, 5F);
            this.lblAEACheckers.Size = new System.Drawing.Size(126, 20);
            this.lblAEACheckers.ZIndex = 7;
            // 
            // label5
            // 
            this.label5.FontSize = 16F;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label5.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label5.Location = new System.Drawing.Point(134, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 40);
            this.label5.Text = ">";
            this.label5.ZIndex = 8;
            // 
            // label4
            // 
            this.label4.FontSize = 12F;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label4.Location = new System.Drawing.Point(156, 40);
            this.label4.Name = "label4";
            this.label4.Padding = new Smobiler.Core.Controls.Padding(2F, 7F, 0F, 0F);
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.Text = "财务审批";
            this.label4.ZIndex = 9;
            // 
            // lblFCheckers
            // 
            this.lblFCheckers.DataMember = "CC_TT_FinancialCheckers";
            this.lblFCheckers.DisplayMember = "CC_TT_FinancialCheckers";
            this.lblFCheckers.FontSize = 12F;
            this.lblFCheckers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lblFCheckers.Location = new System.Drawing.Point(156, 60);
            this.lblFCheckers.Name = "lblFCheckers";
            this.lblFCheckers.Padding = new Smobiler.Core.Controls.Padding(2F, 0F, 0F, 5F);
            this.lblFCheckers.Size = new System.Drawing.Size(126, 20);
            this.lblFCheckers.ZIndex = 10;
            // 
            // frmCostTempletLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(300, 85);
            this.Name = "frmCostTempletLayout";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        internal Smobiler.Core.Controls.Label lblID;
        internal Smobiler.Core.Controls.Label lblType;
        internal Smobiler.Core.Controls.Label label2;
        internal Smobiler.Core.Controls.Panel panel3;
        internal Smobiler.Core.Controls.Panel panel7;
        internal Smobiler.Core.Controls.Label label6;
        internal Smobiler.Core.Controls.Label lblAEACheckers;
        internal Smobiler.Core.Controls.Label label5;
        internal Smobiler.Core.Controls.Label label4;
        internal Smobiler.Core.Controls.Label lblFCheckers;
    }
}