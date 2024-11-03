using MaiaIO.TDD.Domain.EntityBase.Repositories.Interfaces;
using MaiaIO.TDD.Domain.Factories.Entities;

namespace MaiaIO.TDD.Domain.Factories.Repositories.Interfaces
{
    public interface IFactoryRepository : INhibernateRepository<Factory>
    {
        public Task<IEnumerable<Factory>> GetListAsync();
        public Task<Factory> GetByIdAsync(long id);
        public Task<Factory> InsertAsync(Factory factory);
    }
}
