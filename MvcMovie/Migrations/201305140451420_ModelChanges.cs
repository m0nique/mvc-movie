namespace MvcMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelChanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "MovieID", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Movies", "RatingID", c => c.Int(nullable: false));
            AddColumn("dbo.Movies", "GenreID", c => c.Int(nullable: false));
            AddColumn("dbo.Ratings", "RatingID", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Genres", "GenreID", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Movies", new[] { "ID" });
            AddPrimaryKey("dbo.Movies", "MovieID");
            DropPrimaryKey("dbo.Ratings", new[] { "ID" });
            AddPrimaryKey("dbo.Ratings", "RatingID");
            DropPrimaryKey("dbo.Genres", new[] { "ID" });
            AddPrimaryKey("dbo.Genres", "GenreID");
            AddForeignKey("dbo.Movies", "GenreID", "dbo.Genres", "GenreID", cascadeDelete: true);
            AddForeignKey("dbo.Movies", "RatingID", "dbo.Ratings", "RatingID", cascadeDelete: true);
            CreateIndex("dbo.Movies", "GenreID");
            CreateIndex("dbo.Movies", "RatingID");
            DropColumn("dbo.Movies", "ID");
            DropColumn("dbo.Movies", "Genre");
            DropColumn("dbo.Movies", "Rating");
            DropColumn("dbo.Ratings", "ID");
            DropColumn("dbo.Genres", "ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Genres", "ID", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Ratings", "ID", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Movies", "Rating", c => c.String(maxLength: 5));
            AddColumn("dbo.Movies", "Genre", c => c.String(nullable: false));
            AddColumn("dbo.Movies", "ID", c => c.Int(nullable: false, identity: true));
            DropIndex("dbo.Movies", new[] { "RatingID" });
            DropIndex("dbo.Movies", new[] { "GenreID" });
            DropForeignKey("dbo.Movies", "RatingID", "dbo.Ratings");
            DropForeignKey("dbo.Movies", "GenreID", "dbo.Genres");
            DropPrimaryKey("dbo.Genres", new[] { "GenreID" });
            AddPrimaryKey("dbo.Genres", "ID");
            DropPrimaryKey("dbo.Ratings", new[] { "RatingID" });
            AddPrimaryKey("dbo.Ratings", "ID");
            DropPrimaryKey("dbo.Movies", new[] { "MovieID" });
            AddPrimaryKey("dbo.Movies", "ID");
            DropColumn("dbo.Genres", "GenreID");
            DropColumn("dbo.Ratings", "RatingID");
            DropColumn("dbo.Movies", "GenreID");
            DropColumn("dbo.Movies", "RatingID");
            DropColumn("dbo.Movies", "MovieID");
        }
    }
}
