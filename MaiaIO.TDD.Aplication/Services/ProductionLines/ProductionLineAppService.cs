using AutoMapper;
using MaiaIO.TDD.Aplication.DTO.ProductionLines.Requests;
using MaiaIO.TDD.Aplication.DTO.ProductionLines.Response;
using MaiaIO.TDD.Aplication.Services.ProductionLines.Interfaces;
using MaiaIO.TDD.Domain.ProductionLines.Repositories;

namespace MaiaIO.TDD.Aplication.Services.ProductionLines
{
    public class ProductionLineAppService(IMapper mapper,
                                          IProductionLineRepository productionLineRepository) : IProductionLineAppService
    {
        public async Task<IEnumerable<ProductionLineResponse>> GetAllProductionLinesAsync()
        {
            var result = await productionLineRepository.GetAllProductionLinesAsync();
            return mapper.Map<IEnumerable<ProductionLineResponse>>(result);
        }

        public Task<ProductionLineResponse> GetProductionLineByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<ProductionLineResponse> InsertAsync(ProductionLineInsertRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ProductionLineResponse> UpdateAsync(ProductionLineEditRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ProductionLineResponse> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }
    }
}
