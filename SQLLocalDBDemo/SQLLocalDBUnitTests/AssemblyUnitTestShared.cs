using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SQLLocalDBUnitTests
{
    [TestClass]
    public sealed class AssemblyUnitTestShared
    {
        [AssemblyInitialize]
        public static void ClassStartInitialize(TestContext testContext)
        {
            UnitTestStartAndEnd.Start("sampledata");
            //TODO: add database constraints here
        }

        [AssemblyCleanup]
        public static void ClassEndCleanup()
        {
            UnitTestStartAndEnd.End("sampledata");
        }
    }
}
