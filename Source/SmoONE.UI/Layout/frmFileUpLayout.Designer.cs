using System;
using Smobiler.Core;
namespace SmoONE.UI.Layout
{
    partial class frmFileUpLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerForm generated code "

        public frmFileUpLayout()
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
            this.tpFile = new Smobiler.Core.Controls.Panel();
            this.imgPortrait = new Smobiler.Core.Controls.Image();
            this.lblFile = new Smobiler.Core.Controls.Label();
            this.btnDownload = new Smobiler.Core.Controls.Button();
            // 
            // tpFile
            // 
            this.tpFile.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imgPortrait,
            this.lblFile,
            this.btnDownload});
            this.tpFile.Name = "tpFile";
            this.tpFile.Size = new System.Drawing.Size(300, 60);
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
            this.lblFile.Size = new System.Drawing.Size(209, 60);
            // 
            // btnDownload
            // 
            this.btnDownload.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.btnDownload.BorderRadius = 4;
            this.btnDownload.Location = new System.Drawing.Point(256, 20);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(40, 20);
            this.btnDownload.Text = "обть";
            this.btnDownload.Press += new System.EventHandler(this.btnDownload_Press);
            // 
            // frmFileUpLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.tpFile});
            this.Size = new System.Drawing.Size(300, 60);
            this.Name = "frmFileUpLayout";

        }
        #endregion

        private Smobiler.Core.Controls.Panel tpFile;
        private Smobiler.Core.Controls.Image imgPortrait;
        private Smobiler.Core.Controls.Label lblFile;
        private Smobiler.Core.Controls.Button btnDownload;
    }
}