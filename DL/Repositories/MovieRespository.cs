using DAL.Contexts;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DL.Repositories
{
    public class MovieRespository : IMovieRepository
    {
        private readonly DataContext _context;
        public MovieRespository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<MovieDetail>> GetMovieDetails()
        {
           
            return await _context.MovieDetail.Include(x => x.Movie).Include(x => x.Person).ToListAsync();
        }

        
    }
}
