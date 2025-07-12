﻿using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public string Genre { get; set; } = null!;
        public decimal Price { get; set; }
    }
}