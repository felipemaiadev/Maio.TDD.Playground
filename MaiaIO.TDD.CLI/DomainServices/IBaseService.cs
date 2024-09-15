using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiaIO.TDD.CLI.Services
{
    public interface IBaseService<T> where T : class
    {

        Task<bool> AddUser(T entity);
        Task<T> RemoveUser(T entity);
        Task<T> GetUserById(Guid id);
    }
}
