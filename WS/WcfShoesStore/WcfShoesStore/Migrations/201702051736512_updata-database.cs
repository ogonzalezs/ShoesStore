namespace WcfShoesStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatadatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbl_Articles",
                c => new
                    {
                        articleId = c.Int(nullable: false, identity: true),
                        storeId = c.Int(nullable: false),
                        articleName = c.String(nullable: false),
                        articleDescription = c.String(nullable: false),
                        articlePrice = c.String(nullable: false),
                        articleTotalInShelf = c.String(nullable: false),
                        articleTotalInVault = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.articleId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tbl_Articles");
        }
    }
}
