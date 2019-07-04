using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Models;
using DL.Reponse;
using DL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjectMovie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IBaseService _baseService;
        private readonly IMovieService _movieService;

        public MovieController(IBaseService baseService, IMovieService movieService)
        {
            _baseService = baseService;
            _movieService = movieService;
        }

        [HttpGet("GetAllMovie")]
        public Task<BaseResponse> GetAllMovie()
        {
            return _baseService.GetAll();
        }

        [HttpPost("AddMovie")]
        public Task<BaseResponse> AddMovie(Movie movie)
        {
            return _baseService.Insert(movie);
        }

        [HttpGet("GetMovieDetail")]
        public Task<BaseResponse> GetMovieDetail()
        {
            return _movieService.GetMovieDetails();
        }

    }
}