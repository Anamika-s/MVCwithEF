namespace MVCWithEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDuration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Batches", "Duration", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Batches", "Duration");
        }
    }
}
