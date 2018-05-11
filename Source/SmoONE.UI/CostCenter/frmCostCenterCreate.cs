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
    // 主要内容：  成本中心创建编辑界面
    // ******************************************************************
    partial class frmCostCenterCreate : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        public string ATNO;//考勤模板编号
        public string CCID ;//成本中心编号
        string type = "";//类型
        string CTempID = "";//类型模板编号
        string liableMan = "";//责任人
        string D_ID = "";//部门编号
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        /// <summary>
        /// 类型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btntype_Click(object sender, EventArgs e)
        {
            popType.Groups.Clear();
            PopListGroup poli = new PopListGroup();
            popType.Groups.Add(poli);
            poli.Title = "类型选择";
            //获取成本中心类型，并赋值poplist数据
            List<CostCenter_Type>  listCCType=  AutofacConfig.costCenterService.GetAllCCType();
            foreach (CostCenter_Type ccType in listCCType)
            {
                poli.AddListItem(ccType.CC_T_Description, ccType.CC_T_TypeID);
                if (type.Trim().Length > 0)
                {
                    if (type.Trim().Equals(ccType.CC_T_TypeID))
                    {
                        popType.SetSelections(poli.Items[(poli.Items.Count - 1)]);
                    }
                }
            }
            popType.ShowDialog();
        }
        /// <summary>
        /// 类型赋值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void popType_Selected(object sender, EventArgs e)
        {
            if (popType.Selection != null)
            {
                type = popType.Selection.Value;
                btnType.Text = popType.Selection.Text + "   > ";
            }
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCC_Name.Text.Trim().Length <= 0)
                {
                    throw new Exception("请输入成本中心名称！");
                }
                if (string.IsNullOrEmpty(type)==true)
                {
                    throw new Exception("请输入类型！");
                }
                if (txtAmount.Text.Trim().Length <= 0)
                {
                    throw new Exception("金额必须大于0！");
                }
                else
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(txtAmount.Text.Trim(), @"^(?!0+(?:\.0+)?$)(?:[1-9]\d*|0)(?:\.\d{1,2})?$") == false)
                    {
                        throw new Exception("金额必须为大于0的数字！");
                    }
                   
                }
                if (string.IsNullOrWhiteSpace(liableMan) == true)
                {
                    throw new Exception("请输入责任人！");
                }
                if (string.IsNullOrWhiteSpace(CTempID) == true)
                {
                    throw new Exception("请输入成本中心类型模板！");
                }
                if (string.IsNullOrEmpty(D_ID) == true)
                {
                    throw new Exception("该责任人未分配部门，请去分配部门！");
                }
                //更新成本中心数据赋值
                CCInputDto cc = new CCInputDto();
                cc.CC_Name = txtCC_Name.Text.Trim();
                cc.CC_TypeID = type;
                cc.CC_StartDate = dpkStartDate.Value;
                cc.CC_EndDate = dpkEndDate.Value;
                cc.CC_Amount = Convert.ToDecimal(txtAmount.Text.Trim());
                cc.CC_LiableMan = liableMan;
                cc.CC_DepartmentID = D_ID;
                cc.CC_TemplateID = CTempID;
                ReturnInfo result;
                if (string.IsNullOrEmpty(CCID) == false )
                {
                    cc.CC_ID = CCID;
                    cc.CC_UpdateUser = Client.Session["U_ID"].ToString();
                    //更新成本中心
                    result = AutofacConfig.costCenterService.UpdateCostCenter(cc);
                }
                else
                {
                    cc.CC_CreateUser = Client.Session["U_ID"].ToString();
                    //创建成本中心
                    result = AutofacConfig.costCenterService.AddCostCenter(cc);
                }
                //如果返回true，则创建或更新成本中心成功，否则失败并抛出错误
                if (result.IsSuccess == false)
                {
                    throw new Exception(result.ErrorInfo);
                }
                else
                {
                    ShowResult = ShowResult.Yes;
                    //if (string.IsNullOrEmpty(CCID) == true)
                    //{
                        Close();
                    //}
                    Toast("成本中心提交成功！", ToastLength.SHORT);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }
        }
        /// <summary>
        /// 初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCostCenterCreate_Load(object sender, EventArgs e)
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
                //成本中心编号不为空时，成本中心数据
                if (CCID != null)
                {
                    //根据成本中心编号获取成本中心信息
                    CCDetailDto cc = AutofacConfig.costCenterService.GetCCByID(CCID);
                    txtCC_Name.Text = cc.CC_Name;
                    type = cc.CC_TypeID;
                    btnType.Text = cc.CC_TypeName;
                    dpkStartDate.Value = cc.CC_StartDate;
                    dpkEndDate.Value = cc.CC_EndDate;
                    txtAmount.Text = cc.CC_Amount.ToString();
                    liableMan = cc.CC_LiableMan;
                    UserDetailDto user = AutofacConfig.userService.GetUserByUserID(cc.CC_LiableMan);
                    btnLiableMan.Text = user.U_Name;
                    D_ID = cc.CC_DepartmentID;
                    lblDep.Text = cc.CC_DepName;
                    CTempID = cc.CC_TemplateID;
                    btnTemplate.Text = cc.CC_TemplateID;
                }
                else
                {
                    DateTime t = DateTime.Now;
                    dpkEndDate.Value = t.AddYears(1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 跳转到模板界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTemplate_Click(object sender, EventArgs e)
        {
            //跳转到模板界面
            frmCostTemplet frm = new frmCostTemplet();
            frm.IsSelectCTemPlet = true;
            Show(frm, (MobileForm form, object args) =>
               {
                   if (frm.ShowResult == Smobiler.Core.Controls .ShowResult.Yes)
                   {
                       CTempID = frm.CTempID;
                       btnTemplate.Text = frm.CTempID + "   > ";
                   }
               });
        }
        /// <summary>
        /// 选择责任人
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLiableMan_Click(object sender, EventArgs e)
        {
            popLiable.Groups.Clear();
            PopListGroup poli = new PopListGroup();
            popLiable.Groups.Add(poli);
            poli.Title = "责任人选择";
            //获取责任人数据，并赋值poplist数据
            List<UserDto> listuser = AutofacConfig.userService.GetAllUsers();
            foreach (UserDto user in listuser)
            {
                poli.AddListItem(user.U_Name, user.U_ID);
                if (liableMan.Trim().Length > 0)
                {
                    if (liableMan.Trim().Equals(user.U_ID))
                    {
                        popLiable.SetSelections(poli.Items[(poli.Items.Count - 1)]);
                    }
                }
            }
            popLiable.Show();
        }

        /// <summary>
        /// 控件赋值责任人
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void popLiable_Selected(object sender, EventArgs e)
        {
            if (popLiable.Selection != null)
            {
                liableMan = popLiable.Selection.Value;
                btnLiableMan.Text = popLiable.Selection.Text + "   > ";
               UserDepDto user= AutofacConfig.userService.GetUseDepByUserID(liableMan);
               D_ID = user.Dep_ID;
               lblDep.Text =user.Dep_Name;
                
            }
        }
        /// <summary>
        /// 手机自带回退按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCostCenterCreate_KeyDown(object sender, KeyDownEventArgs e)
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
        private void frmCostCenterCreate_TitleImageClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}