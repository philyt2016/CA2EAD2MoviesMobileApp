﻿using System.ComponentModel.DataAnnotations;

namespace MoviesActorsAPI
{
    public class Movie
    {
        [Key]
        public string Name { get; set; }              // unique

        [Required]
        public int ReleaseYear { get; set; }

        [Required]        
        public string Genre { get; set; }

        [Required]
        public int Stars { get; set; }

        [Required]
        public int Runtime { get; set; }

        public string CoverUrl { get; set; }

        public string TrailerUrl { get; set; }

    }
}
