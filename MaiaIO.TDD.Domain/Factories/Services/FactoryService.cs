using MaiaIO.TDD.Domain.Factories.Commands;
using MaiaIO.TDD.Domain.Factories.Entities;
using MaiaIO.TDD.Domain.Factories.Repositories.Interfaces;
using MaiaIO.TDD.Domain.Factories.Services.Interface;
using MaiaIO.TDD.Domain.ProductionLines.Entities;
using Microsoft.VisualBasic;

namespace MaiaIO.TDD.Domain.Factories.Services
{
    public class FactoryService(IFactoryRepository factoryRepository) : IFactoryService
    {


        public async Task<Factory> InsertAsync(FactoryInsertCommand factory)
        {
            var validFactory = await Instantiate(factory);
           return await factoryRepository.InsertAsync(validFactory);
        }

        public async Task<Factory> EditAsync(FactoryEditCommand factoryEditCommand)
        {
            Factory factory = await  Instantiate(factoryEditCommand);
            await factoryRepository.UpdateAsync(factory);
            return factory;
        }

        public async Task<IEnumerable<Factory>> GetListAsync()
        {

            return await factoryRepository.GetListAsync();
        }

        public async Task<Factory> GetByIdAsync(long id)
        {
            return await factoryRepository.GetByIdAsync(id);
        }

        public async Task<Factory> DeleteAsync(long id)
        {
            Factory factory = await GetByIdAsync(id);
            factoryRepository.Delete(factory);
            return factory;
        }

        public async Task<Factory> Instantiate(FactoryInsertCommand factoryInsertCommand)
        {
            Factory validFactory =  await Validate(factoryInsertCommand);
                
            return validFactory;
        }

        public async Task<Factory> Instantiate(FactoryEditCommand factoryEditCommand)
        { 
            Factory factory = await Validate(factoryEditCommand);

            return factory;
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

       

        public async Task<Factory> Validate(FactoryEditCommand factoryEditCommand)
        {
            Factory factory = await factoryRepository.GetByIdAsync(factoryEditCommand.Id);

            if (factory == null) throw new ArgumentException("Fabrica a ser editada não localizada");

            if (factory.UID != factoryEditCommand.UID) throw new ArgumentException("O UID repassado não é o mesmo da entidade presistida");

            factory.SetDescription(factoryEditCommand.Description);
            factory.SetCountry(factoryEditCommand.Country);
            factory.SetStatus(factoryEditCommand.IsActive);
            factory.SetName(factoryEditCommand.Name);

            return factory;
        }

       
    }
}
