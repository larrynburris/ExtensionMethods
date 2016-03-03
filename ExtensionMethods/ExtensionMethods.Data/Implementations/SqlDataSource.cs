using System.Collections.Generic;

namespace ExtensionMethods.Data.Implementations
{
    public class SqlDataSource : IDataSource
    {
        public string Name = "SQL";

        public IEnumerable<DataItem> GetItems()
        {
            return new List<DataItem>
            {
                new DataItem { Code="xyz", Description="from SQL" },
                new DataItem { Code="xyz", Description="from SQL 2" }
            };
        }
    }
}
