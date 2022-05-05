namespace AesophWorks.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatabaseConserved : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.AdirondackChairs");
            DropTable("dbo.ChautericeBoards");
            DropTable("dbo.CNCEngravings");
            DropTable("dbo.Coasters");
            DropTable("dbo.CuttingBoards");
            DropTable("dbo.Knives");
            DropTable("dbo.Ornaments");
            DropTable("dbo.ServingTrays");
            DropTable("dbo.WeddingFavors");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.WeddingFavors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TypeOfWeddingFavor = c.String(),
                        Handles = c.Boolean(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ServingTrays",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TypeOfServingTrays = c.String(),
                        Type = c.String(),
                        Handles = c.Boolean(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Ornaments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Shape = c.String(),
                        Hanger = c.String(),
                        Font = c.String(),
                        Customization = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Knives",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TypeOfKnives = c.String(),
                        TypeOfKnivesOrder = c.String(),
                        GiftBox = c.Boolean(nullable: false),
                        Handles = c.Boolean(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.CuttingBoards",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        JuiceGroove = c.Boolean(nullable: false),
                        TypeOfCuttingBoard = c.String(),
                        FingerGroove = c.Boolean(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Coasters",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Shape = c.String(),
                        Font = c.String(),
                        Customization = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.CNCEngravings",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Font = c.String(),
                        Customization = c.String(),
                        Quantity = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ChautericeBoards",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TypeOfChautericeBoard = c.String(),
                        Type = c.String(),
                        Handles = c.Boolean(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.AdirondackChairs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Font = c.String(),
                        Customization = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
    }
}
