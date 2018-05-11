using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmoONE.UI
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler 
    // 创建时间： 2016/11
    // 主要内容：  用户修改属性
    // ******************************************************************
   public  enum  EuserInfo
    {
       /// <summary>
        /// 修改昵称
       /// </summary>
       修改昵称 = 0,
       /// <summary>
       /// 修改邮件
       /// </summary>
       修改邮件 = 2,
       /// <summary>
       /// 修改登录密码
       /// </summary>
       修改登录密码 =3,
    }
    public enum ConcentState
    {
        /// <summary>
        /// 联系人
        /// </summary>
        Concent = 1,
        /// <summary>
        /// 群组
        /// </summary>
        Group = 2,
       
    }
}
