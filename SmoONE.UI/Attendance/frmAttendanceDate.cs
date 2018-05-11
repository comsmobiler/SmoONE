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
    // 主要内容： 考勤模板工作日期选择界面
    // ******************************************************************
    partial class frmAttendanceDate : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        public string ATNo;//考勤模板编号
        public string weekdays;//考勤日期
        public AttendanceWorkDate atWorkDate;//考勤时间
        public List<AT_CDInputDto> listatcdInput;//自定义考勤日期
        #endregion
        /// <summary>
        /// 初始化方法
        /// </summary>
        private void Bind()
        {
            if (string.IsNullOrEmpty(weekdays) == false )
            {
                 string [] weeks =weekdays.Split (',');
                foreach (string day in weeks)
                {
                    radioDate.SetRadioButtonCheckedByID(day);
                  
                }
            }
        }
        /// <summary>
        /// 跳转到自定义日期界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pCalendar_Press(object sender, EventArgs e)
        {
            try
            {
                bool isOpenAt = false;//是否开启考勤
                switch (atWorkDate .AT_Type )
                {
                    case WorkTimeType.一天一上下班:
                        if (Convert.IsDBNull(atWorkDate.AT_StartTime) == false || Convert.IsDBNull(atWorkDate.AT_EndTime) == false)
                        {

                            isOpenAt = true;
                        }
                        break;
                    case WorkTimeType.一天二上下班:
                        if (Convert.IsDBNull(atWorkDate.AT_AMStartTime) == false || Convert.IsDBNull(atWorkDate.AT_AMEndTime) == false || Convert.IsDBNull(atWorkDate.AT_PMStartTime) == false || Convert.IsDBNull(atWorkDate.AT_PMEndTime) == false)
                        {
                            isOpenAt = true;
                        }
                        break;
                }
                if (isOpenAt == true)
                {
                    frmAttendanceCalendarSetting frm = new frmAttendanceCalendarSetting();
                    if (string.IsNullOrEmpty(ATNo) == false)
                    {
                        frm.ATNo = ATNo;
                    }
                    frm.weekdays = weekdays;
                    frm.atWorkDate = atWorkDate;
                    frm.listatcdInput = listatcdInput;
                    Show(frm, (MobileForm form, object args) =>
                    {
                        if (frm.ShowResult == ShowResult.Yes)
                        {
                            ShowResult = ShowResult.Yes;
                            listatcdInput = frm.listatcdInput;
                            if (listatcdInput.Count > 0)
                            {
                                List<AT_CDInputDto> listdeleteSetting = new List<AT_CDInputDto>();//需要删除的自定义日期集合
                                foreach (AT_CDInputDto atcdInput in listatcdInput)
                                {
                                    //如果自定义日期与考勤工作日期自定义类型相同和考勤时间相同时，删除该自定义考勤
                                    bool isdeleteSetting = false;
                                    int selectday = (int)Enum.Parse(typeof(Week), atcdInput.AT_CD_Date.DayOfWeek.ToString());//获取选中日期是某个星期的第几天
                                    WorkOrRest selectdateType;
                                    //如果当前自定义日期在考勤工作日期中，则自定义日期类型为上班，否则为休息
                                    if (weekdays.Split(',').Contains(selectday.ToString()) == true)
                                    {
                                        selectdateType = WorkOrRest.上班;
                                    }
                                    else
                                    {
                                        selectdateType = WorkOrRest.休息;
                                    }
                                    if (atcdInput.AT_CD_CommutingType == atWorkDate.AT_Type)
                                    {
                                        if (selectdateType == atcdInput.AT_CD_CDType)
                                        {
                                            switch (atcdInput.AT_CD_CDType )
                                            {
                                                case  WorkOrRest.休息:
                                                    isdeleteSetting = true;
                                                    break;
                                                case WorkOrRest.上班:
                                                    switch (atcdInput.AT_CD_CommutingType)
                                                    {
                                                        case WorkTimeType.一天一上下班:

                                                            if (atcdInput.AT_CD_StartTime != null & (Convert.ToDateTime(atcdInput.AT_CD_StartTime).ToString("HH:mm") == Convert.ToDateTime(atWorkDate.AT_StartTime).ToString("HH:mm"))
                                                                & atcdInput.AT_CD_EndTime != null & (Convert.ToDateTime(atcdInput.AT_CD_EndTime).ToString("HH:mm") == Convert.ToDateTime(atWorkDate.AT_EndTime).ToString("HH:mm")))
                                                            {
                                                                isdeleteSetting = true;
                                                            }
                                                            break;
                                                        case WorkTimeType.一天二上下班:
                                                            if (atcdInput.AT_CD_AMStartTime != null & (Convert.ToDateTime(atcdInput.AT_CD_AMStartTime).ToString("HH:mm") == Convert.ToDateTime(atWorkDate.AT_AMStartTime).ToString("HH:mm"))
                                                                & atcdInput.AT_CD_AMEndTime != null & (Convert.ToDateTime(atcdInput.AT_CD_AMEndTime).ToString("HH:mm") == Convert.ToDateTime(atWorkDate.AT_AMEndTime).ToString("HH:mm"))
                                                                & atcdInput.AT_CD_PMStartTime != null & (Convert.ToDateTime(atcdInput.AT_CD_PMStartTime).ToString("HH:mm") == Convert.ToDateTime(atWorkDate.AT_PMStartTime).ToString("HH:mm"))
                                                                & atcdInput.AT_CD_PMEndTime != null & (Convert.ToDateTime(atcdInput.AT_CD_PMEndTime).ToString("HH:mm") == Convert.ToDateTime(atWorkDate.AT_PMEndTime).ToString("HH:mm")))
                                                            {
                                                                isdeleteSetting = true;
                                                            }
                                                            break;
                                                    }
                                                    break;
                                            }
                                        }
                                    }
                                    if (isdeleteSetting ==true )
                                    {
                                        listdeleteSetting.Add(atcdInput);
                                    }
                                }
                                if (listdeleteSetting.Count > 0)
                                {
                                    foreach (AT_CDInputDto atcdInput in listdeleteSetting)
                                    {
                                        listatcdInput.Remove(atcdInput);
                                    }
                                }
                            }
                        }
                    });
                }
                else
                {
                    throw new Exception("请先开启上班或下班考勤！");
                }
            }
            catch (Exception ex)
            {
                Toast (ex.Message , ToastLength.SHORT);
            }
        }
        /// <summary>
        /// 标题栏图片按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAttendanceDate_TitleImageClick(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// 手机自带回退按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAttendanceDate_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                Close();         //关闭当前页面
            }
        }
        /// <summary>
        /// 页面加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAttendanceDate_Load(object sender, EventArgs e)
        {
            Bind();
        }
        /// <summary>
        /// 更改日期
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioDate_ButtonPress(object sender, RadioButtonPressEventArgs e)
        {
            ShowResult = ShowResult.Yes;
            upATDate();
        }
        /// <summary>
        /// 更新日期
        /// </summary>
        private void upATDate()
        {
            weekdays = null;
            foreach (RadioButton rd in radioDate.CheckedButtons)
            {
                if (rd.Checked==true )
                {
                    if (string.IsNullOrEmpty(weekdays) == true)
                    {
                        weekdays = rd.Value.ToString();

                    }
                    else
                    {
                        weekdays += "," + rd.Value.ToString();
                    }
                }         
            }
        }

    }
}