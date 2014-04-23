using System;
using System.Collections.Generic;
using System.Linq;

namespace Anagram
{
    public class AnagramProvider
    {
        private readonly IDictionaryProvider _dictionaryProvider;

        public AnagramProvider(IDictionaryProvider dictionaryProvider)
        {
            if (dictionaryProvider == null) throw new ArgumentNullException("dictionaryProvider");
            _dictionaryProvider = dictionaryProvider;
        }

        public IEnumerable<string> Generate(string word)
        {
            return _dictionaryProvider.GetWords().Where(potentialAnagram => IsAnagram(word, potentialAnagram));
        }

        // Note: Could be optimized. 
        private bool IsAnagram(string word, string potentialAnagram)
        {
            if (String.Compare(word, potentialAnagram, StringComparison.CurrentCultureIgnoreCase) == 0)
                return false;

            if (word.Length != potentialAnagram.Length)
                return false;

            bool isAnagram = (String.Compare(word.ToLower().SortLettersAscending(), potentialAnagram.ToLower().SortLettersAscending(), StringComparison.CurrentCultureIgnoreCase) == 0);
            return isAnagram;
        }
    }
}
