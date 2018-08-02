using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using Smobiler.Plugins.RongIM;
using SmoONE.DTOs;
using SmoONE.CommLib;

namespace SmoONE.UI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmAddUser1Layout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "definition"
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
       
        private void btnAdd_Press(object sender, EventArgs e)
        {
            try
            {
                ContactInputDto cInputDto = new ContactInputDto();
                cInputDto.C_USER = lblUser.BindDataValue.ToString();
                cInputDto.C_CreateUser  = Client.Session["U_ID"].ToString();
                cInputDto.C_UpdateUser  = Client.Session["U_ID"].ToString();
                ReturnInfo r = AutofacConfig.contactService.AddContact(cInputDto);
                if (r.IsSuccess == true)
                {
                    if (((SmoONE.UI.Im.frmAddConcentOrGroup)this.Form).im1 != null)
                    {
                        //添加联系人
                        ((SmoONE.UI.Im.frmAddConcentOrGroup)this.Form).im1.CreateUser(cInputDto.C_USER, lblUser.BindDisplayValue.ToString(),System.IO.Path.Combine( MobileResourceManager.DefaultImagePath ,imgPortrait .BindDisplayValue .ToString ()));
                    }
                    this.Form .ShowResult = ShowResult.Yes;
                    this.Form .Close();
                    this.Form .Toast ("联系人添加成功！", ToastLength.SHORT);
                }
                else
                {
                    throw new Exception(r.ErrorInfo);
                }
            }
           catch (Exception ex)
            {
                this.Form.Toast(ex.Message , ToastLength.SHORT);
            }
        }
    }
}