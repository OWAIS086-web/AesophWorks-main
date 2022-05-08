namespace AesophWorks.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inlayconflictfix : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Inlays", "InlaySpecs");
            DropColumn("dbo.Inlays", "InlayTextStyle");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Inlays", "InlayTextStyle", c => c.String());
            AddColumn("dbo.Inlays", "InlaySpecs", c => c.String());
        }
    }
}
