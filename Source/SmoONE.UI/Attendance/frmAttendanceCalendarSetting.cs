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
    // 主要内容： 考勤模板自定义日期界面
    // ******************************************************************
    partial class frmAttendanceCalendarSetting : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        public string ATNo;//考勤模板编号
        public AttendanceWorkDate atWorkDate;//考勤时间
        private WorkOrRest workType;//自定义日期类型
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        public List<AT_CDInputDto> listatcdInput;//自定义考勤集合
        private AT_CDInputDto atcdInput ;//自定义考勤
        public string weekdays;//考勤日期
        #endregion
    
    
        /// <summary>
        /// 自定义考勤
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnATMode_Click(object sender, EventArgs e)
        {
            try
            {
                //如果自定义考勤（休息或考勤状态）选中日期是当前日期或当前日期前日期，则不可以自定义考勤
                if (calendar1.SelectDate.Date < DateTime.Now.AddDays(+1).Date)
                {
                    throw new Exception("当前日期不可自定义考勤！");
                }
                ShowResult = ShowResult.Yes;
                switch (workType)
                {
                    case WorkOrRest.上班:
                        workType = WorkOrRest.休息;
                        break;
                    case WorkOrRest.休息:
                        workType = WorkOrRest.上班;
                        break;
                }
                 upSettingDateType ();
            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }
        }
        /// <summary>
        /// 手机自带回退按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAttendanceCalendarSetting_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                ShowResult = ShowResult.Yes;
                Close();         //关闭当前页面
            }
        }
        /// <summary>
        /// 标题栏图片按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAttendanceCalendarSetting_TitleImageClick(object sender, EventArgs e)
        {
            ShowResult = ShowResult.Yes;
            Close();
        }
        /// <summary>
        /// 更新自定义日期
        /// </summary>
        private void upSettingDateType()
        {
            if (string.IsNullOrEmpty(ATNo) == true)
            {
                //创建考勤时，日历选中日期大于现在日期，若模板存在自定义，则显示自定义状态
                if (calendar1.SelectDate.Date >= DateTime.Now.AddDays(+1).Date)
                {
                    string startTime = null; //上班时间
                    string endTime = null;//下班时间
                    string amStartTime = null; //上午上班时间
                    string amEndTime = null;//上午下班时间
                    string pmStartTime = null; //下午上班时间
                    string pmEndTime = null;//下午下班时间

                    atcdInput = new AT_CDInputDto();
                    //考勤自定义日期
                    atcdInput.AT_CD_Date = calendar1.SelectDate.Date;
                    //考勤上下班类型
                    atcdInput.AT_CD_CommutingType = atWorkDate.AT_Type;

                    //创建考勤时，现日期之后的选中日期如果已自定义且考勤模式相等，则将自定义日期日期赋值给当前自定义日期控件
                    if (IsCATSettingDay(atcdInput.AT_CD_Date) == true)
                    {
                        foreach (AT_CDInputDto atcdInputDto in listatcdInput)
                        {
                            if (atcdInputDto.AT_CD_Date.Date.Equals(atcdInput.AT_CD_Date.Date) & atcdInputDto.AT_CD_CommutingType == atWorkDate.AT_Type & workType == WorkOrRest.上班)
                            {
                                //workType = atcdInputDto.AT_CD_CDType;
                                //上班时间
                                if (atcdInputDto.AT_CD_StartTime != null)
                                {
                                    startTime = atcdInputDto.AT_CD_StartTime.ToString();
                                }
                                else
                                {
                                    startTime = atWorkDate.AT_StartTime.ToString();
                                }
                                //下班时间
                                if (atcdInputDto.AT_CD_EndTime != null)
                                {
                                    endTime = atcdInputDto.AT_CD_EndTime.ToString();
                                }
                                else
                                {
                                    endTime = atWorkDate.AT_EndTime.ToString();
                                }
                                //上午上班时间
                                if (atcdInputDto.AT_CD_AMStartTime != null)
                                {
                                    amStartTime = atcdInputDto.AT_CD_AMStartTime.ToString();
                                }
                                else
                                {
                                    amStartTime = atWorkDate.AT_AMStartTime.ToString();
                                }
                                //上午下班时间
                                if (atcdInputDto.AT_CD_AMEndTime != null)
                                {
                                    amEndTime = atcdInputDto.AT_CD_AMEndTime.ToString();
                                }
                                else
                                {
                                    amEndTime = atWorkDate.AT_AMEndTime.ToString();
                                }
                                //下午上班时间
                                if (atcdInputDto.AT_CD_PMStartTime != null)
                                {
                                    pmStartTime = atcdInputDto.AT_CD_PMStartTime.ToString();
                                }
                                else
                                {
                                    pmStartTime = atWorkDate.AT_PMStartTime.ToString();
                                }
                                //下午下班时间
                                if (atcdInputDto.AT_CD_PMEndTime != null)
                                {
                                    pmEndTime = atcdInputDto.AT_CD_PMEndTime.ToString();
                                }
                                else
                                {
                                    pmEndTime = atWorkDate.AT_PMEndTime.ToString();
                                }
                                break;
                            }
                        }
                    }
                    else
                    {
                        //上班时间
                        if (atWorkDate.AT_StartTime != null)
                        {
                            startTime = atWorkDate.AT_StartTime.ToString();
                        }
                        //下班时间
                        if (atWorkDate.AT_EndTime != null)
                        {
                            endTime = atWorkDate.AT_EndTime.ToString();
                        }
                        //上午上班时间
                        if (atWorkDate.AT_AMStartTime != null)
                        {
                            amStartTime = atWorkDate.AT_AMStartTime.ToString();
                        }
                        //上午下班时间
                        if (atWorkDate.AT_AMEndTime != null)
                        {
                            amEndTime = atWorkDate.AT_AMEndTime.ToString();
                        }
                        //下午上班时间
                        if (atWorkDate.AT_PMStartTime != null)
                        {
                            pmStartTime = atWorkDate.AT_PMStartTime.ToString();
                        }
                        //下午下班时间
                        if (atWorkDate.AT_PMEndTime != null)
                        {
                            pmEndTime = atWorkDate.AT_PMEndTime.ToString();
                        }
                    }
                    upsettingDate(atcdInput.AT_CD_CommutingType, startTime, endTime, amStartTime, amEndTime, pmStartTime, pmEndTime);
                    atcdInput.AT_CD_CDType = workType;
                  
                }
            }
            //编辑考勤自定义日期类型
            else
            {
                //编辑考勤时，日历选中日期小于等于现在日期，若模板存在自定义，则显示自定义状态
                if (calendar1.SelectDate.Date < DateTime.Now.AddDays(+1).Date)
                {
                    WorkTimeDto atcd = AutofacConfig.attendanceService.GetASByATIDAndDate(ATNo, calendar1.SelectDate.Date);
                    if (atcd != null)
                    {
                        switch ((WorkOrRest)Enum.Parse(typeof(WorkOrRest), atcd.AT_ASType))
                        {
                            case WorkOrRest.上班:
                                switch ((WorkTimeType)Enum.Parse(typeof(WorkTimeType), atcd.AT_CommutingType))
                                {
                                    case WorkTimeType.一天一上下班:

                                        if (atcd.AT_StartTime != null)
                                        {
                                            dpStartWork.Value = Convert.ToDateTime(atcd.AT_StartTime);
                                        }

                                        if (atcd.AT_EndTime != null)
                                        {
                                            dpEndWork.Value = Convert.ToDateTime(atcd.AT_EndTime);
                                        }
                                        break;
                                    case WorkTimeType.一天二上下班:
                                        if (atcd.AT_AMStartTime != null)
                                        {
                                            dpAMStartWork.Value = Convert.ToDateTime(atcd.AT_AMStartTime);
                                        }

                                        if (atcd.AT_AMEndTime != null)
                                        {
                                            dpAMEndWork.Value = Convert.ToDateTime(atcd.AT_AMEndTime);
                                        }

                                        if (atcd.AT_PMStartTime != null)
                                        {
                                            dpPMStartWork.Value = Convert.ToDateTime(atcd.AT_PMStartTime);
                                        }

                                        if (atcd.AT_PMEndTime != null)
                                        {
                                            dpPMEndWork.Value = Convert.ToDateTime(atcd.AT_PMEndTime);
                                        }

                                        break;
                                }
                                break;
                        }
                    }
                }
                if (calendar1.SelectDate.Date >= DateTime.Now.AddDays(+1).Date)
                {
                    string startTime = null; //上班时间
                    string endTime = null;//下班时间
                    string amStartTime = null; //上午上班时间
                    string amEndTime = null;//上午下班时间
                    string pmStartTime = null; //下午上班时间
                    string pmEndTime = null;//下午下班时间

                    atcdInput = new AT_CDInputDto();
                    //考勤自定义日期
                    atcdInput.AT_CD_Date = calendar1.SelectDate.Date;
                    //考勤上下班类型
                    atcdInput.AT_CD_CommutingType = atWorkDate.AT_Type;
                    //编辑考勤时，现日期之后的选中日期如果已自定义且考勤模式相等，则将自定义日期日期赋值给当前自定义日期控件
                    if (IsCATSettingDay(atcdInput.AT_CD_Date) == true)
                    {
                        foreach (AT_CDInputDto atcdInputDto in listatcdInput)
                        {
                            if (atcdInputDto.AT_CD_Date.Date.Equals(atcdInput.AT_CD_Date.Date) & atcdInputDto.AT_CD_CommutingType == atWorkDate.AT_Type & workType==WorkOrRest .上班)
                            {
                                //workType = atcdInputDto.AT_CD_CDType;
                                //上班时间
                                if (atcdInputDto.AT_CD_StartTime != null)
                                {
                                    startTime = atcdInputDto.AT_CD_StartTime.ToString();
                                }
                                else
                                {
                                    startTime = atWorkDate.AT_StartTime.ToString();
                                }
                                //下班时间
                                if (atcdInputDto.AT_CD_EndTime != null)
                                {
                                    endTime = atcdInputDto.AT_CD_EndTime.ToString();
                                }
                                else
                                {
                                    endTime = atWorkDate.AT_EndTime.ToString();
                                }
                                //上午上班时间
                                if (atcdInputDto.AT_CD_AMStartTime != null)
                                {
                                    amStartTime = atcdInputDto.AT_CD_AMStartTime.ToString();
                                }
                                else
                                {
                                    amStartTime = atWorkDate.AT_AMStartTime.ToString();
                                }
                                //上午下班时间
                                if (atcdInputDto.AT_CD_AMEndTime != null)
                                {
                                    amEndTime = atcdInputDto.AT_CD_AMEndTime.ToString();
                                }
                                else
                                {
                                    amEndTime = atWorkDate.AT_AMEndTime .ToString();
                                }
                                //下午上班时间
                                if (atcdInputDto.AT_CD_PMStartTime != null)
                                {
                                    pmStartTime = atcdInputDto.AT_CD_PMStartTime.ToString();
                                }
                                else
                                {
                                    pmStartTime = atWorkDate.AT_PMStartTime .ToString();
                                }
                                //下午下班时间
                                if (atcdInputDto.AT_CD_PMEndTime != null)
                                {
                                    pmEndTime = atcdInputDto.AT_CD_PMEndTime.ToString();
                                }
                                else
                                {
                                    pmEndTime = atWorkDate.AT_PMEndTime .ToString();
                                }
                                break;
                            }
                        }
                    }
                    else
                    {
                        //获取当前选中日期考勤的自定义
                        WorkTimeDto atcd = AutofacConfig.attendanceService.GetASByATIDAndDate(ATNo, calendar1.SelectDate.Date);
                        //如果考勤存在自定义日期且自定义类型与考勤类型一致时，获取考勤上班时间
                        if (atcd != null)
                        {
                            atcdInput.AT_CD_ATID = ATNo;
                            //类型不对，得到的值等于false
                            if (atWorkDate.AT_Type.Equals((WorkTimeType)Enum.Parse(typeof(WorkTimeType), atcd.AT_CommutingType)))
                            {
                                workType = (WorkOrRest)Enum.Parse(typeof(WorkOrRest), atcd.AT_ASType);
                                if (workType == WorkOrRest.上班)
                                {
                                    //上班时间
                                    if (atcd.AT_StartTime != null)
                                    {
                                        startTime = atcd.AT_StartTime.ToString();
                                    }
                                    else
                                    {
                                        startTime = atWorkDate.AT_StartTime.ToString();
                                    }
                                    //下班时间
                                    if (atcd.AT_EndTime != null)
                                    {
                                        endTime = atcd.AT_EndTime.ToString();
                                    }
                                    else
                                    {
                                        endTime = atWorkDate.AT_EndTime.ToString();
                                    }
                                    //上午上班时间
                                    if (atcd.AT_AMStartTime != null)
                                    {
                                        amStartTime = atcd.AT_AMStartTime.ToString();
                                    }
                                    else
                                    {
                                        amStartTime = atWorkDate.AT_AMStartTime.ToString();
                                    }
                                    //上午下班时间
                                    if (atcd.AT_AMEndTime != null)
                                    {
                                        amEndTime = atcd.AT_AMEndTime.ToString();
                                    }
                                    else
                                    {
                                        amEndTime = atWorkDate.AT_AMEndTime.ToString();
                                    }
                                    //下午上班时间
                                    if (atcd.AT_PMStartTime != null)
                                    {
                                        pmStartTime = atcd.AT_PMStartTime.ToString();
                                    }
                                    else
                                    {
                                        pmStartTime = atWorkDate.AT_PMStartTime.ToString();
                                    }
                                    //下午下班时间
                                    if (atcd.AT_PMEndTime != null)
                                    {
                                        pmEndTime = atcd.AT_PMEndTime.ToString();
                                    }
                                    else
                                    {
                                        pmEndTime = atWorkDate.AT_PMEndTime.ToString();
                                    }
                                }
                            }
                            else
                            {
                                switch (workType)
                                {
                                    case WorkOrRest.上班:
                                        //上班时间
                                        if (atWorkDate.AT_StartTime != null)
                                        {
                                            startTime = atWorkDate.AT_StartTime.ToString();
                                        }
                                        //下班时间
                                        if (atWorkDate.AT_EndTime != null)
                                        {
                                            endTime = atWorkDate.AT_EndTime.ToString();
                                        }
                                        //上午上班时间
                                        if (atWorkDate.AT_AMStartTime != null)
                                        {
                                            amStartTime = atWorkDate.AT_AMStartTime.ToString();
                                        }
                                        //上午下班时间
                                        if (atWorkDate.AT_AMEndTime != null)
                                        {
                                            amEndTime = atWorkDate.AT_AMEndTime.ToString();
                                        }
                                        //下午上班时间
                                        if (atWorkDate.AT_PMStartTime != null)
                                        {
                                            pmStartTime = atWorkDate.AT_PMStartTime.ToString();
                                        }
                                        //下午下班时间
                                        if (atWorkDate.AT_PMEndTime != null)
                                        {
                                            pmEndTime = atWorkDate.AT_PMEndTime.ToString();
                                        }
                                        break;
                                }
                            }
                        }
                        else
                        {
                            switch (workType)
                            {
                                case WorkOrRest.上班:
                                    //上班时间
                                    if (atWorkDate.AT_StartTime != null)
                                    {
                                        startTime = atWorkDate.AT_StartTime.ToString();
                                    }
                                    //下班时间
                                    if (atWorkDate.AT_EndTime != null)
                                    {
                                        endTime = atWorkDate.AT_EndTime.ToString();
                                    }
                                    //上午上班时间
                                    if (atWorkDate.AT_AMStartTime != null)
                                    {
                                        amStartTime = atWorkDate.AT_AMStartTime.ToString();
                                    }
                                    //上午下班时间
                                    if (atWorkDate.AT_AMEndTime != null)
                                    {
                                        amEndTime = atWorkDate.AT_AMEndTime.ToString();
                                    }
                                    //下午上班时间
                                    if (atWorkDate.AT_PMStartTime != null)
                                    {
                                        pmStartTime = atWorkDate.AT_PMStartTime.ToString();
                                    }
                                    //下午下班时间
                                    if (atWorkDate.AT_PMEndTime != null)
                                    {
                                        pmEndTime = atWorkDate.AT_PMEndTime.ToString();
                                    }
                                    break;
                            }
                        }
                    }
                    upsettingDate(atcdInput.AT_CD_CommutingType, startTime, endTime, amStartTime, amEndTime, pmStartTime, pmEndTime);
                    atcdInput.AT_CD_CDType = workType;
                }
            }
            if (atcdInput != null)
            {
                if (listatcdInput != null & listatcdInput.Count > 0)
                {
                    foreach (AT_CDInputDto atcdInputDto in listatcdInput)
                    {
                        if (atcdInputDto.AT_CD_Date.Date.Equals(atcdInput.AT_CD_Date.Date))
                        {
                            listatcdInput.Remove(atcdInputDto);//先清空集合中等于选中日期的数据
                            break;
                        }
                    }
                }         
                    listatcdInput.Add(atcdInput);//添加选中日期数据             
            }
            upSettingDateTypeControl();
        }

        /// <summary>
        /// 更新日期自定义类型控件
        /// </summary>
        private void upSettingDateTypeControl()
        {
            if (calendar1.SelectDate.Date < DateTime.Now.AddDays(+1).Date)
            {
                //创建考勤时，当前选中日期小于现日期时，自定义日期考勤控件不显示
                if (string.IsNullOrEmpty(ATNo) == true)
                {
                    lblRest.Visible = false;
                    dpStartWork.Visible = false;
                    dpEndWork.Visible = false;
                    lblPMEndWork.Visible = false;
                    lblPMStartWork.Visible = false;
                    dpAMStartWork.Visible = false;
                    dpAMEndWork.Visible = false;
                    dpPMStartWork.Visible = false;
                    dpPMEndWork.Visible = false;
                    lblStartWork.Visible = false; ;
                    lblEndWork.Visible = false;
                    btnCDType.Visible = false;
                }
                else
                {
                    //编辑考勤时，日历选中日期小于等于现在日期，若模板存在自定义，则显示自定义状态
                    WorkTimeDto atcd = AutofacConfig.attendanceService.GetASByATIDAndDate(ATNo, calendar1.SelectDate .Date);
                    if (atcd != null)
                    {
                        switch ((WorkOrRest)Enum.Parse(typeof(WorkOrRest), atcd.AT_ASType))
                        {
                            case WorkOrRest.上班:
                                switch ((WorkTimeType)Enum.Parse(typeof(WorkTimeType), atcd.AT_CommutingType))
                                {
                                    case WorkTimeType.一天一上下班:

                                        if (atcd.AT_StartTime != null)
                                        {
                                            dpStartWork.Value = Convert.ToDateTime(atcd.AT_StartTime);
                                        }

                                        if (atcd.AT_EndTime != null)
                                        {
                                            dpEndWork.Value  = Convert.ToDateTime(atcd.AT_EndTime);
                                        }
                                        break;
                                    case WorkTimeType.一天二上下班:
                                        if (atcd.AT_AMStartTime != null)
                                        {
                                            dpAMStartWork.Value  = Convert.ToDateTime(atcd.AT_AMStartTime);
                                        }

                                        if (atcd.AT_AMEndTime != null)
                                        {
                                            dpAMEndWork.Value  = Convert.ToDateTime(atcd.AT_AMEndTime);
                                        }

                                        if (atcd.AT_PMStartTime != null)
                                        {
                                            dpPMStartWork.Value  = Convert.ToDateTime(atcd.AT_PMStartTime);
                                        }

                                        if (atcd.AT_PMEndTime != null)
                                        {
                                            dpPMEndWork.Value  = Convert.ToDateTime(atcd.AT_PMEndTime);
                                        }

                                        break;
                                }
                                break;
                        }
                        switch ((WorkOrRest)Enum.Parse(typeof(WorkOrRest), atcd.AT_ASType))
                        {
                            case WorkOrRest.休息:
                                lblRest.Visible = true;
                                dpStartWork.Visible = false;
                                dpEndWork.Visible = false;
                                lblPMEndWork.Visible = false;
                                lblPMStartWork.Visible = false;
                                dpAMStartWork.Visible = false;
                                dpAMEndWork.Visible = false;
                                dpPMStartWork.Visible = false;
                                dpPMEndWork.Visible = false;
                                lblStartWork.Visible = false; ;
                                lblEndWork.Visible = false;
                                btnCDType.Visible = false;
                                break;
                            case WorkOrRest.上班:
                                lblStartWork.Top = lblRest.Top;
                                lblRest.Visible = false;
                                switch ((WorkTimeType)Enum.Parse(typeof(WorkTimeType), atcd.AT_CommutingType))
                                {
                                    case WorkTimeType.一天一上下班:
                                        lblStartWork.Visible = true;
                                        lblEndWork.Visible = true;
                                        dpStartWork.Visible = true;
                                        dpEndWork.Visible = true;
                                        dpStartWork.Enabled = false;
                                        dpEndWork.Enabled = false;
                                        lblPMEndWork.Visible = false;
                                        lblPMStartWork.Visible = false;
                                        dpAMStartWork.Visible = false;
                                        dpAMEndWork.Visible = false;
                                        dpPMStartWork.Visible = false;
                                        dpPMEndWork.Visible = false;
                                        lblStartWork.Text = "上班时间";
                                        lblEndWork.Text = "下班时间";
                                        dpStartWork.Top = lblStartWork.Top;
                                        dpEndWork.Top = lblEndWork.Top;
                                        break;
                                    case WorkTimeType.一天二上下班:
                                        lblStartWork.Visible = true;
                                        lblEndWork.Visible = true;
                                        dpStartWork.Visible = false;
                                        dpEndWork.Visible = false;
                                        lblPMEndWork.Visible = true;
                                        lblPMStartWork.Visible = true;
                                        dpAMStartWork.Visible = true;
                                        dpAMEndWork.Visible = true;
                                        dpPMStartWork.Visible = true;
                                        dpPMEndWork.Visible = true;
                                        dpAMStartWork.Enabled = false;
                                        dpAMEndWork.Enabled = false;
                                        dpPMStartWork.Enabled = false;
                                        dpPMEndWork.Enabled = false;
                                        lblStartWork.Text = "上午上班";
                                        lblEndWork.Text = "上午下班";
                                        dpAMStartWork.Top = lblStartWork.Top;
                                        dpAMEndWork.Top = lblEndWork.Top;
                                        lblPMStartWork.Top = lblEndWork.Top + lblEndWork.Height;
                                        dpPMStartWork.Top = lblPMStartWork.Top;
                                        lblPMEndWork.Top = lblPMStartWork.Top + lblPMStartWork.Height;
                                        dpPMEndWork.Top = lblPMEndWork.Top;
                                        break;
                                }
                                btnCDType.Visible = false;
                                break;
                        }
                    }
                    else
                    {
                        lblRest.Visible = false;
                        dpStartWork.Visible = false;
                        dpEndWork.Visible = false;
                        lblPMEndWork.Visible = false;
                        lblPMStartWork.Visible = false;
                        dpAMStartWork.Visible = false;
                        dpAMEndWork.Visible = false;
                        dpPMStartWork.Visible = false;
                        dpPMEndWork.Visible = false;
                        lblStartWork.Visible = false; ;
                        lblEndWork.Visible = false;
                        btnCDType.Visible = false;
                    }
                }
            }
            //创建编辑考勤时，日历选中日期大于现在日期，根据选中日期自定义类型显示考勤控件             
            if (calendar1.SelectDate.Date >= DateTime.Now.AddDays(+1).Date)
            {
                switch (workType)
                {
                    case WorkOrRest.上班:
                        lblRest.Visible = false;
                       // lblStartWork.Top = calendar1.Top + calendar1.Height + 10;
                        lblStartWork.Top = lblRest.Top ;
                        lblEndWork.Top = lblStartWork.Top + lblStartWork.Height;
                        switch (atWorkDate.AT_Type)
                        {
                            case WorkTimeType.一天一上下班:
                                lblStartWork.Visible = true;
                                lblEndWork.Visible = true;
                                dpStartWork.Visible = true;
                                dpEndWork.Visible = true;
                                dpStartWork.Enabled = true;
                                dpEndWork.Enabled = true;
                                lblPMEndWork.Visible = false;
                                lblPMStartWork.Visible = false;
                                dpAMStartWork.Visible = false;
                                dpAMEndWork.Visible = false;
                                dpPMStartWork.Visible = false;
                                dpPMEndWork.Visible = false;
                                lblStartWork.Text = "上班时间";
                                lblEndWork.Text = "下班时间";
                                dpStartWork.Top = lblStartWork.Top;
                                dpEndWork.Top = lblEndWork.Top;
                                btnCDType.Top = lblEndWork.Top + lblEndWork.Height;
                                break;
                            case WorkTimeType.一天二上下班:
                                dpStartWork.Visible = false;
                                dpEndWork.Visible = false;
                                lblStartWork.Visible = true;
                                lblEndWork.Visible = true;
                                lblPMEndWork.Visible = true;
                                lblPMStartWork.Visible = true;
                                dpAMStartWork.Visible = true;
                                dpAMEndWork.Visible = true;
                                dpPMStartWork.Visible = true;
                                dpPMEndWork.Visible = true;
                                dpAMStartWork.Enabled = true;
                                dpAMEndWork.Enabled = true;
                                dpPMStartWork.Enabled = true;
                                dpPMEndWork.Enabled = true;
                                lblStartWork.Text = "上午上班";
                                lblEndWork.Text = "上午下班";
                                dpAMStartWork.Top = lblStartWork.Top;
                                dpAMEndWork.Top = lblEndWork.Top;
                                lblPMStartWork.Top = lblEndWork.Top + lblEndWork.Height;
                                dpPMStartWork.Top = lblPMStartWork.Top;
                                lblPMEndWork.Top = lblPMStartWork.Top + lblPMStartWork.Height;
                                dpPMEndWork.Top = lblPMEndWork.Top;
                                btnCDType.Top = lblPMEndWork.Top + lblPMEndWork.Height;
                                break;
                        }
                        btnCDType.Visible = true;
                        btnCDType.Text = "设置为休息";
                        break;
                    case WorkOrRest.休息:
                        dpStartWork.Visible = false;
                        dpEndWork.Visible = false;
                        lblPMEndWork.Visible = false;
                        lblPMStartWork.Visible = false;
                        dpAMStartWork.Visible = false;
                        dpAMEndWork.Visible = false;
                        dpPMStartWork.Visible = false;
                        dpPMEndWork.Visible = false;
                        lblStartWork.Visible = false; ;
                        lblEndWork.Visible = false;
                        lblRest.Visible = true;
                        btnCDType.Visible = true;
                        btnCDType.Top = lblRest.Top + lblRest.Height;
                        btnCDType.Text = "设置为考勤";
                        break;
                }
            }
        }
       
        /// <summary>
        /// 自定义日期更新
        /// </summary>
        /// <param name="atType">考勤类型</param>
        /// <param name="StartTime">上班时间</param>
        /// <param name="EndTime">下班时间</param>
        /// <param name="AMStartTime">上午上班时间</param>
        /// <param name="AMEndTime">上午下班时间</param>
        /// <param name="PMStartTime">下午上班时间</param>
        /// <param name="PMEndTime">下午下班时间</param>
        private void upsettingDate(WorkTimeType atType, string StartTime, string EndTime, string AMStartTime, string AMEndTime, string PMStartTime, string PMEndTime)
        {
            try
            {
                switch (atType)
                {
                    case WorkTimeType.一天一上下班:

                        if (string.IsNullOrEmpty(StartTime)==false )
                        {
                            DateTime atsettingDate = atcdInput.AT_CD_Date.Date.AddHours(Convert.ToDateTime(StartTime).Hour).AddMinutes(Convert.ToDateTime(StartTime).Minute);
                            dpStartWork.Value = atsettingDate;
                            atcdInput.AT_CD_StartTime = dpStartWork.Value;
                        }

                        if (string.IsNullOrEmpty(EndTime) == false)
                        {
                            DateTime atsettingDate = atcdInput.AT_CD_Date.Date.AddHours(Convert.ToDateTime(EndTime).Hour).AddMinutes(Convert.ToDateTime(EndTime).Minute);
                            dpEndWork.Value = atsettingDate;
                            atcdInput.AT_CD_EndTime = dpEndWork.Value;
                        }
                        break;
                    case WorkTimeType.一天二上下班:
                        if (string.IsNullOrEmpty(AMStartTime ) == false)
                        {
                            DateTime atsettingDate = atcdInput.AT_CD_Date.Date.AddHours(Convert.ToDateTime(AMStartTime).Hour).AddMinutes(Convert.ToDateTime(AMStartTime).Minute);
                            dpAMStartWork.Value = atsettingDate;
                            atcdInput.AT_CD_AMStartTime = dpAMStartWork.Value;
                        }

                        if (string.IsNullOrEmpty(AMEndTime ) == false)
                        {
                            DateTime atsettingDate = atcdInput.AT_CD_Date.Date.AddHours(Convert.ToDateTime(AMEndTime).Hour).AddMinutes(Convert.ToDateTime(AMEndTime).Minute);
                            dpAMEndWork.Value = atsettingDate;
                            atcdInput.AT_CD_AMEndTime = dpAMEndWork.Value;
                        }

                        if (string.IsNullOrEmpty(PMStartTime) == false)
                        {
                            DateTime atsettingDate = atcdInput.AT_CD_Date.Date.AddHours(Convert.ToDateTime(PMStartTime).Hour).AddMinutes(Convert.ToDateTime(PMStartTime).Minute);
                            dpPMStartWork.Value = atsettingDate;
                            atcdInput.AT_CD_PMStartTime = dpPMStartWork.Value;
                        }

                        if (string.IsNullOrEmpty(PMEndTime) == false)
                        {
                            DateTime atsettingDate = atcdInput.AT_CD_Date.Date.AddHours(Convert.ToDateTime(PMEndTime).Hour).AddMinutes(Convert.ToDateTime(PMEndTime).Minute);
                            dpPMEndWork.Value = atsettingDate;
                            atcdInput.AT_CD_PMEndTime = dpPMEndWork.Value;
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }
        }

        /// <summary>
        /// 判断当前选中日期是否已自定义考勤
        /// </summary>
        /// <returns></returns>
        private bool IsCATSettingDay(DateTime atcdDate)
        {
            bool isatSettingDay = false;
            if (listatcdInput != null & listatcdInput.Count > 0)
            {
                foreach (AT_CDInputDto atcdInputDto in listatcdInput)
                {
                    if (atcdInputDto.AT_CD_Date.Date.Equals(atcdDate.Date))
                    {
                        isatSettingDay = true;
                        break;
                    }

                }
            }
            return isatSettingDay;
        }
 
        /// <summary>
        /// 更新上班时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dpStartWork_DatePicked(object sender, EventArgs e)
        {
            ShowResult = ShowResult.Yes;
            foreach (AT_CDInputDto atct in listatcdInput)
            {
                if (atct.AT_CD_Date.Date.Equals(atcdInput.AT_CD_Date.Date))
                {
                    atct.AT_CD_StartTime = dpStartWork .Value ;
                    break;
                }
            }
        }
        /// <summary>
        /// 更新下班时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dpEndWork_DatePicked(object sender, EventArgs e)
        {
            ShowResult = ShowResult.Yes;
            foreach (AT_CDInputDto atct in listatcdInput)
            {
                if (atct.AT_CD_Date.Date.Equals(atcdInput.AT_CD_Date.Date))
                {                  
                    atct.AT_CD_EndTime = dpEndWork .Value ;
                    break;
                }
            }
        }

        /// <summary>
        /// 更新上午上班时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dpAMStartWork_DatePicked(object sender, EventArgs e)
        {
            ShowResult = ShowResult.Yes;
            foreach (AT_CDInputDto atct in listatcdInput)
            {
                if (atct.AT_CD_Date.Date.Equals(atcdInput.AT_CD_Date.Date))
                {
                    atct.AT_CD_AMStartTime = dpAMStartWork.Value ;
                    break;
                }
            }
        }
      
        /// <summary>
        /// 更新上午下班时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dpAMEndWork_DatePicked(object sender, EventArgs e)
        {
            ShowResult = ShowResult.Yes;
            foreach (AT_CDInputDto atct in listatcdInput)
            {
                if (atct.AT_CD_Date.Date.Equals(atcdInput.AT_CD_Date.Date))
                {
                    atct.AT_CD_AMEndTime = dpAMEndWork.Value;
                    break;
                }
            }
        }
       
        /// <summary>
        /// 更新下午上班时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dpPMStartWork_DatePicked(object sender, EventArgs e)
        {
            ShowResult = ShowResult.Yes;
            foreach (AT_CDInputDto atct in listatcdInput)
            {
                if (atct.AT_CD_Date.Date.Equals(atcdInput.AT_CD_Date.Date))
                {
                    atct.AT_CD_AMStartTime = dpPMStartWork.Value ;
                    break;
                }
            }
        }

        /// <summary>
        /// 更新下午下班时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dpPMEndWork_DatePicked(object sender, EventArgs e)
        {
           
            foreach (AT_CDInputDto atct in listatcdInput)
            {
                if (atct.AT_CD_Date.Date.Equals(atcdInput.AT_CD_Date.Date))
                {
                   atct.AT_CD_PMEndTime = dpPMEndWork.Value ;

                    break;
                }
            }
        }
        /// <summary>
        /// 初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAttendanceCalendarSetting_Load(object sender, EventArgs e)
        {
            try
            {
                upSettingDateType ();
            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }
        }

        /// <summary>
        /// 日历日期点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calendar1_DateChanged(object sender, EventArgs e)
        {
            try
            {
                int selectday = (int)Enum.Parse(typeof(Week), calendar1.SelectDate.DayOfWeek.ToString());//获取选中日期是某个星期的第几天
                //如果当前选中日期在考勤工作日期中，则自定义日期类型为上班，否则为休息
                if (weekdays.Split(',').Contains(selectday.ToString()) == true)
                {
                    workType = WorkOrRest.上班;
                }
                else
                {
                    workType = WorkOrRest.休息;
                }
                //如果当前选中日期已在考勤自定义集合中且自定义类型等于考勤类型，则赋值自定义日期类型
                if (IsCATSettingDay(calendar1.SelectDate.Date) == true)
                {
                    foreach (AT_CDInputDto atcdInputDto in listatcdInput)
                    {
                        if (atcdInputDto.AT_CD_Date.Date.Equals(calendar1.SelectDate.Date) & atcdInputDto.AT_CD_CommutingType == atWorkDate.AT_Type)
                        {
                            workType = atcdInputDto.AT_CD_CDType;
                            break;
                        }
                    }
                }
                upSettingDateType();
            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }
           
        }
    }
}
