namespace MvcMovie.Migrations
{
    using MvcMovie.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcMovie.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MvcMovie.Models.MovieDBContext context)
        {
            context.Genres.AddOrUpdate(i => i.Name,
                new Genre
                {
                    Name = "Action"
                },

                new Genre
                {
                    Name = "Adventure"
                },

                new Genre
                {
                    Name = "Animation"
                },

                new Genre
                {
                    Name = "Comedy"
                },

                new Genre
                {
                    Name = "Crime"
                },

                new Genre
                {
                    Name = "Drama"
                },

                new Genre
                {
                    Name = "Family"
                },

                new Genre
                {
                    Name = "History"
                },

                new Genre
                {
                    Name = "Horror"
                },

                new Genre
                {
                    Name = "Romance"
                },

                new Genre
                {
                    Name = "Thriller"
                },

                new Genre
                {
                    Name = "Western"
                }
            );

            context.Ratings.AddOrUpdate(i => i.Name,
                new Rating
                {
                    Name = "G"
                },

                new Rating
                {
                    Name = "PG"
                },

                new Rating
                {
                    Name = "PG-13"
                },

                new Rating
                {
                    Name = "R"
                },

                new Rating
                {
                    Name = "NC-17"
                }

            );

            context.SaveChanges();

            context.Movies.AddOrUpdate(i => i.Title,
                new Movie
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-1-11"),
                    Genre = context.Genres.Single(x => x.Name == "Comedy"),
                    Price = 7.99M,
                    Rating = context.Ratings.Single(x => x.Name == "G"),
                    GenreID = context.Genres.Single(x => x.Name == "Comedy").GenreID,
                    RatingID = context.Ratings.Single(x => x.Name == "G").RatingID
                },

                 new Movie
                 {
                     Title = "Ghostbusters ",
                     ReleaseDate = DateTime.Parse("1984-3-13"),
                     Genre = context.Genres.Single(x => x.Name == "Comedy"),
                     Price = 8.99M,
                     Rating = context.Ratings.Single(x => x.Name == "G"),
                     GenreID = context.Genres.Single(x => x.Name == "Comedy").GenreID,
                     RatingID = context.Ratings.Single(x => x.Name == "G").RatingID
                 },

                 new Movie
                 {
                     Title = "Ghostbusters 2",
                     ReleaseDate = DateTime.Parse("1986-2-23"),
                     Genre = context.Genres.Single(x => x.Name == "Comedy"),
                     Price = 9.99M,
                     Rating = context.Ratings.Single(x => x.Name == "G"),
                     GenreID = context.Genres.Single(x => x.Name == "Comedy").GenreID,
                     RatingID = context.Ratings.Single(x => x.Name == "G").RatingID
                 },

               new Movie
               {
                   Title = "Rio Bravo",
                   ReleaseDate = DateTime.Parse("1959-4-15"),
                   Genre = context.Genres.Single(x => x.Name == "Western"),
                   Price = 3.99M,
                   Rating = context.Ratings.Single(x => x.Name == "G"),
                   GenreID = context.Genres.Single(x => x.Name == "Western").GenreID,
                   RatingID = context.Ratings.Single(x => x.Name == "G").RatingID
               }
           );

            context.SaveChanges();
        }
    }
}
