using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using MaiaIO.TDD.Domain.Factories.Entities;
using NHibernate;

namespace MaiaIO.TDD.Infra
{
    public class DbContext
    {

        private static ISessionFactory _sessionFactory { get; set; }
        private static string connectionString = @"server=127.0.0.1;Port=3306;database=FTW;Uid=root;pwd=my-secret-pw;";
        //private string connectionString = @"Server=localhost;Database=Base_FTW;Trusted_Connection=True";

        public DbContext() { }

        public static ISessionFactory Initialize()
        {


            //connectionString = new MySQLConnectionStringBuilder();

            if (_sessionFactory == null)
            {
                try
                {



                    //var session = config.SessionFactory();

                    _sessionFactory = Fluently.Configure()
                                            .Database(MySQLConfiguration.Standard
                                            .ConnectionString(connectionString))
                                            .Mappings(m =>
                                            {
                                                //m.HbmMappings.AddFromAssemblyOf<FactoryMapping>();
                                                m.AutoMappings.Add(AutoMap.AssemblyOf<Factory>());
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
