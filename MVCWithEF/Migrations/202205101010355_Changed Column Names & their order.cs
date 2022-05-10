namespace MVCWithEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedColumnNamestheirorder : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Batches", name: "BatchName", newName: "name");
            RenameColumn(table: "dbo.Batches", name: "StartDate", newName: "StartingDate");
            RenameColumn(table: "dbo.Batches", name: "Trainer", newName: "trainerName");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Batches", name: "trainerName", newName: "Trainer");
            RenameColumn(table: "dbo.Batches", name: "StartingDate", newName: "StartDate");
            RenameColumn(table: "dbo.Batches", name: "name", newName: "BatchName");
        }
    }
}
