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
    // 主要内容：  验证码的仓储接口,仅用于查询
    // ******************************************************************
    /// <summary>
    /// 验证码的仓储接口,仅用于查询
    /// </summary>
    public interface IValidateCodeRepository:IRepository<ValidateCode>
    {
        /// <summary>
        /// 判断该电话和验证码是否有效
        /// </summary>
        /// <param name="PhoneNumber">电话号码</param>
        /// <param name="VCode">验证码</param>
        /// <param name="Date">时间</param>
        /// <returns>true表示存在，false表示不存在</returns>
        bool IsValidate(string PhoneNumber,string VCode,DateTime Date);

        /// <summary>
        /// 判断该电话是否发送过验证码
        /// </summary>
        /// <param name="PhoneNumber">电话号码</param>
        /// <returns>true表示存在，false表示不存在</returns>
        bool IsSendVcode(string PhoneNumber);

        /// <summary>
        /// 判断该设备ID是否恶意注册
        /// </summary>
        /// <param name="DeviceID">设备ID</param>
        /// <returns>true表示存在，false表示不存在</returns>
        bool IsMalicious(string DeviceID);
    }
}
