using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Collections;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int MovieID { get; set; }

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

        public virtual ICollection<Rating> Ratings { get; set; }
    }

    public class Rating
    {
        public int RatingID { get; set; }
        public int MovieID { get; set; }
        public string Name { get; set; }
        public virtual Movie Movie { get; set; }

    }

    public class Genre
    {
        public int GenreID { get; set; }
        public int MovieID { get; set; }
        public string Name { get; set; }
        public virtual Genre Genre { get; set; }
    }

    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}