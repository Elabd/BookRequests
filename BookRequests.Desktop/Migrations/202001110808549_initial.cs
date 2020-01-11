namespace BookRequests.Desktop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BookRequests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RequestType = c.Int(nullable: false),
                        Language = c.String(),
                        Note = c.String(),
                        Priority = c.Int(nullable: false),
                        RequestDate = c.DateTime(),
                        DateOfScan = c.DateTime(),
                        DateOfPrint = c.DateTime(),
                        Status = c.Int(nullable: false),
                        StimateDate = c.DateTime(),
                        ArrivedDate = c.DateTime(),
                        Book_Id = c.Int(),
                        Student_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.Book_Id)
                .ForeignKey("dbo.Students", t => t.Student_Id)
                .Index(t => t.Book_Id)
                .Index(t => t.Student_Id);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookName = c.String(),
                        NumberOfPage = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BookRequests", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.BookRequests", "Book_Id", "dbo.Books");
            DropIndex("dbo.BookRequests", new[] { "Student_Id" });
            DropIndex("dbo.BookRequests", new[] { "Book_Id" });
            DropTable("dbo.Books");
            DropTable("dbo.BookRequests");
        }
    }
}
