namespace BookRequests.Desktop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addlang : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Language", c => c.String());
            DropColumn("dbo.BookRequests", "Language");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BookRequests", "Language", c => c.String());
            DropColumn("dbo.Books", "Language");
        }
    }
}
