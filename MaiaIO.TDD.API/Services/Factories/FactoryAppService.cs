using AutoMapper;
using MaiaIO.TDD.API.DTO.Factories.Response;
using MaiaIO.TDD.API.Services.Factories.NewFolder;
using MaiaIO.TDD.Domain.Devices.Servicos.interfaces;
using MaiaIO.TDD.Domain.Factories.Entities;

namespace MaiaIO.TDD.API.Services.Factories
{
    public class FactoryAppService : IFactoryAppService
    {
        public readonly IMapper _mapper;
        public readonly IFactoryService _factoryService;

        public FactoryAppService(IMapper mapper,
                                 IFactoryService factoryService)
        {
            _mapper = mapper;
            _factoryService = factoryService;
        }

        public async Task<Factory> GetByIdAsync(long id)
        {
            return await _factoryService.GetByIdAsync(id);
        }

        public async Task<IEnumerable<FactoryListResponse>> ListarAsync()
        {

            var result = await _factoryService.GetListAsync();
            var mappedResult = _mapper.Map<IEnumerable<FactoryListResponse>>(result);
            return mappedResult;
        }


        Task<Factory> IFactoryAppService.InsertAsync(Factory factory)
        {
            throw new NotImplementedException();
        }

        Task<Factory> IFactoryAppService.UpdateAsync(Factory factory)
        {
            throw new NotImplementedException();
        }

        public Task<Factory> RemoveAsync(Factory factory)
        {
            throw new NotImplementedException();
        }

        public Task<Factory> RemoveByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
