using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using MaiaIO.TDD.Infra.Factories.Mappings;
using Microsoft.Extensions.DependencyInjection;
using NHibernate.Cfg;
using NHibernate.Cfg.MappingSchema;
using NHibernate.Dialect;
using NHibernate.Mapping.ByCode;


namespace MaiaIO.TDD.IoC
{
    public static class NhibernateExtensions
    {

        public static IServiceCollection AddNHibernate(this IServiceCollection services, string connectionString)
        {
            //var mapper = new ModelMapper();
            //mapper.AddMappings(typeof(NhibernateExtensions).Assembly.ExportedTypes);
            //HbmMapping mapping = mapper.CompileMappingForAllExplicitlyAddedEntities();


           

          var sessionFactory =   Fluently.Configure()
                                           .Database(MySQLConfiguration.Standard
                                           .ConnectionString(connectionString))
                                           .Mappings(m =>
                                           {

                                               m.FluentMappings.AddFromAssemblyOf<FactoryMapping>();
                                           })
                                           .ExposeConfiguration(c =>
                                           {
                                               c.SetProperty("show_sql", "true");
                                           })
                                           .BuildSessionFactory();

            services.AddSingleton(sessionFactory);
            services.AddScoped(factory => sessionFactory.OpenSession());

            return services;

        }

    }
}
