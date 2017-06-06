namespace LiftRecorder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateUsersLiftToContainListOfLifts : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UsersLifts", "LiftId", "dbo.Lifts");
            DropIndex("dbo.UsersLifts", new[] { "LiftId" });
            AddColumn("dbo.Lifts", "UsersLift_UsersLiftId", c => c.Int());
            CreateIndex("dbo.Lifts", "UsersLift_UsersLiftId");
            AddForeignKey("dbo.Lifts", "UsersLift_UsersLiftId", "dbo.UsersLifts", "UsersLiftId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Lifts", "UsersLift_UsersLiftId", "dbo.UsersLifts");
            DropIndex("dbo.Lifts", new[] { "UsersLift_UsersLiftId" });
            DropColumn("dbo.Lifts", "UsersLift_UsersLiftId");
            CreateIndex("dbo.UsersLifts", "LiftId");
            AddForeignKey("dbo.UsersLifts", "LiftId", "dbo.Lifts", "LiftId", cascadeDelete: true);
        }
    }
}
