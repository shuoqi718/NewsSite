namespace NewsSite_v1._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class email : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Article",
                c => new
                    {
                        AId = c.Int(nullable: false, identity: true),
                        JId = c.Int(nullable: false),
                        Title = c.String(nullable: false, maxLength: 100),
                        PostTime = c.DateTime(nullable: false),
                        Category = c.String(nullable: false, maxLength: 20),
                        Content = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.AId)
                .ForeignKey("dbo.Journalist", t => t.JId, cascadeDelete: true)
                .Index(t => t.JId);
            
            CreateTable(
                "dbo.Journalist",
                c => new
                    {
                        JId = c.Int(nullable: false, identity: true),
                        FName = c.String(nullable: false, maxLength: 50),
                        LName = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        Phone = c.String(nullable: false),
                        DoB = c.DateTime(nullable: false, storeType: "date"),
                        Country = c.String(nullable: false, maxLength: 20),
                        Company = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.JId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Article", "JId", "dbo.Journalist");
            DropIndex("dbo.Article", new[] { "JId" });
            DropTable("dbo.Journalist");
            DropTable("dbo.Article");
        }
    }
}
