namespace SmoONE.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIM : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContactGroup",
                c => new
                    {
                        G_ID = c.String(nullable: false, maxLength: 20),
                        G_NAME = c.String(nullable: false, maxLength: 20),
                        G_USER = c.String(nullable: false),
                        G_CreateDate = c.DateTime(nullable: false),
                        G_CreateUser = c.String(maxLength: 20),
                        G_UpdateDate = c.DateTime(nullable: false),
                        G_UpdateUser = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.G_ID);
            
            CreateTable(
                "dbo.Contact",
                c => new
                    {
                        C_ID = c.Int(nullable: false, identity: true),
                        C_USER = c.String(nullable: false, maxLength: 20),
                        C_CreateDate = c.DateTime(nullable: false),
                        C_CreateUser = c.String(maxLength: 20),
                        C_UpdateDate = c.DateTime(nullable: false),
                        C_UpdateUser = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.C_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Contact");
            DropTable("dbo.ContactGroup");
        }
    }
}
