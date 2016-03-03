using System.Collections.Generic;

namespace ExtensionMethods.Data.Implementations
{
    public class XmlDataSource : IDataSource
    {
        public string Name = "XML";

        public IEnumerable<DataItem> GetItems()
        {
            return new List<DataItem>
            {
                new DataItem { Code="xyz", Description="from XML" },
                new DataItem { Code="xyz", Description="from XML 2" }
            };
        }
    }
}
