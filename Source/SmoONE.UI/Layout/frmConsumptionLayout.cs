using System;
using Smobiler.Core.Controls;
using SmoONE.UI.RB;

namespace SmoONE.UI.Layout
{
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmConsumptionLayout : Smobiler.Core.Controls.MobileUserControl
    {
        /// <summary>
        /// 编号
        /// </summary>
        internal string NO
        {
            get
            {
                return this.lblMoney.BindDataValue.ToString();
            }

        }

      
        /// <summary>
        /// 查看消费记录详情
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plContent_Press(object sender, EventArgs e)
        {
            try
            {
                frmRowsCreate frm = new frmRowsCreate();      //进入消费记录详情页面
                frm.ID = lblMoney.BindDataValue.ToString();
                this.Form.Show(frm, (MobileForm sender1, object args) =>
                {
                    if (frm.ShowResult == ShowResult.Yes)
                    {
                        ((frmRBRows)(this.Form)).Bind();//重新加载数据
                    }
                    
                });
            }
            catch (Exception ex)
            {
                this.Form.Toast(ex.Message);
            }
        }

    }
}