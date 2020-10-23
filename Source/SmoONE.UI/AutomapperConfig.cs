using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using SmoONE.DTOs;
using SmoONE.Domain;

namespace SmoONE.UI
{
    /// <summary>
    /// AutoMapper配置类
    /// </summary>
    public static class AutomapperConfig
    {
        public static void Init()
        {
            Mapper.Initialize(x => {
                //映射InputDto到Entity
                x.CreateMap<CCInputDto, SmoONE.Domain.CostCenter>();
                x.CreateMap<CCTTInputDto, SmoONE.Domain.CC_Type_Template>();
                x.CreateMap<DepInputDto, SmoONE.Domain.Department>();
                x.CreateMap<LeaveInputDto, SmoONE.Domain.Leave>();
                x.CreateMap<RB_RowsInputDto, SmoONE.Domain.RB_Rows>();
                x.CreateMap<RBInputDto, SmoONE.Domain.Reimbursement>();
                x.CreateMap<RBRTTInputDto, SmoONE.Domain.RB_RType_Template>();
                x.CreateMap<UserInputDto, SmoONE.Domain.User>();
                x.CreateMap<ContactInputDto, SmoONE.Domain.Contact>();
                x.CreateMap<CGroupInputDto, SmoONE.Domain.CGroup>();
                //考勤新加
                //名称相同的,会自动匹配映射,但是名称不同的,需要手动配置(比如L_CreateUser→U_ID)
                x.CreateMap<ALInputDto, SmoONE.Domain.AttendanceLog>()
                    .ForMember(al => al.AL_CommutingType, (map) => map.MapFrom(dto => dto.AL_CommutingType.ToString()))
                    .ForMember(al => al.AL_LogTimeType, (map) => map.MapFrom(dto => dto.AL_LogTimeType.ToString()))
                    .ForMember(al => al.AL_Status, (map) => map.MapFrom(dto => dto.AL_Status.ToString()));
                x.CreateMap<AT_CDInputDto, SmoONE.Domain.AT_CustomDate>()
                    .ForMember(ac => ac.AT_CD_CDType, (map) => map.MapFrom(dto => dto.AT_CD_CDType.ToString()))
                    .ForMember(ac => ac.AT_CD_CommutingType, (map) => map.MapFrom(dto => dto.AT_CD_CommutingType.ToString()));
                x.CreateMap<ATInputDto, SmoONE.Domain.AttendanceTemplate>()
                    .ForMember(at => at.AT_CommutingType, (map) => map.MapFrom(dto => dto.AT_CommutingType.ToString()));
                x.CreateMap<MonthlyResultDto, SmoONE.Domain.MonthlyResult>();
                x.CreateMap<DailyStatisticsDto, SmoONE.Domain.DailyStatistics>();
                x.CreateMap<MonthlyStatisticsDto, SmoONE.Domain.MonthlyStatistics>();


                //映射Entity到查询用的Dto
                x.CreateMap<SmoONE.Domain.CC_Type_Template, CC_Type_TemplateDto>();
                x.CreateMap<SmoONE.Domain.CostCenter, CCDetailDto>();
                x.CreateMap<SmoONE.Domain.CostCenter, CCDto>();
                x.CreateMap<SmoONE.Domain.Department, DepartmentDto>();
                x.CreateMap<SmoONE.Domain.Department, DepDetailDto>();
                x.CreateMap<SmoONE.Domain.Leave, LeaveDetailDto>();
                //名称相同的,会自动匹配映射,但是名称不同的,需要手动配置(比如L_CreateUser→U_ID)
                x.CreateMap<SmoONE.Domain.Leave, LeaveDto>().ForMember(dto => dto.U_ID, (map) => map.MapFrom(m => m.L_CreateUser));
                x.CreateMap<SmoONE.Domain.RB_Rows, RB_RowsDto>();
                x.CreateMap<SmoONE.Domain.RB_RType_Template, RB_RType_TemplateDto>();
                x.CreateMap<SmoONE.Domain.Reimbursement, RBDetailDto>();
                x.CreateMap<SmoONE.Domain.Reimbursement, ReimbursementDto>().ForMember(dto => dto.U_ID, (map) => map.MapFrom(m => m.RB_CreateUser));
                x.CreateMap<SmoONE.Domain.User, UserDepDto>().ForMember(dto => dto.Dep_ID, (map) => map.MapFrom(m => m.U_DepID));
                x.CreateMap<SmoONE.Domain.User, UserDetailDto>();
                x.CreateMap<SmoONE.Domain.User, UserDto>();
                x.CreateMap<SmoONE.Domain.Contact, ContactDto>();
                x.CreateMap<SmoONE.Domain.CGroup, CGroupDto>();

                //考勤新加
                x.CreateMap<SmoONE.Domain.AttendanceLog, ALDto>();
                x.CreateMap<SmoONE.Domain.AT_CustomDate, ATCDDetailDto>();
                x.CreateMap<SmoONE.Domain.AttendanceTemplate, ATDetailDto>();
                x.CreateMap<SmoONE.Domain.AttendanceTemplate, ATDto>();
                x.CreateMap<SmoONE.Domain.MonthlyResult, MonthlyResultDto>();
                //未必有用
                x.CreateMap<SmoONE.Domain.DailyStatistics, DailyStatisticsDto>();
                x.CreateMap<SmoONE.Domain.MonthlyStatistics, MonthlyStatisticsDto>();
            });
          
        }
    }
}
