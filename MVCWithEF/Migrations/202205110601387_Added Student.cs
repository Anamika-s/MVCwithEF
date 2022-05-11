namespace MVCWithEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedStudent : DbMigration
    {
        public override void Up()
        {
            //DropPrimaryKey("dbo.Batches");
            CreateTable(
                "dbo.tblStudent",
                c => new
                    {
                        StudnetName = c.String(nullable: false, maxLength: 30, unicode: false),
                        RollNo = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                        batchId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RollNo)
                .ForeignKey("dbo.Batches", t => t.batchId, cascadeDelete: true)
                .Index(t => t.batchId);
            
            AddColumn("dbo.Batches", "BatchId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Batches", "BatchId");
 
        }
        
        public override void Down()
        {
            AddColumn("dbo.Batches", "Id", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.tblStudent", "batchId", "dbo.Batches");
            DropIndex("dbo.tblStudent", new[] { "batchId" });
            DropPrimaryKey("dbo.Batches");
            DropColumn("dbo.Batches", "BatchId");
            DropTable("dbo.tblStudent");
            AddPrimaryKey("dbo.Batches", "Id");
        }
    }
}
