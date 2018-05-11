using SmoONE.DTOs;
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
    // 主要内容： 用户详细信息
    // ******************************************************************
    class UserDetails
    {
        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="userID"></param>
        public UserDetailDto getUser(string userID)
        {
            try 
            {
                if (string.IsNullOrEmpty(userID) == true)
                {
                    throw new Exception("请输入电话号码！");

                }
                AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
                 UserDetailDto user = AutofacConfig.userService.GetUserByUserID(userID);
                 if (user != null)
                 {
                     if (string.IsNullOrEmpty(user.U_Portrait) == true)
                     {
                         switch (user.U_Sex)
                         {
                             case (int)Sex.男:
                                 user.U_Portrait = "boy";
                                 break;
                             case (int)Sex.女:
                                 user.U_Portrait = "girl";
                                 break;
                         }
                     }
                 }
                 return user;
                }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
