namespace StringExtensions.Truncate
{
    public static class TruncateExtension
    {
        public static string Truncate(this string value, int maxLength, string suffix = "")
        {
            if (string.IsNullOrEmpty(value))
                return value;
            return value.Length <= maxLength ? value : value.Substring(0, maxLength) + suffix;
        }
    }
}
