namespace AesophWorks.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nameaddedbaseentity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AdirondackChairs", "Name", c => c.String());
            AddColumn("dbo.ChautericeBoards", "Name", c => c.String());
            AddColumn("dbo.CNCEngravings", "Name", c => c.String());
            AddColumn("dbo.Coasters", "Name", c => c.String());
            AddColumn("dbo.Knives", "Name", c => c.String());
            AddColumn("dbo.Ornaments", "Name", c => c.String());
            AddColumn("dbo.ServingTrays", "Name", c => c.String());
            AddColumn("dbo.Users", "Name", c => c.String());
            AddColumn("dbo.WeddingFavors", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.WeddingFavors", "Name");
            DropColumn("dbo.Users", "Name");
            DropColumn("dbo.ServingTrays", "Name");
            DropColumn("dbo.Ornaments", "Name");
            DropColumn("dbo.Knives", "Name");
            DropColumn("dbo.Coasters", "Name");
            DropColumn("dbo.CNCEngravings", "Name");
            DropColumn("dbo.ChautericeBoards", "Name");
            DropColumn("dbo.AdirondackChairs", "Name");
        }
    }
}
