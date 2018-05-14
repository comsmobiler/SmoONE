using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;
using SmoONE.UI;
using SmoONE.DTOs;
using SmoONE.CommLib;
using SmoONE.UI.Layout;
using SmoONE.UI.CostCenter;

namespace SmoONE.UI.RB
{
    // ******************************************************************
    // 文件版本： SmoONE 2.0
    // Copyright  (c)  2017-2018 Smobiler 
    // 创建时间： 2017/07
    // 主要内容：  报销单创建界面
    // ******************************************************************
    partial class frmRBCreate : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        private string RBCC;          //成本中心编号
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        /// <summary>
        /// 手机自带返回键操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRBCreate_KeyDown(object sender, KeyDownEventArgs e)
        {
            if(e.KeyCode==KeyCode.Back)
            {
                Close();
            }
        }
        /// <summary>
        /// 窗体初始化加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRBCreate_Load(object sender, EventArgs e)
        {        
            try
            {
                Bind();        //数据加载
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// Bind方法
        /// </summary>
        private void Bind()
        {
            try
            {
                //将用户的未报销消费记录显示出来
                DataTable table = new DataTable();
                table.Columns.Add("ID", typeof(System.Int32));
                table.Columns.Add("RBROW_DATE", typeof(System.String));
                table.Columns.Add("RBROW_TYPE", typeof(System.String));
                table.Columns.Add("RBROW_TYPENAME", typeof(System.String));
                table.Columns.Add("RBROW_AMOUNT", typeof(System.Decimal));
                table.Columns.Add("RBROW_NOTE", typeof(System.String));
                //用户的未报销消费记录
                List<RB_RowsDto> Rows = AutofacConfig.rBService.GetRowsByCreateUser(Client.Session["U_ID"].ToString());
                foreach (RB_RowsDto Row in Rows)
                {
                    string TypeName = AutofacConfig.rBService.GetTypeNameByID(Row.R_TypeID);
                    table.Rows.Add(Row.R_ID, Row.R_ConsumeDate.ToString("yyyy/MM/dd"), Row.R_TypeID, TypeName, Row.R_Amount, Row.R_Note);
                }
                listRBRowData.Rows.Clear();//清空报销单行项列表数据
                if (table.Rows.Count > 0)
                {
                    this.listRBRowData.DataSource = table;
                    this.listRBRowData.DataBind();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 成本中心选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void btnRBCC_Press(object sender, EventArgs e)
        {
            try
            {
                frmRBCostCenter frmCostCenter = new frmRBCostCenter();           //跳转到成本中心界面
                this.Show(frmCostCenter, (MobileForm sender1, object args) =>
                {
                    try
                    {
                        //如果成本中心选择成功
                        if (frmCostCenter.ShowResult == ShowResult.Yes)
                        {
                            string CCID = frmCostCenter.CCID;         //  CCID的值为成本中心编号/名称
                            string[] CCS = CCID.Split(new char[] { '/' });
                            RBCC = CCS[0];                       //成本中心编号              
                            this.btnRBCC.Text = CCS[1]+ "   > ";          //成本中心名称
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
        /// 更新全选状态
        /// </summary>
        public void upCheckState()
        {
            int selectUserQty = 0;      //设置当前选中行项为0
            foreach (ListViewRow Row in listRBRowData.Rows)
            {
                frmRBCreateLayout layout = Row.Control  as frmRBCreateLayout;
                int num=layout.checkNum();
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
                    frmRBCreateLayout layout = Row.Control as frmRBCreateLayout;
                    decimal num = layout.getNum();       //获取选中行消费数量
                    sumAmount += num;
                }
                //将计算出来的选中的消费记录总金额显示在底部
                lblAmount.Text= "￥" + sumAmount.ToString(); 
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 全选或全不选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Checkall_CheckedChanged(object sender, EventArgs e)
        {
            foreach (ListViewRow Row in listRBRowData.Rows)
            {
                frmRBCreateLayout Layout = Row.Control as frmRBCreateLayout;
                Layout.setCheck(Checkall.Checked);
            }
            getAmount();      //计算报销单总金额
        }
        /// <summary>
        /// 创建消费记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Press(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(RBCC))     //判断成本中心是否已经选择
                {
                    throw new Exception("请选择成本中心！");
                }
                else
                {
                    RBInputDto RB = new RBInputDto();       //定义一个新的报销单
                    RB.CC_ID = RBCC;             //成本中心编号
                    RB.RB_Note = this.TxtNote.Text;            //报销单备注
                    //将选中的消费记录行项添加到报销单中
                    foreach (ListViewRow Row in listRBRowData.Rows)
                    {
                        frmRBCreateLayout layout = Row.Control as frmRBCreateLayout;
                        //如果当前行项消费记录被选中
                        if (layout.checkNum()==1)
                        {
                            //把选中行的消费记录行项的数据添加到报销单中
                            int RID = layout.getID();
                            RB_RowsDto RBRow = AutofacConfig.rBService.GetRowByRowID(RID);
                            RB_RowsInputDto NewRBRow = new RB_RowsInputDto();
                            NewRBRow.R_ID = RBRow.R_ID;              //消费记录编号
                            NewRBRow.R_TypeID = RBRow.R_TypeID;           //消费类型编号
                            NewRBRow.R_Amount = RBRow.R_Amount;            //消费记录金额
                            NewRBRow.R_Note = RBRow.R_Note;                //消费记录日期
                            NewRBRow.R_ConsumeDate = RBRow.R_ConsumeDate;           //消费日期
                            RB.RB_Rows.Add(NewRBRow);
                        }
                    }
                    RB.RB_CreateUser = Client.Session["U_ID"].ToString();               //创建用户
                    ReturnInfo r = AutofacConfig.rBService.CreateRB(RB);
                    if (r.IsSuccess == true)
                    {
                        //如果数据库添加报销记录成功
                        this.ShowResult = ShowResult.Yes;
                        this.Close();
                        Toast("报销提交成功！");
                    }
                    else
                    {
                        throw new Exception(r.ErrorInfo);
                    }
                }
            }
            catch(Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}