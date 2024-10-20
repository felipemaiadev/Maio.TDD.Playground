using MaiaIO.TDD.Domain.Factories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MaiaIO.TDD.Domain.Factories.Repositories.Interfaces
{
    public interface IFactoryRepository
    {
        public Task<IEnumerable<Factory>> GetListAsync();
        public Task<Factory> GetByIdAsync(long id);
    }
}
