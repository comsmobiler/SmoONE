namespace SmoONE.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGestures : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.User", "U_Gestures", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.User", "U_Gestures");
        }
    }
}
