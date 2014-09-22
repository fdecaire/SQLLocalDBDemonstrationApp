using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;

namespace SQLLocalDBBlogPost2
{
    public class SampleDataContext
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
                                                                                "Server=FRANK-PC\\FRANK;Integrated Security=True")) // change this to point to your sql server
                                                  .Mappings(m => m.FluentMappings.Add<ProductMap>())
                                                  .Mappings(m => m.FluentMappings.Add<ProductTypeMap>())
                                                  .Mappings(m => m.FluentMappings.Add<StoreMap>())
                                                  .ExposeConfiguration(config =>
                                                  {
                                                      SchemaExport schemaExport = new SchemaExport(config);
                                                  })
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
