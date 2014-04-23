using System;
using Anagram;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EasyAssertions;

namespace AnagramTests
{
    [TestClass]
    public class FileDictionaryProviderTests
    {
        [TestMethod]
        public void GetWords_FilePresent_WordsReturned()
        {
            var sut = new FileDictionaryProvider();

            string[] words = sut.GetWords();

            words.ShouldNotBeEmpty();
        }
    }
}
