using System;
using Smobiler.Core;
namespace SmoONE.UI.CostCenter
{
    partial class frmCostCenterFXDetail : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmCostCenterFXDetail()
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
            Smobiler.Core.Controls.TableViewLabelColumn tableViewLabelColumn1 = new Smobiler.Core.Controls.TableViewLabelColumn();
            Smobiler.Core.Controls.TableViewLabelColumn tableViewLabelColumn2 = new Smobiler.Core.Controls.TableViewLabelColumn();
            Smobiler.Core.Controls.TableViewLabelColumn tableViewLabelColumn3 = new Smobiler.Core.Controls.TableViewLabelColumn();
            Smobiler.Core.Controls.TableViewLabelColumn tableViewLabelColumn4 = new Smobiler.Core.Controls.TableViewLabelColumn();
            Smobiler.Core.Controls.TableViewLabelColumn tableViewLabelColumn5 = new Smobiler.Core.Controls.TableViewLabelColumn();
            this.pieChart1 = new Smobiler.Core.Controls.PieChart();
            this.tableView1 = new Smobiler.Core.Controls.TableView();
            this.title1 = new SmoONE.UI.Layout.Title();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            // 
            // pieChart1
            // 
            this.pieChart1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(300, 200);
            this.pieChart1.XAxisValues = new string[0];
            this.pieChart1.XValueMember = "Type";
            this.pieChart1.YValueMember = "Amount";
            this.pieChart1.ValueSelected += new Smobiler.Core.Controls.PieChartValueSelectedEventHandler(this.pieChart1_ValueSelected);
            // 
            // tableView1
            // 
            this.tableView1.BackColor = System.Drawing.Color.White;
            tableViewLabelColumn1.DataMember = "RB_ID";
            tableViewLabelColumn1.DisplayMember = "RB_ID";
            tableViewLabelColumn1.FontSize = 11F;
            tableViewLabelColumn1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            tableViewLabelColumn1.HeaderText = "编号";
            tableViewLabelColumn1.Width = 120;
            tableViewLabelColumn2.DisplayMember = "R_ConsumeDate";
            tableViewLabelColumn2.FontSize = 11F;
            tableViewLabelColumn2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            tableViewLabelColumn2.HeaderText = "日期";
            tableViewLabelColumn2.Width = 70;
            tableViewLabelColumn3.DisplayMember = "R_TypeName";
            tableViewLabelColumn3.FontSize = 11F;
            tableViewLabelColumn3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            tableViewLabelColumn3.HeaderText = "类型";
            tableViewLabelColumn3.Width = 70;
            tableViewLabelColumn4.DisplayMember = "R_Amount";
            tableViewLabelColumn4.FontSize = 11F;
            tableViewLabelColumn4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            tableViewLabelColumn4.HeaderText = "金额";
            tableViewLabelColumn4.Width = 80;
            tableViewLabelColumn5.DisplayMember = "R_CreateUser";
            tableViewLabelColumn5.FontSize = 11F;
            tableViewLabelColumn5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            tableViewLabelColumn5.HeaderText = "用户";
            tableViewLabelColumn5.Width = 70;
            this.tableView1.Columns.AddRange(new Smobiler.Core.Controls.TableViewColumn[] {
            tableViewLabelColumn1,
            tableViewLabelColumn2,
            tableViewLabelColumn3,
            tableViewLabelColumn4,
            tableViewLabelColumn5});
            this.tableView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableView1.Location = new System.Drawing.Point(0, 200);
            this.tableView1.Name = "tableView1";
            this.tableView1.Size = new System.Drawing.Size(300, 250);
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.title1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title1.Location = new System.Drawing.Point(111, 36);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 50);
            this.title1.TitleText = "成本中心分析";
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.pieChart1,
            this.tableView1});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 119);
            this.panel1.Name = "panel1";
            this.panel1.Scrollable = true;
            this.panel1.Size = new System.Drawing.Size(300, 100);
            // 
            // frmCostCenterFXDetail
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel1});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmCostCenterFXDetail_KeyDown);
            this.Load += new System.EventHandler(this.frmCostCenterFXDetail_Load);
            this.Name = "frmCostCenterFXDetail";

        }
        #endregion

        private Layout.Title title1;
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.PieChart pieChart1;
        private Smobiler.Core.Controls.TableView tableView1;
    }
}