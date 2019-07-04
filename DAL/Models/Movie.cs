using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public ICollection<MovieDetail> MovieDetails { get; set; }
    }
}
