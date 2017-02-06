namespace WcfShoesStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbl_Stores",
                c => new
                    {
                        storeId = c.Int(nullable: false, identity: true),
                        storeName = c.String(nullable: false),
                        storeAddress = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.storeId);
            
            DropTable("dbo.Stores");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Stores",
                c => new
                    {
                        storeId = c.Int(nullable: false, identity: true),
                        storeName = c.String(nullable: false),
                        storeDescription = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.storeId);
            
            DropTable("dbo.tbl_Stores");
        }
    }
}
