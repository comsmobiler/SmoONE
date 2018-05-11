using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class frmAttendanceManagerLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerForm generated code "

        public frmAttendanceManagerLayout()
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
            this.lblId = new Smobiler.Core.Controls.Label();
            this.lblAT = new Smobiler.Core.Controls.Label();
            this.lblATWorking = new Smobiler.Core.Controls.Label();
            this.lblWorkDate = new Smobiler.Core.Controls.Label();
            this.lblWorkDate1 = new Smobiler.Core.Controls.Label();
            this.lblATEffective = new Smobiler.Core.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblId,
            this.lblAT,
            this.lblATWorking,
            this.lblWorkDate,
            this.lblWorkDate1,
            this.lblATEffective});
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 140);
            this.panel1.Touchable = true;
            this.panel1.Press += new System.EventHandler(this.panel1_Press);
            // 
            // lblId
            // 
            this.lblId.BackColor = System.Drawing.Color.White;
            this.lblId.DataMember = "AT_ID";
            this.lblId.DisplayMember = "AT_Name";
            this.lblId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblId.Location = new System.Drawing.Point(0, 9);
            this.lblId.Name = "lblId";
            this.lblId.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.lblId.Size = new System.Drawing.Size(257, 40);
            this.lblId.ZIndex = 1;
            // 
            // lblAT
            // 
            this.lblAT.BackColor = System.Drawing.Color.White;
            this.lblAT.FontSize = 20F;
            this.lblAT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblAT.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblAT.Location = new System.Drawing.Point(257, 9);
            this.lblAT.Name = "lblAT";
            this.lblAT.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.lblAT.Size = new System.Drawing.Size(43, 40);
            this.lblAT.Text = ">";
            this.lblAT.ZIndex = 1;
            // 
            // lblATWorking
            // 
            this.lblATWorking.BackColor = System.Drawing.Color.White;
            this.lblATWorking.DataMember = "AT_CommutingType";
            this.lblATWorking.DisplayMember = "AT_WeeklyWorkingDay";
            this.lblATWorking.FontSize = 12F;
            this.lblATWorking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblATWorking.Location = new System.Drawing.Point(0, 49);
            this.lblATWorking.Name = "lblATWorking";
            this.lblATWorking.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 10F, 0F);
            this.lblATWorking.Size = new System.Drawing.Size(300, 20);
            this.lblATWorking.ZIndex = 3;
            // 
            // lblWorkDate
            // 
            this.lblWorkDate.BackColor = System.Drawing.Color.White;
            this.lblWorkDate.DataMember = "WorkDate";
            this.lblWorkDate.DisplayMember = "WorkDate";
            this.lblWorkDate.FontSize = 12F;
            this.lblWorkDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lblWorkDate.Location = new System.Drawing.Point(0, 69);
            this.lblWorkDate.Name = "lblWorkDate";
            this.lblWorkDate.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 10F, 0F);
            this.lblWorkDate.Size = new System.Drawing.Size(300, 20);
            this.lblWorkDate.ZIndex = 3;
            // 
            // lblWorkDate1
            // 
            this.lblWorkDate1.BackColor = System.Drawing.Color.White;
            this.lblWorkDate1.DataMember = "WorkDate1";
            this.lblWorkDate1.DisplayMember = "WorkDate1";
            this.lblWorkDate1.FontSize = 12F;
            this.lblWorkDate1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lblWorkDate1.Location = new System.Drawing.Point(0, 89);
            this.lblWorkDate1.Name = "lblWorkDate1";
            this.lblWorkDate1.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 10F, 0F);
            this.lblWorkDate1.Size = new System.Drawing.Size(300, 20);
            this.lblWorkDate1.ZIndex = 3;
            // 
            // lblATEffective
            // 
            this.lblATEffective.BackColor = System.Drawing.Color.White;
            this.lblATEffective.BorderColor = System.Drawing.Color.LightGray;
            this.lblATEffective.DataMember = "AT_EffectiveDate";
            this.lblATEffective.DisplayMember = "AT_EffectiveDesc";
            this.lblATEffective.ForeColor = System.Drawing.Color.Orange;
            this.lblATEffective.Location = new System.Drawing.Point(0, 109);
            this.lblATEffective.Name = "lblATEffective";
            this.lblATEffective.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 10F, 0F);
            this.lblATEffective.Size = new System.Drawing.Size(300, 30);
            this.lblATEffective.ZIndex = 1;
            // 
            // frmAttendanceManagerLayout
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(300, 140);
            this.Name = "frmAttendanceManagerLayout";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        internal Smobiler.Core.Controls.Label lblId;
        internal Smobiler.Core.Controls.Label lblAT;
        internal Smobiler.Core.Controls.Label lblATWorking;
        internal Smobiler.Core.Controls.Label lblWorkDate;
        internal Smobiler.Core.Controls.Label lblWorkDate1;
        internal Smobiler.Core.Controls.Label lblATEffective;
    }
}