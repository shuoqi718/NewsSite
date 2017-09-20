namespace NewsSite_v1._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Email2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EmailFormModels", "checkList", c => c.Boolean(nullable: false));
            AddColumn("dbo.EmailFormModels", "Username", c => c.String(nullable: false));
            AddColumn("dbo.EmailFormModels", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.EmailFormModels", "Email");
            DropColumn("dbo.EmailFormModels", "Username");
            DropColumn("dbo.EmailFormModels", "checkList");
        }
    }
}
