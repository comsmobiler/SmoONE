using System;
using Smobiler.Core;
using SmoONE.UI.Layout;

namespace SmoONE.UI.UserInfo
{
    partial class frmCheckOrCCTo : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmCheckOrCCTo()
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
            this.textBox1 = new Smobiler.Core.Controls.TextBox();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.listUserData = new Smobiler.Core.Controls.ListView();
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.title1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title1.Location = new System.Drawing.Point(74, 53);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 50);
            this.title1.TitleText = "联系人";
            // 
            // textBox1
            // 
            this.textBox1.BorderRadius = 2;
            this.textBox1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.textBox1.Location = new System.Drawing.Point(13, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 25);
            this.textBox1.WaterMarkText = "搜索";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 90);
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label1.Size = new System.Drawing.Size(300, 25);
            this.label1.Text = "联系人";
            // 
            // listUserData
            // 
            this.listUserData.BackColor = System.Drawing.Color.White;
            this.listUserData.FooterControlName = null;
            this.listUserData.HeaderControlName = null;
            this.listUserData.Location = new System.Drawing.Point(0, 115);
            this.listUserData.Name = "listUserData";
            this.listUserData.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listUserData.PageSizeTextSize = 11F;
            this.listUserData.Size = new System.Drawing.Size(300, 385);
            this.listUserData.TemplateControlName = "frmUserLayout";
            // 
            // frmCheckOrCCTo
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.textBox1,
            this.label1,
            this.listUserData});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmCheckOrCCTo_KeyDown);
            this.Load += new System.EventHandler(this.frmCheckOrCCTo_Load);
            this.Name = "frmCheckOrCCTo";

        }
        #endregion

        private Title title1;
        private Smobiler.Core.Controls.TextBox textBox1;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.ListView listUserData;
    }
}