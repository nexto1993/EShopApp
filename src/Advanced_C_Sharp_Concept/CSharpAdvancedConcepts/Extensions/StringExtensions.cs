namespace CSharpAdvancedConcepts.Extensions
{
    public static class StringExtensions
    {
        public static string RemoveSpaces(this string value)
        {
            return value.Replace(" ", "");
        }

        public static string ReverseString(this string value)
        {

            char[] charArray = value.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
