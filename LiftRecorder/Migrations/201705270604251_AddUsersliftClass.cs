namespace LiftRecorder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUsersliftClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UsersLifts",
                c => new
                    {
                        UsersLiftId = c.Int(nullable: false, identity: true),
                        LiftDateTime = c.DateTime(nullable: false),
                        Weight = c.Int(nullable: false),
                        Reps = c.Int(nullable: false),
                        AppUserId = c.Int(nullable: false),
                        LiftId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UsersLiftId)
                .ForeignKey("dbo.AppUsers", t => t.AppUserId, cascadeDelete: true)
                .ForeignKey("dbo.Lifts", t => t.LiftId, cascadeDelete: true)
                .Index(t => t.AppUserId)
                .Index(t => t.LiftId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UsersLifts", "LiftId", "dbo.Lifts");
            DropForeignKey("dbo.UsersLifts", "AppUserId", "dbo.AppUsers");
            DropIndex("dbo.UsersLifts", new[] { "LiftId" });
            DropIndex("dbo.UsersLifts", new[] { "AppUserId" });
            DropTable("dbo.UsersLifts");
        }
    }
}
