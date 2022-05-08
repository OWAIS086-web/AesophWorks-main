namespace AesophWorks.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GiftBoxAndHandlesAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GiftBoxes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ItemID = c.Int(nullable: false),
                        Price = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Handles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ItemID = c.Int(nullable: false),
                        Price = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Handles");
            DropTable("dbo.GiftBoxes");
        }
    }
}
