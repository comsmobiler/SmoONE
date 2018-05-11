using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SmoONE.DTOs;

namespace SmoONE.UI.Attendance
{
    // ******************************************************************
    // 文件版本： SmoONE 1.1
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2017/2
    // 主要内容： 考勤模板列表界面
    // ******************************************************************
    partial class frmAttendanceManager : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        /// <summary>
        /// 标题栏图片按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAttendanceManager_TitleImageClick(object sender, EventArgs e)
        {
            Close();
        }
       
        /// <summary>
        /// 获取初始化数据
        /// </summary>
        public  void Bind()
        {
            List<ATDto> listATDto = AutofacConfig.attendanceService.GetAll();
            gridATData.Rows.Clear();//清除考勤模板列表数据
            //如果考勤模板数据条数大于0
            if (listATDto.Count > 0)
            {
                List<AttendanceManager> listAT = new List<AttendanceManager>();
                foreach (ATDto at in listATDto)
                {
                    AttendanceManager atManager = new AttendanceManager();
                    atManager.AT_ID = at.AT_ID;
                    atManager.AT_Name = at.AT_Name;
                    atManager.AT_CommutingType = at.AT_CommutingType;
                    atManager.AT_WeeklyWorkingDay = atManager.getWeekDesc(at.AT_WeeklyWorkingDay);
                    switch ((WorkTimeType)Enum.Parse(typeof(WorkTimeType), at.AT_CommutingType))
                    {
                        case WorkTimeType.一天一上下班:
                            atManager.WorkDate = "上班：" + Convert.ToDateTime(at.AT_StartTime).ToString("HH:mm") + "    下班：" + Convert.ToDateTime(at.AT_EndTime).ToString("HH:mm");
                            break;
                        case WorkTimeType.一天二上下班:
                            atManager.WorkDate = "上午上班：" + Convert.ToDateTime(at.AT_AMStartTime).ToString("HH:mm") + "    上午下班：" + Convert.ToDateTime(at.AT_AMEndTime).ToString("HH:mm");
                            atManager.WorkDate1 = "下午上班：" + Convert.ToDateTime(at.AT_PMStartTime).ToString("HH:mm") + "    下午下班：" + Convert.ToDateTime(at.AT_PMEndTime).ToString("HH:mm");
                            break;
                    }
                    atManager.AT_EffectiveDesc = at.AT_EffectiveDate.ToString ("yyyy年MM月dd日")+"考勤生效";
                    listAT.Add(atManager);
                }
                gridATData.DataSource = listAT;
                gridATData.DataBind();
            }
        }
        /// <summary>
        /// 手机自带回退按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAttendanceManager_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                Close();         //关闭当前页面
            }
        }
        /// <summary>
        /// 跳转到创建考勤界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmAttendanceCreate frm = new frmAttendanceCreate();
            Show(frm, (MobileForm form, object args) =>
            {
                if (frm.ShowResult == ShowResult.Yes)
                {
                    Bind();
                }
            });
        }
        /// <summary>
        /// 页面加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAttendanceManager_Load(object sender, EventArgs e)
        {
            Bind();
        }
    }
}