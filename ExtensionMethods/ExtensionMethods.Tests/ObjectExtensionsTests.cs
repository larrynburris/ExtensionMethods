using ExtensionMethods.Data;
using ExtensionMethods.Data.Implementations;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ExtensionMethods.Tests
{
    [TestFixture]
    public class ObjectExtensionsTests
    {
        [Test]
        public void Test_ToJsonString()
        {
            var obj1 = int.MaxValue;
            Debug.WriteLine("obj1 - " + obj1.ToJsonString());

            var obj2 = new DateTime(2016, 3, 3);
            Debug.WriteLine("obj2 - " + obj2.ToJsonString());

            var obj3 = new DataItem
            {
                Code = "xyz",
                Description = "123"
            };
            Debug.WriteLine("obj3 - " + obj3.ToJsonString());

            IEnumerable<IDataSource> obj4 = new List<IDataSource>{
                new SqlDataSource(),
                new XmlDataSource(),
                new ApiDataSource()
            };
            Debug.WriteLine("obj4 - " + obj4.ToJsonString());
        }

        [Test]
        public void Test_GetJsonTypeDescription()
        {
            var obj1 = int.MaxValue;
            Debug.WriteLine("obj1 - " + obj1.GetJsonTypeDescription());

            var obj2 = new DateTime(2016, 3, 3);
            Debug.WriteLine("obj2 - " + obj2.GetJsonTypeDescription());

            var obj3 = new DataItem
            {
                Code = "xyz",
                Description = "123"
            };
            Debug.WriteLine("obj3 - " + obj3.GetJsonTypeDescription());

            IEnumerable<IDataSource> obj4 = new List<IDataSource>{
                new SqlDataSource(),
                new XmlDataSource(),
                new ApiDataSource()
            };
            Debug.WriteLine("obj4 - " + obj4.GetJsonTypeDescription());
        }
    }
}
