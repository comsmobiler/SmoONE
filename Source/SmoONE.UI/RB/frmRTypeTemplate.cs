using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;
using SmoONE.UI;
using SmoONE.DTOs;

namespace SmoONE.UI.RB
{
    // ******************************************************************
    // 文件版本： SmoONE 2.0
    // Copyright  (c)  2017-2018 Smobiler 
    // 创建时间： 2017/07
    // 主要内容：  消费模板列表界面
    // ******************************************************************
    partial class frmRTypeTemplate : Smobiler.Core.Controls.MobileForm
    {
        #region "Properties"
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        /// <summary>
        /// 创建消费模板
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Press(object sender, EventArgs e)
        {
            try
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
            catch(Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 初始化页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRTypeTemplate_Load(object sender, EventArgs e)
        {
            Bind();      //加载数据
        }
        /// <summary>
        /// 删除行项
        /// </summary>
        /// <param name="row"></param>
        internal void RemoveRow(ListViewRow row)
        {
            this.listRBModelData.Rows.Remove(row);
        }
        ///// <summary>
        ///// 关闭行项侧滑
        ///// </summary>
        //public void CloseRowSwipe()
        //{
        //    foreach (ListViewRow Row in listRBModelData.Rows)
        //    {
        //        Layout.frmRBModelLayout RBModeLayout = Row.Control as Layout.frmRBModelLayout;
        //        RBModeLayout.CloseSwipe();
        //    }
        //}
        /// <summary>
        /// 初始化方法
        /// </summary>
        /// <remarks></remarks>
        internal void Bind()
        {
            try
            {
                List<RB_RType_TemplateDto> RBRTypeTemplate = AutofacConfig.rBService.GetTemplateByCreateUser(Client.Session["U_ID"].ToString());    //根据当前用户ID查询消费模板
                DataTable table = new DataTable();
                table.Columns.Add("RB_RTT_TemplateID");         //消费模板编号
                table.Columns.Add("RB_RTT_TypeID");             //消费类型编号
                table.Columns.Add("RB_RTT_TypeName");           //消费类型名称
                table.Columns.Add("RB_RTT_Amount");             //消费金额
                table.Columns.Add("RB_RTT_Note");               //消费备注  
                foreach (RB_RType_TemplateDto row in RBRTypeTemplate)
                {
                    String TypeName = AutofacConfig.rBService.GetTypeNameByID(row.RB_RTT_TypeID);
                    table.Rows.Add(row.RB_RTT_TemplateID, row.RB_RTT_TypeID, TypeName, row.RB_RTT_Amount, row.RB_RTT_Note);
                }
                this.listRBModelData.Rows.Clear(); //清空消费模板列表数据
                if (table.Rows.Count > 0)              //当行项中有数据时
                {
                    this.lblInfor.Visible = false;            //隐藏提示文字
                    //赋值数据
                    this.listRBModelData.DataSource = table;
                    this.listRBModelData.DataBind();
                }
                else
                {
                    this.lblInfor.Visible = true;

                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 手机自带返回键操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRTypeTemplate_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                this.Close();         //关闭当前页面
            }
        }
    }
}