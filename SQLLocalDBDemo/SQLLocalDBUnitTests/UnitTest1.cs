using Microsoft.VisualStudio.TestTools.UnitTesting;
using NHibernate;
using SQLLocalDBBlogPost2;

namespace SQLLocalDBUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void Initialize()
        {
            // not used here
        }

        [TestCleanup]
        public void Cleanup()
        {
            // truncate any existing data
            UnitTestStartAndEnd.TruncateData("sampledata", SampleDatabase.TableList);
        }

        [TestMethod]
        public void test_method_11()
        {
            using (ISession unitTestSession = SampleDataTestContext.OpenSession())
            {
                Store store = new Store
                {
                    testfield = "1234567890abcdefghijklmnopqrstuvwxyz1234567890abcdefghijklmnopqrstuvwxyz1234567890abcdefghijklmnopqrstuvwxyz1234567890abcdefghijklmnopqrstuvwxyz1234567890abcdefghijklmnopqrstuvwxyz1234567890abcdefghijklmnopqrstuvwxyz1234567890abcdefghijklmnopqrstuvwxyz1234567890abcdefghijklmnopqrstuvwxyz1234567890abcdefghijklmnopqrstuvwxyz1234567890abcdefghijklmnopqrstuvwxyz"
                };
                unitTestSession.Save(store);
                unitTestSession.Flush();
            }
        }

        // 10 generic unit tests to demonstrate performance
        [TestMethod]
        public void test_method_1()
        {
            using (ISession unitTestSession = SampleDataTestContext.OpenSession())
            {
                Product product = new Product
                {
                    Name = "P 1",
                    ProductId = 1,
                    store = 1
                };
                unitTestSession.Save(product);
                unitTestSession.Flush();
                product = new Product
                {
                    Name = "P 2",
                    ProductId = 2,
                    store = 1
                };
                unitTestSession.Save(product);
                unitTestSession.Flush();
                product = new Product
                {
                    Name = "P 3",
                    ProductId = 3,
                    store = 1
                };
                unitTestSession.Save(product);
                unitTestSession.Flush();
                product = new Product
                {
                    Name = "P 4",
                    ProductId = 4,
                    store = 1
                };
                unitTestSession.Save(product);
                unitTestSession.Flush();

                ProductObject productObject = new ProductObject(unitTestSession);
                var productList = productObject.ReadAll();

                Assert.AreEqual(4, productList.Count);
            }
        }

        [TestMethod]
        public void test_method_2()
        {
            using (ISession unitTestSession = SampleDataTestContext.OpenSession())
            {
                Product product = new Product
                {
                    Name = "P 1",
                    ProductId = 1,
                    store = 1
                };
                unitTestSession.Save(product);
                unitTestSession.Flush();

                ProductObject productObject = new ProductObject(unitTestSession);
                var productList = productObject.ReadAll();

                Assert.AreEqual("P 1", productList[0].Name);
            }
        }

        [TestMethod]
        public void test_method_3()
        {
            using (ISession unitTestSession = SampleDataTestContext.OpenSession())
            {
                Product product = new Product
                {
                    Name = "P 1",
                    ProductId = 1,
                    store = 1
                };
                unitTestSession.Save(product);
                unitTestSession.Flush();
                product = new Product
                {
                    Name = "P 2",
                    ProductId = 2,
                    store = 1
                };
                unitTestSession.Save(product);
                unitTestSession.Flush();
                product = new Product
                {
                    Name = "P 3",
                    ProductId = 3,
                    store = 1
                };
                unitTestSession.Save(product);
                unitTestSession.Flush();
                product = new Product
                {
                    Name = "P 4",
                    ProductId = 4,
                    store = 1
                };
                unitTestSession.Save(product);
                unitTestSession.Flush();

                ProductObject productObject = new ProductObject(unitTestSession);
                var productList = productObject.ReadAll();

                Assert.AreEqual(4, productList.Count);
            }
        }

        [TestMethod]
        public void test_method_4()
        {
            using (ISession unitTestSession = SampleDataTestContext.OpenSession())
            {
                Product product = new Product
                {
                    Name = "P 1",
                    ProductId = 1,
                    store = 1
                };
                unitTestSession.Save(product);
                unitTestSession.Flush();
                product = new Product
                {
                    Name = "P 2",
                    ProductId = 2,
                    store = 1
                };
                unitTestSession.Save(product);
                unitTestSession.Flush();
                product = new Product
                {
                    Name = "P 3",
                    ProductId = 3,
                    store = 1
                };
                unitTestSession.Save(product);
                unitTestSession.Flush();
                product = new Product
                {
                    Name = "P 4",
                    ProductId = 4,
                    store = 1
                };
                unitTestSession.Save(product);
                unitTestSession.Flush();

                ProductObject productObject = new ProductObject(unitTestSession);
                var productList = productObject.ReadAll();

                Assert.AreEqual(4, productList.Count);
            }
        }

        [TestMethod]
        public void test_method_5()
        {
            using (ISession unitTestSession = SampleDataTestContext.OpenSession())
            {
                Product product = new Product
                {
                    Name = "P 1",
                    ProductId = 1,
                    store = 1
                };
                unitTestSession.Save(product);
                unitTestSession.Flush();
                product = new Product
                {
                    Name = "P 2",
                    ProductId = 2,
                    store = 1
                };
                unitTestSession.Save(product);
                unitTestSession.Flush();
                product = new Product
                {
                    Name = "P 3",
                    ProductId = 3,
                    store = 1
                };
                unitTestSession.Save(product);
                unitTestSession.Flush();
                product = new Product
                {
                    Name = "P 4",
                    ProductId = 4,
                    store = 1
                };
                unitTestSession.Save(product);
                unitTestSession.Flush();

                ProductObject productObject = new ProductObject(unitTestSession);
                var productList = productObject.ReadAll();

                Assert.AreEqual(4, productList.Count);
            }
        }

        [TestMethod]
        public void test_method_6()
        {
            using (ISession unitTestSession = SampleDataTestContext.OpenSession())
            {
                Product product = new Product
                {
                    Name = "P 1",
                    ProductId = 1,
                    store = 1
                };
                unitTestSession.Save(product);
                unitTestSession.Flush();
                product = new Product
                {
                    Name = "P 2",
                    ProductId = 2,
                    store = 1
                };
                unitTestSession.Save(product);
                unitTestSession.Flush();
                product = new Product
                {
                    Name = "P 3",
                    ProductId = 3,
                    store = 1
                };
                unitTestSession.Save(product);
                unitTestSession.Flush();
                product = new Product
                {
                    Name = "P 4",
                    ProductId = 4,
                    store = 1
                };
                unitTestSession.Save(product);
                unitTestSession.Flush();

                ProductObject productObject = new ProductObject(unitTestSession);
                var productList = productObject.ReadAll();

                Assert.AreEqual(4, productList.Count);
            }
        }

        [TestMethod]
        public void test_method_7()
        {
            using (ISession unitTestSession = SampleDataTestContext.OpenSession())
            {
                Product product = new Product
                {
                    Name = "P 1",
                    ProductId = 1,
                    store = 1
                };
                unitTestSession.Save(product);
                unitTestSession.Flush();
                product = new Product
                {
                    Name = "P 2",
                    ProductId = 2,
                    store = 1
                };
                unitTestSession.Save(product);
                unitTestSession.Flush();
                product = new Product
                {
                    Name = "P 3",
                    ProductId = 3,
                    store = 1
                };
                unitTestSession.Save(product);
                unitTestSession.Flush();
                product = new Product
                {
                    Name = "P 4",
                    ProductId = 4,
                    store = 1
                };
                unitTestSession.Save(product);
                unitTestSession.Flush();

                ProductObject productObject = new ProductObject(unitTestSession);
                var productList = productObject.ReadAll();

                Assert.AreEqual(4, productList.Count);
            }
        }

        [TestMethod]
        public void test_method_8()
        {
            using (ISession unitTestSession = SampleDataTestContext.OpenSession())
            {
                Product product = new Product
                {
                    Name = "P 1",
                    ProductId = 1,
                    store = 1
                };
                unitTestSession.Save(product);
                unitTestSession.Flush();
                product = new Product
                {
                    Name = "P 2",
                    ProductId = 2,
                    store = 1
                };
                unitTestSession.Save(product);
                unitTestSession.Flush();
                product = new Product
                {
                    Name = "P 3",
                    ProductId = 3,
                    store = 1
                };
                unitTestSession.Save(product);
                unitTestSession.Flush();
                product = new Product
                {
                    Name = "P 4",
                    ProductId = 4,
                    store = 1
                };
                unitTestSession.Save(product);
                unitTestSession.Flush();

                ProductObject productObject = new ProductObject(unitTestSession);
                var productList = productObject.ReadAll();

                Assert.AreEqual(4, productList.Count);
            }
        }

        [TestMethod]
        public void test_method_9()
        {
            using (ISession unitTestSession = SampleDataTestContext.OpenSession())
            {
                Product product = new Product
                {
                    Name = "P 1",
                    ProductId = 1,
                    store = 1
                };
                unitTestSession.Save(product);
                unitTestSession.Flush();
                product = new Product
                {
                    Name = "P 2",
                    ProductId = 2,
                    store = 1
                };
                unitTestSession.Save(product);
                unitTestSession.Flush();
                product = new Product
                {
                    Name = "P 3",
                    ProductId = 3,
                    store = 1
                };
                unitTestSession.Save(product);
                unitTestSession.Flush();
                product = new Product
                {
                    Name = "P 4",
                    ProductId = 4,
                    store = 1
                };
                unitTestSession.Save(product);
                unitTestSession.Flush();

                ProductObject productObject = new ProductObject(unitTestSession);
                var productList = productObject.ReadAll();

                Assert.AreEqual(4, productList.Count);
            }
        }

        [TestMethod]
        public void test_method_10()
        {
            using (ISession unitTestSession = SampleDataTestContext.OpenSession())
            {
                Product product = new Product
                {
                    Name = "P 1",
                    ProductId = 1,
                    store = 1
                };
                unitTestSession.Save(product);
                unitTestSession.Flush();
                product = new Product
                {
                    Name = "P 2",
                    ProductId = 2,
                    store = 1
                };
                unitTestSession.Save(product);
                unitTestSession.Flush();
                product = new Product
                {
                    Name = "P 3",
                    ProductId = 3,
                    store = 1
                };
                unitTestSession.Save(product);
                unitTestSession.Flush();
                product = new Product
                {
                    Name = "P 4",
                    ProductId = 4,
                    store = 1
                };
                unitTestSession.Save(product);
                unitTestSession.Flush();

                ProductObject productObject = new ProductObject(unitTestSession);
                var productList = productObject.ReadAll();

                Assert.AreEqual(4, productList.Count);
            }
        }
    }
}
