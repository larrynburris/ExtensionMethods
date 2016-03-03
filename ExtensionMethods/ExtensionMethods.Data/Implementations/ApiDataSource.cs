using System.Collections.Generic;

namespace ExtensionMethods.Data.Implementations
{
    public class ApiDataSource : IDataSource
    {
        public string Name = "API";

        public IEnumerable<DataItem> GetItems()
        {
            return new List<DataItem>
            {
                new DataItem { Code="xyz", Description="from API" },
                new DataItem { Code="xyz", Description="from API 2" }
            };
        }
    }
}
