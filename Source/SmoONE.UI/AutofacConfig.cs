using Autofac;
using SmoONE.Application;
using SmoONE.Domain.IRepository;
using SmoONE.Infrastructure;
using SmoONE.Repository;
using SmoONE.Repository.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmoONE.UI
{
    /// <summary>
    /// Autofac配置类
    /// </summary>
    public class AutofacConfig
    {
        /// <summary>
        /// 成本中心相关服务的接口
        /// </summary>
        public Application.ICostCenterService costCenterService;

        /// <summary>
        /// 部门相关服务的接口
        /// </summary>
        public Application.IDepartmentService departmentService;

        /// <summary>
        /// 请假单相关服务的接口
        /// </summary>
        public Application.ILeaveService leaveService;

        /// <summary>
        /// 报销单相关服务的接口
        /// </summary>
        public IReimbursementService rBService;

        /// <summary>
        /// 用户相关服务的接口
        /// </summary>
        public IUserService userService;

        /// <summary>
        /// 考勤相关服务的接口
        /// </summary>
        public IAttendanceService attendanceService;

        /// <summary>
        /// 联系人相关服务的接口
        /// </summary>
        public Application.IServices.IContactService contactService;

        /// <summary>
        /// 联系人群组相关服务的接口
        /// </summary>
        public Application.IServices.ICGroupService cGroupService;

        /// <summary>
        /// Ioc容器
        /// </summary>
        private ContainerBuilder containerBuilder;

        /// <summary>
        /// 初始化
        /// </summary>
        public void Init()
        {
            this.containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterType<SmoONEDbContext>().As<IDbContext>().SingleInstance();
            containerBuilder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();
            //
            containerBuilder.RegisterType<CC_Type_TemplateRepository>().As<ICC_Type_TemplateRepository>().InstancePerDependency();
            containerBuilder.RegisterType<CostCenter_TypeRepository>().As<ICostCenter_TypeRepository>().InstancePerDependency();
            containerBuilder.RegisterType<CostCenterRepository>().As<ICostCenterRepository>().InstancePerDependency();
            containerBuilder.RegisterType<DepartmentRepository>().As<IDepartmentRepository>().InstancePerDependency();
            containerBuilder.RegisterType<LeaveRepository>().As<ILeaveRepository>().InstancePerDependency();
            containerBuilder.RegisterType<LeaveTypeRepository>().As<ILeaveTypeRepository>().InstancePerDependency();
            containerBuilder.RegisterType<LogRepository>().As<ILogRepository>().InstancePerDependency();
            containerBuilder.RegisterType<MenuRepository>().As<IMenuRepository>().InstancePerDependency();
            containerBuilder.RegisterType<RB_RowsRepository>().As<IRB_RowsRepository>().InstancePerDependency();
            containerBuilder.RegisterType<RB_Type_TemplateRepository>().As<IRB_Type_TemplateRepository>().InstancePerDependency();
            containerBuilder.RegisterType<RB_TypeRepository>().As<IRB_TypeRepository>().InstancePerDependency();
            containerBuilder.RegisterType<ReimbursementRepository>().As<IReimbursementRepository>().InstancePerDependency();
            containerBuilder.RegisterType<RoleMenuRepository>().As<IRoleMenuRepository>().InstancePerDependency();
            containerBuilder.RegisterType<RoleRepository>().As<IRoleRepository>().InstancePerDependency();
            containerBuilder.RegisterType<UserRepository>().As<IUserRepository>().InstancePerDependency();
            containerBuilder.RegisterType<UserRoleRepository>().As<IUserRoleRepository>().InstancePerDependency();
            containerBuilder.RegisterType<ContactRepository>().As<IContactRepository>().InstancePerDependency();


            containerBuilder.RegisterType<AT_CustomDateRepository>().As<IAT_CustomDateRepository>().InstancePerDependency();
            containerBuilder.RegisterType<AttendanceLogRepository>().As<IAttendanceLogRepository>().InstancePerDependency();
            containerBuilder.RegisterType<AttendanceTemplateRepository>().As<IAttendanceTemplateRepository>().InstancePerDependency();
            containerBuilder.RegisterType<AttendanceSchedulingRepository>().As<IAttendanceSchedulingRepository>().InstancePerDependency();
            containerBuilder.RegisterType<DailyStatisticsRepository>().As<IDailyStatisticsRepository>().InstancePerDependency();
            containerBuilder.RegisterType<MonthlyStatisticsRepository>().As<IMonthlyStatisticsRepository>().InstancePerDependency();
            containerBuilder.RegisterType<AT_UserLogRepository>().As<IAT_UserLogRepository>().InstancePerDependency();
            containerBuilder.RegisterType<MonthlyResultRepository>().As<IMonthlyResultRepository>().InstancePerDependency();

            containerBuilder.RegisterType<CGroupRepository>().As<ICGroupRepository>().InstancePerDependency();
            containerBuilder.RegisterType<ValidateCodeRepository>().As<IValidateCodeRepository>().InstancePerDependency();

            containerBuilder.RegisterType<CostCenterService>().As<ICostCenterService>().InstancePerLifetimeScope();
            containerBuilder.RegisterType<DepartmentService>().As<IDepartmentService>().InstancePerLifetimeScope();
            containerBuilder.RegisterType<LeaveService>().As<ILeaveService>().InstancePerLifetimeScope();
            containerBuilder.RegisterType<ReimbursementService>().As<IReimbursementService>().InstancePerLifetimeScope();
            containerBuilder.RegisterType<UserService>().As<IUserService>().InstancePerLifetimeScope();
            containerBuilder.RegisterType<AttendanceService>().As<IAttendanceService>().InstancePerLifetimeScope();

            containerBuilder.RegisterType<Application.Services.ContactService>().As<Application.IServices.IContactService>().InstancePerLifetimeScope();
            containerBuilder.RegisterType<Application.Services.CGroupService >().As<Application.IServices.ICGroupService >().InstancePerLifetimeScope();
        }

        /// <summary>
        /// 构造函数,最终得到新的服务实例
        /// </summary>
        public AutofacConfig()
        {
            if (this.containerBuilder == null)
            {
                Init();
            }
            IContainer container = this.containerBuilder.Build();
            IDbContext db = container.Resolve<IDbContext>();
            this.costCenterService = container.Resolve<ICostCenterService>();
            this.departmentService = container.Resolve<IDepartmentService>();
            this.leaveService = container.Resolve<ILeaveService>();
            this.rBService = container.Resolve<IReimbursementService>();
            this.userService = container.Resolve<IUserService>();
            this.attendanceService = container.Resolve<IAttendanceService>();
            this.contactService  = container.Resolve<Application.IServices.IContactService>();
            this.cGroupService  = container.Resolve<Application.IServices.ICGroupService>();
        }
    }
}

