using System.IO;

namespace Anagram
{
    public class FileDictionaryProvider : IDictionaryProvider
    {
        public string[] GetWords()
        {
            return File.ReadAllLines("wordlist.txt");
        }
    }
}