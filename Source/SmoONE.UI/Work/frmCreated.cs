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
    // 主要内容：  我创建的列表界面
    // ******************************************************************
    partial class frmCreated : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        /// <summary>
        /// 手机自带回退按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCreated_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                Close();         //关闭当前页面
            }
        }
        /// <summary>
        /// 初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCreated_Load(object sender, EventArgs e)
        {
            Bind();
        }
        /// <summary>
        /// 获取初始化数据
        /// </summary>
        public void Bind()
        {
            try
            {
                //获取当前用户创建的请假数据
                List<LeaveDto> listLeaveDto = AutofacConfig.leaveService.GetByCreateUsers(Client.Session["U_ID"].ToString());
                //获取当前用户创建的报销数据
                List<ReimbursementDto> listRBDto = AutofacConfig.rBService.GetByCreateUsers(Client.Session["U_ID"].ToString());
                List<DataGridview> listCreated = new List<DataGridview>();//我发起的数据
                UserDetails userDetails = new UserDetails();
                //如果请假数据条数大于0，则添加到我发起的数据
                if (listLeaveDto.Count > 0)
                {
                    foreach (LeaveDto leave in listLeaveDto)
                    {
                        DataGridview dataGItem = new DataGridview();
                        dataGItem.ID = leave.L_ID;
                        if (string.IsNullOrEmpty(leave.U_Portrait) == true)
                        {
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
                        listCreated.Add(dataGItem);
                    }
                }

                //如果报销数据条数大于0，则添加到我发起的数据
                if (listRBDto.Count > 0)
                {
                    foreach (ReimbursementDto reimbursement in listRBDto)
                    {
                        DataGridview dataGItem = new DataGridview();
                        dataGItem.ID = reimbursement.RB_ID;
                        if (string.IsNullOrEmpty(reimbursement.U_Portrait) == true)
                        {
                            UserDetailDto user = userDetails.getUser(reimbursement.U_ID);
                            if (user != null)
                            {
                                dataGItem.U_Portrait = user.U_Portrait;
                            }
                        }
                        else
                        {
                            dataGItem.U_Portrait = reimbursement.U_Portrait;
                        }
                        dataGItem.Name = reimbursement.U_Name + "的" + DataGridviewType.报销;
                        dataGItem.Type = ((int)Enum.Parse(typeof(DataGridviewType), DataGridviewType.报销.ToString())).ToString();
                        dataGItem.CreateDate = reimbursement.RB_CreateDate.ToString("yyyy/MM/dd");
                        switch (reimbursement.RB_Status)
                        {
                            case (int)RB_Status.新建:
                                dataGItem.L_StatusDesc = "等待责任人审批";
                                break;
                            case (int)RB_Status.责任人审批:
                                dataGItem.L_StatusDesc = "等待行政审批";
                                break;
                            case (int)RB_Status.行政审批:
                                dataGItem.L_StatusDesc = "等待财务审批";
                                break;
                            case (int)RB_Status.财务审批:
                                dataGItem.L_StatusDesc = "财务已审批";
                                break;
                            case (int)RB_Status.已拒绝:
                                dataGItem.L_StatusDesc = "已审批（拒绝）";
                                break;
                        }
                        listCreated.Add(dataGItem);
                    }
                }
                listCrateData.Rows.Clear();//清空我发起的列表数据
                if (listCreated.Count > 0)
                {
                    listCrateData.DataSource = listCreated;//绑定gridView数据
                    listCrateData.DataBind();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }
        }
    }
}