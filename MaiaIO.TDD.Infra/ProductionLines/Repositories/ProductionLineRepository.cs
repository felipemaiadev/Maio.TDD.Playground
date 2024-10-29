using MaiaIO.TDD.Domain.ProductionLines.Entities;
using MaiaIO.TDD.Domain.ProductionLines.Repositories;
using NHibernate.Linq;

namespace MaiaIO.TDD.Infra.ProductionLines.Repositories
{
    public class ProductionLineRepository : IProductionLineRepository
    {
        public async Task<IEnumerable<ProductionLineDTO>> GetAllProductionLinesAsync()
        {
            DbContext.Initialize();
            var session = DbContext.OpenSession();

            var query = from p in session.Query<ProductionLine>().Fetch(x  => x.Factory)
                                                                 .Fetch(s => s.Machines)
                        select new ProductionLineDTO
                        {
                            Name = p.Name,
                            Descriptrion = p.Descriptrion,
                            IdFactory = p.Factory.Id,
                            FactoryName = p.Factory.Name,
                            Machines = p.Machines,
                            IsActive = p.IsActive
                        };

            return await query.ToListAsync();


        }
    }
}
