namespace codefirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.unit",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.doctors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 15),
                        Surname = c.String(),
                        Birim_Id = c.Int(),
                        Nobet_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.unit", t => t.Birim_Id)
                .ForeignKey("dbo.sentry", t => t.Nobet_Id)
                .Index(t => t.Birim_Id)
                .Index(t => t.Nobet_Id);
            
            CreateTable(
                "dbo.sentry",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.doctors", "Nobet_Id", "dbo.sentry");
            DropForeignKey("dbo.doctors", "Birim_Id", "dbo.unit");
            DropIndex("dbo.doctors", new[] { "Nobet_Id" });
            DropIndex("dbo.doctors", new[] { "Birim_Id" });
            DropTable("dbo.sentry");
            DropTable("dbo.doctors");
            DropTable("dbo.unit");
        }
    }
}
