using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class frmConsumptionLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerTouchUserControl generated code "

        public frmConsumptionLayout()
            : base()
        {
            //This call is required by the SmobilerTouchUserControl.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call
        }

        //SmobilerTouchUserControl overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerTouchUserControl
        //It can be modified using the SmobilerTouchUserControl.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.swipeView1 = new Smobiler.Core.Controls.SwipeView();
            this.plContent = new Smobiler.Core.Controls.Panel();
            this.imgType = new Smobiler.Core.Controls.Image();
            this.lblMoney = new Smobiler.Core.Controls.Label();
            this.lbldate = new Smobiler.Core.Controls.Label();
            this.lblnote = new Smobiler.Core.Controls.Label();
            // 
            // swipeView1
            // 
            this.swipeView1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plContent});
            this.swipeView1.Name = "swipeView1";
            this.swipeView1.RightControlName = "SwipeDeleteControl";
            this.swipeView1.Size = new System.Drawing.Size(300, 60);
            // 
            // plContent
            // 
            this.plContent.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imgType,
            this.lblMoney,
            this.lbldate,
            this.lblnote});
            this.plContent.Name = "plContent";
            this.plContent.Size = new System.Drawing.Size(300, 60);
            this.plContent.Touchable = true;
            this.plContent.Press += new System.EventHandler(this.plContent_Press);
            // 
            // imgType
            // 
            this.imgType.DataMember = "RBROW_TYPENAME";
            this.imgType.DisplayMember = "RBROW_TYPE";
            this.imgType.Location = new System.Drawing.Point(5, 7);
            this.imgType.Name = "imgType";
            this.imgType.Size = new System.Drawing.Size(45, 45);
            // 
            // lblMoney
            // 
            this.lblMoney.DataMember = "ID";
            this.lblMoney.DisplayFormat = "гд{0:N}";
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
            this.lbldate.DisplayFormat = "{0:d}";
            this.lbldate.DisplayMember = "RBROW_DATE";
            this.lbldate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lbldate.Location = new System.Drawing.Point(55, 30);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(95, 30);
            // 
            // lblnote
            // 
            this.lblnote.DataMember = "RBROW_NOTE";
            this.lblnote.DisplayMember = "RBROW_NOTE";
            this.lblnote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.lblnote.Location = new System.Drawing.Point(150, 0);
            this.lblnote.Name = "lblnote";
            this.lblnote.Padding = new Smobiler.Core.Controls.Padding(2F, 10F, 10F, 0F);
            this.lblnote.Size = new System.Drawing.Size(150, 60);
            this.lblnote.VerticalAlignment = Smobiler.Core.Controls.VerticalAlignment.Top;
            // 
            // frmConsumptionLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.swipeView1});
            this.Size = new System.Drawing.Size(0, 60);
            this.Name = "frmConsumptionLayout";

        }
        #endregion
        private Smobiler.Core.Controls.Panel plContent;
        private Smobiler.Core.Controls.Image imgType;
        internal Smobiler.Core.Controls.Label lblMoney;
        internal Smobiler.Core.Controls.Label lbldate;
        internal Smobiler.Core.Controls.Label lblnote;
        public Smobiler.Core.Controls.SwipeView swipeView1;
    }
}