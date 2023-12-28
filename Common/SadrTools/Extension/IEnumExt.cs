using System.Collections.Generic;

namespace SadrTools.Extension
{
    public static class IEnumExt
    {
        public static string Print(this IEnumerable<int> numbers)
        {
            var result = string.Empty;

            foreach (var number in numbers)
            {
                result += $"{number},";
            }

            return result.RemoveLastCharacter();
        }

        public static string PrintMe<T>(this IEnumerable<T> items) where T : class
        {
            var result = string.Empty;

            foreach (var item in items)
            {
                result += $"{item}";
            }

            return result;
        }

    }
}
