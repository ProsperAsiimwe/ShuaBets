namespace ShuaBets.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mg : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adverts",
                c => new
                    {
                        AdvertId = c.Int(nullable: false, identity: true),
                        FileName = c.String(maxLength: 1000),
                        UploadDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AdvertId);
            
            DropTable("dbo.Articles");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Articles",
                c => new
                    {
                        ArticleId = c.Int(nullable: false, identity: true),
                        Author = c.String(maxLength: 1000),
                        Published = c.DateTime(nullable: false),
                        Title = c.String(maxLength: 100),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ArticleId);
            
            DropTable("dbo.Adverts");
        }
    }
}
