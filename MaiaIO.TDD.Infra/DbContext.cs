using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using MaiaIO.TDD.Infra.Factories.Mappings;
using NHibernate;

namespace MaiaIO.TDD.Infra
{
    public class DbContext
    {

        public static ISessionFactory sessionFactory => _sessionFactory;

        private static ISessionFactory _sessionFactory { get; set; }
        private static string connectionString = @"server=127.0.0.1;Port=3306;database=FTW;Uid=root;pwd=my-secret-pw;";
        //private string connectionString = @"Server=localhost;Database=Base_FTW;Trusted_Connection=True";

        public DbContext(ISessionFactory sessionFactory)
        {
            _sessionFactory = sessionFactory;
        }

        public static ISessionFactory Initialize()
        {

            if (_sessionFactory == null)
            {
                try
                {
                    _sessionFactory = Fluently.Configure()
                                            .Database(MySQLConfiguration.Standard
                                            .ConnectionString(connectionString))
                                            .Mappings(m =>
                                            {
                                                //m.HbmMappings.AddFromAssemblyOf<FactoryMapping>();
                                                m.FluentMappings.AddFromAssemblyOf<FactoryMapping>();
                                            })
                                            .ExposeConfiguration(c =>
                                            {
                                                c.SetProperty("show_sql", "true");
                                            })
                                            .BuildSessionFactory();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }
            }
            return _sessionFactory;
        }

        public static ISession OpenSession()
        {
            return _sessionFactory.OpenSession();
        }
    }


}
