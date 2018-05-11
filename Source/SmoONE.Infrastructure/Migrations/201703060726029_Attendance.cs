namespace SmoONE.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Attendance : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AT_CustomDate",
                c => new
                    {
                        AT_CD_ID = c.Int(nullable: false, identity: true),
                        AT_CD_ATID = c.String(maxLength: 20),
                        AT_CD_CommutingType = c.String(nullable: false, maxLength: 20),
                        AT_CD_Date = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        AT_CD_CDType = c.String(nullable: false, maxLength: 20),
                        AT_CD_StartTime = c.DateTime(precision: 7, storeType: "datetime2"),
                        AT_CD_EndTime = c.DateTime(precision: 7, storeType: "datetime2"),
                        AT_CD_AMStartTime = c.DateTime(precision: 7, storeType: "datetime2"),
                        AT_CD_AMEndTime = c.DateTime(precision: 7, storeType: "datetime2"),
                        AT_CD_PMStartTime = c.DateTime(precision: 7, storeType: "datetime2"),
                        AT_CD_PMEndTime = c.DateTime(precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.AT_CD_ID);
            
            CreateTable(
                "dbo.AT_UserLog",
                c => new
                    {
                        AT_UL_ID = c.Int(nullable: false, identity: true),
                        AT_UL_UserID = c.String(nullable: false, maxLength: 20),
                        AT_UL_ATID = c.String(nullable: false, maxLength: 20),
                        AT_UL_StartTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        AT_UL_EndTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        AT_UL_CreateDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.AT_UL_ID);
            
            CreateTable(
                "dbo.AttendanceLog",
                c => new
                    {
                        AL_LogID = c.Int(nullable: false, identity: true),
                        AL_UserID = c.String(nullable: false, maxLength: 20),
                        AL_Date = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        AL_CommutingType = c.String(nullable: false, maxLength: 20),
                        AL_LogTimeType = c.String(nullable: false, maxLength: 20),
                        AL_OnTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        AL_Status = c.String(nullable: false),
                        AL_Position = c.String(maxLength: 50),
                        AL_Reason = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.AL_LogID);
            
            CreateTable(
                "dbo.AttendanceScheduling",
                c => new
                    {
                        AS_ID = c.Int(nullable: false, identity: true),
                        AS_ATID = c.String(nullable: false, maxLength: 20),
                        AS_DateTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        AS_CommutingType = c.String(nullable: false, maxLength: 20),
                        AS_ASType = c.String(nullable: false, maxLength: 20),
                        AS_StartTime = c.DateTime(precision: 7, storeType: "datetime2"),
                        AS_EndTime = c.DateTime(precision: 7, storeType: "datetime2"),
                        AS_AMStartTime = c.DateTime(precision: 7, storeType: "datetime2"),
                        AS_AMEndTime = c.DateTime(precision: 7, storeType: "datetime2"),
                        AS_PMStartTime = c.DateTime(precision: 7, storeType: "datetime2"),
                        AS_PMEndTime = c.DateTime(precision: 7, storeType: "datetime2"),
                        AS_Users = c.String(nullable: false),
                        AS_Longitude = c.Decimal(nullable: false, precision: 11, scale: 8),
                        AS_Latitude = c.Decimal(nullable: false, precision: 11, scale: 8),
                        AS_Positions = c.String(nullable: false, maxLength: 500),
                        AS_AllowableDeviation = c.Int(nullable: false),
                        AS_CreateDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        AS_LogCount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AS_ID);
            
            CreateTable(
                "dbo.AttendanceTemplate",
                c => new
                    {
                        AT_ID = c.String(nullable: false, maxLength: 20),
                        AT_Name = c.String(nullable: false, maxLength: 20),
                        AT_CommutingType = c.String(nullable: false, maxLength: 20),
                        AT_WeeklyWorkingDay = c.String(nullable: false, maxLength: 50),
                        AT_StartTime = c.DateTime(precision: 7, storeType: "datetime2"),
                        AT_EndTime = c.DateTime(precision: 7, storeType: "datetime2"),
                        AT_AMStartTime = c.DateTime(precision: 7, storeType: "datetime2"),
                        AT_AMEndTime = c.DateTime(precision: 7, storeType: "datetime2"),
                        AT_PMStartTime = c.DateTime(precision: 7, storeType: "datetime2"),
                        AT_PMEndTime = c.DateTime(precision: 7, storeType: "datetime2"),
                        AT_Users = c.String(),
                        AT_Longitude = c.Decimal(nullable: false, precision: 11, scale: 8),
                        AT_Latitude = c.Decimal(nullable: false, precision: 11, scale: 8),
                        AT_Positions = c.String(nullable: false, maxLength: 500),
                        AT_AllowableDeviation = c.Int(nullable: false),
                        AT_EffectiveDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        AT_CreateDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        AT_CreateUser = c.String(nullable: false, maxLength: 20),
                        AT_UpdateDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        AT_UpdateUser = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.AT_ID);
            
            CreateTable(
                "dbo.DailyStatistics",
                c => new
                    {
                        DS_ID = c.Int(nullable: false, identity: true),
                        DS_UserID = c.String(maxLength: 20),
                        DS_Date = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        DS_AllCount = c.Int(nullable: false),
                        DS_RealCount = c.Int(nullable: false),
                        DS_InTimeCount = c.Int(nullable: false),
                        DS_ComeLateCount = c.Int(nullable: false),
                        DS_LeaveEarlyCount = c.Int(nullable: false),
                        DS_NoSignInCount = c.Int(nullable: false),
                        DS_NoSignOutCount = c.Int(nullable: false),
                        DS_IsNormal = c.Int(nullable: false),
                        DS_IsAbsent = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DS_ID);
            
            CreateTable(
                "dbo.MonthlyResult",
                c => new
                    {
                        MR_ID = c.Int(nullable: false, identity: true),
                        MR_Year = c.Int(nullable: false),
                        MR_Month = c.Int(nullable: false),
                        MR_AllUserCount = c.Int(nullable: false),
                        MR_InTimeUserCount = c.Int(nullable: false),
                        MR_InTimeUser = c.String(),
                        MR_ComeLateUserCount = c.Int(nullable: false),
                        MR_ComeLateUser = c.String(),
                        MR_LeaveEarlyUserCount = c.Int(nullable: false),
                        MR_LeaveEarlyUser = c.String(),
                        MR_NoSignUserCount = c.Int(nullable: false),
                        MR_NoSignUser = c.String(),
                        MR_AbsentUserCount = c.Int(nullable: false),
                        MR_AbsentUser = c.String(),
                    })
                .PrimaryKey(t => t.MR_ID);
            
            CreateTable(
                "dbo.MonthlyStatistics",
                c => new
                    {
                        MS_ID = c.Int(nullable: false, identity: true),
                        MS_UserID = c.String(maxLength: 20),
                        MS_Year = c.Int(nullable: false),
                        MS_Month = c.Int(nullable: false),
                        MS_AllCount = c.Int(nullable: false),
                        MS_RealCount = c.Int(nullable: false),
                        MS_InTimeCount = c.Int(nullable: false),
                        MS_ComeLateCount = c.Int(nullable: false),
                        MS_LeaveEarlyCount = c.Int(nullable: false),
                        MS_NoSignInCount = c.Int(nullable: false),
                        MS_NoSignOutCount = c.Int(nullable: false),
                        DS_AllDayCount = c.Int(nullable: false),
                        DS_NormalDayCount = c.Int(nullable: false),
                        DS_AbsentDayCount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MS_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MonthlyStatistics");
            DropTable("dbo.MonthlyResult");
            DropTable("dbo.DailyStatistics");
            DropTable("dbo.AttendanceTemplate");
            DropTable("dbo.AttendanceScheduling");
            DropTable("dbo.AttendanceLog");
            DropTable("dbo.AT_UserLog");
            DropTable("dbo.AT_CustomDate");
        }
    }
}
