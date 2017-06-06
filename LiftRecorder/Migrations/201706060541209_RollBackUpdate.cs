namespace LiftRecorder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RollBackUpdate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AppUsers", "UsersLift_UsersLiftId", "dbo.UsersLifts");
            DropForeignKey("dbo.UsersLifts", "AppUser_AppUserId1", "dbo.AppUsers");
            DropForeignKey("dbo.UsersLifts", "AppUser_AppUserId", "dbo.AppUsers");
            DropIndex("dbo.AppUsers", new[] { "UsersLift_UsersLiftId" });
            DropIndex("dbo.UsersLifts", new[] { "AppUser_AppUserId" });
            DropIndex("dbo.UsersLifts", new[] { "AppUser_AppUserId1" });
            DropColumn("dbo.UsersLifts", "AppUserId");
            DropColumn("dbo.UsersLifts", "AppUserId");
            RenameColumn(table: "dbo.UsersLifts", name: "AppUser_AppUserId1", newName: "AppUserId");
            RenameColumn(table: "dbo.UsersLifts", name: "AppUser_AppUserId", newName: "AppUserId");
            AlterColumn("dbo.UsersLifts", "AppUserId", c => c.Int(nullable: false));
            AlterColumn("dbo.UsersLifts", "AppUserId", c => c.Int(nullable: false));
            CreateIndex("dbo.UsersLifts", "AppUserId");
            CreateIndex("dbo.UsersLifts", "LiftId");
            AddForeignKey("dbo.UsersLifts", "LiftId", "dbo.Lifts", "LiftId", cascadeDelete: true);
            AddForeignKey("dbo.UsersLifts", "AppUserId", "dbo.AppUsers", "AppUserId", cascadeDelete: true);
            DropColumn("dbo.AppUsers", "UsersLift_UsersLiftId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AppUsers", "UsersLift_UsersLiftId", c => c.Int());
            DropForeignKey("dbo.UsersLifts", "AppUserId", "dbo.AppUsers");
            DropForeignKey("dbo.UsersLifts", "LiftId", "dbo.Lifts");
            DropIndex("dbo.UsersLifts", new[] { "LiftId" });
            DropIndex("dbo.UsersLifts", new[] { "AppUserId" });
            AlterColumn("dbo.UsersLifts", "AppUserId", c => c.Int());
            AlterColumn("dbo.UsersLifts", "AppUserId", c => c.Int());
            RenameColumn(table: "dbo.UsersLifts", name: "AppUserId", newName: "AppUser_AppUserId");
            RenameColumn(table: "dbo.UsersLifts", name: "AppUserId", newName: "AppUser_AppUserId1");
            AddColumn("dbo.UsersLifts", "AppUserId", c => c.Int(nullable: false));
            AddColumn("dbo.UsersLifts", "AppUserId", c => c.Int(nullable: false));
            CreateIndex("dbo.UsersLifts", "AppUser_AppUserId1");
            CreateIndex("dbo.UsersLifts", "AppUser_AppUserId");
            CreateIndex("dbo.AppUsers", "UsersLift_UsersLiftId");
            AddForeignKey("dbo.UsersLifts", "AppUser_AppUserId", "dbo.AppUsers", "AppUserId");
            AddForeignKey("dbo.UsersLifts", "AppUser_AppUserId1", "dbo.AppUsers", "AppUserId");
            AddForeignKey("dbo.AppUsers", "UsersLift_UsersLiftId", "dbo.UsersLifts", "UsersLiftId");
        }
    }
}
