using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SmoONE.DTOs;
using System.Data;

namespace SmoONE.UI.CostCenter
{
    partial class frmCostCenterFXDetail : Smobiler.Core.Controls.MobileForm
    {

        #region "definition"
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        public string CCID;//成本中心
        public decimal CC_Amount;//成本中心金额
        private  decimal CC_confirmAmount=0;//已报销金额
        private decimal CC_createAmount = 0;//报销中金额
        private List<ReimbursementDto> listRBDto=new List<ReimbursementDto>();
        #endregion
        /// <summary>
        /// 获取分析数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCostCenterFXDetail_Load(object sender, EventArgs e)
        {
            getRBDate();
            getCCFXDate();
            getBindtableDate("已报销");
        }
        /// <summary>
        /// 获取成本中心报销分析数据
        /// </summary>
        private  void getRBDate()
        {

            try
            {
                //获取当前成本中心的报销数据
                listRBDto = AutofacConfig.rBService.GetByCCID(CCID);
                if (listRBDto.Count > 0)
                {
                    foreach (ReimbursementDto reimbursement in listRBDto)
                    {
                        switch (reimbursement.RB_Status)
                        {
                            case (int)RB_Status.新建:
                            case (int)RB_Status.责任人审批:
                            case (int)RB_Status.行政审批:
                                CC_createAmount += reimbursement.RB_TotalAmount;
                                break;
                            case (int)RB_Status.财务审批:
                                CC_confirmAmount += reimbursement.RB_TotalAmount;

                                break;

                        }
                    }
                }
              }
              
                    catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }
        }
        /// <summary>
        /// 绑定拼图分析数据
        /// </summary>
        private  void getCCFXDate()
        {

            try
            {
                DataTable table = new DataTable();
                table.Columns.Add("Type", typeof(System.String));
                table.Columns.Add("Amount", typeof(System.Decimal));
                if (CC_Amount > 0)
                {
                    DataRow dr1 = table.NewRow();

                    dr1["Type"] = "已报销";
                    dr1["Amount"] = CC_confirmAmount;
                    table.Rows.Add(dr1);
                    DataRow dr2 = table.NewRow();
                    dr2["Type"] = "报销中";
                    dr2["Amount"] = CC_createAmount;
                    table.Rows.Add(dr2);
                    DataRow dr3 = table.NewRow();
                    dr3["Type"] = "剩余金额";
                    dr3["Amount"] =CC_Amount - CC_confirmAmount- CC_createAmount;
                    table.Rows.Add(dr3);
                   
                    pieChart1.DataSource = table;
                    pieChart1.DataBind();
                }
                   


            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }

        }
        /// <summary>
        /// 绑定tableview数据
        /// </summary>
        /// <param name="type"></param>
        private  void getBindtableDate(string type)
        {

            try
            {
                tableView1.Rows.Clear();  
                //如果报销数据条数大于0，分析数据
                if (listRBDto.Count > 0 & (type.Equals("已报销") || type.Equals("报销中")))
                {
                    DataTable rbtable = new DataTable();
                    rbtable.Columns.Add("RB_ID", typeof(System.String));
                    rbtable.Columns.Add("R_ConsumeDate", typeof(System.String ));
                    rbtable.Columns.Add("R_TypeName", typeof(System.String));
                    rbtable.Columns.Add("R_Amount", typeof(System.String));
                    rbtable.Columns.Add("R_CreateUser", typeof(System.String));
                    List<string> listRBNO = new List<string>();
                    foreach (ReimbursementDto reimbursement in listRBDto)
                    {
                        if ((type.Equals("已报销") & reimbursement.RB_Status.Equals((int)RB_Status.财务审批)) || (type.Equals("报销中")&(reimbursement.RB_Status.Equals((int)RB_Status.新建)|| reimbursement.RB_Status.Equals((int)RB_Status.责任人审批 )|| reimbursement.RB_Status.Equals((int)RB_Status.行政审批))))
                        {
                            listRBNO.Add(reimbursement.RB_ID);
                        }
                    }
                    if (listRBNO.Count  >0)
                    {
                        foreach (string  rbNO in listRBNO)
                        {
                            List<RB_RowsDto> Rows = AutofacConfig.rBService.GetRowByRBID(rbNO);         //查找报销单的消费记录信息
                            if (Rows .Count >0)
                            {
                                foreach (RB_RowsDto Row in Rows)
                                {
                                    DataRow dr = rbtable.NewRow();
                                    dr["RB_ID"] = Row.RB_ID ;
                                    dr["R_ConsumeDate"] = Row.R_ConsumeDate.ToString("yyyy/MM/dd");
                                    dr["R_TypeName"] = Row.R_TypeName;
                                    dr["R_Amount"] = "￥" + Row.R_Amount.ToString();
                                    UserDetailDto user = AutofacConfig.userService.GetUserByUserID(Row.R_CreateUser);
                                    if (user != null & string.IsNullOrEmpty(user.U_Name) == false)
                                    {
                                        dr["R_CreateUser"] = user.U_Name;
                                    }
                                      
                                    rbtable.Rows.Add(dr);
                                }
                            }
                           
                        }
                      }
                    tableView1.DataSource = rbtable;
                    tableView1.DataBind();
                }
                }
                    catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }

        }

        /// <summary>
        /// 手机自带回退按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCostCenterFXDetail_KeyDown(object sender, KeyDownEventArgs e)
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
        private void frmCostCenterFXDetail_TitleImageClick(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pieChart1_ValueSelected(object sender, PieChartValueSelectedEventArgs e)
        {
            try
            {
              if ( e.XValue.Equals ("已报销") || e.XValue.Equals("报销中"))
              {
                    getBindtableDate(e.XValue);
                }

            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }
        }
    }
}