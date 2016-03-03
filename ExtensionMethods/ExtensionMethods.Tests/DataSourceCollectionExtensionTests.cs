using ExtensionMethods.Data;
using ExtensionMethods.Data.Implementations;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethods.Tests
{
    [TestFixture]
    public class DataSourceCollectionExtensionTests
    {
        [Test]
        public void Test_GetAllItemsByCode_Array()
        {
            var sources = new IDataSource[]
            {
                new SqlDataSource(),
                new XmlDataSource(),
                new ApiDataSource()
            };
            var items = sources.GetAllItemsByCode("xyz");
            Assert.AreEqual(6, items.Count());
        }

        [Test]
        public void Test_GetAllItemsByCode_Enumerable()
        {
            var sources = new List<IDataSource>
            {
                new SqlDataSource(),
                new XmlDataSource(),
                new ApiDataSource()
            };
            var items = sources.GetAllItemsByCode("xyz");
            Assert.AreEqual(6, items.Count());
        }
    }
}
