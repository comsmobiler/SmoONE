namespace SmoONE.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.User",
                c => new
                    {
                        U_ID = c.String(nullable: false, maxLength: 20),
                        U_Name = c.String(nullable: false, maxLength: 50),
                        U_Portrait = c.String(maxLength: 50),
                        U_Pwd = c.String(nullable: false, maxLength: 50),
                        U_Sex = c.Int(nullable: false),
                        U_Email = c.String(maxLength: 50),
                        U_Tel = c.String(maxLength: 20),
                        U_IsCheck = c.Int(nullable: false),
                        U_IsCC = c.Int(nullable: false),
                        U_Birthday = c.DateTime(nullable: false, storeType: "datetime2"),
                        U_DepID = c.String(maxLength: 20),
                        U_CreateDate = c.DateTime(nullable: false, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.U_ID);
            
            CreateTable(
                "dbo.Leave",
                c => new
                    {
                        L_ID = c.String(nullable: false, maxLength: 20),
                        L_TypeID = c.String(nullable: false, maxLength: 20),
                        L_StartDate = c.DateTime(nullable: false, storeType: "datetime2"),
                        L_EndDate = c.DateTime(nullable: false, storeType: "datetime2"),
                        L_LDay = c.Decimal(nullable: false, precision: 10, scale: 1),
                        L_Reason = c.String(maxLength: 500),
                        L_Img1 = c.String(maxLength: 50),
                        L_Img2 = c.String(maxLength: 50),
                        L_Img3 = c.String(maxLength: 50),
                        L_Img4 = c.String(maxLength: 50),
                        L_Img5 = c.String(maxLength: 50),
                        L_Img6 = c.String(maxLength: 50),
                        L_Img7 = c.String(maxLength: 50),
                        L_Img8 = c.String(maxLength: 50),
                        L_Img9 = c.String(maxLength: 50),
                        L_CheckUsers = c.String(nullable: false, maxLength: 200),
                        L_CurrantCheck = c.String(maxLength: 20),
                        L_Status = c.Int(nullable: false),
                        L_CCTo = c.String(maxLength: 200),
                        L_RejectionReason = c.String(maxLength: 500),
                        L_CreateUser = c.String(maxLength: 20),
                        L_CreateDate = c.DateTime(nullable: false, storeType: "datetime2"),
                        L_UpdateUser = c.String(maxLength: 20),
                        L_UpdateDate = c.DateTime(nullable: false, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.L_ID);
            
            CreateTable(
                "dbo.LeaveType",
                c => new
                    {
                        L_T_ID = c.String(nullable: false, maxLength: 20),
                        L_T_Name = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.L_T_ID);
            
            CreateTable(
                "dbo.Reimbursement",
                c => new
                    {
                        RB_ID = c.String(nullable: false, maxLength: 20),
                        RB_TotalAmount = c.Decimal(nullable: false, precision: 10, scale: 2),
                        RB_Note = c.String(maxLength: 500),
                        RB_Img1 = c.String(maxLength: 50),
                        RB_Img2 = c.String(maxLength: 50),
                        RB_Img3 = c.String(maxLength: 50),
                        RB_Img4 = c.String(maxLength: 50),
                        RB_Img5 = c.String(maxLength: 50),
                        RB_Img6 = c.String(maxLength: 50),
                        RB_Img7 = c.String(maxLength: 50),
                        RB_Img8 = c.String(maxLength: 50),
                        RB_Img9 = c.String(maxLength: 50),
                        RB_LiableMan = c.String(nullable: false, maxLength: 20),
                        RB_AEACheckers = c.String(nullable: false, maxLength: 200),
                        RB_FinancialCheckers = c.String(nullable: false, maxLength: 200),
                        RB_CurrantLiableMan = c.String(maxLength: 20),
                        RB_LiableDate = c.DateTime(nullable: false, storeType: "datetime2"),
                        RB_CurrantAEACheck = c.String(maxLength: 20),
                        RB_AEADate = c.DateTime(nullable: false, storeType: "datetime2"),
                        RB_CurrantFinCheck = c.String(maxLength: 20),
                        RB_FinDate = c.DateTime(nullable: false, storeType: "datetime2"),
                        RB_CurrantCheck = c.String(maxLength: 20),
                        RB_Status = c.Int(nullable: false),
                        RB_RejectionReason = c.String(maxLength: 500),
                        RB_CreateUser = c.String(maxLength: 20),
                        RB_CreateDate = c.DateTime(nullable: false, storeType: "datetime2"),
                        RB_UpdateUser = c.String(maxLength: 20),
                        RB_UpdateDate = c.DateTime(nullable: false, storeType: "datetime2"),
                        CC_ID = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.RB_ID);
            
            CreateTable(
                "dbo.RB_Rows",
                c => new
                    {
                        R_ID = c.Int(nullable: false, identity: true),
                        RB_ID = c.String(maxLength: 20),
                        R_Amount = c.Decimal(nullable: false, precision: 10, scale: 2),
                        R_TypeID = c.String(nullable: false, maxLength: 20),
                        R_Note = c.String(nullable: false, maxLength: 500),
                        R_CreateUser = c.String(maxLength: 20),
                        R_CreateDate = c.DateTime(nullable: false, storeType: "datetime2"),
                        R_ConsumeDate = c.DateTime(nullable: false, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.R_ID);
            
            CreateTable(
                "dbo.RB_RType",
                c => new
                    {
                        RB_RT_ID = c.String(nullable: false, maxLength: 20),
                        RB_RT_Name = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.RB_RT_ID);
            
            CreateTable(
                "dbo.Log",
                c => new
                    {
                        L_ID = c.Int(nullable: false, identity: true),
                        U_ID = c.String(nullable: false, maxLength: 20),
                        L_LoginTime = c.DateTime(nullable: false, storeType: "datetime2"),
                        L_Result = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.L_ID);
            
            CreateTable(
                "dbo.CC_Type_Template",
                c => new
                    {
                        CC_TT_TemplateID = c.String(nullable: false, maxLength: 20),
                        CC_TT_TypeID = c.String(nullable: false, maxLength: 20),
                        CC_TT_AEACheckers = c.String(nullable: false, maxLength: 200),
                        CC_TT_FinancialCheckers = c.String(nullable: false, maxLength: 200),
                        CC_TT_UpdateUser = c.String(maxLength: 20),
                        CC_TT_UpdateDate = c.DateTime(nullable: false, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.CC_TT_TemplateID);
            
            CreateTable(
                "dbo.CostCenter",
                c => new
                    {
                        CC_ID = c.String(nullable: false, maxLength: 20),
                        CC_Name = c.String(nullable: false, maxLength: 20),
                        CC_TypeID = c.String(nullable: false, maxLength: 20),
                        CC_LiableMan = c.String(nullable: false, maxLength: 20),
                        CC_DepartmentID = c.String(nullable: false, maxLength: 20),
                        CC_StartDate = c.DateTime(nullable: false, storeType: "datetime2"),
                        CC_EndDate = c.DateTime(nullable: false, storeType: "datetime2"),
                        CC_Amount = c.Decimal(nullable: false, precision: 10, scale: 2),
                        CC_TemplateID = c.String(nullable: false, maxLength: 20),
                        CC_UsedAmount = c.Decimal(nullable: false, precision: 10, scale: 2),
                        CC_IsActive = c.Int(nullable: false),
                        CC_CreateUser = c.String(maxLength: 20),
                        CC_CreateDate = c.DateTime(nullable: false, storeType: "datetime2"),
                        CC_UpdateUser = c.String(maxLength: 20),
                        CC_UpdateDate = c.DateTime(nullable: false, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.CC_ID);
            
            CreateTable(
                "dbo.CostCenter_Type",
                c => new
                    {
                        CC_T_TypeID = c.String(nullable: false, maxLength: 20),
                        CC_T_Description = c.String(nullable: false, maxLength: 20),
                        CC_T_IsActive = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CC_T_TypeID);
            
            CreateTable(
                "dbo.RB_RType_Template",
                c => new
                    {
                        RB_RTT_TemplateID = c.String(nullable: false, maxLength: 20),
                        RB_RTT_TypeID = c.String(nullable: false, maxLength: 20),
                        RB_RTT_Amount = c.Decimal(nullable: false, precision: 10, scale: 2),
                        RB_RTT_Note = c.String(maxLength: 200),
                        RB_RTT_CreateUser = c.String(maxLength: 20),
                        RB_RTT_CreateDate = c.DateTime(nullable: false, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.RB_RTT_TemplateID);
            
            CreateTable(
                "dbo.Department",
                c => new
                    {
                        Dep_ID = c.String(nullable: false, maxLength: 20),
                        Dep_Name = c.String(nullable: false, maxLength: 20),
                        Dep_IsActive = c.Int(nullable: false),
                        Dep_Leader = c.String(nullable: false, maxLength: 20),
                        Dep_UpdateUser = c.String(maxLength: 20),
                        Dep_UpdateDate = c.DateTime(nullable: false, storeType: "datetime2"),
                        Dep_ProDay = c.Decimal(nullable: false, precision: 10, scale: 1),
                        Dep_OtherDay = c.Decimal(nullable: false, precision: 10, scale: 1),
                        Dep_Icon = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Dep_ID);
            
            CreateTable(
                "dbo.Menu",
                c => new
                    {
                        M_MenuID = c.String(nullable: false, maxLength: 20),
                        M_Description = c.String(nullable: false, maxLength: 20),
                        M_Sort = c.Int(nullable: false),
                        M_IsActive = c.Int(nullable: false),
                        M_ParentID = c.String(maxLength: 20),
                        M_Portrait = c.String(maxLength: 50),
                        M_UpdateUser = c.String(maxLength: 20),
                        M_UpdateDate = c.DateTime(nullable: false, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.M_MenuID);
            
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        R_RoleID = c.String(nullable: false, maxLength: 20),
                        R_Name = c.String(nullable: false, maxLength: 20),
                        R_IsActive = c.Int(nullable: false),
                        R_UpdateUser = c.String(maxLength: 20),
                        R_UpdateDate = c.DateTime(nullable: false, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.R_RoleID);
            
            CreateTable(
                "dbo.UserRole",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.String(nullable: false, maxLength: 20),
                        RoleID = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ValidateCode",
                c => new
                    {
                        V_CodeID = c.Int(nullable: false, identity: true),
                        V_PhoneNumber = c.String(nullable: false, maxLength: 20),
                        V_VCode = c.String(nullable: false, maxLength: 20),
                        V_UpdateDate = c.DateTime(nullable: false, storeType: "datetime2"),
                        V_DeviceID = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.V_CodeID);
            
            CreateTable(
                "dbo.RoleMenu",
                c => new
                    {
                        RM_ID = c.Int(nullable: false, identity: true),
                        RM_RoleID = c.String(nullable: false, maxLength: 20),
                        RM_MenuID = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.RM_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RoleMenu");
            DropTable("dbo.ValidateCode");
            DropTable("dbo.UserRole");
            DropTable("dbo.Role");
            DropTable("dbo.Menu");
            DropTable("dbo.Department");
            DropTable("dbo.RB_RType_Template");
            DropTable("dbo.CostCenter_Type");
            DropTable("dbo.CostCenter");
            DropTable("dbo.CC_Type_Template");
            DropTable("dbo.Log");
            DropTable("dbo.RB_RType");
            DropTable("dbo.RB_Rows");
            DropTable("dbo.Reimbursement");
            DropTable("dbo.LeaveType");
            DropTable("dbo.Leave");
            DropTable("dbo.User");
        }
    }
}
