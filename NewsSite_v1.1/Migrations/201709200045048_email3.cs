namespace NewsSite_v1._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class email3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.EmailFormModels", "Message", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.EmailFormModels", "Message", c => c.String(nullable: false));
        }
    }
}
