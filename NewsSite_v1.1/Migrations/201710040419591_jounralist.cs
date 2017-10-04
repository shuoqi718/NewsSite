namespace NewsSite_v1._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class jounralist : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Journalist", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Journalist", "Email", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
