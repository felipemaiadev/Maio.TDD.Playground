using MaiaIO.TDD.Domain.EntityBase.Repositories.Interfaces;
using MaiaIO.TDD.Domain.Factories.Entities;
using MaiaIO.TDD.Domain.Factories.Repositories.Consultas;

namespace MaiaIO.TDD.Domain.Factories.Repositories.Interfaces
{
    public interface IFactoryRepository : INhibernateRepository<Factory>
    {
        public Task<IList<FactoryListarConsulta>> GetListAsync();
        public Task<Factory> GetByIdAsync(long id);
        public Task<Factory> InsertAsync(Factory factory);
        public Task<Factory> UpdateAsync(Factory factory);
    }
}
