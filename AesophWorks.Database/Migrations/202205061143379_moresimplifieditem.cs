namespace AesophWorks.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class moresimplifieditem : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Items", "JuiceGroove");
            DropColumn("dbo.Items", "FingerGroove");
            DropColumn("dbo.Items", "Handles");
            DropColumn("dbo.Items", "Font");
            DropColumn("dbo.Items", "Customization");
            DropColumn("dbo.Items", "Quantity");
            DropColumn("dbo.Items", "Shape");
            DropColumn("dbo.Items", "TypeOfOrder");
            DropColumn("dbo.Items", "GiftBox");
            DropColumn("dbo.Items", "Hanger");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Items", "Hanger", c => c.String());
            AddColumn("dbo.Items", "GiftBox", c => c.Boolean(nullable: false));
            AddColumn("dbo.Items", "TypeOfOrder", c => c.String());
            AddColumn("dbo.Items", "Shape", c => c.String());
            AddColumn("dbo.Items", "Quantity", c => c.Int(nullable: false));
            AddColumn("dbo.Items", "Customization", c => c.String());
            AddColumn("dbo.Items", "Font", c => c.String());
            AddColumn("dbo.Items", "Handles", c => c.Boolean(nullable: false));
            AddColumn("dbo.Items", "FingerGroove", c => c.Boolean(nullable: false));
            AddColumn("dbo.Items", "JuiceGroove", c => c.Boolean(nullable: false));
        }
    }
}
