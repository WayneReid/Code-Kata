using System.Linq;

namespace Anagram
{
    public static class StringExtensions
    {
        public static string SortLettersAscending(this string word)
        {
            return new string(word.OrderBy(c => c).ToArray());
        }
    }
}