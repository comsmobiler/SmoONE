using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;

namespace SmoONE.UI.FileUp
{
    partial class frmFileDetail : Smobiler.Core.Controls.MobileForm
    {
        private void frmFileDetail_Load(object sender, EventArgs e)
        {
            Bind();
        }
        /// <summary>
        /// 删除列表行项
        /// </summary>
        /// <param name="row"></param>
        internal void RemoveRow(ListViewRow row)
        {
            this.listView1 .Rows.Remove(row);
            this.Toast("文件已删除！");
        }
        public void Bind()
        {

            try
            {
                listView1.Rows.Clear();//清理数据

                this.Client.File.List((obj, args) =>
                {
                    Smobiler.Core.RPC.FileListArgs.FileListData[] filelist = args.Lists;
                    if (filelist.Length > 0)
                    {
                        DataTable table = new DataTable();
                        table.Columns.Add("FImg", typeof(System.String));
                        table.Columns.Add("FileName", typeof(System.String));
                        foreach (Smobiler.Core.RPC.FileListArgs.FileListData filedata in filelist)
                        {
                            DataRow row = table.NewRow();
                            switch (filedata.Name.Split('.')[1])
                            {
                                case "doc":
                                    row["FImg"] = "word";
                                    break;
                                case "xls":
                                    row["FImg"] = "Excel";
                                    break;
                                case "ppt":
                                    row["FImg"] = "ppt";
                                    break;
                                case "rar":
                                    row["FImg"] = "zip";
                                    break;
                            }
                            row["FileName"] = filedata.Name;
                            table.Rows.Add(row);
                        }
                        listView1.DataSource = table;
                        listView1.DataBind();
                    }
                });
            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }

        }
    }
}