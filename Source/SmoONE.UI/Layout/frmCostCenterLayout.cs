using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SmoONE.UI.CostCenter;

namespace SmoONE.UI.Layout
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2016/11
    // 主要内容： 成本中心列表模板
    // ******************************************************************
    partial class frmCostCenterLayout : Smobiler.Core.Controls.MobileUserControl
    {
        /// <summary>
        /// 成本中心行项点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_Press(object sender, EventArgs e)
        {
            if (this.Form.ToString() == "SmoONE.UI.CostCenter.frmCostCenter")
            {
                string CCID = lblCC_ID.BindDataValue.ToString();
                //跳转到成本中心详细界面
                SmoONE.UI.CostCenter.frmCostCenterDetail frm = new SmoONE.UI.CostCenter.frmCostCenterDetail();
                frm.CCID = CCID;
                this.Form.Show(frm, (MobileForm form, object args) =>
                {
                    if (frm.ShowResult == ShowResult.Yes)
                    {
                        ((SmoONE.UI.CostCenter.frmCostCenter)this.Form).Bind();
                    }
                });
            }
            else if (this.Form.ToString() == "SmoONE.UI.CostCenter.frmRBCostCenter")
            {
                ((frmRBCostCenter)(this.Form)).CCID = lblCC_ID.BindDataValue.ToString() + "/" + lblCC_Name.BindDataValue.ToString();
                this.Form.ShowResult = ShowResult.Yes;
                this.Form.Close();
            }
            else if (this.Form.ToString() == "SmoONE.UI.CostCenter.frmCostCenterFX")
            {
                string CCID = lblCC_ID.BindDataValue.ToString();
                //跳转到成本中心详细界面
                SmoONE.UI.CostCenter.frmCostCenterFXDetail frm = new SmoONE.UI.CostCenter.frmCostCenterFXDetail();
                frm.CCID = CCID;
                frm.CC_Amount = Convert.ToDecimal(lblAmount.BindDataValue);
                this.Form.Show(frm);
            }
        }
      
    }
}