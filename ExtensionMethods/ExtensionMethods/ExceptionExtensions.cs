using System.Text;

namespace System
{
    public static class ExceptionExtensions
    {
        public static string FullMessage(this Exception ex)
        {
            var sb = new StringBuilder();
            while (ex != null)
            {
                sb.AppendFormat("{0}{1}", ex.Message, Environment.NewLine);
                ex = ex.InnerException;
            }
            return sb.ToString();
        }
    }
}
