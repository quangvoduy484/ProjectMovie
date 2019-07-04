using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DL.Repositories
{
    public interface IMovieRepository
    {
        Task<List<MovieDetail>> GetMovieDetails();
    }
}
