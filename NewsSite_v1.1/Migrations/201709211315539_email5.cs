namespace NewsSite_v1._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class email5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EmailFormModels", "check", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.EmailFormModels", "check");
        }
    }
}
