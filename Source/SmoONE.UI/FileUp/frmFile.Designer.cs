using System;
using Smobiler.Core;
namespace SmoONE.UI.FileUp
{
    partial class frmFile : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmFile()
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
            this.title1 = new SmoONE.UI.Layout.Title();
            this.btnFile = new Smobiler.Core.Controls.Button();
            this.listView1 = new Smobiler.Core.Controls.ListView();
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.title1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 50);
            this.title1.TitleText = "服务端文件下载";
            // 
            // btnFile
            // 
            this.btnFile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnFile.Location = new System.Drawing.Point(93, 60);
            this.btnFile.Margin = new Smobiler.Core.Controls.Margin(10F, 10F, 10F, 0F);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(100, 30);
            this.btnFile.Text = "手机文件下载清单";
            this.btnFile.Press += new System.EventHandler(this.btnFile_Press);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 95);
            this.listView1.Name = "listView1";
            this.listView1.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listView1.PageSizeTextSize = 11F;
            this.listView1.ShowSplitLine = true;
            this.listView1.Size = new System.Drawing.Size(300, 300);
            this.listView1.SplitLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.listView1.TemplateControlName = "frmFileUpLayout";
            // 
            // frmFile
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.btnFile,
            this.listView1});
            this.Load += new System.EventHandler(this.frmFile_Load);
            this.Name = "frmFile";

        }
        #endregion

        private Layout.Title title1;
        private Smobiler.Core.Controls.Button btnFile;
        private Smobiler.Core.Controls.ListView listView1;
    }
}