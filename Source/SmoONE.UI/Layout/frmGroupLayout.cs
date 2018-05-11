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
    partial class frmGroupLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "definition"
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
      
        #endregion
        //public frmGroupLayout(IM im):this()
        //{
        //    im1 = im;
        //}
        /// <summary>
        /// 群组聊天
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tpUser_Press(object sender, EventArgs e)
        {
            try
            {
                if (((SmoONE.UI.Im.frmConcent)this.Form).im1 != null)
                {
                    //在群组列表模板中调用群组聊天
                    ((SmoONE.UI.Im.frmConcent)this.Form).im1.StartGroupChat(lblGroup.BindDataValue.ToString(), lblGroup.BindDisplayValue.ToString());
                }
                }
            catch (Exception ex)
            {
                this.Form.Toast(ex.Message,ToastLength.SHORT );
            }
        }
    }
}