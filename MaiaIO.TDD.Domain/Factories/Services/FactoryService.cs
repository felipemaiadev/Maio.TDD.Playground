using MaiaIO.TDD.Domain.Factories.Commands;
using MaiaIO.TDD.Domain.Factories.Entities;
using MaiaIO.TDD.Domain.Factories.Repositories.Interfaces;
using MaiaIO.TDD.Domain.Factories.Services.Interface;
using MaiaIO.TDD.Domain.ProductionLines.Entities;
using Microsoft.VisualBasic;

namespace MaiaIO.TDD.Domain.Factories.Services
{
    public class FactoryService : IFactoryService
    {
        public readonly IFactoryRepository _factoryRepository;


        public FactoryService(IFactoryRepository factoryRepository)
        {
            _factoryRepository = factoryRepository;
        }

        public async Task<Factory> InsertAsync(FactoryInsertCommand factory)
        {
            var validFactory = await Instantiate(factory);
           return await _factoryRepository.InsertAsync(validFactory);
        }

        public async Task<IEnumerable<Factory>> GetListAsync()
        {

            return await _factoryRepository.GetListAsync();
        }

        public async Task<Factory> GetByIdAsync(long id)
        {
            return await _factoryRepository.GetByIdAsync(id);
        }

        public async Task<Factory> Instantiate(FactoryInsertCommand factoryInsertCommand)
        {
            Factory validFactory =  await Validate(factoryInsertCommand);
                
            return validFactory;
        }

        public async Task<Factory> Validate(FactoryInsertCommand factoryInsertCommand)
        {
            Factory factory = new Factory();

            factory.SetName(factoryInsertCommand.Name);
            factory.SetDescription(factoryInsertCommand.Description);
            factory.SetCountry(factoryInsertCommand.Country);
            factory.SetStatus(factoryInsertCommand.IsActive);
            factory.SetLines(new List<ProductionLine>());

            return factory;
        }



    }
}
