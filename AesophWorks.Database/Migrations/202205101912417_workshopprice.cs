namespace AesophWorks.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class workshopprice : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Workshops", "Price", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Workshops", "Price");
        }
    }
}
