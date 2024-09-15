using MaiaIO.TDD.CLI.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiaIO.TDD.CLI.Repository
{
    public class BaseRepository<T> : IBaseService<T> where T : class
    {
        private readonly DbContext _context;
        private readonly DbSet<T> _dbSet;

        public BaseRepository(DbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddUser(T entity)
        {
             await _context.AddAsync(entity);
             var result = await _context.SaveChangesAsync();
            return result > 0; 
        }

        public async Task<T> RemoveUser(T entity)
        {
            var obj = _context.Remove(entity);
            _context.SaveChanges();
            return obj.Entity;
        }

        public async Task<T> GetUserById(Guid id)
        {
            return await _context.FindAsync<T>(id);
        }
    }
}
