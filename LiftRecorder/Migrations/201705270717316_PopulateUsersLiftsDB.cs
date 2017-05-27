namespace LiftRecorder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateUsersLiftsDB : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO UsersLifts (LiftDateTime, Weight, Reps, AppUserId, LiftId) VALUES ('05/27/2017', 90, 15, 1, 3)");
            Sql("INSERT INTO UsersLifts (LiftDateTime, Weight, Reps, AppUserId, LiftId) VALUES ('05/27/2017', 57, 15, 1, 4)");
        }
        
        public override void Down()
        {
        }
    }
}
