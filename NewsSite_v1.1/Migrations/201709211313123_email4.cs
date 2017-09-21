namespace NewsSite_v1._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class email4 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.EmailFormModels", "check");
        }
        
        public override void Down()
        {
            AddColumn("dbo.EmailFormModels", "check", c => c.Boolean(nullable: false));
        }
    }
}
