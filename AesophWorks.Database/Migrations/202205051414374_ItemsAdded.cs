namespace AesophWorks.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ItemsAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        JuiceGroove = c.Boolean(nullable: false),
                        ItemType = c.String(),
                        Type = c.String(),
                        FingerGroove = c.Boolean(nullable: false),
                        Handles = c.Boolean(nullable: false),
                        Font = c.String(),
                        Customization = c.String(),
                        Quantity = c.Int(nullable: false),
                        Shape = c.String(),
                        TypeOfOrder = c.String(),
                        GiftBox = c.Boolean(nullable: false),
                        Hanger = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Items");
        }
    }
}
