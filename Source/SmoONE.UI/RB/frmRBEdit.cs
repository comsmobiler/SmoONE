using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;
using SmoONE.DTOs;
using SmoONE.UI;
using SmoONE.CommLib;
using SmoONE.UI.Layout;
using SmoONE.UI.CostCenter;

namespace SmoONE.UI.RB
{
    // ******************************************************************
    // 文件版本： SmoONE 2.0
    // Copyright  (c)  2017-2018 Smobiler 
    // 创建时间： 2017/07
    // 主要内容：  报销单编辑界面
    // ******************************************************************
    partial class frmRBEdit : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        private string RBCC;                 //成本中心编号
        internal string ID;                //报销单编号
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        /// <summary>
        /// 成本中心选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRBCC_Press(object sender, EventArgs e)
        {
            try
            {
                frmRBCostCenter frmCostCenter = new frmRBCostCenter();
                this.Show(frmCostCenter, (MobileForm sender1, object args) =>
                {
                    try
                    {
                        if (frmCostCenter.ShowResult == ShowResult.Yes)
                        {
                            string CCID = frmCostCenter.CCID;
                            string[] CCS = CCID.Split(new char[] { '/' });
                            RBCC = CCS[0];         //成本中心编号
                            this.btnRBCC.Text = CCS[1] + "   > ";           //成本中心名称
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                });
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 保存报销编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Press(object sender, EventArgs e)
        {
            try
            {
                RBInputDto ReimBur = new RBInputDto();
                ReimBur.RB_Rows = new List<RB_RowsInputDto>();
                ReimBur.RB_ID = this.lblRBNO.Text;            //报销单编号
                ReimBur.CC_ID = RBCC;                   //成本中心编号
                ReimBur.RB_Note = this.TxtNote.Text;                  //备注
                //消费记录行项更改
                foreach (ListViewRow Row in listRBRowData.Rows)
                {
                    //判断消费记录是否选中
                    frmConsumption1Layout layout = Row.Control as frmConsumption1Layout;
                    if (layout.checkNum() == 1)
                    {
                        //把选中行的Row的数据添加到报销单中
                        int RID = layout.getID();
                        RB_RowsDto RBRow = AutofacConfig.rBService.GetRowByRowID(RID);
                        RB_RowsInputDto NewRBRow = new RB_RowsInputDto();
                        NewRBRow.R_ID = RBRow.R_ID;
                        NewRBRow.R_TypeID = RBRow.R_TypeID;
                        NewRBRow.R_Amount = RBRow.R_Amount;
                        NewRBRow.R_Note = RBRow.R_Note;
                        NewRBRow.R_ConsumeDate = RBRow.R_ConsumeDate;
                        ReimBur.RB_Rows.Add(NewRBRow);
                    }
                }
                ReturnInfo r = AutofacConfig.rBService.UpdateRB(ReimBur);       //将报销记录更新到数据库中
                if (r.IsSuccess == true)
                {
                    this.ShowResult = ShowResult.Yes;
                    this.Close();
                    Toast("报销提交成功！");
                }
                else
                {
                    throw new Exception(r.ErrorInfo);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 初始化数据，将数据显示到页面上
        /// </summary>
        private void Bind()
        {
            try
            {
                //显示报销明细
                List<RB_RowsDto> Rows = AutofacConfig.rBService.GetRowByRBID(ID);
                List<RB_RowsDto> UnReimRows = AutofacConfig.rBService.GetRowsByCreateUser(Client.Session["U_ID"].ToString());
                this.lblRBNO.Text = ID;                 //报销编号
                RBDetailDto Reim = AutofacConfig.rBService.GetByID(ID);
                RBCC = Reim.CC_ID;                //成本中心编号
                CCDetailDto Cost = AutofacConfig.costCenterService.GetCCByID(Reim.CC_ID);
                this.btnRBCC.Text = Cost.CC_Name + "   > ";               //成本中心名称
                this.TxtNote.Text = Reim.RB_Note;                       //备注
                DataTable rowTable = new DataTable();
                rowTable.Columns.Add("ID", typeof(System.Int32));                       //消费记录编号
                rowTable.Columns.Add("RBCHECKED", typeof(System.Boolean));              //是否选中
                rowTable.Columns.Add("RB_NO", typeof(System.String));                   //报销单编号
                rowTable.Columns.Add("RBROW_DATE", typeof(System.String));              //消费日期
                rowTable.Columns.Add("RBROW_TYPE", typeof(System.String));              //消费类型编号
                rowTable.Columns.Add("RBROW_TYPENAME", typeof(System.String));          //消费类型名称
                rowTable.Columns.Add("RBROW_AMOUNT", typeof(System.Decimal));           //消费金额
                rowTable.Columns.Add("RBROW_NOTE", typeof(System.String));              //消费备注 
                foreach (RB_RowsDto Row in Rows)          //将原报销单中的行项添加到数据源中
                {
                    string TypeName = AutofacConfig.rBService.GetTypeNameByID(Row.R_TypeID);

                    rowTable.Rows.Add(Row.R_ID, true, Row.RB_ID, Row.R_ConsumeDate.ToString("yyyy/MM/dd"), Row.R_TypeID, TypeName, Row.R_Amount, Row.R_Note);
                }
                foreach (RB_RowsDto Row in UnReimRows)          //将当前用户未报销的行项添加到数据源中
                {
                    string TypeName = AutofacConfig.rBService.GetTypeNameByID(Row.R_TypeID);
                    rowTable.Rows.Add(Row.R_ID, false, Row.RB_ID, Row.R_ConsumeDate.ToString("yyyy/MM/dd"), Row.R_TypeID, TypeName, Row.R_Amount, Row.R_Note);
                }
                if (rowTable.Rows.Count > 0)
                {

                    rowTable.Columns.Add("ROW_NOTE", typeof(System.String));
                    rowTable.Columns.Add("ROW_DATE", typeof(System.String));
                    this.listRBRowData.DataSource = rowTable;
                    this.listRBRowData.DataBind();
                    getAmount();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRBEdit_Load(object sender, EventArgs e)
        {
            try
            {               
                Bind();               //初始化数据
                upCheckState();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 更新全选状态
        /// </summary>
        public void upCheckState()
        {
            int selectUserQty = 0;      //设置当前选中行项为0
            foreach (ListViewRow Row in listRBRowData.Rows)
            {
                frmConsumption1Layout layout = Row.Control as frmConsumption1Layout;
                int num = layout.checkNum();
                selectUserQty += num;
            }
            if (selectUserQty == listRBRowData.Rows.Count)                //当选中所有行项时
            {
                Checkall.Checked = true;
            }
            else                               //当没有选中所有行项时
            {
                Checkall.Checked = false;
            }
        }
        /// <summary>
        ///计算报销单总金额
        /// </summary>
        /// <remarks></remarks>
        public void getAmount()
        {
            try
            {
                decimal sumAmount = 0;
                foreach (ListViewRow Row in listRBRowData.Rows)
                {
                    //判断消费记录是否选中，计算选中的消费记录总金额
                    frmConsumption1Layout layout = Row.Control as frmConsumption1Layout;
                    decimal num = layout.getNum();       //获取选中行消费数量
                    sumAmount += num;
                }
                //将计算出来的选中的消费记录总金额显示在底部
                lblAmount.Text = "￥" + sumAmount.ToString();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 全选或者全不选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Checkall_CheckedChanged(object sender, EventArgs e)
        {
            foreach (ListViewRow Row in listRBRowData.Rows)
            {
                frmConsumption1Layout Layout = Row.Control as frmConsumption1Layout;
                Layout.setCheck(Checkall.Checked);
            }
            getAmount();      //计算报销单总金额
        }
        /// <summary>
        /// 手机自带返回键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRBEdit_KeyDown(object sender, KeyDownEventArgs e)
        {
            //按了手机返回键，则返回到上一页
            if (e.KeyCode == KeyCode.Back)
            {
                this.Close();            //关闭当前页面
            }
        }
    }
}