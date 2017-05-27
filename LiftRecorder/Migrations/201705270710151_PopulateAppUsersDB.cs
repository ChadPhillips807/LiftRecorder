namespace LiftRecorder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateAppUsersDB : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO AppUsers (Email, FirstName, LastName) VALUES ('chadphillips807@hotmail.com', 'Chad', 'Phillips')");
            Sql("INSERT INTO AppUsers (Email, FirstName, LastName) VALUES ('caseyverd@hotmail.com', 'Casey', 'Phillips')");
            Sql("INSERT INTO AppUsers (Email, FirstName, LastName) VALUES ('Bruce.Wayne@WayneCorp.com', 'Bruce', 'Wayne')");
        }
        
        public override void Down()
        {
        }
    }
}
