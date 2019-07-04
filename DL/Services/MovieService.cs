using DAL.Models;
using DL.Infrastructure;
using DL.Models;
using DL.Reponse;
using DL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.Services
{
    public class MovieService : IBaseService, IMovieService
    {
        // MovieService chỉ chứa những phương thức cơ bản như thêm xóa sữa 
        // Chia nhỏ interface để thực hiện report movie
        private readonly IRespository<Movie> _respository;
        private readonly IErrorHandler _errorHandler;
        private readonly IMovieRepository _movieRepository;
        public MovieService(IRespository<Movie> respository, IErrorHandler errorHandler, IMovieRepository movieRepository)
        {
            _respository = respository;
            _errorHandler = errorHandler;
            _movieRepository = movieRepository;
        }

        public async Task<BaseResponse> GetAll()
        {
            var Movies = await _respository.GetAll();
            if (Movies == null)
            {
                return new BaseResponse
                {
                    ErrorCode = 1,
                    Messege = _errorHandler.GetMessage(ErrorMessagesEnum.ListEntityEmpty)
                };
            }
            return new BaseResponse
            {
                ErrorCode = 0,
                Messege = _errorHandler.GetMessage(ErrorMessagesEnum.LoadSuccess),
                Data = Movies
            };

        }
        
        public async Task<BaseResponse> Insert(Movie entity)
        {
            if (string.IsNullOrWhiteSpace(entity.MovieName))
            {
                return new BaseResponse
                {
                    ErrorCode = 1,
                    Messege = String.Format(_errorHandler.GetMessage(ErrorMessagesEnum.ModelValidation), "Movie Name is Null")
                };
            }
            var movie = await _respository.Insert(entity);
            return new BaseResponse
            {
                ErrorCode = 0,
                Messege = _errorHandler.GetMessage(ErrorMessagesEnum.AddSuccess),
                Data = movie
            };

        }

        public async Task<BaseResponse> GetMovieDetails()
        {
         
            var ListMovieDetails = await _movieRepository.GetMovieDetails();
           
            if (ListMovieDetails == null)
            {
                return new BaseResponse
                {
                    ErrorCode = 1,
                    Messege = _errorHandler.GetMessage(ErrorMessagesEnum.ListEntityEmpty)
                };
            }
            var DetailMovies = ListMovieDetails.Select(x => new InfoMovie
            { 
                NamePerson = x.Person.PersonName,
                NameMovie = x.Movie.MovieName,
                CreateDate = x.CreateDate
            }).ToList();

            return new BaseResponse
            {
                ErrorCode = 0,
                Messege = _errorHandler.GetMessage(ErrorMessagesEnum.LoadSuccess),
                Data = DetailMovies
            };

        }


    }
}
