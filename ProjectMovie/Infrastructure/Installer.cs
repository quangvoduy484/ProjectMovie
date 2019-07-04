using DAL.Contexts;
using DAL.Models;
using DL.Infrastructure;
using DL.Repositories;
using DL.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectMovie.Infrastructure
{
    internal class Installer
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DataContext>();

            services.AddTransient<IRespository<Movie>, BaseRepository<Movie>>();
            services.AddTransient<IMovieRepository, MovieRespository>();
            services.AddTransient<IBaseService, MovieService>();
            services.AddTransient<IMovieService, MovieService>();
            services.AddTransient<IErrorHandler, ErrorMessages>();
        }
    }
}
