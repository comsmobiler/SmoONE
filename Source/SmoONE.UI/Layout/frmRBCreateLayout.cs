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
    partial class frmRBCreateLayout : Smobiler.Core.Controls.MobileUserControl
    {
        /// <summary>
        /// 更改选中事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Check_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                ((frmRBCreate)(this.Form)).upCheckState();    //更新全选框状态
                ((frmRBCreate)(this.Form)).getAmount();         //计算当前选中行项总金额
            }
            catch (Exception ex)
            {
                this.Form.Toast(ex.Message);
            }
        }
        /// <summary>
        /// 获取当前行是否选中
        /// </summary>
        public int checkNum()
        {
            if (Check.Checked == true)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        /// <summary>
        /// 获取当前选中行报销明细ID
        /// </summary>
        /// <returns></returns>
        public int getID()
        {
            return Convert.ToInt32(imgType.BindDataValue);
        }
        /// <summary>
        /// 获取选中行项金额
        /// </summary>
        /// <returns></returns>
        public decimal getNum()
        {
            if (Check.Checked == true)
            {
                return Convert.ToDecimal(lblMoney.BindDataValue);
            }
            else
            {
                return 0;
            }
        }
        /// <summary>
        /// 设置每行checkBox状态
        /// </summary>
        public void setCheck(bool state)
        {
            Check.Checked = state;
        }
        /// <summary>
        /// 行项点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plContent_Press(object sender, EventArgs e)
        {
            try
            {
                if (Check.Checked == true)
                {
                    Check.Checked = false;
                }
                else
                {
                    Check.Checked = true;
                }
                ((frmRBCreate)(this.Form)).upCheckState();          //更新全选框状态
                ((frmRBCreate)(this.Form)).getAmount();         //计算当前选中行项总金额 
            }
            catch (Exception ex)
            {
                this.Form.Toast(ex.Message);
            }
        }
    }
}