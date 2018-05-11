using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SmoONE.Domain;
using SmoONE.CommLib;
using SmoONE.DTOs;

namespace SmoONE.UI.CostCenter
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2016/11
    // 主要内容：  成本中心详情界面
    // ******************************************************************
    partial class frmCostCenterDetail : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        public string CCID ;//成本中心编号
        private int currantSatus;//当前成本中心状态
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        /// <summary>
        /// 跳转到成本中心编辑界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //跳转到编辑界面
            frmCostCenterCreate frm = new frmCostCenterCreate();
            frm.CCID = CCID;
            Show(frm, (MobileForm form, object args) =>
            {
                if (frm.ShowResult == ShowResult.Yes)
                {
                    ShowResult = ShowResult.Yes;
                    Bind();
                }
            });
        }
        /// <summary>
        /// 初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCostCenterDetail_Load(object sender, EventArgs e)
        {
            Bind();
        }
        /// <summary>
        /// 初始化方法
        /// </summary>
        private void Bind()
        {
            try
            {
                    //根据成本中心编号获取成本中心数据
                    CCDetailDto cc = AutofacConfig.costCenterService.GetCCByID(CCID);
                    lblCC_Name.Text = cc.CC_Name;
                    lblType.Text = cc.CC_TypeName;
                    lblStartDate.Text = cc.CC_StartDate.ToString("yyyy/MM/dd");
                    lblEndDate.Text = cc.CC_EndDate.ToString("yyyy/MM/dd");
                    lblAmount.Text = cc.CC_Amount.ToString();
                    lblRBAmount.Text = cc.CC_UsedAmount.ToString();
                    UserDetailDto user = AutofacConfig.userService.GetUserByUserID(cc.CC_LiableMan);
                    lblLiableMan.Text = user.U_Name;
                    lblDep.Text = cc.CC_DepName;
                    lblTemplate.Text = cc.CC_TemplateID;
                    currantSatus = cc.CC_IsActive;
                    switch (cc.CC_IsActive)
                    {
                        case (int)IsActive.激活:
                            lblActive.Text = "激活";
                            btnActive.Text = "冻结";
                            btnActive.BackColor= System.Drawing.Color.FromArgb(97, 121, 138);
                            break;
                        case (int)IsActive.冻结:
                            lblActive.Text = "冻结";
                            btnActive.Text = "激活";
                            btnActive.BackColor= System.Drawing.Color.FromArgb(229,96,79);
                            break;
                    }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 激活或锁定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActive_Click(object sender, EventArgs e)
        {
            try
            {
                IsActive upStatus = IsActive.冻结;//更改状态
                switch (currantSatus)
                {
                    case (int)IsActive.激活:
                        upStatus = IsActive.冻结;
                        break;
                    case (int)IsActive.冻结:
                        upStatus = IsActive.激活;
                        break;
                }
                AutofacConfig AutofacConfig = new AutofacConfig();
                //更新成本中心状态
                ReturnInfo result = AutofacConfig.costCenterService.UpdateCostCenterStatus(CCID, upStatus,Client .Session ["U_ID"].ToString ());
                if (result.IsSuccess == false)
                {
                    throw new Exception(result.ErrorInfo);
                }
                else
                {
                    Toast("已"+btnActive .Text +"成功！", ToastLength.SHORT);
                    Bind();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message , ToastLength.SHORT);
            }
        }
        /// <summary>
        /// 手机自带回退按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCostCenterDetail_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                Close();         //关闭当前页面
            }
        }
        /// <summary>
        /// 标题栏图片按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCostCenterDetail_TitleImageClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}