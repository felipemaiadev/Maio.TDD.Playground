using MaiaIO.TDD.Domain.Factories.Entities;
using MaiaIO.TDD.Domain.Factories.Repositories.Interfaces;
using NHibernate.Linq;

namespace MaiaIO.TDD.Infra.Factories.Repositories
{
    public class FactoryRepository : IFactoryRepository
    {
        public async Task<IEnumerable<Factory>> GetListAsync()
        {
            DbContext.Initialize();
            var session = DbContext.OpenSession();

            //session.BeginTransaction();

            var result = await session.Query<Factory>().ToListAsync();

            return result;


        }

        public async Task<Factory> InsertAsync(Factory factory)
        {
            DbContext.Initialize();
            var session = DbContext.OpenSession();

            var transaction = session.BeginTransaction();

            var result = await session.SaveAsync(factory, CancellationToken.None);

            transaction.Commit();

            return (Factory)result;
        }

        public async Task<Factory> GetByIdAsync(long id)
        {
            DbContext.Initialize();
            var session = DbContext.OpenSession();

            //session.BeginTransaction();

            var result = await session.Query<Factory>().FirstOrDefaultAsync(x => x.Id == id);

            return result;
        }


    }
}
