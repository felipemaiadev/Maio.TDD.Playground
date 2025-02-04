using MaiaIO.TDD.Domain.ProductionLines.Entities;
using MaiaIO.TDD.Domain.ProductionLines.Repositories;
using NHibernate;

namespace MaiaIO.TDD.Infra.ProductionLines.Repositories
{
    internal class ProductionLineWorkerOrderRepository(ISession session) : IProductionLineWorkerOrderRepository
    {
        public async Task<int> AddProductionLineWorkerOrder(ProductionLineWorkerOrder entidade)
        {
            var result = await session.SaveAsync(entidade);
            return 0;
        }

        public Task<int> EditProductionLineWorkerOrder(ProductionLineWorkerOrder entidade)
        {
            throw new NotImplementedException();
        }
    }
}
