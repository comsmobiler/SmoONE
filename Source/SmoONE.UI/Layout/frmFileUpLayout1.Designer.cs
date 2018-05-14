using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class frmFileUpLayout1 : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        public frmFileUpLayout1()
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
            this.tpFile = new Smobiler.Core.Controls.Panel();
            this.imgPortrait = new Smobiler.Core.Controls.Image();
            this.lblFile = new Smobiler.Core.Controls.Label();
            this.btnUp = new Smobiler.Core.Controls.Button();
            this.btnDel = new Smobiler.Core.Controls.Button();
            // 
            // tpFile
            // 
            this.tpFile.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imgPortrait,
            this.lblFile});
            this.tpFile.Name = "tpFile";
            this.tpFile.Size = new System.Drawing.Size(250, 60);
            this.tpFile.Touchable = true;
            this.tpFile.Press += new System.EventHandler(this.tpFileOpen_Press);
            // 
            // imgPortrait
            // 
            this.imgPortrait.DataMember = "FImg";
            this.imgPortrait.DisplayMember = "FImg";
            this.imgPortrait.Location = new System.Drawing.Point(4, 14);
            this.imgPortrait.Name = "imgPortrait";
            this.imgPortrait.Size = new System.Drawing.Size(32, 32);
            // 
            // lblFile
            // 
            this.lblFile.DisplayMember = "FileName";
            this.lblFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblFile.Location = new System.Drawing.Point(43, 0);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(206, 60);
            // 
            // btnUp
            // 
            this.btnUp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(158)))), ((int)(((byte)(38)))));
            this.btnUp.BorderRadius = 4;
            this.btnUp.Location = new System.Drawing.Point(256, 2);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(40, 25);
            this.btnUp.Text = "ÉÏ´«";
            this.btnUp.Press += new System.EventHandler(this.btnUp_Press);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Red;
            this.btnDel.BorderColor = System.Drawing.Color.Red;
            this.btnDel.BorderRadius = 4;
            this.btnDel.Location = new System.Drawing.Point(256, 33);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(40, 25);
            this.btnDel.Text = "É¾³ý";
            this.btnDel.Press += new System.EventHandler(this.btnDel_Press);
            // 
            // frmFileUpLayout1
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.tpFile,
            this.btnUp,
            this.btnDel});
            this.Size = new System.Drawing.Size(300, 60);
            this.Name = "frmFileUpLayout1";

        }
        #endregion

        private Smobiler.Core.Controls.Panel tpFile;
        private Smobiler.Core.Controls.Image imgPortrait;
        private Smobiler.Core.Controls.Label lblFile;
        private Smobiler.Core.Controls.Button btnUp;
        private Smobiler.Core.Controls.Button btnDel;
    }
}