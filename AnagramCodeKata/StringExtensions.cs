using System.Linq;

namespace AnagramCodeKata
{
    public static class StringExtensions
    {
        public static bool IsAnagramOf(this string firstWord, string secondWord)
        {
            return string.Join("", firstWord.OrderBy(c => c)) == string.Join("", secondWord.OrderBy(c => c));
        }
    }
}