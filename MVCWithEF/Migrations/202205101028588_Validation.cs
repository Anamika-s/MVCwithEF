namespace MVCWithEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Validation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Batches", "Password", c => c.String(nullable: false));
            AddColumn("dbo.Batches", "ReTypePasword", c => c.String());
            AlterColumn("dbo.Batches", "name", c => c.String(nullable: false, maxLength: 4));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Batches", "name", c => c.String(nullable: false));
            DropColumn("dbo.Batches", "ReTypePasword");
            DropColumn("dbo.Batches", "Password");
        }
    }
}
