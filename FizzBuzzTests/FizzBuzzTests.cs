using FizzBuzzKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EasyAssertions;

namespace FizzBuzzTests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void Request_NotDivisible_NullString()
        {
            var sut = new FizzBuzz();

            string result = sut.Request(7);

            result.ShouldBe(string.Empty);
        }

        [TestMethod]
        public void Request_DivisibleBy3_Fizz()
        {
            var sut = new FizzBuzz();

            string result = sut.Request(3);

            result.ShouldBe("fizz");
        }

        [TestMethod]
        public void Request_DivisibleBy5_Buzz()
        {
            var sut = new FizzBuzz();

            string result = sut.Request(5);

            result.ShouldBe("buzz");
        }

        [TestMethod]
        public void Request_DivisibleBy3And5_FizzBuzz()
        {
            var sut = new FizzBuzz();

            string result = sut.Request(15);

            result.ShouldBe("fizzbuzz");
        }
    }
}