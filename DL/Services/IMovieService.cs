using DL.Reponse;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DL.Services
{
    public interface IMovieService
    {
        Task<BaseResponse> GetMovieDetails();
    }
}
