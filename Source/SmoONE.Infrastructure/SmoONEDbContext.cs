using SmoONE.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmoONE.Infrastructure
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2016/11
    // 主要内容：  数据库上下文的实现
    // ******************************************************************
    /// <summary>
    /// 数据库上下文的实现
    /// </summary>
    public class SmoONEDbContext : DbContext, IDbContext
    {
        #region 构造函数

        /// <summary>
        ///     初始化一个 使用连接名称为“default”的数据访问上下文类 的新实例
        /// </summary>
        public SmoONEDbContext()
            : base("default")
        {
            //手动创建了数据库和表,不用产生系统表
            //if (!Database.Exists("default"))
            //{
            //    Database.SetInitializer<SmoONEDbContext>(
            //            new DropCreateDatabaseIfModelChanges<SmoONEDbContext>());
            //}
            //自动创建更新数据库和表,产生系统表
            //Database.SetInitializer<SmoONEDbContext>(null);
            Database.SetInitializer<SmoONEDbContext>(
                    new DropCreateDatabaseIfModelChanges<SmoONEDbContext>());
            this.Configuration.LazyLoadingEnabled = false;
        }

        /// <summary>
        /// 初始化一个 使用指定数据连接名称或连接串 的数据访问上下文类 的新实例
        /// </summary>
        public SmoONEDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString) { }

        #endregion

        #region 属性

        /// <summary>
        /// 申明所需要映射的所有类
        /// </summary>

        public DbSet<User> Users { get; set; }

        public DbSet<Leave> Leaves { get; set; }

        public DbSet<LeaveType> LeaveTypes { get; set; }

        public DbSet<Reimbursement> Reimbursements { get; set; }

        public DbSet<RB_Rows> RB_Rows { get; set; }

        public DbSet<RB_RType> RB_Types { get; set; }

        public DbSet<Log> Logs { get; set; }

        public DbSet<CC_Type_Template> CC_Type_Templates { get; set; }

        public DbSet<CostCenter> CostCenters { get; set; }

        public DbSet<CostCenter_Type> CostCenter_Types { get; set; }

        public DbSet<RB_RType_Template> RB_Type_Templates { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Menu> Menus { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<UserRole> UserRoles { get; set; }

        public DbSet<ValidateCode> ValidateCodes { get; set; }

        public DbSet<RoleMenu> RoleMenus { get; set; }

        //新增的,考勤相关
        public DbSet<AT_CustomDate> AT_CustomDates { get; set; }

        public DbSet<AttendanceLog> AttendanceLogs { get; set; }

        public DbSet<AttendanceTemplate> AttendanceTemplates { get; set; }

        public DbSet<AttendanceScheduling> AttendanceSchedulings { get; set; }

        public DbSet<DailyStatistics> DailyStatistics { get; set; }

        public DbSet<MonthlyStatistics> MonthlyStatistics { get; set; }

        public DbSet<AT_UserLog> AT_UserLogs { get; set; }

        public DbSet<MonthlyResult> MonthlyResults { get; set; }

        public DbSet<Contact > Contacts { get; set; }

        public DbSet<CGroup> CGroups { get; set; }

        #endregion

        /// <summary>
        /// 数据库模型产生时执行
        /// </summary>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {            
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //移除一对多的级联删除约定，想要级联删除可以在 EntityTypeConfiguration<TEntity>的实现类中进行控制
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            //比较基础的映射配置,在Domain的Entity文件夹下已经配置了(通过Data Annotations)
            //配置需要额外映射的属性（通过Fluent API）
            modelBuilder.Configurations.Add(new LeaveConfiguration());
            modelBuilder.Configurations.Add(new ReimbursementConfiguration());
            modelBuilder.Configurations.Add(new RB_RowsConfiguration());
            modelBuilder.Configurations.Add(new CostCenterConfiguration());
            modelBuilder.Configurations.Add(new DepartmentConfiguration());
            modelBuilder.Configurations.Add(new RB_Type_TemplateConfiguration());
            //新增加的
            modelBuilder.Configurations.Add(new AttendanceTemplateConfiguration());
            modelBuilder.Configurations.Add(new AttendanceSchedulingConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}