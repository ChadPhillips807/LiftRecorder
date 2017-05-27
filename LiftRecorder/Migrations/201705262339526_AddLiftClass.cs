namespace LiftRecorder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLiftClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Lifts",
                c => new
                    {
                        LiftId = c.Int(nullable: false, identity: true),
                        LiftTypeId = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.LiftId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Lifts");
        }
    }
}
