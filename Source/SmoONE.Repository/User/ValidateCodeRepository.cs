using SmoONE.Domain;
using SmoONE.Domain.IRepository;
using SmoONE.DTOs;
using SmoONE.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmoONE.Repository
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
    public class ValidateCodeRepository: BaseRepository<ValidateCode>, IValidateCodeRepository
    {
        /// <summary>
        /// 仓储类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public ValidateCodeRepository(IDbContext dbContext)
            : base(dbContext)
        { }

        /// <summary>
        /// 判断该电话和验证码是否有效
        /// </summary>
        /// <param name="PhoneNumber">电话号码</param>
        /// <param name="VCode">验证码</param>
        /// <returns>true表示存在，false表示不存在</returns>
        public bool IsValidate(string PhoneNumber, string VCode,DateTime Date)
        {
            return _entities.Any(x => x.V_PhoneNumber == PhoneNumber && x.V_VCode == VCode&&x.V_UpdateDate>=Date);
        }


        /// <summary>
        /// 判断该电话是否发送过验证码
        /// </summary>
        /// <param name="PhoneNumber">电话号码</param>
        /// <returns>true表示存在，false表示不存在</returns>
        public bool IsSendVcode(string PhoneNumber)
        {
            return _entities.Any(x => x.V_PhoneNumber == PhoneNumber);
        }

        /// <summary>
        /// 判断该设备ID是否恶意注册
        /// </summary>
        /// <param name="DeviceID">设备ID</param>
        /// <returns>true表示存在，false表示不存在</returns>
        public bool IsMalicious(string DeviceID)
        {
            int Count = _entities.Count(x => x.V_DeviceID == DeviceID);
            if (Count >= 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
