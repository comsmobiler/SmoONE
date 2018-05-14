using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SmoONE.DTOs;
using SmoONE.CommLib;

namespace SmoONE.UI.Attendance
{
    // ******************************************************************
    // 文件版本： SmoONE 1.1
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2017/2
    // 主要内容： 考勤签到原因填写界面
    // ******************************************************************
    partial class frmAttendanceMainLayoutDialog : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        public ALInputDto newLog = new ALInputDto();     //新建日志传输对象
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类     
        #endregion
        /// <summary>
        /// 提交签到记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(this.txtReason.Text)==true)         //原因不能为空
                {
                    throw new Exception(this.title1 .TitleText+"不能为空");
                }
                newLog.AL_Reason = this.txtReason.Text;           //迟到早退原因
                ReturnInfo r = AutofacConfig.attendanceService.AddAttendanceLog(newLog);
                if (r.IsSuccess == true)               //提交记录成功
                {
                    this.ShowResult =Smobiler.Core.Controls .ShowResult.Yes;
                    this.Close();
                    if(this.title1 .TitleText=="迟到理由")
                    {
                        Toast("签到成功"); 
                    }
                    else
                    {
                        Toast("签退成功");
                    }                   
                }
                else
                {
                    throw new Exception(r.ErrorInfo);
                }
            }
            catch(Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 手机自带返回键操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAttendanceMainLayoutDialog_KeyDown(object sender, KeyDownEventArgs e)
        {
            if(e.KeyCode==KeyCode.Back)
            {
                Close();
            }
        }
        /// <summary>
        /// 左上角返回键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAttendanceMainLayoutDialog_TitleImageClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}