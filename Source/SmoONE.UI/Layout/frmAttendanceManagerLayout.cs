using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace SmoONE.UI.Layout
{
    // ******************************************************************
    // 文件版本： SmoONE 1.1
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2017/2
    // 主要内容： 考勤模板列表模板
    // ******************************************************************
    partial class frmAttendanceManagerLayout : Smobiler.Core.Controls.MobileUserControl
    {
        /// <summary>
        /// 跳转到考勤编辑界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_Press(object sender, EventArgs e)
        {

            try
            {
                string ID = lblId.BindDataValue.ToString();
                SmoONE.UI.Attendance.frmAttendanceCreate frmAttendanceCreate = new SmoONE.UI.Attendance.frmAttendanceCreate();
                frmAttendanceCreate.ATNo = ID;
                this.Form.Show(frmAttendanceCreate, (MobileForm form, object args) =>
                {
                    if (frmAttendanceCreate.ShowResult == ShowResult.Yes)
                    {
                        ((SmoONE.UI.Attendance.frmAttendanceManager)this.Form).Bind();
                    }
                });

            }
            catch (Exception ex)
            {
                this.Form.Toast(ex.Message, ToastLength.SHORT);
            }
        }
    }
}