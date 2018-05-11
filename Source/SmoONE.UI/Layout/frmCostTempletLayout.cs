using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace SmoONE.UI.Layout
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2016/11
    // 主要内容：  成本中心模板列表模板
    // ******************************************************************
    partial class frmCostTempletLayout : Smobiler.Core.Controls.MobileUserControl
    {
        /// <summary>
        /// 成本中心模板列表模板行项点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_Press(object sender, EventArgs e)
        {
           ((SmoONE.UI.CostCenter.frmCostTemplet)this.Form).CTempID = lblID.BindDataValue.ToString();
            //如果是为成本模板选择，点击时则关闭界面
            if (((SmoONE.UI.CostCenter.frmCostTemplet)this.Form).IsSelectCTemPlet == true)
            {
                this.Form .ShowResult = Smobiler.Core.Controls.ShowResult.Yes;
               this.Form . Close();
            }
            else
            {
                //跳转到成本模板详细界面
                SmoONE.UI.CostCenter.frmCostTempletDetail frm = new SmoONE.UI.CostCenter.frmCostTempletDetail();
                frm.CTempID =((SmoONE.UI.CostCenter.frmCostTemplet)this.Form). CTempID;
                this.Form.Show(frm, (MobileForm form, object args) =>
                {
                    if (frm.ShowResult == ShowResult.Yes)
                    {
                        ((SmoONE.UI.CostCenter.frmCostTemplet)this.Form).Bind();
                    }
                });
            }
        }

       
    }
}