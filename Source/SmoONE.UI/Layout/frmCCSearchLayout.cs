using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SmoONE.UI.CostCenter;
using SmoONE.DTOs;

namespace SmoONE.UI.Layout
{
    partial class frmCCSearchLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "definition"
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        private void btnccuser_Press(object sender, EventArgs e)
        {
            ((frmRBCostCenter)(this.Form)).popList1.Groups.Clear();
            PopListGroup poli = new PopListGroup();
            ((frmRBCostCenter)(this.Form)).popList1.Groups.Add(poli);
            poli.Title = "责任人选择";
            List<UserDto> listuser = AutofacConfig.userService.GetAllUsers();
            foreach (UserDto user in listuser)
            {
                poli.AddListItem(user.U_Name, user.U_ID);
                if (((frmRBCostCenter)(this.Form)).liableMan.Trim().Length > 0)
                {
                    if (((frmRBCostCenter)(this.Form)).liableMan.Trim().Equals(user.U_ID))
                    {
                        ((frmRBCostCenter)(this.Form)).popList1.SetSelections(poli.Items[(poli.Items.Count - 1)]);
                    }
                }
            }
            ((frmRBCostCenter)(this.Form)).popList1.Show();
        }

        public void ChangeValue(string Value)
        {
            btnccuser.Text = Value;
        }
        private void btncurrentUser_Press(object sender, EventArgs e)
        {
            UserDetailDto userInfo = AutofacConfig.userService.GetUserByUserID(Client.Session["U_ID"].ToString());
            btnccuser.Text = userInfo.U_Name;
        }

        private void btnCancel_Press(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Press(object sender, EventArgs e)
        {
            string ccname = txtCCName.Text;
            ((frmRBCostCenter)(this.Form)).GetCC(ccname, ((frmRBCostCenter)(this.Form)).liableMan);
            this.Close();
        }
    }
}