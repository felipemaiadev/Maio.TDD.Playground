using Microsoft.Extensions.DependencyInjection;
using NHibernate.Cfg;
using NHibernate.Cfg.MappingSchema;
using NHibernate.Dialect;
using NHibernate.Driver;
using NHibernate.Mapping.ByCode;
using System.Configuration;


namespace MaiaIO.TDD.IoC
{
    public static class NhibernateExtensions
    {

        public static IServiceCollection AddNHibernate(this IServiceCollection services, string connectionString)
        {
            var mapper = new ModelMapper();
            mapper.AddMappings(typeof(NhibernateExtensions).Assembly.ExportedTypes);
            HbmMapping mapping = mapper.CompileMappingForAllExplicitlyAddedEntities();

            var configuration = new NHibernate.Cfg.Configuration();

            configuration.DataBaseIntegration(c =>
            {
                c.Dialect<MySQL8Dialect>();
                c.ConnectionString = connectionString;
                c.KeywordsAutoImport = Hbm2DDLKeyWords.AutoQuote;
                c.SchemaAction = SchemaAutoAction.Validate;
                c.LogFormattedSql = true;
                c.LogSqlInConsole = true;
            });

            configuration.AddMapping(mapping);

            var sessionFactory = configuration.BuildSessionFactory();

            services.AddSingleton(sessionFactory);
            services.AddScoped(factory => sessionFactory.OpenSession());
            //services.AddScoped<IMapperSession, NHibernateMapperSession>();

            return services;

        }

    }
}
