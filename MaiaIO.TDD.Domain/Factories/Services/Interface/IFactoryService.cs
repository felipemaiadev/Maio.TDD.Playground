using MaiaIO.TDD.Domain.Factories.Commands;
using MaiaIO.TDD.Domain.Factories.Entities;

namespace MaiaIO.TDD.Domain.Factories.Services.Interface
{
    public interface IFactoryService
    {

        //public Task<Factory> GetAllFactories(FactoryGetListCommand command);

        public Task<IEnumerable<Factory>> GetListAsync();
        public Task<Factory> GetByIdAsync(long id);
        public Task<Factory> InsertAsync(FactoryInsertCommand factory);
        public Task<Factory> EditAsync(FactoryEditCommand factoryEditCommand);
        public Task<Factory> DeleteAsync(long id);
        public Task<Factory> Instantiate(FactoryInsertCommand factoryInsertRequest);
        public Task<Factory> Instantiate(FactoryEditCommand factoryEditCommand);
        public Task<Factory> Validate(FactoryInsertCommand factoryInsertCommand);
        public Task<Factory> Validate(FactoryEditCommand factoryEditCommand);
    }
}
