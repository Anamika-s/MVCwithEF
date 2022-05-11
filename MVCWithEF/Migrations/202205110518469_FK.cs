namespace MVCWithEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FK : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblCourse",
                c => new
                    {
                        CourseCode = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Duration = c.Int(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.CourseCode);
            
            AddColumn("dbo.Batches", "CourseCode", c => c.Int(nullable: false));
            CreateIndex("dbo.Batches", "CourseCode");
            AddForeignKey("dbo.Batches", "CourseCode", "dbo.tblCourse", "CourseCode", cascadeDelete: true);
            DropColumn("dbo.Batches", "Duration");
            DropColumn("dbo.Batches", "ReTypePasword");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Batches", "ReTypePasword", c => c.String());
            AddColumn("dbo.Batches", "Duration", c => c.Int(nullable: false));
            DropForeignKey("dbo.Batches", "CourseCode", "dbo.tblCourse");
            DropIndex("dbo.Batches", new[] { "CourseCode" });
            DropColumn("dbo.Batches", "CourseCode");
            DropTable("dbo.tblCourse");
        }
    }
}
