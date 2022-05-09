namespace AesophWorks.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ordersadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Item = c.String(),
                        GiftBox = c.String(),
                        GiftBoxPrice = c.Double(nullable: false),
                        Handle = c.String(),
                        HandPrice = c.Double(nullable: false),
                        WoodType = c.String(),
                        WoodTypePrice = c.String(),
                        Feet = c.String(),
                        FeetPrice = c.Double(nullable: false),
                        Inlay = c.String(),
                        InlayPrice = c.Double(nullable: false),
                        InlayTextStyle = c.String(),
                        InlayTextSpecification = c.String(),
                        Size = c.String(),
                        SizePrice = c.Double(nullable: false),
                        CutterButter = c.String(),
                        CutterButterPrice = c.Double(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Orders");
        }
    }
}
