using System.Collections.Generic;
using EasyAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeFactors;

namespace PrimeFactorsTests
{
    [TestClass]
    public class PrimeFactorizerTests
    {
        [TestMethod]
        public void Generate_PrimesOf1_EmptyList()
        {
            var sut = new PrimeFactorizer();

            IList<int> result = sut.Factorize(1);

            result.ShouldBeEmpty();
        }

        [TestMethod]
        public void Generate_PrimesOf2_Returned2()
        {
            var sut = new PrimeFactorizer();

            IList<int> result = sut.Factorize(2);

            result.ShouldMatch(2);
        }

        [TestMethod]
        public void Generate_PrimesOf3_Returned3()
        {
            var sut = new PrimeFactorizer();

            IList<int> result = sut.Factorize(3);

            result.ShouldMatch(3);
        }

        [TestMethod]
        public void Generate_PrimesOf6_Returned3x2()
        {
            var sut = new PrimeFactorizer();

            IList<int> result = sut.Factorize(6);

            result.ShouldContainItems(new[] {3, 2});
        }

        [TestMethod]
        public void Generate_PrimesOf8_Returned2x2x2()
        {
            var sut = new PrimeFactorizer();

            IList<int> result = sut.Factorize(8);

            result.ShouldMatch(2, 2, 2);
        }

        [TestMethod]
        public void Generate_PrimesOf9_Returned3x3()
        {
            var sut = new PrimeFactorizer();

            IList<int> result = sut.Factorize(9);

            result.ShouldMatch(3, 3);
        }
    }
}