using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmoONE.Domain.IRepository
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2016/11
    // 主要内容：  请假类型的仓储接口,仅用于查询
    // ******************************************************************
    /// <summary>
    /// 请假类型的仓储接口,仅用于查询
    /// </summary>
    public interface ILeaveTypeRepository : IRepository<LeaveType>
    {
        /// <summary>
        /// 根据请假类型ID返回请假类型对象
        /// </summary>
        /// <param name="ID">请假类型ID</param>
        LeaveType GetByID(string ID);
    }
}

