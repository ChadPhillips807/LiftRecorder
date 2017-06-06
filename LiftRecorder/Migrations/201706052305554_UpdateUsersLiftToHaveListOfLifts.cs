namespace LiftRecorder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateUsersLiftToHaveListOfLifts : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Lifts", "UsersLift_UsersLiftId", "dbo.UsersLifts");
            DropIndex("dbo.Lifts", new[] { "UsersLift_UsersLiftId" });
            DropColumn("dbo.Lifts", "UsersLift_UsersLiftId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Lifts", "UsersLift_UsersLiftId", c => c.Int());
            CreateIndex("dbo.Lifts", "UsersLift_UsersLiftId");
            AddForeignKey("dbo.Lifts", "UsersLift_UsersLiftId", "dbo.UsersLifts", "UsersLiftId");
        }
    }
}
