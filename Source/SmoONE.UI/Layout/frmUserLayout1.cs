using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using Smobiler.Plugins.RongIM;

namespace SmoONE.UI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmUserLayout1 : Smobiler.Core.Controls.MobileUserControl
    {
       
        /// <summary>
        /// 用户聊天
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tpUser_Press(object sender, EventArgs e)
        {
            try
            {
            
                //在联系人模板中调用im用户聊天
                if (((SmoONE.UI.Im .frmConcent)this.Form).im1  != null)
                {
                    ((SmoONE.UI.Im.frmConcent)this.Form).im1.StartPrivateChat(lblUser .BindDataValue .ToString (), lblUser.BindDisplayValue.ToString());
                }
            
            }
            catch (Exception ex)
            {
                this.Form.Toast(ex.Message);
            }
        }
    }
}