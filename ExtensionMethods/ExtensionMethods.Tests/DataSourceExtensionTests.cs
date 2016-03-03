using ExtensionMethods.Data;
using ExtensionMethods.Data.Implementations;
using NUnit.Framework;
using System.Linq;

namespace ExtensionMethods.Tests
{
    [TestFixture]
    public class DataSourceExtensionTests
    {
        [Test]
        public void Test_GetItems()
        {
            IDataSource source;
            source = new SqlDataSource();
            Assert.AreEqual(2, source.GetItems().Count());
            source = new XmlDataSource();
            Assert.AreEqual(2, source.GetItems().Count());
            source = new ApiDataSource();
            Assert.AreEqual(2, source.GetItems().Count());
        }

        [Test]
        public void Test_GetItemsByCodeFromSqlSource()
        {
            var source = new SqlDataSource();
            Assert.AreEqual(2, source.GetItemsByCode("xyz").Count());
        }

        [Test]
        public void Test_GetItemsByCodeFromApiSource()
        {
            var source = new ApiDataSource();
            Assert.AreEqual(2, source.GetItemsByCode("xyz").Count());
        }

        [Test]
        public void Test_GetItemsByCodeFromXmlSource()
        {
            var source = new XmlDataSource();
            Assert.AreEqual(2, source.GetItemsByCode("xyz").Count());
        }
    }
}
