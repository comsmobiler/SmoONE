using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SmoONE.UI;
using SmoONE.DTOs;
using SmoONE.CommLib;

namespace SmoONE.UI.RB
{
    // ******************************************************************
    // 文件版本： SmoONE 2.0
    // Copyright  (c)  2017-2018 Smobiler 
    // 创建时间： 2017/07
    // 主要内容：  消费模板创建或编辑界面
    // ******************************************************************
    partial class frmRTypeTempCreate : Smobiler.Core.Controls.MobileForm
    {
        #region "Properties"
        internal string ID;                 //消费模板编号
        private string TYPEID;              //消费类型编号
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        /// <summary>
        /// 消费类型选择按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRBType_Press(object sender, EventArgs e)
        {
            try
            {
                frmRTypeChoose frm = new frmRTypeChoose();
                this.Show(frm, (MobileForm sender1, object args) =>
                {
                    try
                    {
                        if (frm.ShowResult == ShowResult.Yes)
                        {
                            string TYPEIDs = frm.TYPEID;
                            if (TYPEIDs.Length > 0)
                            {
                                string[] types = TYPEIDs.Split(new char[] { '/' });
                                TYPEID = types[0];               //消费类型编号
                                this.btnRBType.Text = types[1] + "   > ";  //消费类型名称
                            }
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
        /// 消费模板创建或者保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Press(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtMoney.Text))
                {
                    throw new Exception("请输入消费金额！");
                }
                else
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(txtMoney.Text.Trim(), @"^(?!0+(?:\.0+)?$)(?:[1-9]\d*|0)(?:\.\d{1,2})?$") == false)
                    {
                        throw new Exception("金额必须为大于0的数字！");
                    }
                }
                if (string.IsNullOrEmpty(TYPEID))
                {
                    throw new Exception("请选择消费类别！");
                }
                if (string.IsNullOrEmpty(this.txtNote.Text))
                {
                    throw new Exception("请输入备注！");
                }
                RBRTTInputDto RBModel = new RBRTTInputDto();                    //定义一个报销单
                RBModel.RB_RTT_Amount = Convert.ToDecimal(this.txtMoney.Text);             //消费金额
                RBModel.RB_RTT_TypeID = TYPEID;                             //消费类别
                RBModel.RB_RTT_Note = this.txtNote.Text;                       //消费备注
                if (string.IsNullOrWhiteSpace(ID) == false)
                {
                    RBModel.RB_RTT_TemplateID = ID;
                    ReturnInfo r = AutofacConfig.rBService.UpdateRB_Type_Template(RBModel);           //更新消费模板信息
                    if (r.IsSuccess == true)
                    {
                        this.ShowResult = ShowResult.Yes;
                        this.Close();
                        Toast("消费模板修改成功");
                    }
                    else
                    {
                        throw new Exception(r.ErrorInfo);
                    }
                }
                else
                {
                    RBModel.RB_RTT_CreateUser = Client.Session["U_ID"].ToString();                           //模板创建用户
                    ReturnInfo r = AutofacConfig.rBService.CreateRB_Type_Template(RBModel);
                    if (r.IsSuccess == true)
                    {
                        this.ShowResult = ShowResult.Yes;
                        this.Close();
                        Toast("消费模板提交成功！");
                    }
                    else
                    {
                        throw new Exception(r.ErrorInfo);
                    }
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 消费模板删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Press(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("是否确定删除消费模板？", MessageBoxButtons.YesNo, (Object s1, MessageBoxHandlerArgs args1) =>
                {
                    if (args1.Result == Smobiler.Core.Controls.ShowResult.Yes)
                    {
                        ReturnInfo r = AutofacConfig.rBService.DeleteRB_Type_Template(ID);
                        if (r.IsSuccess == true)
                        {
                            this.ShowResult = ShowResult.Yes;
                            this.Close();
                            Toast("删除消费模板成功");
                        }
                        else
                        {
                            throw new Exception(r.ErrorInfo);
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 手机自带返回键操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRTypeTempCreate_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                this.Close();         //关闭当前页面
            }
        }
        /// <summary>
        /// 初始化页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRTypeTempCreate_Load(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ID) == false)
                {
                    RB_RType_TemplateDto RBRTypeTem = AutofacConfig.rBService.GetTemplateByTemplateID(ID);
                    string RBType = AutofacConfig.rBService.GetTypeNameByID(RBRTypeTem.RB_RTT_TypeID);
                    this.txtMoney.Text = RBRTypeTem.RB_RTT_Amount.ToString();
                    TYPEID = RBRTypeTem.RB_RTT_TypeID;       //消费模板编号
                    this.btnRBType.Text = RBType;
                    this.txtNote.Text = RBRTypeTem.RB_RTT_Note;
                    title.TitleText = "消费模板";
                }
                else
                {
                    title.TitleText = "消费模板创建";
                    this.btnDelete.Visible = false;
                    btnSave.Width = 280;
                    btnSave.Left = 10;
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}