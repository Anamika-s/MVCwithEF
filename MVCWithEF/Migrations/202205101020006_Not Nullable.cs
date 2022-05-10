namespace MVCWithEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NotNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Batches", "name", c => c.String(nullable: false));
            AlterColumn("dbo.Batches", "trainerName", c => c.String(nullable: false));
            AlterColumn("dbo.Batches", "Duration", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Batches", "Duration", c => c.String());
            AlterColumn("dbo.Batches", "trainerName", c => c.String());
            AlterColumn("dbo.Batches", "name", c => c.String());
        }
    }
}
