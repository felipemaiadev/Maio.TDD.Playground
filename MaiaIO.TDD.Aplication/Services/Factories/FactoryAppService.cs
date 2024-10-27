using AutoMapper;
using MaiaIO.TDD.API.DTO.Factories.Response;
using MaiaIO.TDD.API.Services.Factories.Interfaces;
using MaiaIO.TDD.Aplication.DTO.Factories.Requests;
using MaiaIO.TDD.Domain.Factories.Commands;
using MaiaIO.TDD.Domain.Factories.Entities;
using MaiaIO.TDD.Domain.Factories.Services.Interface;

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


        public async Task<FactoryResponse> InsertAsync(FactoryInsertRequest factory)
        {
            var command =  _mapper.Map<FactoryInsertCommand>(factory);

            var response =  _mapper.Map<FactoryResponse>(await _factoryService.InsertAsync(command));

            return response;

        }

        public async Task<FactoryResponse> GetByIdAsync(long id)
        {

            var resultmap = _mapper.Map<FactoryResponse>(await _factoryService.GetByIdAsync(id));
            return resultmap;
        }



        public async Task<IEnumerable<FactoryListResponse>> ListarAsync()
        {

            var result = await _factoryService.GetListAsync();
            var mappedResult = _mapper.Map<IEnumerable<FactoryListResponse>>(result);
            return mappedResult;
        }


    }
}
