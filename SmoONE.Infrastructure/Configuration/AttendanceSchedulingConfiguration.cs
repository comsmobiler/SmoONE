using SmoONE.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmoONE.Infrastructure
{
    // ******************************************************************
    // 文件版本： SmoONE 1.1
    // Copyright  (c)  2016-2017 Smobiler 
    // 创建时间： 2017/2
    // 主要内容： 配置考勤排班表的映射信息
    // ******************************************************************
    public class AttendanceSchedulingConfiguration: EntityTypeConfiguration<AttendanceScheduling>
    {
        /// <summary>
        /// 配置考勤排班表的映射信息
        /// </summary>
        public AttendanceSchedulingConfiguration()
        {
            Property(l => l.AS_Longitude).HasPrecision(11, 8);
            Property(l => l.AS_Latitude).HasPrecision(11, 8);
        }
    }
}
