using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using SQLLocalDBBlogPost2;

namespace SQLLocalDBUnitTests
{
    public class SampleDataTestContext
    {
        private static ISessionFactory _sessionFactory;
        private static ISessionFactory SessionFactory
        {
            get
            {
                try
                {
                    if (_sessionFactory == null)
                    {
                        _sessionFactory = Fluently.Configure()
                                                  .Database(MsSqlConfiguration.MsSql2005
                                                                              .ConnectionString(
                                                                                "Server=(localdb)\\sampledatatestinstance;Integrated Security=True"))
                                                  .Mappings(m => m.FluentMappings.Add<ProductMap>())
                                                  .Mappings(m => m.FluentMappings.Add<ProductTypeMap>())
                                                  .Mappings(m => m.FluentMappings.Add<StoreMap>())
                                                  .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(true, true))
                                                  .BuildSessionFactory();
                    }
                    return _sessionFactory;
                }
                catch (Exception ex)
                {
                    string temp = ex.Message;
                    throw;
                }
            }
        }
        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}
