namespace NewsSite_v1._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userattri2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "BirthDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.AspNetUsers", "DoB");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "DoB", c => c.DateTime(nullable: false));
            DropColumn("dbo.AspNetUsers", "BirthDate");
        }
    }
}
