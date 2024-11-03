using AutoMapper;
using MaiaIO.TDD.API.DTO.Factories.Response;
using MaiaIO.TDD.API.Services.Factories.Interfaces;
using MaiaIO.TDD.Aplication.DTO.Factories.Requests;
using MaiaIO.TDD.Aplication.DTO.Factories.Response;
using MaiaIO.TDD.Domain.Factories.Commands;
using MaiaIO.TDD.Domain.Factories.Services.Interface;

namespace MaiaIO.TDD.API.Services.Factories
{
    public class FactoryAppService(IMapper mapper,
                                   IFactoryService factoryService) : IFactoryAppService

    {


        public async Task<FactoryResponse> InsertAsync(FactoryInsertRequest factory)
        {
            var command = mapper.Map<FactoryInsertCommand>(factory);
            var response = mapper.Map<FactoryResponse>(await factoryService.InsertAsync(command));

            return response;
        }

        public async Task<FactoryResponse> GetByIdAsync(long id)
        {

            var resultmap = mapper.Map<FactoryResponse>(await factoryService.GetByIdAsync(id));
            return resultmap;
        }

        public async Task<IEnumerable<FactoryListResponse>> ListarAsync()
        {

            var result = await factoryService.GetListAsync();
            var mappedResult = mapper.Map<IEnumerable<FactoryListResponse>>(result);
         
            return mappedResult;
        }

        public async Task<FactoryResponse> EditAsync(FactoryEditRequest factory)
        {
            FactoryEditCommand command = mapper.Map<FactoryEditCommand>(factory);
            return mapper.Map<FactoryResponse>(await  factoryService.EditAsync(command));
        }

        public async Task<FactoryResponse> RemoveByIdAsync(long id)
        {
            FactoryResponse response = mapper.Map<FactoryResponse>(await factoryService.DeleteAsync(id));

            return response;
        }
    }
}
