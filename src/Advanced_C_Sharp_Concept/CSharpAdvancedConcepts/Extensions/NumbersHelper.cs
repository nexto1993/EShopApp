namespace CSharpAdvancedConcepts.Extensions
{
    public static class NumbersHelper
    {
        public static bool isBetween(this int value, int max, int min)
        {
            return value >= min && value <= max;
        }
    }
}
