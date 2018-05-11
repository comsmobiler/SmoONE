using SmoONE.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmoONE.DTOs;
using SmoONE.CommLib;
using SmoONE.Domain.IRepository;
using SmoONE.Repository;
using SmoONE.Infrastructure;
using System.Text.RegularExpressions;

namespace SmoONE.Application
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2016/11
    // 主要内容：  帮助类,主要用于数据库对象的验证和产生表的主键ID
    // ******************************************************************
    /// <summary>
    /// 帮助类,主要用于数据库对象的验证和产生表的主键ID
    /// </summary>
    public static class Helper
    {
        /// <summary>
        /// 数据库的上下文的接口
        /// </summary>
        public static IDbContext context = new SmoONEDbContext();

        /// <summary>
        /// 用户的仓储类的接口
        /// </summary>
        public static IUserRepository userRepository = new UserRepository(context);

        /// <summary>
        /// 产生部分表的主键ID
        /// </summary>
        /// <param name="Head">自定义的ID开头</param>
        /// <param name="MaxID">当前表中的最大ID</param>
        public static string GenerateID(string Head,string MaxID)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Head);
            sb.Append(DateTime.Now.ToString("yyyyMMddHHmm"));
            if (string.IsNullOrEmpty(MaxID))
            {
                sb.Append("0001");
            }
            else if (MaxID.Contains(DateTime.Now.ToString("yyyyMMddHHmm")))
            {
                int HeadLength = Head.Length;
                int MinuteMax = int.Parse(MaxID.Substring(HeadLength+12, 4));
                string NowMax = (MinuteMax + 1).ToString();
                for (int i = NowMax.Length; i < 4; i++)
                {
                    sb.Append("0");
                }
                sb.Append((MinuteMax + 1).ToString());
            }
            else
            {
                sb.Append("0001");
            }
            return sb.ToString();
        }



        /// <summary>
        /// 产生部分表的主键ID
        /// </summary>
        /// <param name="Head">自定义的ID开头</param>
        /// <param name="MaxID">当前表中的最大ID</param>
        public static string GenerateIDEx(string Head, string MaxID)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Head);
            sb.Append(DateTime.Now.ToString("yyyyMMdd"));
            if (string.IsNullOrEmpty(MaxID))
            {
                sb.Append("001");
            }
            else if (MaxID.Contains(DateTime.Now.ToString("yyyyMMdd")))
            {
                int HeadLength = Head.Length;
                int MinuteMax = int.Parse(MaxID.Substring(HeadLength + 8, 3));
                string NowMax = (MinuteMax + 1).ToString();
                for (int i = NowMax.Length; i < 3; i++)
                {
                    sb.Append("0");
                }
                sb.Append((MinuteMax + 1).ToString());
            }
            else
            {
                sb.Append("001");
            }
            return sb.ToString();
        }

        /// <summary>
        /// 产生部分表的主键ID
        /// </summary>
        /// <param name="Head">自定义的ID开头</param>
        /// <param name="MaxID">当前表中的最大ID</param>
        public static string GenerateID2(string Head, string MaxID)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Head);
            if (string.IsNullOrEmpty(MaxID))
            {
                sb.Append("000001");
            }
            else 
            {
                int HeadLength = Head.Length;
                int MinuteMax = int.Parse(MaxID.Substring(HeadLength, 6));
                string NowMax = (MinuteMax + 1).ToString();
                for (int i = NowMax.Length; i < 6; i++)
                {
                    sb.Append("0");
                }
                sb.Append((MinuteMax + 1).ToString());
            }
            
            return sb.ToString();
        }

        /// <summary>
        /// 请假单验证
        /// </summary>
        /// <param name="entity">请假单对象</param>
        public static string ValidateLeaveInputDto(LeaveInputDto entity)
        {
            //基础验证
            StringBuilder sb = BasicValidate<LeaveInputDto>(entity);
            //额外验证(开始时间不能大于结束时间,审批人在用户表里)
            if (!string.IsNullOrEmpty(entity.L_StartDate.ToString()) && !string.IsNullOrEmpty(entity.L_EndDate.ToString()))
            {
                if (entity.L_StartDate > entity.L_EndDate)
                {
                    sb.Append("开始日期不能大于结束日期!");
                }
            }
            if (entity.L_LDay <= 0)
            {
                sb.Append("请假天数必须为正!");
            }
            if(!Regex.IsMatch(entity.L_LDay.ToString(),@"^(?!0+(?:\.0+)?$)(?:[1-9]\d*|0)(?:\.\d{1})?$"))
            {
                sb.Append("请假天数格式错误,至多2位小数!");
            }
            if (!string.IsNullOrEmpty(entity.L_CheckUsers))
            {
                string[] CheckUsers = entity.L_CheckUsers.Split(',');
                if (CheckUsers.Length > 0)
                {
                    foreach (string s in CheckUsers)
                    {
                        if (!userRepository.IsExists(s))
                        {
                            sb.Append("审批人" + s + "不在用户表中!");
                        }

                    }
                }
            }
            if (!string.IsNullOrEmpty(entity.L_CCTo))
            {
                string[] CCTo = entity.L_CCTo.Split(',');
                if (CCTo.Length > 0)
                {
                    foreach (string s in CCTo)
                    {
                        if (!userRepository.IsExists(s))
                        {
                            sb.Append("抄送人" + s + "不在用户表中!");
                        }

                    }
                }
            }
            
            return sb.ToString();
        }

        /// <summary>
        /// 用户验证
        /// </summary>
        /// <param name="entity">用户对象</param>
        public static string ValidateUserInputDto(UserInputDto entity)
        {
            //基础验证
            StringBuilder sb = BasicValidate<UserInputDto>(entity);
            //额外验证
            return sb.ToString();
        }


        /// <summary>
        /// 报销单验证
        /// </summary>
        /// <param name="entity">报销单对象</param>
        public static string ValidateRBInputDto(RBInputDto entity)
        {
            //基础验证
            StringBuilder sb = BasicValidate<RBInputDto>(entity);
            //额外验证(Rows中的每个的类型，金额，事由均不能为空,list必须有值,审批人在用户列表里)
            if (entity.RB_Rows.Count == 0)
            {
                sb.Append("报销明细至少需要1条;");
            }
            else
            {
                foreach (RB_RowsInputDto row in entity.RB_Rows)
                {
                    sb.Append(BasicValidate<RB_RowsInputDto>(row));
                }                
            }          
            return sb.ToString();
        }

        /// <summary>
        /// 消费记录明细验证
        /// </summary>
        /// <param name="entity">消费记录明细对象</param>
        public static string ValidateRB_RowsInputDto(RB_RowsInputDto entity)
        {
            //基础验证            
            StringBuilder sb = BasicValidate<RB_RowsInputDto>(entity);
            //额外验证
            if (entity.R_Amount <= 0)
            {
                sb.Append("金额必须大于0!");
            }
            if (!Regex.IsMatch(entity.R_Amount.ToString(), @"^(?!0+(?:\.0+)?$)(?:[1-9]\d*|0)(?:\.\d{1,2})?$"))
            {
                sb.Append("金额格式错误,至多2位小数!");
            }
            if (entity.R_ConsumeDate != null)
            {
                if (entity.R_ConsumeDate > DateTime.Now)
                {
                    sb.Append("消费时间不能为未来时间!");
                }
            }
            
            return sb.ToString();
        }

        /// <summary>
        /// 消费记录类型模板的验证
        /// </summary>
        /// <param name="entity">消费记录类型模板对象</param>
        public static string ValidateRBRTTInputDto(RBRTTInputDto entity)
        {
            //基础验证
            StringBuilder sb = BasicValidate<RBRTTInputDto>(entity);
            //额外验证
            if (entity.RB_RTT_Amount <= 0)
            {
                sb.Append("金额必须大于0!");
            }
            if (!Regex.IsMatch(entity.RB_RTT_Amount.ToString(), @"^(?!0+(?:\.0+)?$)(?:[1-9]\d*|0)(?:\.\d{1,2})?$"))
            {
                sb.Append("金额格式错误,至多2位小数!");
            }
            return sb.ToString();
        }

        /// <summary>
        /// 部门验证
        /// </summary>
        /// <param name="entity">部门对象</param>
        public static string ValidateDepInputDto(DepInputDto entity)
        {
            //基础验证
            StringBuilder sb = BasicValidate<DepInputDto>(entity);
            //额外验证
            if (entity.Dep_OtherDay < 0)
            {
                sb.Append("目标其他/人天不能为负!");
            }
            if (!Regex.IsMatch(entity.Dep_OtherDay.ToString(), @"/^0$|^[0-9]\d{0,15}$|^[0-9]\d{0,15}\.{1}\d{1,1}$|^0\.{1}\d{1,1}$/g"))
            {
                sb.Append("目标其他/人天格式错误,至多1位小数!");
            }
            if (entity.Dep_ProDay < 0)
            {
                sb.Append("目标项目/人天不能为负!");
            }
            if (!Regex.IsMatch(entity.Dep_ProDay.ToString(), @"/^0$|^[0-9]\d{0,15}$|^[0-9]\d{0,15}\.{1}\d{1,1}$|^0\.{1}\d{1,1}$/g"))
            {
                sb.Append("目标其他/人天格式错误,至多1位小数!");
            }
            if (entity.UserIDs.Count > 0)
            {
                foreach (string s in entity.UserIDs)
                {
                    if (!userRepository.IsExists(s))
                    {
                        sb.Append("部门人员" + s + "不在用户表中!");
                    }

                }
            }
            else
            {
                sb.Append("部门人员至少需要一人!");
            }
            return sb.ToString();
            
        }


        /// <summary>
        /// 成本中心验证
        /// </summary>
        /// <param name="entity">成本中心对象</param>
        public static string ValidateCCInputDto(CCInputDto entity)
        {
            //基础验证
            StringBuilder sb = BasicValidate<CCInputDto>(entity);
            //额外验证(开始小于结束)
            if (!string.IsNullOrEmpty(entity.CC_StartDate.ToString()) && !string.IsNullOrEmpty(entity.CC_EndDate.ToString()))
            {
                if (entity.CC_StartDate > entity.CC_EndDate)
                {
                    sb.Append("开始日期不能大于结束日期!");
                }
            }
            if (entity.CC_Amount < 0)
            {
                sb.Append("预算金额必须为正!");
            }
            if (!Regex.IsMatch(entity.CC_Amount.ToString(), @"^(?!0+(?:\.0+)?$)(?:[1-9]\d*|0)(?:\.\d{1,2})?$"))
            {
                sb.Append("预算金额格式错误,至多2位小数!");
            }
            if (!string.IsNullOrEmpty(entity.CC_LiableMan))
            {
                if (!userRepository.IsExists(entity.CC_LiableMan))
                {
                    sb.Append("责任人" + entity.CC_LiableMan + "不在用户表中!");
                }
            }           
            return sb.ToString();
        }

        /// <summary>
        /// 成本中心类型模板的验证
        /// </summary>
        /// <param name="entity">成本中心类型模板对象</param>
        public static string ValidateCCTTInputDto(CCTTInputDto entity)
        {
            //基础验证
            StringBuilder sb = BasicValidate<CCTTInputDto>(entity);
            //额外验证
            if (!string.IsNullOrEmpty(entity.CC_TT_AEACheckers ))
            {
                string[] CheckUsers = entity.CC_TT_AEACheckers.Split(',');
                foreach (string s in CheckUsers)
                {
                    if (!userRepository.IsExists(s))
                    {
                        sb.Append("行政审批人" + s + "不在用户表中!");
                    }

                }
            }
            if (!string.IsNullOrEmpty(entity.CC_TT_FinancialCheckers))
            {
                string[] CheckUsers2 = entity.CC_TT_FinancialCheckers.Split(',');
                foreach (string s in CheckUsers2)
                {
                    if (!userRepository.IsExists(s))
                    {
                        sb.Append("财政审批人" + s + "不在用户表中!");
                    }

                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// 考勤模板验证
        /// </summary>
        /// <param name="entity">考勤模板对象</param>
        public static string ValidateATInputDto(ATInputDto entity)
        {
            //基础验证
            StringBuilder sb = BasicValidate<ATInputDto>(entity);
            //额外验证(自定义日期的字段判断,不同的上下班类型,均存在不能为空的时间字段)
            if (entity.CustomDates!=null)
            {
                foreach (AT_CDInputDto ac in entity.CustomDates)
                {
                    sb.Append(ValidateAT_CDInputDto(ac));
                }
            }
            if (entity.AT_CommutingType == WorkTimeType.一天一上下班)
            {
                if (entity.AT_StartTime == null)
                {
                    sb.Append("上班时间不能为空.");
                }
                if (entity.AT_EndTime == null)
                {
                    sb.Append("下班时间不能为空.");
                }
            }
            else if (entity.AT_CommutingType == WorkTimeType.一天二上下班)
            {
                if (entity.AT_AMStartTime == null)
                {
                    sb.Append("上午上班时间不能为空.");
                }
                if (entity.AT_AMEndTime == null)
                {
                    sb.Append("上午下班时间不能为空.");
                }
                if (entity.AT_PMStartTime == null)
                {
                    sb.Append("下午上班时间不能为空.");
                }
                if (entity.AT_PMEndTime == null)
                {
                    sb.Append("下午下班时间不能为空.");
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// 考勤日志验证
        /// </summary>
        /// <param name="entity">考勤日志对象</param>
        public static string ValidateALInputDto(ALInputDto entity)
        {
            //基础验证
            StringBuilder sb = BasicValidate<ALInputDto>(entity);


            return sb.ToString();
        }


        /// <summary>
        /// 自定义日期验证
        /// </summary>
        /// <param name="entity">自定义日期对象</param>
        public static string ValidateAT_CDInputDto(AT_CDInputDto entity)
        {
            //基础验证
            StringBuilder sb = BasicValidate<AT_CDInputDto>(entity);
            //额外验证(自定义为上班,则不同的上下班类型,部分字段不能为空)
            if (entity.AT_CD_CDType ==WorkOrRest.上班)
            {
                if (entity.AT_CD_CommutingType == WorkTimeType.一天一上下班)
                {
                    if (entity.AT_CD_StartTime == null)
                    {
                        sb.Append("上班时间不能为空.");
                    }
                    if (entity.AT_CD_EndTime == null)
                    {
                        sb.Append("下班时间不能为空.");
                    }
                }
                else if (entity.AT_CD_CommutingType == WorkTimeType.一天二上下班)
                {
                    if (entity.AT_CD_AMStartTime == null)
                    {
                        sb.Append("上午上班时间不能为空.");
                    }
                    if (entity.AT_CD_AMEndTime == null)
                    {
                        sb.Append("上午下班时间不能为空.");
                    }
                    if (entity.AT_CD_PMStartTime == null)
                    {
                        sb.Append("下午上班时间不能为空.");
                    }
                    if (entity.AT_CD_PMEndTime == null)
                    {
                        sb.Append("下午下班时间不能为空.");
                    }
                }
            
            }
            

            return sb.ToString();
        }

        /// <summary>
        /// 基础验证
        /// </summary>
        /// <param name="entity">继承自IEntity的泛型对象</param>
        public static StringBuilder BasicValidate<T>(T entity) where T:SmoONE.DTOs.IEntity
        {
            StringBuilder sb = new StringBuilder();
            //基础验证
            if (entity != null)
            {
                foreach (var item in entity.IsValid())
                {
                    if (!string.IsNullOrEmpty(item.Message))
                    {
                        if (item.Message.Contains("必需的"))
                        {
                            sb.Append(item.FieldName+"是必需的!");
                        }
                        else
                        {
                            sb.Append(item.FieldName + item.Message + "!");
                        }
                    }
                }
            }
            else
            {
                string ShortName = entity.GetType().ToString().Replace("SmoONE.DTOs", "");
                string ShowName = DealName(ShortName);
                sb.Append("传入了空的"+ShowName+"对象.");
            }            
            return sb;
        }
        /// <summary>
        /// 群组验证
        /// </summary>
        /// <param name="entity">群组对象</param>
        public static string ValidateCGroupInputDto(CGroupInputDto entity)
        {
            //基础验证
            StringBuilder sb = BasicValidate<CGroupInputDto>(entity);
            if (entity.G_NAME  == null)
            {
                sb.Append("群组名称不能为空.");
            }

            return sb.ToString();
        }
        /// <summary>
        /// 联系人验证
        /// </summary>
        /// <param name="entity">联系人对象</param>
        public static string ValidateContactInputDto(ContactInputDto  entity)
        {
            //基础验证
            StringBuilder sb = BasicValidate<ContactInputDto>(entity);
            if (entity.C_USER == null)
            {
                sb.Append("联系人不能为空.");
            }

            return sb.ToString();
        }
        private static string DealName(string ShortName)
        {
            switch (ShortName)
            {
                case "CCTTInputDto":
                    return "成本中心类型模板";
                case "CCInputDto":
                    return "成本中心";
                case "LeaveInputDto":
                    return "请假单";
                case "RB_RowsInputDto":
                    return "消费记录";
                case "RBRTTInputDto":
                    return "报销类型模板";
                case "RBInputDto":
                    return "报销单";
                case "DepInputDto":
                    return "部门";
                case "UserInputDto":
                    return "用户";
                case "ALInputDto":
                    return "考勤记录";
                case "AT_CDInputDto":
                    return "自定义日期";
                case "ATInputDto":
                    return "考勤模板";
                default:
                    return "";
            }
        
        }
    }
}
