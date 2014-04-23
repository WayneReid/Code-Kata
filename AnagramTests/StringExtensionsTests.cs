using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram;
using EasyAssertions;

namespace AnagramTests
{
    [TestClass]
    public class StringExtensionsTests
    {
        [TestMethod]
        public void SortLettersAscending_EmptyString_EmptyString()
        {
            string empty = string.Empty;

            string result = empty.SortLettersAscending();

            result.ShouldBe(string.Empty);
        }

        [TestMethod]
        public void SortLettersAscending_cat_act()
        {
            const string empty = "cat";

            string result = empty.SortLettersAscending();

            result.ShouldBe("act");
        }
    }
}
