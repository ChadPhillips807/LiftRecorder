namespace LiftRecorder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveLiftTypeDbSet : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.LiftTypes");
        }
        
        public override void Down()
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
    }
}
