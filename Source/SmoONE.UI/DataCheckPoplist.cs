using SmoONE.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SmoONE.UI
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler 
    // 创建时间： 2016/11
    // 主要内容：  我审批的筛选数据
    // ******************************************************************
   public  class DataCheckPoplist
    {
        /// <summary>
        /// 待审批或已审批筛选分组
        /// </summary>
        /// <returns></returns>
        public DataTable GetPopGroup()
        {
            DataTable table = new DataTable();
            table.Columns.Add ("GroupID", typeof(System.Int32));
            table.Columns.Add("GroupName", typeof(System.String));
            DataRow dr1 = table.NewRow();
            dr1["GroupID"] = (int)Enum.Parse(typeof(DataGridviewType), DataGridviewType.请假.ToString());
            dr1["GroupName"] = DataGridviewType.请假;
            table.Rows.Add(dr1);

            DataRow dr2 = table.NewRow();
            dr2["GroupID"] = (int)Enum.Parse(typeof(DataGridviewType), DataGridviewType.报销.ToString());
            dr2["GroupName"] = DataGridviewType.报销;
            table.Rows.Add(dr2);
            return table;
        }
        /// <summary>
        /// 待审批筛选分组项状态
        /// </summary>
        /// <returns></returns>
        public DataTable GetPendingCheckPopItem()
        {
            DataTable table = new DataTable();
            table.Columns.Add("PopItemID", typeof(System.String));
            table.Columns.Add("PopItemName", typeof(System.String));
            table.Columns.Add("ParentID", typeof(System.String));
            table.Columns.Add("Status", typeof(System.Int32));
            int  nrow = 0;
            DataRow dr1 = table.NewRow();
            nrow += 1;
            dr1["PopItemID"] = nrow;
            dr1["PopItemName"] = "待审批";
            dr1["ParentID"] = (int)Enum.Parse(typeof(DataGridviewType), DataGridviewType.请假.ToString());
            dr1["Status"] = (int)Enum.Parse(typeof(L_Status), L_Status.新建.ToString());
            table.Rows.Add(dr1);

            DataRow dr2 = table.NewRow();
            nrow += 1;
            dr2["PopItemID"] = nrow;
            dr2["PopItemName"] = "待责任人审批";
            dr2["ParentID"] = (int)Enum.Parse(typeof(DataGridviewType), DataGridviewType.报销.ToString());
            dr2["Status"] = (int)Enum.Parse(typeof(RB_Status), RB_Status.新建.ToString());
            table.Rows.Add(dr2);

            DataRow dr3 = table.NewRow();
            nrow += 1;
            dr3["PopItemID"] = nrow;
            dr3["PopItemName"] = "待行政人审批";
            dr3["ParentID"] = (int)Enum.Parse(typeof(DataGridviewType), DataGridviewType.报销.ToString());
            dr3["Status"] =  (int)Enum.Parse(typeof(RB_Status), RB_Status.责任人审批.ToString());
            table.Rows.Add(dr3);

            DataRow dr4 = table.NewRow();
            nrow += 1;
            dr4["PopItemID"] = nrow;
            dr4["PopItemName"] = "待财务人审批";
            dr4["ParentID"] = (int)Enum.Parse(typeof(DataGridviewType), DataGridviewType.报销.ToString());
            dr4["Status"] =  (int)Enum.Parse(typeof(RB_Status), RB_Status.行政审批.ToString());
            table.Rows.Add(dr4);
            return table;
        }

        /// <summary>
        /// 已审批筛选分组项状态
        /// </summary>
        /// <returns></returns>
        public DataTable GetCheckPopItem()
        {
            DataTable table = new DataTable();
            table.Columns.Add("PopItemID", typeof(System.String));
            table.Columns.Add("PopItemName", typeof(System.String));
            table.Columns.Add("ParentID", typeof(System.String));
            table.Columns.Add("Status", typeof(System.String));
            int nrow = 0;
            DataRow dr1 = table.NewRow();
            nrow += 1;
            dr1["PopItemID"] = nrow;
           dr1["PopItemName"] = "请假已审批";
           dr1["ParentID"] = (int)Enum.Parse(typeof(DataGridviewType), DataGridviewType.请假.ToString());
           dr1["Status"] = (int)Enum.Parse(typeof(L_Status), L_Status.已审批.ToString());
           table.Rows.Add(dr1);

           DataRow dr2= table.NewRow();
            nrow += 1;
            dr2["PopItemID"] = nrow;
            dr2["PopItemName"] = "请假已拒绝";
            dr2["ParentID"] = (int)Enum.Parse(typeof(DataGridviewType), DataGridviewType.请假.ToString());
            dr2["Status"] = (int)Enum.Parse(typeof(L_Status), L_Status.已拒绝.ToString());
            table.Rows.Add(dr2);

            DataRow dr3 = table.NewRow();
            nrow += 1;
            dr3["PopItemID"] = nrow;
            dr3["PopItemName"] = "报销责任人已审批";
            dr3["ParentID"] = (int)Enum.Parse(typeof(DataGridviewType), DataGridviewType.报销.ToString());
            dr3["Status"] = (int)Enum.Parse(typeof(RB_Status), RB_Status.责任人审批.ToString());
            table.Rows.Add(dr3);

            DataRow dr4 = table.NewRow();
            nrow += 1;
            dr4["PopItemID"] = nrow;
            dr4["PopItemName"] = "报销行政人已审批";
            dr4["ParentID"] = (int)Enum.Parse(typeof(DataGridviewType), DataGridviewType.报销.ToString());
            dr4["Status"] = (int)Enum.Parse(typeof(RB_Status), RB_Status.行政审批.ToString());
            table.Rows.Add(dr4);

            DataRow dr5 = table.NewRow();
            nrow += 1;
            dr5["PopItemID"] = nrow;
            dr5["PopItemName"] = "报销财务人已审批";
            dr5["ParentID"] = (int)Enum.Parse(typeof(DataGridviewType), DataGridviewType.报销.ToString());
            dr5["Status"] = (int)Enum.Parse(typeof(RB_Status), RB_Status.财务审批.ToString());
            table.Rows.Add(dr5);

            DataRow dr6 = table.NewRow();
            nrow += 1;
            dr6["PopItemID"] = nrow;
            dr6["PopItemName"] = "报销已拒绝";
            dr6["ParentID"] = (int)Enum.Parse(typeof(DataGridviewType), DataGridviewType.报销.ToString());
            dr6["Status"] = (int)Enum.Parse(typeof(RB_Status), RB_Status.已拒绝.ToString());
            table.Rows.Add(dr6);
            return table;
        }
    }
}
