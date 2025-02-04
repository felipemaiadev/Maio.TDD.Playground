using MaiaIO.TDD.Domain.ProductionLines.Entities;

namespace MaiaIO.TDD.Domain.ProductionLines.Repositories
{
    public interface IProductionLineWorkerOrderRepository
    {
        public Task<int> AddProductionLineWorkerOrder(ProductionLineWorkerOrder entidade);
        public Task<int> EditProductionLineWorkerOrder(ProductionLineWorkerOrder entidade);
    }
}
