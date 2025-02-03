using MaiaIO.TDD.Domain.Factories.Entities;
using MaiaIO.TDD.Domain.Factories.Repositories.Consultas;
using MaiaIO.TDD.Domain.Factories.Repositories.Interfaces;
using MaiaIO.TDD.Infra.BaseEntities.Repositories;
using NHibernate;
using NHibernate.Linq;

namespace MaiaIO.TDD.Infra.Factories.Repositories
{
    public class FactoryRepository(ISession session) : NHibernateRepository<Factory>(session), IFactoryRepository
    {
        public async Task<IList<FactoryListarConsulta>> GetListAsync()
        {

            var resultado = session.Query<Factory>()
                                          .SelectMany(x => x.Lines,
                                                      (factory, lines) =>
                                                      new FactoryListarConsulta
                                                      {
                                                          FactoryId = factory.Id,
                                                          FatoryName = factory.Name,
                                                          FactoryDescription = factory.Description,
                                                          LineAssemblyTimeStamp = lines.AssemblyStamp,
                                                          LineDescription = lines.Descriptrion
                                                      })
                                          .ToList();
            return resultado;

        }

        public async Task<Factory> InsertAsync(Factory factory)
        {
            base.Add(factory);
            return factory;
        }

        public async Task<Factory> GetByIdAsync(long id)
        {
            var result = await session.Query<Factory>().FirstOrDefaultAsync(x => x.Id == id);

            return result;
        }

        public async Task<Factory> UpdateAsync(Factory factory)
        {
            try
            {
                var trns = session.BeginTransaction();
                await session.SaveOrUpdateAsync(factory);
                trns.Commit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

            return factory;
        }
    }
}
