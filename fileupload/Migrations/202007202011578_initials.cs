namespace fileupload.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initials : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FileClasses",
                c => new
                    {
                        FileClassId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        File = c.Binary(),
                    })
                .PrimaryKey(t => t.FileClassId);
            
            DropTable("dbo.Files");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Files",
                c => new
                    {
                        FileId = c.Int(nullable: false, identity: true),
                        FileName = c.String(),
                        FileUpload = c.Binary(),
                    })
                .PrimaryKey(t => t.FileId);
            
            DropTable("dbo.FileClasses");
        }
    }
}
