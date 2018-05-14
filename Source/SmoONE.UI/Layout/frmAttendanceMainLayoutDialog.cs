using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SmoONE.DTOs;
using SmoONE.CommLib;
using SmoONE.UI.Attendance;

namespace SmoONE.UI.Layout
{
    // ******************************************************************
    // 文件版本： SmoONE 1.1
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2017/2
    // 主要内容： 考勤签到原因填写界面
    // ******************************************************************
    partial class frmAttendanceMainLayoutDialog : Smobiler.Core.Controls.MobileUserControl
    {
        #region "definition"
        public ALInputDto newLog = new ALInputDto();     //新建日志传输对象
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类     
        public bool ShowResult = false;   //是否提交
        #endregion
        /// <summary>
        /// 提交签到记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Press(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtReason.Text) == true)         //原因不能为空
                {
                    throw new Exception(this.lblTitle + "不能为空");
                }
                newLog.AL_Reason = this.txtReason.Text;           //迟到早退原因
                ReturnInfo r = AutofacConfig.attendanceService.AddAttendanceLog(newLog);
                if (r.IsSuccess == true)               //提交记录成功
                {
                    ShowResult = true;
                    this.Close();
                    if (lblTitle.Text == "迟到理由")
                    {
                        this.Form.Toast("签到成功");
                    }
                    else
                    {
                        this.Form.Toast("签退成功");
                    }
                    ((frmAttendanceMain)(Form)).Bind();                     //刷新页面
                }
                else
                {
                    throw new Exception(r.ErrorInfo);
                }
            }
            catch (Exception ex)
            {
                this.Form.Toast(ex.Message);
            }
        }
        /// <summary>
        /// 关闭当前弹出框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Press(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}