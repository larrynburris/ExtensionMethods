using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethods.Data
{
    public static class IDataSourceCollectionExtensions
    {
        public static IEnumerable<DataItem> GetAllItemsByCode(this IDataSource[] sources, string code)
        {
            var items = new List<DataItem>();
            foreach(var source in sources)
            {
                items.AddRange(source.GetItemsByCode(code));
            }
            return items;
        }

        public static IEnumerable<DataItem> GetAllItemsByCode(this IEnumerable<IDataSource> sources, string code)
        {
            return sources.SelectMany(s => s.GetItemsByCode(code));
        }
    }
}
