namespace NewsSite_v1._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class email : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.EmailFormModels", "check");
            DropColumn("dbo.EmailFormModels", "Username");
            DropColumn("dbo.EmailFormModels", "Email");
        }
        
        public override void Down()
        {
            AddColumn("dbo.EmailFormModels", "Email", c => c.String(nullable: false));
            AddColumn("dbo.EmailFormModels", "Username", c => c.String(nullable: false));
            AddColumn("dbo.EmailFormModels", "check", c => c.Boolean(nullable: false));
        }
    }
}
