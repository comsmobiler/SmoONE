using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
partial class frmMain : System.Windows.Forms.Form
{

    //Form 重写 Dispose，以清理组件列表。
    [System.Diagnostics.DebuggerNonUserCode()]
    protected override void Dispose(bool disposing)
    {
        try
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            if (disposing && server != null)
            {
                server.StopServer();
            }
        }
        finally
        {
            base.Dispose(disposing);
        }
    }

    //Windows 窗体设计器所必需的

    private System.ComponentModel.IContainer components;
    //注意:  以下过程是 Windows 窗体设计器所必需的
    //可以使用 Windows 窗体设计器修改它。  
    //不要使用代码编辑器修改它。
    [System.Diagnostics.DebuggerStepThrough()]
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
        this.labNets = new System.Windows.Forms.Label();
        this.combNets = new System.Windows.Forms.ComboBox();
        this.txtNetAddress = new System.Windows.Forms.TextBox();
        this.Label1 = new System.Windows.Forms.Label();
        this.txtInfo = new System.Windows.Forms.TextBox();
        this.labTCPPort = new System.Windows.Forms.Label();
        this.labHTTPPort = new System.Windows.Forms.Label();
        this.txtTcpPort = new System.Windows.Forms.TextBox();
        this.txtHTTPPort = new System.Windows.Forms.TextBox();
        this.btnSetting = new System.Windows.Forms.Button();
        this.qrcodeControl = new Smobiler.Utility.Encoding.Windows.Forms.QrCodeImgControl();
        ((System.ComponentModel.ISupportInitialize)(this.qrcodeControl)).BeginInit();
        this.SuspendLayout();
        // 
        // labNets
        // 
        this.labNets.AutoSize = true;
        this.labNets.Location = new System.Drawing.Point(19, 14);
        this.labNets.Name = "labNets";
        this.labNets.Size = new System.Drawing.Size(53, 12);
        this.labNets.TabIndex = 2;
        this.labNets.Text = "选择网卡";
        // 
        // combNets
        // 
        this.combNets.BackColor = System.Drawing.Color.White;
        this.combNets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.combNets.FormattingEnabled = true;
        this.combNets.Location = new System.Drawing.Point(90, 11);
        this.combNets.Name = "combNets";
        this.combNets.Size = new System.Drawing.Size(237, 20);
        this.combNets.TabIndex = 3;
        this.combNets.SelectedIndexChanged += new System.EventHandler(this.combNets_SelectedIndexChanged);
        // 
        // txtNetAddress
        // 
        this.txtNetAddress.BackColor = System.Drawing.Color.White;
        this.txtNetAddress.Location = new System.Drawing.Point(90, 37);
        this.txtNetAddress.Name = "txtNetAddress";
        this.txtNetAddress.ReadOnly = true;
        this.txtNetAddress.Size = new System.Drawing.Size(237, 21);
        this.txtNetAddress.TabIndex = 4;
        // 
        // Label1
        // 
        this.Label1.AutoSize = true;
        this.Label1.Location = new System.Drawing.Point(19, 40);
        this.Label1.Name = "Label1";
        this.Label1.Size = new System.Drawing.Size(65, 12);
        this.Label1.TabIndex = 2;
        this.Label1.Text = "服务器地址";
        // 
        // txtInfo
        // 
        this.txtInfo.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
        this.txtInfo.Location = new System.Drawing.Point(354, 10);
        this.txtInfo.Multiline = true;
        this.txtInfo.Name = "txtInfo";
        this.txtInfo.ReadOnly = true;
        this.txtInfo.Size = new System.Drawing.Size(389, 396);
        this.txtInfo.TabIndex = 5;
        this.txtInfo.Text = resources.GetString("txtInfo.Text");
        // 
        // labTCPPort
        // 
        this.labTCPPort.AutoSize = true;
        this.labTCPPort.Location = new System.Drawing.Point(19, 68);
        this.labTCPPort.Name = "labTCPPort";
        this.labTCPPort.Size = new System.Drawing.Size(47, 12);
        this.labTCPPort.TabIndex = 2;
        this.labTCPPort.Text = "TCP端口";
        // 
        // labHTTPPort
        // 
        this.labHTTPPort.AutoSize = true;
        this.labHTTPPort.Location = new System.Drawing.Point(192, 68);
        this.labHTTPPort.Name = "labHTTPPort";
        this.labHTTPPort.Size = new System.Drawing.Size(53, 12);
        this.labHTTPPort.TabIndex = 2;
        this.labHTTPPort.Text = "HTTP端口";
        // 
        // txtTcpPort
        // 
        this.txtTcpPort.BackColor = System.Drawing.Color.White;
        this.txtTcpPort.Location = new System.Drawing.Point(90, 64);
        this.txtTcpPort.Name = "txtTcpPort";
        this.txtTcpPort.ReadOnly = true;
        this.txtTcpPort.Size = new System.Drawing.Size(76, 21);
        this.txtTcpPort.TabIndex = 4;
        // 
        // txtHTTPPort
        // 
        this.txtHTTPPort.BackColor = System.Drawing.Color.White;
        this.txtHTTPPort.Location = new System.Drawing.Point(251, 64);
        this.txtHTTPPort.Name = "txtHTTPPort";
        this.txtHTTPPort.ReadOnly = true;
        this.txtHTTPPort.Size = new System.Drawing.Size(76, 21);
        this.txtHTTPPort.TabIndex = 4;
        // 
        // btnSetting
        // 
        this.btnSetting.Location = new System.Drawing.Point(21, 91);
        this.btnSetting.Name = "btnSetting";
        this.btnSetting.Size = new System.Drawing.Size(306, 23);
        this.btnSetting.TabIndex = 6;
        this.btnSetting.Text = "更多设置";
        this.btnSetting.UseVisualStyleBackColor = true;
        this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
        // 
        // qrcodeControl
        // 
        this.qrcodeControl.ErrorCorrectLevel = Smobiler.Utility.Encoding.ErrorCorrectionLevel.M;
        this.qrcodeControl.Image = ((System.Drawing.Image)(resources.GetObject("qrcodeControl.Image")));
        this.qrcodeControl.Location = new System.Drawing.Point(21, 130);
        this.qrcodeControl.Name = "qrcodeControl";
        this.qrcodeControl.QuietZoneModule = Smobiler.Utility.Encoding.Windows.Render.QuietZoneModules.Two;
        this.qrcodeControl.Size = new System.Drawing.Size(306, 276);
        this.qrcodeControl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        this.qrcodeControl.TabIndex = 7;
        this.qrcodeControl.TabStop = false;
        this.qrcodeControl.Text = "smobiler";
        // 
        // frmMain
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.White;
        this.ClientSize = new System.Drawing.Size(755, 418);
        this.Controls.Add(this.btnSetting);
        this.Controls.Add(this.txtInfo);
        this.Controls.Add(this.txtHTTPPort);
        this.Controls.Add(this.txtTcpPort);
        this.Controls.Add(this.txtNetAddress);
        this.Controls.Add(this.combNets);
        this.Controls.Add(this.labHTTPPort);
        this.Controls.Add(this.labTCPPort);
        this.Controls.Add(this.Label1);
        this.Controls.Add(this.labNets);
        this.Controls.Add(this.qrcodeControl);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.Name = "frmMain";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Smobiler Launcher";
        this.Load += new System.EventHandler(this.frmMain_Load);
        ((System.ComponentModel.ISupportInitialize)(this.qrcodeControl)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();

    }
    internal System.Windows.Forms.Label labNets;
    internal System.Windows.Forms.ComboBox combNets;
    internal System.Windows.Forms.TextBox txtNetAddress;
    internal System.Windows.Forms.Label Label1;

    internal System.Windows.Forms.TextBox txtInfo;
    public frmMain()
    {
        InitializeComponent();
    }

    internal System.Windows.Forms.Label labTCPPort;
    internal System.Windows.Forms.Label labHTTPPort;
    internal System.Windows.Forms.TextBox txtTcpPort;
    internal System.Windows.Forms.TextBox txtHTTPPort;
    private System.Windows.Forms.Button btnSetting;
    internal Smobiler.Utility.Encoding.Windows.Forms.QrCodeImgControl qrcodeControl;
}