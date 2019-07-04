using DAL.Models;
using DL.Reponse;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DL.Services
{
    public interface IBaseService
    { 
        Task<BaseResponse> GetAll();
        Task<BaseResponse> Insert(Movie entity); 
    }
}
