using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class frmCostCenterLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerForm generated code "

        public frmCostCenterLayout()
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
            this.lblCC_ID = new Smobiler.Core.Controls.Label();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.lblAmount = new Smobiler.Core.Controls.Label();
            this.lblCC_Name = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.lblCC_LiableMan = new Smobiler.Core.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblCC_ID,
            this.label4,
            this.lblAmount,
            this.lblCC_Name,
            this.label3,
            this.label2,
            this.lblCC_LiableMan});
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 60);
            this.panel1.Touchable = true;
            this.panel1.Press += new System.EventHandler(this.panel1_Press);
            // 
            // lblCC_ID
            // 
            this.lblCC_ID.DataMember = "CC_ID";
            this.lblCC_ID.DisplayMember = "CC_ID";
            this.lblCC_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblCC_ID.Name = "lblCC_ID";
            this.lblCC_ID.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.lblCC_ID.Size = new System.Drawing.Size(190, 20);
            this.lblCC_ID.ZIndex = 1;
            // 
            // label4
            // 
            this.label4.FontSize = 12F;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label4.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label4.Location = new System.Drawing.Point(150, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.Text = "已报销金额";
            this.label4.ZIndex = 1;
            // 
            // lblAmount
            // 
            this.lblAmount.DataMember = "CC_Amount";
            this.lblAmount.DisplayMember = "CC_Amount";
            this.lblAmount.FontSize = 12F;
            this.lblAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lblAmount.Location = new System.Drawing.Point(75, 40);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(75, 20);
            this.lblAmount.ZIndex = 1;
            // 
            // lblCC_Name
            // 
            this.lblCC_Name.DataMember = "CC_Name";
            this.lblCC_Name.DisplayMember = "CC_Name";
            this.lblCC_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lblCC_Name.Location = new System.Drawing.Point(0, 20);
            this.lblCC_Name.Name = "lblCC_Name";
            this.lblCC_Name.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 10F, 0F);
            this.lblCC_Name.Size = new System.Drawing.Size(300, 20);
            this.lblCC_Name.ZIndex = 3;
            // 
            // label3
            // 
            this.label3.FontSize = 12F;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label3.Location = new System.Drawing.Point(0, 40);
            this.label3.Name = "label3";
            this.label3.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.Text = "预算金额";
            this.label3.ZIndex = 1;
            // 
            // label2
            // 
            this.label2.DataMember = "CC_UsedAmount";
            this.label2.DisplayMember = "CC_UsedAmount";
            this.label2.FontSize = 12F;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label2.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label2.Location = new System.Drawing.Point(225, 40);
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Controls.Padding(2F, 0F, 10F, 0F);
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.ZIndex = 2;
            // 
            // lblCC_LiableMan
            // 
            this.lblCC_LiableMan.DataMember = "CC_LiableMan";
            this.lblCC_LiableMan.DisplayMember = "CC_LiableMan";
            this.lblCC_LiableMan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblCC_LiableMan.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblCC_LiableMan.Location = new System.Drawing.Point(190, 0);
            this.lblCC_LiableMan.Name = "lblCC_LiableMan";
            this.lblCC_LiableMan.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.lblCC_LiableMan.Size = new System.Drawing.Size(110, 20);
            this.lblCC_LiableMan.ZIndex = 2;
            // 
            // frmCostCenterLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(300, 60);
            this.Name = "frmCostCenterLayout";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        internal Smobiler.Core.Controls.Label lblCC_ID;
        internal Smobiler.Core.Controls.Label label4;
        internal Smobiler.Core.Controls.Label lblAmount;
        internal Smobiler.Core.Controls.Label lblCC_Name;
        internal Smobiler.Core.Controls.Label label3;
        internal Smobiler.Core.Controls.Label label2;
        internal Smobiler.Core.Controls.Label lblCC_LiableMan;

    }
}