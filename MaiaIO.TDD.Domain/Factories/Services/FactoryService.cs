using MaiaIO.TDD.Domain.Devices.Servicos.interfaces;
using MaiaIO.TDD.Domain.Factories.Commands;
using MaiaIO.TDD.Domain.Factories.Entities;
using MaiaIO.TDD.Domain.Factories.Repositories.Interfaces;
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
        public Factory InsertAsync(Factory factory)
        {
            throw new NotImplementedException();
        }

        public Factory UpdateAsync(Factory factory)
        {
            throw new NotImplementedException();
        }

        public Factory DeleteAsync(Factory factory)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Factory>> GetListAsync()
        {
            
            return await _factoryRepository.GetListAsync();
        }

        public async Task<Factory> GetByIdAsync(long id)
        {
            return await _factoryRepository.GetByIdAsync(id);
        }
        //public async Task<Factory> GetAllFactories(FactoryGetListCommand command)
        //{
        //    //var resporitory = new FactoryRepository();

        //    //var result = await new List<Factory> { new Factory { Id = 1 }, new Factory { Id = 2 } } 

        //    return await GetFactories();
        //}



    }
}
