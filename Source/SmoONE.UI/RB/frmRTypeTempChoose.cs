using System;
using System.Collections.Generic;
using Smobiler.Core.Controls;
using System.Data;
using SmoONE.DTOs;

namespace SmoONE.UI.RB
{
    // ******************************************************************
    // 文件版本： SmoONE 2.0
    // Copyright  (c)  2017-2018 Smobiler 
    // 创建时间： 2017/07
    // 主要内容：  消费模板选择界面
    // ******************************************************************
    partial class frmRTypeTempChoose : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        internal string RTTemplaetID;           //模板编号
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        /// <summary>
        /// 手机自带返回操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRTypeTempChoose_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                this.Close();         //关闭当前页面
            }
        }
        /// <summary>
        /// 初始化页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRTypeTempChoose_Load(object sender, EventArgs e)
        {
            Bind();                   //加载消费模板数据
        }
        /// <summary>
        /// 初始化方法，加载数据
        /// </summary>
        private void Bind()
        {
            try
            {
                List<RB_RType_TemplateDto> RBRTypeTemplate = AutofacConfig.rBService.GetTemplateByCreateUser(Client.Session["U_ID"].ToString());    //Steven的用户ID
                DataTable table = new DataTable();
                table.Columns.Add("RB_RTT_TemplateID");
                table.Columns.Add("RB_RTT_TypeID");
                table.Columns.Add("RB_RTT_TypeName");
                table.Columns.Add("RB_RTT_Amount");
                table.Columns.Add("RB_RTT_Note");
                foreach (RB_RType_TemplateDto row in RBRTypeTemplate)
                {
                    String TypeName = AutofacConfig.rBService.GetTypeNameByID(row.RB_RTT_TypeID);
                    table.Rows.Add(row.RB_RTT_TemplateID, row.RB_RTT_TypeID, TypeName, row.RB_RTT_Amount, row.RB_RTT_Note);
                }
                listRBModel.Rows.Clear(); //清空消费模板选择列表数据
                if (table.Rows.Count > 0)
                {
                    this.lblInfor.Visible = false;
                    this.btnCreate.Visible = false;
                    this.listRBModel.DataSource = table;
                    this.listRBModel.DataBind();
                }

            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 点击创建按钮，跳转到创建模板界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Press(object sender, EventArgs e)
        {
            frmRTypeTempCreate frm = new frmRTypeTempCreate();         //进入模板创建页面
            this.Show(frm, (MobileForm from, object args) =>
            {
                if (frm.ShowResult == ShowResult.Yes)
                {
                    Bind();
                }
            });
        }

        private void title1_Load(object sender, EventArgs e)
        {

        }
    }
}