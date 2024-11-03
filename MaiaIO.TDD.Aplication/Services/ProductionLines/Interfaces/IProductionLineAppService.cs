using MaiaIO.TDD.Aplication.DTO.ProductionLines.Requests;
using MaiaIO.TDD.Aplication.DTO.ProductionLines.Response;

namespace MaiaIO.TDD.Aplication.Services.ProductionLines.Interfaces
{
    public interface IProductionLineAppService
    {

        public Task<IEnumerable<ProductionLineResponse>> GetAllProductionLinesAsync();
        public Task<ProductionLineResponse> GetProductionLineByIdAsync(long id);
        public Task<ProductionLineResponse> InsertAsync(ProductionLineInsertRequest request);
        public Task<ProductionLineResponse> UpdateAsync(ProductionLineEditRequest request);
        public Task<ProductionLineResponse> DeleteAsync(long id);
    }
}
