namespace ORM_AugustinRibreau.ORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Intervener : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Interveners", "History_HistoryId", "dbo.Histories");
            DropIndex("dbo.Interveners", new[] { "History_HistoryId" });
            AddColumn("dbo.Interveners", "Tools_PersonId", c => c.Int());
            AddColumn("dbo.Interventions", "History_HistoryId", c => c.Int());
            CreateIndex("dbo.Interventions", "History_HistoryId");
            CreateIndex("dbo.Interveners", "Tools_PersonId");
            AddForeignKey("dbo.Interventions", "History_HistoryId", "dbo.Histories", "HistoryId");
            AddForeignKey("dbo.Interveners", "Tools_PersonId", "dbo.Tools", "PersonId");
            DropColumn("dbo.Interveners", "History_HistoryId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Interveners", "History_HistoryId", c => c.Int());
            DropForeignKey("dbo.Interveners", "Tools_PersonId", "dbo.Tools");
            DropForeignKey("dbo.Interventions", "History_HistoryId", "dbo.Histories");
            DropIndex("dbo.Interveners", new[] { "Tools_PersonId" });
            DropIndex("dbo.Interventions", new[] { "History_HistoryId" });
            DropColumn("dbo.Interventions", "History_HistoryId");
            DropColumn("dbo.Interveners", "Tools_PersonId");
            CreateIndex("dbo.Interveners", "History_HistoryId");
            AddForeignKey("dbo.Interveners", "History_HistoryId", "dbo.Histories", "HistoryId");
        }
    }
}
