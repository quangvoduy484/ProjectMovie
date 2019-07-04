using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DL.Repositories
{
    public interface IRespository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Insert(T entity);
    }
}
