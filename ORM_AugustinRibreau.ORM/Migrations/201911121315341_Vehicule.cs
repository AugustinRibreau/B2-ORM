namespace ORM_AugustinRibreau.ORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Vehicule : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Interventions", "Intervener_IntervenerId", c => c.Int());
            AddColumn("dbo.Interveners", "Vehicle_VehicleId", c => c.Int());
            CreateIndex("dbo.Interventions", "Intervener_IntervenerId");
            CreateIndex("dbo.Interveners", "Vehicle_VehicleId");
            AddForeignKey("dbo.Interveners", "Vehicle_VehicleId", "dbo.Vehicles", "VehicleId");
            AddForeignKey("dbo.Interventions", "Intervener_IntervenerId", "dbo.Interveners", "IntervenerId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Interventions", "Intervener_IntervenerId", "dbo.Interveners");
            DropForeignKey("dbo.Interveners", "Vehicle_VehicleId", "dbo.Vehicles");
            DropIndex("dbo.Interveners", new[] { "Vehicle_VehicleId" });
            DropIndex("dbo.Interventions", new[] { "Intervener_IntervenerId" });
            DropColumn("dbo.Interveners", "Vehicle_VehicleId");
            DropColumn("dbo.Interventions", "Intervener_IntervenerId");
        }
    }
}
