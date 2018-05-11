using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SmoONE.DTOs;
using System.Data;

namespace SmoONE.UI.Attendance
{
        // ******************************************************************
    // 文件版本： SmoONE 1.1
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2017/2
        // 主要内容： 用户考勤类型详情记录界面
        // ******************************************************************
    partial class frmAttendanceStatSelfDetail : Smobiler.Core.Controls.MobileForm
    {
        
        #region "definition"
        internal string UserID;      //用户ID
        public string Type;          //签到类型 
        public string Daytime;       //选择时间
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        #endregion
        /// <summary>
        /// 手机自带返回键，退出页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAttendanceStatSelfDetail_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                Close();
            }
        }
        /// <summary>
        /// 左上角返回键，退出页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAttendanceStatSelfDetail_TitleImageClick(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// 页面加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAttendanceStatSelfDetail_Load(object sender, EventArgs e)
        {
            try
            {
                Bind();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 绑定数据， 显示所要查看签到类型下的日期
        /// </summary>
        private void Bind()
        {
            try
            {
                List<StatisticsType> listType = new List<StatisticsType>();
                List<ALDto> listATlog = new List<ALDto>();
                listView1.Rows.Clear();
                listView2.Rows.Clear();
                StatisticsType stype = (StatisticsType)Enum.Parse(typeof(StatisticsType), Type);
                listType.Add(stype);
                listATlog = AutofacConfig.attendanceService.GetAlDtoOfType(UserID, Convert.ToDateTime(Daytime), listType);
                switch (stype)
                {
                    case StatisticsType.未签到:
                    case StatisticsType.未签退:
                        listView1.Visible = true;
                        listView2.Visible = false ;
                        // listView1.TemplateControlName = "frmATStatSelfDetailDayLayout";
                        if (listATlog.Count > 0)
                        {
                            List<DateTime> listATDate = new List<DateTime>();
                            foreach (ALDto al in listATlog)
                            {
                                if (listATDate.Contains(al.AL_Date.Date) == false)
                                {
                                    listATDate.Add(al.AL_Date.Date);
                                }
                            }
                            //listATDate.Distinct();//去除重复考勤日期
                            listATDate.Sort();//考勤日期排序
                            DataTable table = new DataTable();
                            table.Columns.Add("AL_Date");         //签到日期
                            table.Columns.Add("AL_DateDesc");         //签到日期描述
                            foreach (DateTime atDate in listATDate)
                            {
                                string atSignTime = atDate.ToString("yyyy年M月d日    dddd", new System.Globalization.CultureInfo("zh-CN"));
                                table.Rows.Add(atDate, atSignTime);
                            }
                            listView1.DataSource = table;
                            listView1.DataBind();
                        }
                        break;
                    case StatisticsType.准点:
                    case StatisticsType.迟到:
                    case StatisticsType.早退:
                        listView1.Visible = false ;
                        listView2.Visible = true ;
                        //listView1.TemplateControlName = "frmATStatSelfDetailTypeLayout";
                        if (listATlog.Count > 0)
                        {
                            List<ATStatSelfDetail> listATlogStatistics = new List<ATStatSelfDetail>();
                            foreach (ALDto al in listATlog)
                            {
                                ATStatSelfDetail atDetail = new ATStatSelfDetail();
                                if (string.IsNullOrEmpty(al.AL_Reason) == false)
                                {
                                    switch (stype)
                                    {
                                        case StatisticsType.迟到:
                                            atDetail.AL_Reason = StatisticsType.迟到 + "理由：" + al.AL_Reason;
                                            break;
                                        case StatisticsType.早退:
                                            atDetail.AL_Reason = StatisticsType.早退 + "理由：" + al.AL_Reason;
                                            break;
                                    }
                                }
                                atDetail.AL_DateDesc = "签到 " + al.AL_Date.ToString("yyyy年MM月dd日  HH:mm");
                                atDetail.AL_Position = al.AL_Position;
                                listATlogStatistics.Add(atDetail);
                            }
                            listView2.DataSource = listATlogStatistics;
                            listView2.DataBind();
                        }
                        break;
                }
               
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}