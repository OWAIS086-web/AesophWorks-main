namespace AesophWorks.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class typefixes : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Items", "Type");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Items", "Type", c => c.String());
        }
    }
}
