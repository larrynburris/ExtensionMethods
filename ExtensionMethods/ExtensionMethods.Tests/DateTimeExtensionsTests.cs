using NUnit.Framework;
using System;

namespace ExtensionMethods.Tests
{
    [TestFixture]
    public class DateTimeExtensionsTests
    {
        [Test]
        public void Test_Tomorrow_Match()
        {
            var dt = new DateTime(2016, 3, 3);
            Assert.AreEqual(new DateTime(2016, 3, 4), dt.Tomorrow());
        }

        [Test]
        public void Test_Tomorrow_Mismatch()
        {
            var dt = new DateTime(2016, 3, 3);
            Assert.AreNotEqual(new DateTime(2016, 3, 5), dt.Tomorrow());
        }

        [Test]
        public void Test_ToXmlDateTime()
        {
            var dt = new DateTime(2016, 3, 3, 13, 10, 15, 951);
            Assert.AreEqual("2016-03-03T13:10:15.951Z", dt.ToXmlDateTime());
        }

        [Test]
        public void Test_ToXmlDateTime_ModeOverloadUtc()
        {
            var dt = new DateTime(2016, 3, 3, 13, 10, 15, 951);
            Assert.AreEqual("2016-03-03T13:10:15.951Z", dt.ToXmlDateTime(System.Xml.XmlDateTimeSerializationMode.Utc));
        }

        [Test]
        public void Test_ToXmlDateTime_ModeOverload()
        {
            var dt = new DateTime(2016, 3, 3, 13, 10, 15, 951);
            Assert.AreEqual("2016-03-03T13:10:15.951-05:00", dt.ToXmlDateTime(System.Xml.XmlDateTimeSerializationMode.Local));
        }
    }
}
