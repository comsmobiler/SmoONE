using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class frmRBModelLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerTouchUserControl generated code "

        public frmRBModelLayout()
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
            this.lblRT_Type = new Smobiler.Core.Controls.Label();
            this.lblRT_Money = new Smobiler.Core.Controls.Label();
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
            this.lblRT_Type,
            this.lblRT_Money,
            this.lblnote});
            this.plContent.Name = "plContent";
            this.plContent.Size = new System.Drawing.Size(300, 60);
            this.plContent.Touchable = true;
            this.plContent.Press += new System.EventHandler(this.plContent_Press);
            // 
            // imgType
            // 
            this.imgType.BorderRadius = 18;
            this.imgType.DisplayMember = "RB_RTT_TypeID";
            this.imgType.Location = new System.Drawing.Point(8, 12);
            this.imgType.Name = "imgType";
            this.imgType.Size = new System.Drawing.Size(35, 35);
            this.imgType.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Cover;
            // 
            // lblRT_Type
            // 
            this.lblRT_Type.DisplayMember = "RB_RTT_TypeName";
            this.lblRT_Type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblRT_Type.Location = new System.Drawing.Point(54, 0);
            this.lblRT_Type.Name = "lblRT_Type";
            this.lblRT_Type.Padding = new Smobiler.Core.Controls.Padding(0F, 10F, 0F, 0F);
            this.lblRT_Type.Size = new System.Drawing.Size(96, 30);
            this.lblRT_Type.VerticalAlignment = Smobiler.Core.Controls.VerticalAlignment.Top;
            // 
            // lblRT_Money
            // 
            this.lblRT_Money.DataMember = "RB_RTT_TemplateID";
            this.lblRT_Money.DisplayFormat = "гд{0}";
            this.lblRT_Money.DisplayMember = "RB_RTT_Amount";
            this.lblRT_Money.ForeColor = System.Drawing.Color.Orange;
            this.lblRT_Money.Location = new System.Drawing.Point(54, 30);
            this.lblRT_Money.Name = "lblRT_Money";
            this.lblRT_Money.Size = new System.Drawing.Size(96, 30);
            // 
            // lblnote
            // 
            this.lblnote.DisplayMember = "RB_RTT_Note";
            this.lblnote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.lblnote.Location = new System.Drawing.Point(150, 0);
            this.lblnote.Name = "lblnote";
            this.lblnote.Padding = new Smobiler.Core.Controls.Padding(2F, 10F, 10F, 0F);
            this.lblnote.Size = new System.Drawing.Size(150, 60);
            this.lblnote.VerticalAlignment = Smobiler.Core.Controls.VerticalAlignment.Top;
            // 
            // frmRBModelLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.swipeView1});
            this.Size = new System.Drawing.Size(300, 60);
            this.Name = "frmRBModelLayout";

        }
        #endregion
        private Smobiler.Core.Controls.SwipeView swipeView1;
        private Smobiler.Core.Controls.Panel plContent;
        internal Smobiler.Core.Controls.Image imgType;
        private Smobiler.Core.Controls.Label lblRT_Type;
        private Smobiler.Core.Controls.Label lblRT_Money;
        private Smobiler.Core.Controls.Label lblnote;
    }
}