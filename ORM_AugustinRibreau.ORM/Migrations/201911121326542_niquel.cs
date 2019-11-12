namespace ORM_AugustinRibreau.ORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class niquel : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Interveners", name: "Vehicle_VehicleId", newName: "Vehicles_VehicleId");
            RenameIndex(table: "dbo.Interveners", name: "IX_Vehicle_VehicleId", newName: "IX_Vehicles_VehicleId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Interveners", name: "IX_Vehicles_VehicleId", newName: "IX_Vehicle_VehicleId");
            RenameColumn(table: "dbo.Interveners", name: "Vehicles_VehicleId", newName: "Vehicle_VehicleId");
        }
    }
}
