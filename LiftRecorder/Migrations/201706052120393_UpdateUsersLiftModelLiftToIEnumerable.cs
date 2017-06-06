namespace LiftRecorder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateUsersLiftModelLiftToIEnumerable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UsersLifts", "LiftId", "dbo.Lifts");
            DropIndex("dbo.UsersLifts", new[] { "LiftId" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.UsersLifts", "LiftId");
            AddForeignKey("dbo.UsersLifts", "LiftId", "dbo.Lifts", "LiftId", cascadeDelete: true);
        }
    }
}
