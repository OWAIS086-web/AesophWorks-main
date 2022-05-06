namespace AesophWorks.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ItemTypeRenamed : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.OrderTypes", newName: "ItemTypes");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.ItemTypes", newName: "OrderTypes");
        }
    }
}
