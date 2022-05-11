namespace MVCWithEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCValidators : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Batches", "Duration", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Batches", "Duration", c => c.String(nullable: false));
        }
    }
}
