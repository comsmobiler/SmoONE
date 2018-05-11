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
    // 主要内容：  性别
    // ******************************************************************
    class UserSex
    {
        /// <summary>
        /// 获取性别
        /// </summary>
        /// <returns></returns>
        public DataTable GetSex()
        {
            DataTable table = new DataTable();
            table.Columns.Add("SexID", typeof(System.Int32));
            table.Columns.Add("SexName", typeof(System.String));
            DataRow dr1 = table.NewRow();
            dr1["SexID"] = (int)Enum.Parse(typeof(Sex), Sex.男.ToString());
            dr1["SexName"] = Sex.男;
            table.Rows.Add(dr1);

            DataRow dr2 = table.NewRow();
            dr2["SexID"] = (int)Enum.Parse(typeof(Sex), Sex.女.ToString());
            dr2["SexName"] = Sex.女;
            table.Rows.Add(dr2);
            return table;
        }
    }
}
