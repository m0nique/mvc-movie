namespace MvcMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        GenreID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.GenreID);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        MovieID = c.Int(nullable: false, identity: true),
                        RatingID = c.Int(nullable: false),
                        GenreID = c.Int(nullable: false),
                        Title = c.String(nullable: false),
                        ReleaseDate = c.DateTime(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SelectedGenre = c.String(),
                        SelectedRating = c.String(),
                    })
                .PrimaryKey(t => t.MovieID)
                .ForeignKey("dbo.Genres", t => t.GenreID, cascadeDelete: true)
                .ForeignKey("dbo.Ratings", t => t.RatingID, cascadeDelete: true)
                .Index(t => t.GenreID)
                .Index(t => t.RatingID);
            
            CreateTable(
                "dbo.Ratings",
                c => new
                    {
                        RatingID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.RatingID);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Movies", new[] { "RatingID" });
            DropIndex("dbo.Movies", new[] { "GenreID" });
            DropForeignKey("dbo.Movies", "RatingID", "dbo.Ratings");
            DropForeignKey("dbo.Movies", "GenreID", "dbo.Genres");
            DropTable("dbo.Ratings");
            DropTable("dbo.Movies");
            DropTable("dbo.Genres");
        }
    }
}
