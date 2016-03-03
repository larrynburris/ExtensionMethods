using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionMethods.Data
{
    public static class IDataSourceExtensions
    {
        public static IEnumerable<DataItem> GetItemsByCode(this IDataSource source, string code)
        {
            return source.GetItems().Where(i => i.Code == code);
        }
    }
}
