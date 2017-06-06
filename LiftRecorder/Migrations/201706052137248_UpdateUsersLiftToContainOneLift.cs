namespace LiftRecorder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateUsersLiftToContainOneLift : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.UsersLifts", "LiftId");
            AddForeignKey("dbo.UsersLifts", "LiftId", "dbo.Lifts", "LiftId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UsersLifts", "LiftId", "dbo.Lifts");
            DropIndex("dbo.UsersLifts", new[] { "LiftId" });
        }
    }
}
