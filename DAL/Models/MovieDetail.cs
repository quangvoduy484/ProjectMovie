using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class MovieDetail
    {
        public int MovieDetailId { get; set; }
        public DateTime CreateDate { get; set; }
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
