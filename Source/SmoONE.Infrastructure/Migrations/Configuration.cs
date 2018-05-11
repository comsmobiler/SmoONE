namespace SmoONE.Infrastructure.Migrations
{
    using SmoONE.Domain;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using CommLib;
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2016/11
    // 主要内容：  数据库上下文的配置
    // ******************************************************************

    /// <summary>
    /// 数据库上下文的配置
    /// </summary>
    internal sealed class Configuration : DbMigrationsConfiguration<SmoONE.Infrastructure.SmoONEDbContext>
    {
        public Configuration()
        {
            //关闭自动迁移
            AutomaticMigrationsEnabled = false;
        }

        /// <summary>
        /// 种子数据(数据库创建或者更新后,数据库里必定存在的数据）
        /// </summary>
        protected override void Seed(SmoONE.Infrastructure.SmoONEDbContext context)
        {
            //  This method will be called after migrating to the latest version.            
            
         
            #region 建议不要注释掉的默认数据（酌情修改）,不然可能影响应用的使用
            //在LeaveType表中添加默认数据
            context.LeaveTypes.AddOrUpdate(
                  new LeaveType { L_T_ID = "SJ", L_T_Name = "事假" },
                  new LeaveType { L_T_ID = "BJ", L_T_Name = "病假" },
                  new LeaveType { L_T_ID = "NJ", L_T_Name = "年假" },
                  new LeaveType { L_T_ID = "TX", L_T_Name = "调休" },
                  new LeaveType { L_T_ID = "HJ", L_T_Name = "婚假" },
                  new LeaveType { L_T_ID = "CJ", L_T_Name = "产假" },
                  new LeaveType { L_T_ID = "PCJ", L_T_Name = "陪产假" },
                  new LeaveType { L_T_ID = "LTJ", L_T_Name = "路途假" },
                  new LeaveType { L_T_ID = "QT", L_T_Name = "其他" }
                );
            //在RB_Type表中添加默认数据
            context.RB_Types.AddOrUpdate(
                  new RB_RType { RB_RT_ID = "BJ", RB_RT_Name = "保洁费" },
                  new RB_RType { RB_RT_ID = "BJB", RB_RT_Name = "笔记本" },
                  new RB_RType { RB_RT_ID = "CB", RB_RT_Name = "出差补贴" },
                  new RB_RType { RB_RT_ID = "CF", RB_RT_Name = "餐费" },
                  new RB_RType { RB_RT_ID = "FZ", RB_RT_Name = "房租" },
                  new RB_RType { RB_RT_ID = "GL", RB_RT_Name = "过路费" },
                  new RB_RType { RB_RT_ID = "HD", RB_RT_Name = "硬件" },
                  new RB_RType { RB_RT_ID = "JT", RB_RT_Name = "交通费" },
                  new RB_RType { RB_RT_ID = "JY", RB_RT_Name = "加油费" },
                  new RB_RType { RB_RT_ID = "KD", RB_RT_Name = "快递费" },
                  new RB_RType { RB_RT_ID = "TC", RB_RT_Name = "停车费" },
                  new RB_RType { RB_RT_ID = "TXF", RB_RT_Name = "通讯费" },
                  new RB_RType { RB_RT_ID = "WX", RB_RT_Name = "电脑维修费" },
                  new RB_RType { RB_RT_ID = "WY", RB_RT_Name = "物业费" },
                  new RB_RType { RB_RT_ID = "XZ", RB_RT_Name = "行政费用" },
                  new RB_RType { RB_RT_ID = "YJ", RB_RT_Name = "押金" },
                  new RB_RType { RB_RT_ID = "YW", RB_RT_Name = "业务费" },
                  new RB_RType { RB_RT_ID = "ZS", RB_RT_Name = "住宿费" },
                  new RB_RType { RB_RT_ID = "QT", RB_RT_Name = "其他费用" }
                );
            //在CostCenter_Type表中添加默认数据
            context.CostCenter_Types.AddOrUpdate(
                new CostCenter_Type { CC_T_TypeID = "1", CC_T_Description = "维护", CC_T_IsActive = 1 },
                new CostCenter_Type { CC_T_TypeID = "2", CC_T_Description = "办公", CC_T_IsActive = 1 },
                new CostCenter_Type { CC_T_TypeID = "3", CC_T_Description = "产品体系", CC_T_IsActive = 1 },
                new CostCenter_Type { CC_T_TypeID = "4", CC_T_Description = "项目", CC_T_IsActive = 1 },
                new CostCenter_Type { CC_T_TypeID = "5", CC_T_Description = "个人售前", CC_T_IsActive = 1 },
                new CostCenter_Type { CC_T_TypeID = "6", CC_T_Description = "销售", CC_T_IsActive = 1 },
                new CostCenter_Type { CC_T_TypeID = "7", CC_T_Description = "工单", CC_T_IsActive = 1 },
                new CostCenter_Type { CC_T_TypeID = "8", CC_T_Description = "运营", CC_T_IsActive = 1 }
                );
            //在Role表中添加默认数据
            context.Roles.AddOrUpdate(
                new Role { R_RoleID = "Administrator", R_IsActive = 1, R_Name = "管理员", R_UpdateDate = DateTime.Now },
                new Role { R_RoleID = "Employee", R_IsActive = 1, R_Name = "员工", R_UpdateDate = DateTime.Now }
                );
            //在Menu表中添加默认数据
            context.Menus.AddOrUpdate(
                new Menu { M_MenuID = "RB", M_Description = "报销", M_Sort = 1, M_IsActive = 1, M_ParentID = "", M_UpdateDate = DateTime.Now, M_Portrait = "RB" },
                new Menu { M_MenuID = "Leave", M_Description = "请假", M_Sort = 2, M_IsActive = 1, M_ParentID = "", M_UpdateDate = DateTime.Now, M_Portrait = "Leave" },
                new Menu { M_MenuID = "Department", M_Description = "部门", M_Sort = 3, M_IsActive = 1, M_ParentID = "", M_UpdateDate = DateTime.Now, M_Portrait = "Department" },
                new Menu { M_MenuID = "CC", M_Description = "成本中心", M_Sort = 4, M_IsActive = 1, M_ParentID = "", M_UpdateDate = DateTime.Now, M_Portrait = "CC" },
                new Menu { M_MenuID = "CCFX", M_Description = "成本分析", M_Sort = 5, M_IsActive = 1, M_ParentID = "CC", M_UpdateDate = DateTime.Now, M_Portrait = "CCFX" },
                new Menu { M_MenuID = "RB_Rows", M_Description = "消费明细", M_Sort = 2, M_IsActive = 1, M_ParentID = "RB", M_UpdateDate = DateTime.Now, M_Portrait = "xiaofeimingxi" },
                new Menu { M_MenuID = "RB_RType_Template", M_Description = "消费模板", M_Sort = 1, M_IsActive = 1, M_ParentID = "RB", M_UpdateDate = DateTime.Now, M_Portrait = "xiaofeimuban" },
                new Menu { M_MenuID = "Reimbursement", M_Description = "报销单", M_Sort = 3, M_IsActive = 1, M_ParentID = "RB", M_UpdateDate = DateTime.Now, M_Portrait = "baoxiaodan" },
                new Menu { M_MenuID = "CC_Type_Template", M_Description = "模板", M_Sort = 1, M_IsActive = 1, M_ParentID = "CC", M_UpdateDate = DateTime.Now, M_Portrait = "ccmuban" },
                new Menu { M_MenuID = "CostCenter", M_Description = "成本中心", M_Sort = 2, M_IsActive = 1, M_ParentID = "CC", M_UpdateDate = DateTime.Now, M_Portrait = "chengbeng" },
                new Menu { M_MenuID = "Attendance", M_Description = "考勤", M_Sort = 1, M_IsActive = 1, M_ParentID = "", M_UpdateDate = DateTime.Now, M_Portrait = "Attendance" },
                new Menu { M_MenuID = "AttendanceManagement", M_Description = "考勤管理", M_Sort = 1, M_IsActive = 1, M_ParentID = "Attendance", M_UpdateDate = DateTime.Now, M_Portrait = "kaoqinguanli" },
                new Menu { M_MenuID = "AttendanceInfo", M_Description = "考勤", M_Sort = 2, M_IsActive = 1, M_ParentID = "Attendance", M_UpdateDate = DateTime.Now, M_Portrait = "kaoqin" },
                new Menu { M_MenuID = "MyAttendanceHistory", M_Description = "我的考勤", M_Sort = 3, M_IsActive = 1, M_ParentID = "Attendance", M_UpdateDate = DateTime.Now, M_Portrait = "wodekaoqinlishi" },
                new Menu { M_MenuID = "AttendanceStatistics", M_Description = "考勤统计", M_Sort = 4, M_IsActive = 1, M_ParentID = "Attendance", M_UpdateDate = DateTime.Now, M_Portrait = "kaoqintongji" },
                new Menu { M_MenuID = "IM", M_Description = "IM", M_Sort = 1, M_IsActive = 1, M_ParentID = "", M_UpdateDate = DateTime.Now, M_Portrait = "IM"},
                new Menu { M_MenuID = "FileUp", M_Description = "文件上传", M_Sort = 2, M_IsActive = 1, M_ParentID = "", M_UpdateDate = DateTime.Now, M_Portrait = "FileUp" }
                );
            //在RoleMenu表中添加默认数据
            context.RoleMenus.AddOrUpdate(
                new RoleMenu { RM_ID = 1, RM_RoleID = "Administrator", RM_MenuID = "RB" },
                new RoleMenu { RM_ID = 2, RM_RoleID = "Administrator", RM_MenuID = "Leave" },
                new RoleMenu { RM_ID = 3, RM_RoleID = "Administrator", RM_MenuID = "Department" },
                new RoleMenu { RM_ID = 4, RM_RoleID = "Administrator", RM_MenuID = "CC" },
                new RoleMenu { RM_ID = 5, RM_RoleID = "Administrator", RM_MenuID = "RB_Rows" },
                new RoleMenu { RM_ID = 6, RM_RoleID = "Administrator", RM_MenuID = "RB_RType_Template" },
                new RoleMenu { RM_ID = 7, RM_RoleID = "Administrator", RM_MenuID = "Reimbursement" },
                new RoleMenu { RM_ID = 8, RM_RoleID = "Administrator", RM_MenuID = "CC_Type_Template" },
                new RoleMenu { RM_ID = 9, RM_RoleID = "Administrator", RM_MenuID = "CostCenter" },
                new RoleMenu { RM_ID = 10, RM_RoleID = "Employee", RM_MenuID = "RB" },
                new RoleMenu { RM_ID = 11, RM_RoleID = "Employee", RM_MenuID = "Leave" },
                new RoleMenu { RM_ID = 12, RM_RoleID = "Employee", RM_MenuID = "RB_Rows" },
                new RoleMenu { RM_ID = 13, RM_RoleID = "Employee", RM_MenuID = "RB_RType_Template" },
                new RoleMenu { RM_ID = 14, RM_RoleID = "Employee", RM_MenuID = "Reimbursement" },
                new RoleMenu { RM_ID = 15, RM_RoleID = "Administrator", RM_MenuID = "Attendance" },
                new RoleMenu { RM_ID = 16, RM_RoleID = "Administrator", RM_MenuID = "AttendanceManagement" },
                new RoleMenu { RM_ID = 17, RM_RoleID = "Administrator", RM_MenuID = "AttendanceInfo" },
                new RoleMenu { RM_ID = 18, RM_RoleID = "Administrator", RM_MenuID = "MyAttendanceHistory" },
                new RoleMenu { RM_ID = 19, RM_RoleID = "Administrator", RM_MenuID = "AttendanceStatistics" },
                new RoleMenu { RM_ID = 20, RM_RoleID = "Employee", RM_MenuID = "Attendance" },
                new RoleMenu { RM_ID = 21, RM_RoleID = "Employee", RM_MenuID = "AttendanceInfo" },
                new RoleMenu { RM_ID = 22, RM_RoleID = "Employee", RM_MenuID = "MyAttendanceHistory" },
                new RoleMenu { RM_ID = 23, RM_RoleID = "Employee", RM_MenuID = "AttendanceStatistics" },
                new RoleMenu { RM_ID = 24, RM_RoleID = "Administrator", RM_MenuID = "CCFX" },
                new RoleMenu { RM_ID = 25, RM_RoleID = "Administrator", RM_MenuID = "IM" },
                new RoleMenu { RM_ID = 26, RM_RoleID = "Administrator", RM_MenuID = "FileUp" },
                new RoleMenu { RM_ID = 27, RM_RoleID = "Employee", RM_MenuID = "IM" },
                new RoleMenu { RM_ID = 28, RM_RoleID = "Employee", RM_MenuID = "FileUp" }
                );
            //在Department表中添加默认数据
            //context.Departments.AddOrUpdate(
            //    new Department { Dep_ID = "Dep2016102517120001", Dep_Name = "人事部", Dep_IsActive = 1, Dep_Leader = "13725731234", Dep_UpdateDate = DateTime.Now, Dep_UpdateUser = "13725731234", Dep_ProDay = 500, Dep_OtherDay = 400 }
            //    );
            #endregion


            #region 可以注释的默认数据（都是通过主键区分）
            //在User表中添加默认数据
            //context.Users.AddOrUpdate(
            //    new User { U_ID = "13725731234", U_Name = "Apple", U_Pwd = DESEncrypt.Encrypt("123456"), U_Birthday = DateTime.Parse("1996-10-20 16:01:44"), U_CreateDate = DateTime.Now, U_Sex = 1, U_IsCheck = 1, U_IsCC = 0,U_DepID="Dep2016102517120001" },
            //    new User { U_ID = "13725731235", U_Name = "Apple2", U_Pwd = DESEncrypt.Encrypt("123456"), U_Birthday = DateTime.Parse("1996-10-21 16:01:44"), U_CreateDate = DateTime.Now, U_Sex = 0, U_IsCheck = 0, U_IsCC = 0 },
            //    new User { U_ID = "13725731236", U_Name = "Apple3", U_Pwd = DESEncrypt.Encrypt("123456"), U_Birthday = DateTime.Parse("1996-10-22 16:01:44"), U_CreateDate = DateTime.Now, U_Sex = 1, U_IsCheck = 0, U_IsCC = 1 },
            //    new User { U_ID = "13725731237", U_Name = "Apple4", U_Pwd = DESEncrypt.Encrypt("123456"), U_Birthday = DateTime.Parse("1996-10-23 16:01:44"), U_CreateDate = DateTime.Now, U_Sex = 0, U_IsCheck = 1, U_IsCC = 0 },
            //    new User { U_ID = "13725731238", U_Name = "Apple5", U_Pwd = DESEncrypt.Encrypt("123456"), U_Birthday = DateTime.Parse("1996-10-24 16:01:44"), U_CreateDate = DateTime.Now, U_Sex = 1, U_IsCheck = 1, U_IsCC = 1 }
            //    );
            ////在Leave表中添加默认数据
            //context.Leaves.AddOrUpdate(
            //    new Leave { L_ID = "Lv2016111012110001", L_CheckUsers = "13725731237,13725731238", L_CreateUser = "13725731235", L_CCTo = "13725731234", L_StartDate = DateTime.Now, L_CreateDate = DateTime.Now, L_EndDate = DateTime.Now.AddDays(3), L_LDay = 3, L_Reason = "测试1", L_Status = 0, L_TypeID = "SJ", L_UpdateDate = DateTime.Now },
            //    new Leave { L_ID = "Lv2016111113140001", L_CheckUsers = "13725731237,13725731234", L_CreateUser = "13725731236", L_CCTo = "13725731235", L_StartDate = DateTime.Now.AddDays(-2), L_CreateDate = DateTime.Now, L_EndDate = DateTime.Now, L_LDay = 2, L_Reason = "测试2", L_Status = 1, L_TypeID = "NJ", L_UpdateDate = DateTime.Now, L_UpdateUser = "13725731237", L_CurrantCheck = "13725731237" },
            //    new Leave { L_ID = "Lv2016111415420001", L_CheckUsers = "13725731234,13725731238", L_CreateUser = "13725731237", L_CCTo = "13725731236", L_StartDate = DateTime.Now.AddDays(-1), L_CreateDate = DateTime.Now, L_EndDate = DateTime.Now.AddDays(3), L_LDay = 4, L_Reason = "测试3", L_Status = 0, L_TypeID = "CJ", L_UpdateDate = DateTime.Now },
            //    new Leave { L_ID = "Lv2016111707160001", L_CheckUsers = "13725731234", L_CreateUser = "13725731235", L_CCTo = "13725731236", L_StartDate = DateTime.Now.AddDays(1), L_CreateDate = DateTime.Now, L_EndDate = DateTime.Now.AddDays(5), L_LDay = 4, L_Reason = "测试4", L_Status = -1, L_TypeID = "HJ", L_UpdateDate = DateTime.Now, L_UpdateUser = "13725731234", L_CurrantCheck = "13725731234" }
            //    );
            ////在Reimbursement表中添加默认数据
            //context.Reimbursements.AddOrUpdate(
            //    new Reimbursement { RB_ID = "RB2016110108160001", RB_TotalAmount = 120, RB_LiableMan = "13725731236", RB_AEACheckers = "13725731234", RB_FinancialCheckers = "13725731235,13725731236", RB_CreateUser = "13725731237", RB_CreateDate = DateTime.Now, RB_Note = "Note1", RB_Status = 0, RB_UpdateDate = DateTime.Now, CC_ID = "CC2016111320140001" },
            //    new Reimbursement { RB_ID = "RB2016110816100001", RB_TotalAmount = 100, RB_LiableMan = "13725731238", RB_AEACheckers = "13725731236,13725731237", RB_FinancialCheckers = "13725731235,13725731238", RB_CreateUser = "13725731235", RB_CreateDate = DateTime.Now, RB_Note = "Note2", RB_Status = 1, RB_UpdateDate = DateTime.Now, CC_ID = "CC2016110218450001", RB_CurrantCheck = "13725731238" },
            //    new Reimbursement { RB_ID = "RB2016111620130001", RB_TotalAmount = 140, RB_LiableMan = "13725731237", RB_AEACheckers = "13725731237", RB_FinancialCheckers = "13725731235,13725731234", RB_CreateUser = "13725731236", RB_CreateDate = DateTime.Now, RB_Note = "Note3", RB_Status = -1, RB_UpdateDate = DateTime.Now, CC_ID = "CC2016110619260001", RB_CurrantCheck = "13725731235" }
            //    );
            ////在RB_Rows表中添加默认数据
            //context.RB_Rows.AddOrUpdate(
            //    new RB_Rows { R_ID = 1, RB_ID = "RB2016110108160001", R_Amount = 20.3M, R_Note = "明细1", R_TypeID = "JY", R_CreateDate = DateTime.Now, R_ConsumeDate = DateTime.Now.AddDays(-5) },
            //    new RB_Rows { R_ID = 2, RB_ID = "RB2016110108160001", R_Amount = 79.7M, R_Note = "明细2", R_TypeID = "KD", R_CreateDate = DateTime.Now, R_ConsumeDate = DateTime.Now.AddDays(-4) },
            //    new RB_Rows { R_ID = 3, RB_ID = "RB2016110108160001", R_Amount = 20, R_Note = "明细1", R_TypeID = "CB", R_CreateDate = DateTime.Now, R_ConsumeDate = DateTime.Now.AddDays(-3) },
            //    new RB_Rows { R_ID = 4, RB_ID = "RB2016110816100001", R_Amount = 70, R_Note = "明细2", R_TypeID = "TXF", R_CreateDate = DateTime.Now, R_ConsumeDate = DateTime.Now.AddDays(-2) },
            //    new RB_Rows { R_ID = 5, RB_ID = "RB2016110816100001", R_Amount = 12.1M, R_Note = "明细3", R_TypeID = "YW", R_CreateDate = DateTime.Now, R_ConsumeDate = DateTime.Now.AddDays(-1) },
            //    new RB_Rows { R_ID = 6, RB_ID = "RB2016110816100001", R_Amount = 17.9M, R_Note = "明细4", R_TypeID = "FZ", R_CreateDate = DateTime.Now, R_ConsumeDate = DateTime.Now },
            //    new RB_Rows { R_ID = 7, RB_ID = "RB2016111620130001", R_Amount = 20, R_Note = "明细1", R_TypeID = "GL", R_CreateDate = DateTime.Now, R_ConsumeDate = DateTime.Now },
            //    new RB_Rows { R_ID = 8, RB_ID = "RB2016111620130001", R_Amount = 20, R_Note = "明细2", R_TypeID = "YJ", R_CreateDate = DateTime.Now, R_ConsumeDate = DateTime.Now }
            //    );
            //在UserRole表中添加默认数据
            //context.UserRoles.AddOrUpdate(
            //    new UserRole { ID = 1, UserID = "13725731234", RoleID = "Administrator" },
            //    new UserRole { ID = 2, UserID = "13725731235", RoleID = "Employee" },
            //    new UserRole { ID = 3, UserID = "13725731236", RoleID = "Employee" },
            //    new UserRole { ID = 4, UserID = "13725731237", RoleID = "Employee" },
            //    new UserRole { ID = 5, UserID = "13725731238", RoleID = "Administrator" }
            //    );
            ////在CC_Type_Template表中添加默认数据
            //context.CC_Type_Templates.AddOrUpdate(
            //    new CC_Type_Template { CC_TT_TemplateID = "CT2016110314280001", CC_TT_TypeID = "1", CC_TT_AEACheckers = "13725731234", CC_TT_FinancialCheckers = "13725731235,13725731236", CC_TT_UpdateDate = DateTime.Now },
            //    new CC_Type_Template { CC_TT_TemplateID = "CT2016110613470001", CC_TT_TypeID = "2", CC_TT_AEACheckers = "13725731236,13725731237", CC_TT_FinancialCheckers = "13725731235,13725731238", CC_TT_UpdateDate = DateTime.Now },
            //    new CC_Type_Template { CC_TT_TemplateID = "CT2016110809360001", CC_TT_TypeID = "3", CC_TT_AEACheckers = "13725731237", CC_TT_FinancialCheckers = "13725731235,13725731234", CC_TT_UpdateDate = DateTime.Now }
            //    );
            ////在CostCenter表中添加默认数据
            //context.CostCenters.AddOrUpdate(
            //    new CostCenter { CC_ID = "CC2016111320140001", CC_Name = "维护1", CC_TypeID = "1", CC_LiableMan = "13725731236", CC_DepartmentID = "Dep2016102517120001", CC_StartDate = DateTime.Now.AddDays(-100), CC_EndDate = DateTime.Now.AddDays(60), CC_TemplateID = "CT2016110314280001", CC_Amount = 6000.6M, CC_IsActive = 1, CC_UsedAmount = 0, CC_CreateDate = DateTime.Now, CC_UpdateDate = DateTime.Now },
            //    new CostCenter { CC_ID = "CC2016110218450001", CC_Name = "办公1", CC_TypeID = "2", CC_LiableMan = "13725731238", CC_DepartmentID = "Dep2016102517120001", CC_StartDate = DateTime.Now.AddDays(-100), CC_EndDate = DateTime.Now.AddDays(60), CC_TemplateID = "CT2016110613470001", CC_Amount = 7000.6M, CC_IsActive = 1, CC_UsedAmount = 0, CC_CreateDate = DateTime.Now, CC_UpdateDate = DateTime.Now },
            //    new CostCenter { CC_ID = "CC2016110619260001", CC_Name = "产品体系1", CC_TypeID = "3", CC_LiableMan = "13725731237", CC_DepartmentID = "Dep2016102517120001", CC_StartDate = DateTime.Now.AddDays(-100), CC_EndDate = DateTime.Now.AddDays(60), CC_TemplateID = "CT2016110809360001", CC_Amount = 8000.6M, CC_IsActive = 1, CC_UsedAmount = 0, CC_CreateDate = DateTime.Now, CC_UpdateDate = DateTime.Now }
            //    );
            #endregion
        }
    }
}
