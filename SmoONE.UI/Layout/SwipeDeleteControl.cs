using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SmoONE.CommLib;

namespace SmoONE.UI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class SwipeDeleteControl : Smobiler.Core.Controls.MobileUserControl
    {
        #region "Properties"
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
       

        /// <summary>
        /// 删除列表行项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelRow_Press(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("确认要删除选中行项？", MessageBoxButtons.YesNo, (Object s1, MessageBoxHandlerArgs args) =>
                {
                    //此委托为异步委托事件
                    if (args.Result == Smobiler.Core.Controls.ShowResult.Yes)
                    {
                        switch (this.Form.ToString())
                        {
                            case "SmoONE.UI.RB.frmRTypeTemplate":
                                ReturnInfo r = AutofacConfig.rBService.DeleteRB_Type_Template(((frmRBModelLayout)this.Parent.Parent).NO);
                                if (r.IsSuccess == true)
                                {
                                    ListViewRow row = this.Parent.Parent.Tag as ListViewRow;
                                    ((RB.frmRTypeTemplate)(this.Form)).RemoveRow(row);//删除当前列表行项
                                    Toast("删除消费模板成功");
                                }
                                else
                                {
                                    throw new Exception(r.ErrorInfo);
                                }
                                break;
                            case "SmoONE.UI.RB.frmRBRows":
                                ReturnInfo r1 = AutofacConfig.rBService.DeleteRB_Rows(Convert.ToInt32(((frmConsumptionLayout)this.Parent.Parent).NO));
                                if (r1.IsSuccess == true)
                                {
                                    ListViewRow row = this.Parent.Parent.Tag as ListViewRow;
                                    ((RB.frmRBRows)(this.Form)).RemoveRow(row);//删除当前列表行项
                                    Toast("删除消费记录成功");
                                }
                                else
                                {
                                    throw new Exception(r1.ErrorInfo);
                                }
                                break;
                        }
                    }
                });
                   
               
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

       
    }
}