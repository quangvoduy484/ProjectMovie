using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public ICollection<MovieDetail> MovieDetails { get; set; }
    }
}
