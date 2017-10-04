namespace NewsSite_v1._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class jour : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Journalist", "UserId", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Journalist", "UserId");
        }
    }
}
