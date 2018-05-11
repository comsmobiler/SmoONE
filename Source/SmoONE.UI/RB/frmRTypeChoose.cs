using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;
using SmoONE.UI;

namespace SmoONE.UI.RB
{
    // ******************************************************************
    // 文件版本： SmoONE 2.0
    // Copyright  (c)  2017-2018 Smobiler 
    // 创建时间： 2017/07
    // 主要内容：  消费类型选择列表
    // ******************************************************************
    partial class frmRTypeChoose : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        internal string TYPEID;                //消费类型编号
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        /// <summary>
        /// 手机自带回退按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRTypeChoose_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                this.Close();         //关闭当前页面
            }
        }
        /// <summary>
        /// 初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRTypeChoose_Load(object sender, EventArgs e)
        {
            Bind();//绑定数据库数据操作
        }
        /// <summary>
        /// 初始化方法
        /// </summary>
        /// <remarks></remarks>
        private void Bind()
        {
            try
            {
                //显示数据报销类型
                List<SmoONE.Domain.RB_RType> Types = AutofacConfig.rBService.GetAllType();
                DataTable typetable = new DataTable();
                typetable.Columns.Add("TYPE", typeof(System.String));          //消费类型编号
                typetable.Columns.Add("TYPENAME", typeof(System.String));      //消费类型名称
                foreach (SmoONE.Domain.RB_RType row in Types)
                {
                    typetable.Rows.Add(row.RB_RT_ID, row.RB_RT_Name);
                }
                this.listRBRowTypeData.Rows.Clear();//清空消费类型选择列表数据
                if (typetable.Rows.Count > 0)
                {
                    this.listRBRowTypeData.DataSource = typetable;
                    this.listRBRowTypeData.DataBind();
                }

            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}