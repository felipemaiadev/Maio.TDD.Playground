using MaiaIO.TDD.Domain.Factories.Entities;
using MaiaIO.TDD.Domain.Factories.Repositories.Interfaces;
using MaiaIO.TDD.Infra.BaseEntities.Repositories;
using Microsoft.VisualBasic;
using NHibernate;
using NHibernate.Linq;

namespace MaiaIO.TDD.Infra.Factories.Repositories
{
    public class FactoryRepository : NHibernateRepository<Factory>, IFactoryRepository
    {
        public FactoryRepository(ISession session) : base(session)
        {
        }

        public async Task<IEnumerable<Factory>> GetListAsync()
        {
            
            IQueryable<Factory> result =  base.GetAll();

            return await result.ToListAsync();

        }

        public async Task<Factory> InsertAsync(Factory factory)
        {
            base.Add(factory);
            return factory;
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
