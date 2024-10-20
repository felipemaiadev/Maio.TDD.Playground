using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using MaiaIO.TDD.Infra.Devices.Mappings;
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


            //connectionString = new MySQLConnectionStringBuilder();

            if (_sessionFactory == null)
            {
                try
                {


                    //NHibernate.Cfg.Configuration config = new NHibernate.Cfg.Configuration();

                    //var session = config.SessionFactory();

                    

                    _sessionFactory = Fluently.Configure()
                                            .Database(MySQLConfiguration.Standard
                                            .ConnectionString(connectionString))
                                            .Mappings(m =>
                                            {
                                                //m.HbmMappings.AddFromAssemblyOf<FactoryMapping>();
                                                m.FluentMappings.AddFromAssemblyOf<BaseDeviceMappings>();
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
