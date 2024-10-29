using MaiaIO.TDD.Aplication.DTO.ProductionLines.Response;

namespace MaiaIO.TDD.Aplication.Services.ProductionLines.Interfaces
{
    public interface IProductionLineAppService
    {

        public Task<IEnumerable<ProductionLineResponse>> GetAllProductionLinesAsync();
    }
}
