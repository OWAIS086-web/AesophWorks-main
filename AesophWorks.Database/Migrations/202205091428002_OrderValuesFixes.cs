namespace AesophWorks.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderValuesFixes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "OrderType", c => c.String());
            AddColumn("dbo.Orders", "OrderTypePrice", c => c.Double(nullable: false));
            AddColumn("dbo.Orders", "Accent", c => c.String());
            AddColumn("dbo.Orders", "AccentPrice", c => c.Double(nullable: false));
            AlterColumn("dbo.Orders", "WoodTypePrice", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "WoodTypePrice", c => c.String());
            DropColumn("dbo.Orders", "AccentPrice");
            DropColumn("dbo.Orders", "Accent");
            DropColumn("dbo.Orders", "OrderTypePrice");
            DropColumn("dbo.Orders", "OrderType");
        }
    }
}
