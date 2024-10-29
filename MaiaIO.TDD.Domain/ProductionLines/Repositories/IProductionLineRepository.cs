

using MaiaIO.TDD.Domain.ProductionLines.Entities;

namespace MaiaIO.TDD.Domain.ProductionLines.Repositories
{
    public interface IProductionLineRepository
    {

        public Task<IEnumerable<ProductionLineDTO>> GetAllProductionLinesAsync();
    }
}
