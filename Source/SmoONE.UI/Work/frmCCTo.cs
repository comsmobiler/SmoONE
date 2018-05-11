using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SmoONE.UI;
using SmoONE.DTOs;

namespace SmoONE.UI.Work
{
    // ******************************************************************
    // 文件版本： SmoONE 2.0
    // Copyright  (c)  2017-2018 Smobiler 
    // 创建时间： 2017/07
    // 主要内容：  抄送我的列表界面
    // ******************************************************************
    partial class frmCCTo : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        /// <summary>
        /// 初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCCTo_Load(object sender, EventArgs e)
        {
            Bind();
        }/// <summary>
         /// 获取初始化数据
         /// </summary>
        public void Bind()
        {
            try
            {
                List<DataGridview> listCCTo = new List<DataGridview>();//抄送我的数据
                //获取抄送给当前用户的请假数据
                List<LeaveDto> listLeaveDto = AutofacConfig.leaveService.GetByCCTo(Client.Session["U_ID"].ToString());
                //如果请假数据条数大于0，则添加到抄送我的数据
                if (listLeaveDto.Count > 0)
                {
                    foreach (LeaveDto leave in listLeaveDto)
                    {
                        DataGridview dataGItem = new DataGridview();
                        dataGItem.ID = leave.L_ID;
                        if (string.IsNullOrEmpty(leave.U_Portrait) == true)
                        {
                            UserDetails userDetails = new UserDetails();
                            UserDetailDto user = userDetails.getUser(leave.U_ID);
                            if (user != null)
                            {
                                dataGItem.U_Portrait = user.U_Portrait;
                            }
                        }
                        else
                        {
                            dataGItem.U_Portrait = leave.U_Portrait;
                        }
                        dataGItem.Name = leave.U_Name + "的" + DataGridviewType.请假;
                        dataGItem.Type = ((int)Enum.Parse(typeof(DataGridviewType), DataGridviewType.请假.ToString())).ToString();
                        dataGItem.CreateDate = leave.L_CreateDate.ToString("yyyy/MM/dd");
                        switch (leave.L_Status)
                        {
                            case (int)L_Status.新建:
                                dataGItem.L_StatusDesc = "等待审批";
                                break;
                            case (int)L_Status.已审批:
                                dataGItem.L_StatusDesc = "已审批（完成）";
                                break;
                            case (int)L_Status.已拒绝:
                                dataGItem.L_StatusDesc = "已审批（拒绝）";
                                break;
                        }
                        listCCTo.Add(dataGItem);
                    }
                }

                listCCData.Rows.Clear();//清除抄送我的列表数据
                if (listCCTo.Count > 0)
                {
                    //绑定gridView数据
                    listCCData.DataSource = listCCTo;
                    listCCData.DataBind();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }
        }
        /// <summary>
        /// 手机自带回退按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCCTo_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                Close();         //关闭当前页面
            }
        }
    }
}