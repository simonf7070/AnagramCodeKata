using System.Linq;

namespace AnagramCodeKata
{
    public static class StringExtensions
    {
        public static bool IsAnagramOf(this string firstWord, string secondWord)
        {
            return firstWord.OrderBy(s => s).SequenceEqual(secondWord.OrderBy(s => s));
        }
        public static bool IsAnagramOfSortedWord(this string firstWord, string secondWord)
        {
            return firstWord.SequenceEqual(secondWord.OrderBy(s => s));
        }

        public static string SortedLetters(this string word)
        {
            return string.Join("", word.OrderBy(s => s));
        }
    }
}