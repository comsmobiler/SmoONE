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
    // 主要内容：  消费记录列表界面
    // ******************************************************************
    partial class frmRBRows : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        /// <summary>
        /// 初始化方法
        /// </summary>
        /// <remarks></remarks>
        public void Bind()
        {
            try
            {
                List<RB_RowsDto> RBRows = AutofacConfig.rBService.GetRowsByCreateUser(Client.Session["U_ID"].ToString());
                //消费记录测试数据
                DataTable table = new DataTable();
                table.Columns.Add("ID", typeof(System.Int32));               //消费记录编号
                table.Columns.Add("RB_NO", typeof(System.String));           //报销单编号
                table.Columns.Add("RBROW_DATE", typeof(System.String));      //消费日期
                table.Columns.Add("RBROW_TYPE", typeof(System.String));      //消费类型编号
                table.Columns.Add("RBROW_TYPENAME", typeof(System.String));  //消费类型名称
                table.Columns.Add("RBROW_AMOUNT", typeof(System.Decimal));   //消费金额
                table.Columns.Add("RBROW_NOTE", typeof(System.String));      //消费备注
                foreach (RB_RowsDto rows in RBRows)
                {
                    table.Rows.Add(rows.R_ID, rows.RB_ID, rows.R_ConsumeDate.ToString("yyyy/MM/dd"), rows.R_TypeID, rows.R_TypeName, rows.R_Amount, rows.R_Note);
                }
                this.listRBRowData.Rows.Clear();//清空消费记录列表数据
                if (table.Rows.Count > 0)    //当行项中有数据时
                {

                    this.lblInfor.Visible = false;          //隐藏提示文字
                    this.listRBRowData.DataSource = table;
                    this.listRBRowData.DataBind();
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

        ///// <summary>
        ///// 关闭行项侧滑
        ///// </summary>
        //public void CloseRowSwipe()
        //{
        //    foreach (ListViewRow Row in listRBRowData.Rows)
        //    {                
        //        Layout.frmConsumptionLayout RBRowsLayout = Row.Control as Layout.frmConsumptionLayout;
        //        RBRowsLayout.swipeView1 .Close ();
        //    }
        //}
        /// <summary>
        /// 手机自带回退按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRBRows_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                this.Close();             //关闭当前页面
            }
        }
        /// <summary>
        /// 删除列表行项
        /// </summary>
        /// <param name="row"></param>
        internal void RemoveRow(ListViewRow row)
        {
            this.listRBRowData.Rows.Remove(row);
        }

        /// <summary>
        /// 初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRBRows_Load(object sender, EventArgs e)
        {
            Bind();            //初始化数据
            
        }
        /// <summary>
        /// 创建消费记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Press(object sender, EventArgs e)
        {
            frmRowsCreate frm = new frmRowsCreate();
            this.Show(frm, (MobileForm from, object args) =>
            {
                if (frm.ShowResult == ShowResult.Yes)
                {
                    Bind();          //重新加载数据
                }
            });
        }
    }
}