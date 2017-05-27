namespace LiftRecorder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateLiftsDB : DbMigration
    {
        public override void Up()
        {
            //Update the LiftsDB
            Sql("INSERT INTO Lifts (LiftTypeId, Name) VALUES (1, 'Flat Dumbbell Press')");
            Sql("INSERT INTO Lifts (LiftTypeId, Name) VALUES (1, 'Incline Dumbbell Press')");
            Sql("INSERT INTO Lifts (LiftTypeId, Name) VALUES (2, 'Single Arm Dumbbell Row')");
            Sql("INSERT INTO Lifts (LiftTypeId, Name) VALUES (2, 'Standing Cable Pullovers')");
            Sql("INSERT INTO Lifts (LiftTypeId, Name) VALUES (3, 'Squat')");
            Sql("INSERT INTO Lifts (LiftTypeId, Name) VALUES (3, 'Leg Press')");
            Sql("INSERT INTO Lifts (LiftTypeId, Name) VALUES (4, 'Overhead Dumbbell Press')");
            Sql("INSERT INTO Lifts (LiftTypeId, Name) VALUES (4, 'Lateral Raises')");
        }
        
        public override void Down()
        {
        }
    }
}
