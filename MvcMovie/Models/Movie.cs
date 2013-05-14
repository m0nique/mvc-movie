using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [Required]
        public string Title { get; set; }

        [DataType(DataType.Text)]
        [DisplayName("Release Date")]
        [DisplayFormat(ApplyFormatInEditMode=true, DataFormatString = "{0:d}")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public string Genre { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [StringLength(5)]
        public string Rating { get; set; }
    }

    public class Rating
    {
        public int ID { get; set; }

        public string Name { get; set; }
    }

    public class Genre
    {
        public int ID { get; set; }

        public string Name { get; set; }
    }

    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}