using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SmoONE.DTOs;
using SmoONE.Domain;

namespace SmoONE.UI.CostCenter
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2016/11
    // 主要内容：  成本中心模板列表界面
    // ******************************************************************
    partial class frmCostTemplet : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        /// <summary>
        /// 是否选择成本中心类型模板
        /// </summary>
        public bool IsSelectCTemPlet;
        /// <summary>
        /// 模板编号
        /// </summary>
        public string CTempID;
        /// <summary>
        /// 模板编号
        /// </summary>
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
   
        /// <summary>
        /// 初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCostTemplet_Load(object sender, EventArgs e)
        {
            Bind();
        }
        /// <summary>
        /// 初始化方法
        /// </summary>
        public  void Bind()
        {
            //获取所有成本模板
          List<CC_Type_TemplateDto> listCCTemp=  AutofacConfig.costCenterService.GetAllCCTTemplate();

          gridCCTempletData.Cells .Clear();//清空成本中心模板列表数据
          if (listCCTemp.Count > 0)
          {
              foreach (CC_Type_TemplateDto ccTemp in listCCTemp)
              {
                  string AEACheckers = "";
                  string[] AEAChecks = ccTemp.CC_TT_AEACheckers.Split(',');
                  foreach (string AEACheck in AEAChecks)
                  {
                      UserDetailDto user = AutofacConfig.userService.GetUserByUserID(AEACheck);
                      if (string.IsNullOrWhiteSpace(AEACheckers) == true)
                      {
                          AEACheckers =user.U_Name;
                      }
                      else
                      {
                          AEACheckers += "," + user.U_Name;
                      }
                  }
                  ccTemp.CC_TT_AEACheckers = AEACheckers;
                  string FCheckers = "";
                  string[] FChecks = ccTemp.CC_TT_FinancialCheckers.Split(',');
                  foreach (string FCheck in FChecks)
                  {
                      UserDetailDto user = AutofacConfig.userService.GetUserByUserID(FCheck);
                      if (string.IsNullOrWhiteSpace(FCheckers) == true)
                      {
                          FCheckers =user.U_Name;
                      }
                      else
                      {
                          FCheckers += "," + user.U_Name;
                      }
                  }
                  ccTemp.CC_TT_FinancialCheckers = FCheckers;
              }
              lblInfor.Visible = false;
              gridCCTempletData.DataSource = listCCTemp;
              gridCCTempletData.DataBind();
          }
          else
          {
              lblInfor.Visible = true ;
          }
        }
        /// <summary>
        /// 标题栏图片按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCostTemplet_TitleImageClick(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// 手机自带回退键事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCostTemplet_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                Close();         //关闭当前页面
            }
        }
        /// <summary>
        /// 跳转到模板创建界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {  //跳转到成本模板创建界面
            frmCostTempletCreate frm = new frmCostTempletCreate();
            Show(frm, (MobileForm form, object args) =>
            {
                if (frm.ShowResult == ShowResult.Yes)
                {
                    Bind();
                }
            });
        }
    }
}