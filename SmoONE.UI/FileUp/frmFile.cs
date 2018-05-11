using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;

namespace SmoONE.UI.FileUp
{
    partial class frmFile : Smobiler.Core.Controls.MobileForm
    {
        /// <summary>
        /// 加载数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmFile_Load(object sender, EventArgs e)
        {
            Bind();
        }

        private void Bind()
        {
            try
            {
                listView1.Rows.Clear();//清理数据
                DataTable table = new DataTable();
                table.Columns.Add("FImg", typeof(System.String));
                table.Columns.Add("FileName", typeof(System.String));
                table.Rows.Add("word", "成绩单.doc");
                table.Rows.Add("Excel", "资产.xls");
                table.Rows.Add("ppt", "SombilerApp.ppt");
                table.Rows.Add("zip", "1.rar");
                listView1.DataSource = table;
                listView1.DataBind ();

            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }
        }

        /// <summary>
        /// 手机上文件清单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFile_Press(object sender, EventArgs e)
        {
            try
            {
                //调用文件清单
                frmFileDetail frmFileDetail = new frmFileDetail();
                this.Show(frmFileDetail);

            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }
        }
    }
}