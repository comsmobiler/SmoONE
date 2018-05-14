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
            //映射InputDto到Entity
            Mapper.CreateMap<CCInputDto, SmoONE.Domain.CostCenter>();
            Mapper.CreateMap<CCTTInputDto, SmoONE.Domain.CC_Type_Template>();
            Mapper.CreateMap<DepInputDto, SmoONE.Domain.Department>();
            Mapper.CreateMap<LeaveInputDto, SmoONE.Domain.Leave>();
            Mapper.CreateMap<RB_RowsInputDto, SmoONE.Domain.RB_Rows>();
            Mapper.CreateMap<RBInputDto, SmoONE.Domain.Reimbursement>();
            Mapper.CreateMap<RBRTTInputDto, SmoONE.Domain.RB_RType_Template>();
            Mapper.CreateMap<UserInputDto, SmoONE.Domain.User>();
            Mapper.CreateMap<ContactInputDto, SmoONE.Domain.Contact >();
            Mapper.CreateMap<CGroupInputDto, SmoONE.Domain.CGroup >();
            //考勤新加
            //名称相同的,会自动匹配映射,但是名称不同的,需要手动配置(比如L_CreateUser→U_ID)
            Mapper.CreateMap<ALInputDto, SmoONE.Domain.AttendanceLog>()
                .ForMember(al=>al.AL_CommutingType,(map)=>map.MapFrom(dto=>dto.AL_CommutingType.ToString()))
                .ForMember(al=>al.AL_LogTimeType,(map)=>map.MapFrom(dto=>dto.AL_LogTimeType.ToString()))
                .ForMember(al=>al.AL_Status,(map)=>map.MapFrom(dto=>dto.AL_Status.ToString()));
            Mapper.CreateMap<AT_CDInputDto, SmoONE.Domain.AT_CustomDate>()
                .ForMember(ac => ac.AT_CD_CDType, (map) => map.MapFrom(dto => dto.AT_CD_CDType.ToString()))
                .ForMember(ac => ac.AT_CD_CommutingType, (map) => map.MapFrom(dto => dto.AT_CD_CommutingType.ToString()));
            Mapper.CreateMap<ATInputDto, SmoONE.Domain.AttendanceTemplate>()
                .ForMember(at => at.AT_CommutingType, (map) => map.MapFrom(dto => dto.AT_CommutingType.ToString()));
            Mapper.CreateMap<MonthlyResultDto, SmoONE.Domain.MonthlyResult>();
            Mapper.CreateMap<DailyStatisticsDto, SmoONE.Domain.DailyStatistics>();
            Mapper.CreateMap<MonthlyStatisticsDto, SmoONE.Domain.MonthlyStatistics>();
            

            //映射Entity到查询用的Dto
            Mapper.CreateMap<SmoONE.Domain.CC_Type_Template, CC_Type_TemplateDto>();
            Mapper.CreateMap<SmoONE.Domain.CostCenter, CCDetailDto>();
            Mapper.CreateMap<SmoONE.Domain.CostCenter, CCDto>();
            Mapper.CreateMap<SmoONE.Domain.Department, DepartmentDto>();
            Mapper.CreateMap<SmoONE.Domain.Department, DepDetailDto>();
            Mapper.CreateMap<SmoONE.Domain.Leave, LeaveDetailDto>();
            //名称相同的,会自动匹配映射,但是名称不同的,需要手动配置(比如L_CreateUser→U_ID)
            Mapper.CreateMap<SmoONE.Domain.Leave, LeaveDto>().ForMember(dto => dto.U_ID, (map) => map.MapFrom(m => m.L_CreateUser));
            Mapper.CreateMap<SmoONE.Domain.RB_Rows, RB_RowsDto>();
            Mapper.CreateMap<SmoONE.Domain.RB_RType_Template, RB_RType_TemplateDto>();
            Mapper.CreateMap<SmoONE.Domain.Reimbursement, RBDetailDto>();
            Mapper.CreateMap<SmoONE.Domain.Reimbursement, ReimbursementDto>().ForMember(dto => dto.U_ID, (map) => map.MapFrom(m => m.RB_CreateUser));
            Mapper.CreateMap<SmoONE.Domain.User, UserDepDto>().ForMember(dto => dto.Dep_ID, (map) => map.MapFrom(m => m.U_DepID));
            Mapper.CreateMap<SmoONE.Domain.User, UserDetailDto>();
            Mapper.CreateMap<SmoONE.Domain.User, UserDto>();
            Mapper.CreateMap<SmoONE.Domain.Contact, ContactDto>();
            Mapper.CreateMap<SmoONE.Domain.CGroup, CGroupDto>();

            //考勤新加
            Mapper.CreateMap<SmoONE.Domain.AttendanceLog, ALDto>();
            Mapper.CreateMap<SmoONE.Domain.AT_CustomDate, ATCDDetailDto>();
            Mapper.CreateMap<SmoONE.Domain.AttendanceTemplate, ATDetailDto>();
            Mapper.CreateMap<SmoONE.Domain.AttendanceTemplate, ATDto>();
            Mapper.CreateMap<SmoONE.Domain.MonthlyResult, MonthlyResultDto>();
            //未必有用
            Mapper.CreateMap<SmoONE.Domain.DailyStatistics, DailyStatisticsDto>();
            Mapper.CreateMap<SmoONE.Domain.MonthlyStatistics, MonthlyStatisticsDto>();
        }
    }
}
