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
    }
}
