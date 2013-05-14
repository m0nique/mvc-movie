namespace MvcMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addratingstable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ratings",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Genres", "Name", c => c.String());
            DropColumn("dbo.Genres", "GenreName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Genres", "GenreName", c => c.String());
            DropColumn("dbo.Genres", "Name");
            DropTable("dbo.Ratings");
        }
    }
}
