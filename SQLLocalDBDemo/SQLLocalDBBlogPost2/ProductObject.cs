using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Linq;

namespace SQLLocalDBBlogPost2
{
    public class ProductObject
    {
        ISession db;

        public ProductObject(ISession testSession)
        {
            db = testSession;
        }

        public ProductObject()
        {
            db = SampleDataContext.OpenSession();
        }

        public List<Product> ReadAll()
        {
            return (from p in db.Query<Product>() select p).ToList();
        }
    }
}
