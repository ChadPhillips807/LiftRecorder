namespace LiftRecorder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLiftTypeClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LiftTypes",
                c => new
                    {
                        LiftTypeId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.LiftTypeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LiftTypes");
        }
    }
}
