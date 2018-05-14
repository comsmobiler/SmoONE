using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class frmRBRowLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        public frmRBRowLayout()
            : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call
        }

        //SmobilerUserControl overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerUserControl
        //It can be modified using the SmobilerUserControl.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.imgType = new Smobiler.Core.Controls.Image();
            this.lblMoney = new Smobiler.Core.Controls.Label();
            this.lbldate = new Smobiler.Core.Controls.Label();
            this.lblnote = new Smobiler.Core.Controls.Label();
            // 
            // imgType
            // 
            this.imgType.BorderRadius = 15;
            this.imgType.DataMember = "RBROW_TYPENAME";
            this.imgType.DisplayMember = "RBROW_TYPE";
            this.imgType.Location = new System.Drawing.Point(0, 7);
            this.imgType.Name = "imgType";
            this.imgType.Size = new System.Drawing.Size(45, 45);
            this.imgType.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Cover;
            // 
            // lblMoney
            // 
            this.lblMoney.DataMember = "RBROW_AMOUNT";
            this.lblMoney.DisplayFormat = "гд{0}";
            this.lblMoney.DisplayMember = "RBROW_AMOUNT";
            this.lblMoney.ForeColor = System.Drawing.Color.Orange;
            this.lblMoney.Location = new System.Drawing.Point(55, 0);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Padding = new Smobiler.Core.Controls.Padding(0F, 10F, 0F, 0F);
            this.lblMoney.Size = new System.Drawing.Size(95, 30);
            this.lblMoney.VerticalAlignment = Smobiler.Core.Controls.VerticalAlignment.Top;
            // 
            // lbldate
            // 
            this.lbldate.DataMember = "RBROW_DATE";
            this.lbldate.DisplayMember = "RBROW_DATE";
            this.lbldate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lbldate.Location = new System.Drawing.Point(55, 30);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(95, 30);
            this.lbldate.ZIndex = 4;
            // 
            // lblnote
            // 
            this.lblnote.DisplayMember = "RBROW_NOTE";
            this.lblnote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.lblnote.Location = new System.Drawing.Point(150, 0);
            this.lblnote.Name = "lblnote";
            this.lblnote.Padding = new Smobiler.Core.Controls.Padding(2F, 10F, 10F, 0F);
            this.lblnote.Size = new System.Drawing.Size(150, 60);
            this.lblnote.VerticalAlignment = Smobiler.Core.Controls.VerticalAlignment.Top;
            // 
            // frmRBRowLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imgType,
            this.lblMoney,
            this.lbldate,
            this.lblnote});
            this.Size = new System.Drawing.Size(0, 60);
            this.Name = "frmRBRowLayout";

        }
        #endregion

        internal Smobiler.Core.Controls.Image imgType;
        internal Smobiler.Core.Controls.Label lblMoney;
        internal Smobiler.Core.Controls.Label lbldate;
        internal Smobiler.Core.Controls.Label lblnote;
    }
}