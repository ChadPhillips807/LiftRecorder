namespace LiftRecorder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateAppUserAddSingleUserLift : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UsersLifts", "AppUserId", "dbo.AppUsers");
            DropIndex("dbo.UsersLifts", new[] { "AppUserId" });
            AddColumn("dbo.AppUsers", "UsersLift_UsersLiftId", c => c.Int());
            AddColumn("dbo.UsersLifts", "AppUser_AppUserId", c => c.Int());
            AddColumn("dbo.UsersLifts", "AppUser_AppUserId1", c => c.Int());
            CreateIndex("dbo.AppUsers", "UsersLift_UsersLiftId");
            CreateIndex("dbo.UsersLifts", "AppUser_AppUserId");
            CreateIndex("dbo.UsersLifts", "AppUser_AppUserId1");
            AddForeignKey("dbo.AppUsers", "UsersLift_UsersLiftId", "dbo.UsersLifts", "UsersLiftId");
            AddForeignKey("dbo.UsersLifts", "AppUser_AppUserId1", "dbo.AppUsers", "AppUserId");
            AddForeignKey("dbo.UsersLifts", "AppUser_AppUserId", "dbo.AppUsers", "AppUserId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UsersLifts", "AppUser_AppUserId", "dbo.AppUsers");
            DropForeignKey("dbo.UsersLifts", "AppUser_AppUserId1", "dbo.AppUsers");
            DropForeignKey("dbo.AppUsers", "UsersLift_UsersLiftId", "dbo.UsersLifts");
            DropIndex("dbo.UsersLifts", new[] { "AppUser_AppUserId1" });
            DropIndex("dbo.UsersLifts", new[] { "AppUser_AppUserId" });
            DropIndex("dbo.AppUsers", new[] { "UsersLift_UsersLiftId" });
            DropColumn("dbo.UsersLifts", "AppUser_AppUserId1");
            DropColumn("dbo.UsersLifts", "AppUser_AppUserId");
            DropColumn("dbo.AppUsers", "UsersLift_UsersLiftId");
            CreateIndex("dbo.UsersLifts", "AppUserId");
            AddForeignKey("dbo.UsersLifts", "AppUserId", "dbo.AppUsers", "AppUserId", cascadeDelete: true);
        }
    }
}
