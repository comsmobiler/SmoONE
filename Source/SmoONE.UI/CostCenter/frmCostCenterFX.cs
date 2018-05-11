using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SmoONE.DTOs;

namespace SmoONE.UI.CostCenter
{
        // ******************************************************************
        // 文件版本： SmoONE 1.0
        // Copyright  (c)  2016-2017 Smobiler
        // 创建时间： 2016/11
        // 主要内容： 成本中心列表界面
        // ******************************************************************
        partial class frmCostCenterFX : Smobiler.Core.Controls.MobileForm
        {
            #region "definition"
            AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
            #endregion

            /// <summary>
            /// 初始化事件
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void frmCostCenterFX_Load(object sender, EventArgs e)
            {
                Bind();
            }
            /// <summary>
            /// 初始化方法
            /// </summary>
            public void Bind()
            {
                //获取所有成本中心数据
                List<CCDto> listCC = AutofacConfig.costCenterService.GetAllCC();

                gridCCData.Rows.Clear();//清空成本中心列表数据
                if (listCC.Count > 0)
                {
                    foreach (CCDto cc in listCC)
                    {
                        UserDetailDto user = AutofacConfig.userService.GetUserByUserID(cc.CC_LiableMan);
                        cc.CC_LiableMan = user.U_Name;

                    }
                  
                    gridCCData.DataSource = listCC;
                    gridCCData.DataBind();
                }
                
            }
            /// <summary>
            /// 手机自带回退按钮事件
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void frmCostCenterFX_KeyDown(object sender, KeyDownEventArgs e)
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
            private void frmCostCenterFX_TitleImageClick(object sender, EventArgs e)
            {
                Close();
            }
        }
    }
