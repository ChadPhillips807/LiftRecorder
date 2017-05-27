namespace LiftRecorder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLiftClass1 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Lifts", "LiftTypeId");
            AddForeignKey("dbo.Lifts", "LiftTypeId", "dbo.LiftTypes", "LiftTypeId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Lifts", "LiftTypeId", "dbo.LiftTypes");
            DropIndex("dbo.Lifts", new[] { "LiftTypeId" });
        }
    }
}
