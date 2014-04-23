using System;
using System.Collections.Generic;
using Anagram;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EasyAssertions;
using Moq;

namespace AnagramTests
{
    [TestClass]
    public class AnagramGeneratorTests
    {
        #region Unit Tests

        [TestMethod]
        public void Generate_WordNotInDictionary_ReturnsEmpty()
        {
            IDictionaryProvider dictionary =
                Mock.Of<IDictionaryProvider>(d => d.GetWords() == new[] { "Fresher", "Refresh" });
            var sut = new AnagramProvider(dictionary);

            IEnumerable<string> result = sut.Generate("jklasdgfjklsdgfjklsdgf");

            result.ShouldBeEmpty();
        }

        [TestMethod]
        public void Generate_Fresher_ReturnsRefresh()
        {
            IDictionaryProvider dictionary =
                Mock.Of<IDictionaryProvider>(d => d.GetWords() == new[] {"Fresher", "Refresh"});
            var sut = new AnagramProvider(dictionary);

            IEnumerable<string> result = sut.Generate("Fresher");

            result.ShouldMatch("Refresh");
        }

        #endregion

        #region Integration Tests

        [TestMethod]
        public void Generate_Boaster_ReturnsBoatersBorates()
        {
            var sut = new AnagramProvider(new FileDictionaryProvider());

            IEnumerable<string> result = sut.Generate("boaster");

            result.ShouldContainItems(new[] {"boaters", "borates"});
        }

        #endregion

    }
}
