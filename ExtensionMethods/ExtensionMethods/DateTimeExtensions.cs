using System.Xml;

namespace System
{
    public static class DateTimeExtensions
    {
        public static DateTime Tomorrow(this DateTime dt)
        {
            return dt.AddDays(1);
        }

        public static string ToXmlDateTime(this DateTime dt)
        {
            return dt.ToXmlDateTime(XmlDateTimeSerializationMode.Utc);
        }

        public static string ToXmlDateTime(this DateTime dt, XmlDateTimeSerializationMode mode)
        {
            return XmlConvert.ToString(dt, mode);
        }
    }
}
