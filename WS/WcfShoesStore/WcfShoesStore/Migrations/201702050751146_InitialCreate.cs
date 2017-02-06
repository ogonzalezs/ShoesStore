namespace WcfShoesStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Stores");
        }
    }
}
