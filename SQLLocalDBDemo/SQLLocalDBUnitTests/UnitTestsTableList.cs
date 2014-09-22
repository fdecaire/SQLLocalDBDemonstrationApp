namespace SQLLocalDBUnitTests
{
    public static class SampleDatabase
    {
        public static string[] TableList
        {
            get
            {
                // make sure these are in the right order.
                return new string[]
                  {
                    "product","producttype","store"
                  };
            }
        }
    }
}
