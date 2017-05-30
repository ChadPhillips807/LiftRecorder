namespace LiftRecorder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLiftTypeAsStringToLift : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Lifts", "LiftTypeId", "dbo.LiftTypes");
            DropIndex("dbo.Lifts", new[] { "LiftTypeId" });
            AddColumn("dbo.Lifts", "LiftType", c => c.String());
            DropColumn("dbo.Lifts", "LiftTypeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Lifts", "LiftTypeId", c => c.Int(nullable: false));
            DropColumn("dbo.Lifts", "LiftType");
            CreateIndex("dbo.Lifts", "LiftTypeId");
            AddForeignKey("dbo.Lifts", "LiftTypeId", "dbo.LiftTypes", "LiftTypeId", cascadeDelete: true);
        }
    }
}
