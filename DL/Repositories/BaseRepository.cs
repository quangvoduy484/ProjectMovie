using DAL.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DL.Repositories
{
    public class BaseRepository<T> : IRespository<T> where T : class
    {
        private readonly DataContext _context;

        private readonly DbSet<T> _entities;

        public BaseRepository(DataContext context)
        {
            _context = context;
            _entities = context.Set<T>();

        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _entities.ToListAsync();
        }

        public async Task<T> Insert(T entity)
        {
            await _entities.AddAsync(entity);
            _context.SaveChanges();
            return entity;
        }

    }
}
