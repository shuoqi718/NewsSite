namespace NewsSite_v1._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class email31 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EmailFormModels", "check", c => c.Boolean(nullable: false));
            DropColumn("dbo.EmailFormModels", "checkList");
        }
        
        public override void Down()
        {
            AddColumn("dbo.EmailFormModels", "checkList", c => c.Boolean(nullable: false));
            DropColumn("dbo.EmailFormModels", "check");
        }
    }
}
