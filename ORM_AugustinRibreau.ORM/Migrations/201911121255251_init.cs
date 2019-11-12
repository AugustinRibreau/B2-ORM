namespace ORM_AugustinRibreau.ORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Histories",
                c => new
                    {
                        HistoryId = c.Int(nullable: false, identity: true),
                        OpeningHours = c.DateTime(nullable: false),
                        ClosingHours = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.HistoryId);
            
            CreateTable(
                "dbo.Interveners",
                c => new
                    {
                        IntervenerId = c.Int(nullable: false, identity: true),
                        LastName = c.String(nullable: false, maxLength: 50),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        PersonnelNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IntervenerId);
            
            CreateTable(
                "dbo.Interventions",
                c => new
                    {
                        InterventionId = c.Int(nullable: false, identity: true),
                        InterventionAddress = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.InterventionId);
            
            CreateTable(
                "dbo.Tools",
                c => new
                    {
                        PersonId = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false, maxLength: 50),
                        Designation = c.String(nullable: false),
                        PurchaseDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PersonId);
            
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        VehicleId = c.Int(nullable: false, identity: true),
                        Brand = c.String(maxLength: 50),
                        Model = c.String(maxLength: 50),
                        Registration = c.String(maxLength: 100),
                        Volume = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.VehicleId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Vehicles");
            DropTable("dbo.Tools");
            DropTable("dbo.Interventions");
            DropTable("dbo.Interveners");
            DropTable("dbo.Histories");
        }
    }
}
