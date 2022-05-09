namespace AesophWorks.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class datatypechangedtodouble : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Accents", "Price", c => c.Double(nullable: false));
            AlterColumn("dbo.CutterButters", "Price", c => c.Double(nullable: false));
            AlterColumn("dbo.Feet", "Price", c => c.Double(nullable: false));
            AlterColumn("dbo.GiftBoxes", "Price", c => c.Double(nullable: false));
            AlterColumn("dbo.Handles", "Price", c => c.Double(nullable: false));
            AlterColumn("dbo.Inlays", "Price", c => c.Double(nullable: false));
            AlterColumn("dbo.ItemTypes", "Price", c => c.Double(nullable: false));
            AlterColumn("dbo.OrderTypes", "Price", c => c.Double(nullable: false));
            AlterColumn("dbo.Sizes", "Price", c => c.Double(nullable: false));
            AlterColumn("dbo.WoodTypes", "Price", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.WoodTypes", "Price", c => c.String());
            AlterColumn("dbo.Sizes", "Price", c => c.String());
            AlterColumn("dbo.OrderTypes", "Price", c => c.String());
            AlterColumn("dbo.ItemTypes", "Price", c => c.String());
            AlterColumn("dbo.Inlays", "Price", c => c.String());
            AlterColumn("dbo.Handles", "Price", c => c.String());
            AlterColumn("dbo.GiftBoxes", "Price", c => c.String());
            AlterColumn("dbo.Feet", "Price", c => c.String());
            AlterColumn("dbo.CutterButters", "Price", c => c.String());
            AlterColumn("dbo.Accents", "Price", c => c.String());
        }
    }
}
