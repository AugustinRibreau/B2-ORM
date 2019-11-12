namespace ORM_AugustinRibreau.ORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationForTestLiaisonWithHistoryAndIntervener : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Interveners", "History_HistoryId", c => c.Int());
            CreateIndex("dbo.Interveners", "History_HistoryId");
            AddForeignKey("dbo.Interveners", "History_HistoryId", "dbo.Histories", "HistoryId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Interveners", "History_HistoryId", "dbo.Histories");
            DropIndex("dbo.Interveners", new[] { "History_HistoryId" });
            DropColumn("dbo.Interveners", "History_HistoryId");
        }
    }
}
