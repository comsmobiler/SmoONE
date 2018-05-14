using System;
using Smobiler.Core;
namespace SmoONE.UI.Im
{
    partial class frmAddConcentOrGroup : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmAddConcentOrGroup()
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
            this.pGName = new Smobiler.Core.Controls.Panel();
            this.Label4 = new Smobiler.Core.Controls.Label();
            this.txtName = new Smobiler.Core.Controls.TextBox();
            this.pPost = new Smobiler.Core.Controls.Panel();
            this.btnSave = new Smobiler.Core.Controls.Button();
            this.listView1 = new Smobiler.Core.Controls.ListView();
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.title1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 50);
            // 
            // pGName
            // 
            this.pGName.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label4,
            this.txtName});
            this.pGName.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.pGName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pGName.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.pGName.Location = new System.Drawing.Point(0, 60);
            this.pGName.Margin = new Smobiler.Core.Controls.Margin(0F, 10F, 0F, 0F);
            this.pGName.Name = "pGName";
            this.pGName.Size = new System.Drawing.Size(300, 35);
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.White;
            this.Label4.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.Label4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label4.Name = "Label4";
            this.Label4.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.Label4.Size = new System.Drawing.Size(66, 0);
            this.Label4.Text = "群组名称";
            this.Label4.ZIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.txtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtName.Flex = 1;
            this.txtName.FontSize = 12F;
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtName.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.txtName.ReturnKeyType = Smobiler.Core.Controls.ReturnKeyType.Done;
            this.txtName.Size = new System.Drawing.Size(0, 0);
            this.txtName.WaterMarkText = "（必填）";
            this.txtName.ZIndex = 2;
            // 
            // pPost
            // 
            this.pPost.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnSave});
            this.pPost.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pPost.Location = new System.Drawing.Point(0, 461);
            this.pPost.Name = "pPost";
            this.pPost.Size = new System.Drawing.Size(100, 50);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnSave.BorderRadius = 4;
            this.btnSave.FontSize = 17F;
            this.btnSave.Location = new System.Drawing.Point(10, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(280, 35);
            this.btnSave.Text = "提交";
            this.btnSave.Press += new System.EventHandler(this.btnSave_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 95);
            this.listView1.Margin = new Smobiler.Core.Controls.Margin(0F, 10F, 0F, 0F);
            this.listView1.Name = "listView1";
            this.listView1.PageSize = 8;
            this.listView1.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listView1.PageSizeTextSize = 11F;
            this.listView1.Size = new System.Drawing.Size(300, 0);
            // 
            // frmAddConcentOrGroup
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.pGName,
            this.pPost,
            this.listView1});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.Load += new System.EventHandler(this.frmAddConcentOrGroup_Load);
            this.Name = "frmAddConcentOrGroup";

        }
        #endregion

        private Layout.Title title1;
        private Smobiler.Core.Controls.Panel pGName;
        internal Smobiler.Core.Controls.Label Label4;
        internal Smobiler.Core.Controls.TextBox txtName;
      
        private Smobiler.Core.Controls.Panel pPost;
        private Smobiler.Core.Controls.ListView listView1;
        private Smobiler.Core.Controls.Button btnSave;
    }
}