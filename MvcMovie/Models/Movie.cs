using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MvcMovie.Models
{
    public class Rating
    {
        public int RatingID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }
    }

    public class Genre
    {
        public int GenreID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }        
    }

    public class Movie
    {
        public int MovieID { get; set; }

        [Required]
        public int RatingID { get; set; }

        [Required]
        public int GenreID { get; set; }

        [Required]
        public string Title { get; set; }

        [DataType(DataType.Text)]
        [DisplayName("Release Date")]
        [DisplayFormat(ApplyFormatInEditMode=true, DataFormatString = "{0:d}")]
        public DateTime ReleaseDate { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public virtual Genre Genre { get; set; }
        public virtual Rating Rating { get; set; }
    }

    public class MovieDBContext : DbContext
    {
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Rating> Ratings { get; set; }        
        public DbSet<Movie> Movies { get; set; }

        internal void SaveChange()
        {
            throw new NotImplementedException();
        }
    }
}