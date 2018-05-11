using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class frmLeaveLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        public frmLeaveLayout()
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
            this.tpLeave = new Smobiler.Core.Controls.Panel();
            this.imgPortrait = new Smobiler.Core.Controls.Image();
            this.lblId = new Smobiler.Core.Controls.Label();
            this.lblType = new Smobiler.Core.Controls.Label();
            this.lblDate = new Smobiler.Core.Controls.Label();
            // 
            // tpLeave
            // 
            this.tpLeave.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imgPortrait,
            this.lblId,
            this.lblType,
            this.lblDate});
            this.tpLeave.Name = "tpLeave";
            this.tpLeave.Size = new System.Drawing.Size(300, 60);
            this.tpLeave.Touchable = true;
            this.tpLeave.Press += new System.EventHandler(this.tpLeave_Press);
            // 
            // imgPortrait
            // 
            this.imgPortrait.BorderRadius = 18;
            this.imgPortrait.DataMember = "U_Portrait";
            this.imgPortrait.DisplayMember = "U_Portrait";
            this.imgPortrait.Location = new System.Drawing.Point(10, 12);
            this.imgPortrait.Name = "imgPortrait";
            this.imgPortrait.Size = new System.Drawing.Size(35, 35);
            this.imgPortrait.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Cover;
            // 
            // lblId
            // 
            this.lblId.DataMember = "ID";
            this.lblId.DisplayMember = "Name";
            this.lblId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblId.Location = new System.Drawing.Point(54, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(246, 30);
            this.lblId.ZIndex = 2;
            // 
            // lblType
            // 
            this.lblType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblType.DataMember = "Type";
            this.lblType.DisplayMember = "L_StatusDesc";
            this.lblType.ForeColor = System.Drawing.Color.Orange;
            this.lblType.Location = new System.Drawing.Point(54, 30);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(133, 30);
            this.lblType.Text = "µ»¥˝Œ“…Û≈˙";
            this.lblType.ZIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblDate.DataMember = "CreateDate";
            this.lblDate.DisplayMember = "CreateDate";
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lblDate.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblDate.Location = new System.Drawing.Point(190, 30);
            this.lblDate.Name = "lblDate";
            this.lblDate.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.lblDate.Size = new System.Drawing.Size(113, 30);
            this.lblDate.ZIndex = 4;
            // 
            // frmLeaveLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.tpLeave});
            this.Size = new System.Drawing.Size(0, 60);
            this.Name = "frmLeaveLayout";

        }
        #endregion

        private Smobiler.Core.Controls.Panel tpLeave;
        private Smobiler.Core.Controls.Image imgPortrait;
        private Smobiler.Core.Controls.Label lblId;
        internal Smobiler.Core.Controls.Label lblType;
        internal Smobiler.Core.Controls.Label lblDate;
    }
}