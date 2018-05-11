using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SmoONE.UI.RB;

namespace SmoONE.UI.Layout
{
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmRBModelLayout : Smobiler.Core.Controls.MobileUserControl
    {
        

        /// <summary>
        /// 选中模板，将模板编号传递到上个页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plContent_Press(object sender, EventArgs e)
        {
            try
            {
                
                if (this.Form.ToString() == "SmoONE.UI.RB.frmRTypeTempChoose")
                {
                    ((frmRTypeTempChoose)(this.Form)).RTTemplaetID = lblRT_Money.BindDataValue.ToString();
                    this.Form.ShowResult = ShowResult.Yes;
                    this.Form.Close();
                }
                else if (this.Form.ToString() == "SmoONE.UI.RB.frmRTypeTemplate")
                {
                    frmRTypeTempCreate frm = new frmRTypeTempCreate();              //进入模板创建或者详情页面
                    frm.ID = lblRT_Money.BindDataValue.ToString(); 
                    this.Form.Show(frm, (MobileForm sender1, object args) =>
                    {
                        if (frm.ShowResult == ShowResult.Yes)
                        {
                            ((frmRTypeTemplate)(this.Form)).Bind();            //重新加载数据
                           
                        }
                    });
                }
            }
            catch (Exception ex)
            {
                this.Form.Toast(ex.Message);
            }
        }

       

        /// <summary>
        /// 编号
        /// </summary>
        internal string NO
        {
            get
            {
                return   this.lblRT_Money.BindDataValue.ToString();
            }
            
        }
    }
}