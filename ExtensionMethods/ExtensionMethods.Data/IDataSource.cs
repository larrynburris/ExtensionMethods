using System.Collections.Generic;

namespace ExtensionMethods.Data
{
    public interface IDataSource
    {
        IEnumerable<DataItem> GetItems();
    }
}
