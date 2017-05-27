namespace LiftRecorder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateLiftTypeDB : DbMigration
    {
        public override void Up()
        {
            //Update the LiftTypeDB
            Sql("INSERT INTO LiftTypes (Name) VALUES ('Chest')");
            Sql("INSERT INTO LiftTypes (Name) VALUES ('Back')");
            Sql("INSERT INTO LiftTypes (Name) VALUES ('Legs')");
            Sql("INSERT INTO LiftTypes (Name) VALUES ('Shoulders')");
        }
        
        public override void Down()
        {
        }
    }
}
