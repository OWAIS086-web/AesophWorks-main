namespace AesophWorks.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dateremovedfrombooking : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.WorkshopBookings", "Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.WorkshopBookings", "Date", c => c.DateTime(nullable: false));
        }
    }
}
