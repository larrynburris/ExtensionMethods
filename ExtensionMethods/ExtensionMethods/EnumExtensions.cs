namespace System
{
    public static class EnumExtensions
    {
        public static string GetName(this Enum value)
        {
            return Enum.GetName(value.GetType(), value);
        }
    }
}
