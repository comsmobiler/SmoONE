using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class frmConsumption1Layout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        public frmConsumption1Layout()
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
            this.plContent = new Smobiler.Core.Controls.Panel();
            this.Check = new Smobiler.Core.Controls.CheckBox();
            this.imgType = new Smobiler.Core.Controls.Image();
            this.lblMoney = new Smobiler.Core.Controls.Label();
            this.lbldate = new Smobiler.Core.Controls.Label();
            this.lblnote = new Smobiler.Core.Controls.Label();
            // 
            // plContent
            // 
            this.plContent.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Check,
            this.imgType,
            this.lblMoney,
            this.lbldate,
            this.lblnote});
            this.plContent.Name = "plContent";
            this.plContent.Size = new System.Drawing.Size(300, 60);
            this.plContent.Touchable = true;
            this.plContent.Press += new System.EventHandler(this.plContent_Press);
            // 
            // Check
            // 
            this.Check.DataMember = "RBCHECKED";
            this.Check.DisplayMember = "RBCHECKED";
            this.Check.Location = new System.Drawing.Point(10, 22);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(15, 15);
            this.Check.ZIndex = 1;
            this.Check.CheckedChanged += new System.EventHandler(this.Check_CheckedChanged);
            // 
            // imgType
            // 
            this.imgType.BorderRadius = 15;
            this.imgType.DataMember = "ID";
            this.imgType.DisplayMember = "RBROW_TYPE";
            this.imgType.Location = new System.Drawing.Point(25, 7);
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
            this.lblMoney.Location = new System.Drawing.Point(75, 0);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Padding = new Smobiler.Core.Controls.Padding(0F, 10F, 0F, 0F);
            this.lblMoney.Size = new System.Drawing.Size(75, 30);
            this.lblMoney.VerticalAlignment = Smobiler.Core.Controls.VerticalAlignment.Top;
            this.lblMoney.ZIndex = 3;
            // 
            // lbldate
            // 
            this.lbldate.DataMember = "RBROW_DATE";
            this.lbldate.DisplayMember = "RBROW_DATE";
            this.lbldate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lbldate.Location = new System.Drawing.Point(75, 30);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(75, 30);
            this.lbldate.ZIndex = 4;
            // 
            // lblnote
            // 
            this.lblnote.DataMember = "ID";
            this.lblnote.DisplayMember = "RBROW_NOTE";
            this.lblnote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.lblnote.Location = new System.Drawing.Point(150, 0);
            this.lblnote.Name = "lblnote";
            this.lblnote.Padding = new Smobiler.Core.Controls.Padding(2F, 10F, 10F, 0F);
            this.lblnote.Size = new System.Drawing.Size(150, 60);
            this.lblnote.VerticalAlignment = Smobiler.Core.Controls.VerticalAlignment.Top;
            this.lblnote.ZIndex = 5;
            // 
            // frmConsumption1Layout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plContent});
            this.Size = new System.Drawing.Size(0, 60);
            this.Name = "frmConsumption1Layout";

        }
        #endregion
        private Smobiler.Core.Controls.Panel plContent;
        internal Smobiler.Core.Controls.CheckBox Check;
        internal Smobiler.Core.Controls.Image imgType;
        internal Smobiler.Core.Controls.Label lblMoney;
        internal Smobiler.Core.Controls.Label lbldate;
        internal Smobiler.Core.Controls.Label lblnote;
    }
}