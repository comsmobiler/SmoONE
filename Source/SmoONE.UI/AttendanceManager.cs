using SmoONE.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmoONE.UI
{
    // ******************************************************************
    // 文件版本： SmoONE 1.1
    // Copyright  (c)  2016-2017 Smobiler 
    // 创建时间： 2017/2
    // 主要内容：  考勤模板列表属性及方法
    // ******************************************************************
    class AttendanceManager : SmoONE.DTOs.ATDto
    {
        /// <summary>
        /// 工作时间描述
        /// </summary>
        public string WorkDate { get; set; }
        /// <summary>
        /// 工作时间描述1
        /// </summary>
        public string WorkDate1 { get; set; }
         /// <summary>
        /// 生效时间描述
        /// </summary>
        public string AT_EffectiveDesc { get; set; }
        
        /// <summary>
        /// 获取每周工作日描述
        /// </summary>
        /// <param name="weekworkday"></param>
        /// <returns></returns>
        public string getWeekDesc(string weekworkday)
        {
            string weeklyWorkingDay = "";
            if (string.IsNullOrEmpty(weekworkday) == false)
            {
                string[] weeks = weekworkday.Split(',');
                foreach (string weekday in weeks)
                {
                    string weekday1 = "";

                    switch (int.Parse(weekday))
                    {
                        case (int)Week.Monday:
                            weekday1 = "一";
                            break;
                        case (int)Week.Tuesday:
                            weekday1 = "二";
                            break;
                        case (int)Week.Wednesday:
                            weekday1 = "三";
                            break;
                        case (int)Week.Thursday:
                            weekday1 = "四";
                            break;
                        case (int)Week.Friday:
                            weekday1 = "五";
                            break;
                        case (int)Week.Saturday:
                            weekday1 = "六";
                            break;
                        case (int)Week.Sunday:
                            weekday1 = "日";
                            break;
                    }
                    if (string.IsNullOrEmpty(weeklyWorkingDay) == true)
                    {
                        weeklyWorkingDay = "每周" + weekday1;

                    }
                    else
                    {
                        weeklyWorkingDay += "、" + weekday1;
                    }
                }
            }
            return weeklyWorkingDay;
        }
    }
}
