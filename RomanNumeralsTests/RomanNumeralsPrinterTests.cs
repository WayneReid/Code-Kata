using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumerals;
using EasyAssertions;

namespace RomanNumeralsTests
{
    [TestClass]
    public class RomanNumeralsPrinterTests
    {
        [TestMethod]
        public void Print_1_I()
        {
            var sut = new RomanNumeralsPrinter();

            string result = sut.Print(1);

            result.ShouldBe("I");
        }

        [TestMethod]
        public void Print_2_II()
        {
            var sut = new RomanNumeralsPrinter();

            string result = sut.Print(2);

            result.ShouldBe("II");
        }

        [TestMethod]
        public void Print_4_IV()
        {
            var sut = new RomanNumeralsPrinter();

            string result = sut.Print(4);

            result.ShouldBe("IV");
        }

        [TestMethod]
        public void Print_7_VII()
        {
            var sut = new RomanNumeralsPrinter();

            string result = sut.Print(7);

            result.ShouldBe("VII");
        }

        [TestMethod]
        public void Print_9_IX()
        {
            var sut = new RomanNumeralsPrinter();

            string result = sut.Print(9);

            result.ShouldBe("IX");
        }

        [TestMethod]
        public void Print_10_X()
        {
            var sut = new RomanNumeralsPrinter();

            string result = sut.Print(10);

            result.ShouldBe("X");
        }

        [TestMethod]
        public void Print_30_XXX()
        {
            var sut = new RomanNumeralsPrinter();

            string result = sut.Print(30);

            result.ShouldBe("XXX");
        }

        [TestMethod]
        public void Print_40_XL()
        {
            var sut = new RomanNumeralsPrinter();

            string result = sut.Print(40);

            result.ShouldBe("XL");
        }

        [TestMethod]
        public void Print_49_XLIX()
        {
            var sut = new RomanNumeralsPrinter();

            string result = sut.Print(49);

            result.ShouldBe("XLIX");
        }

        [TestMethod]
        public void Print_50_L()
        {
            var sut = new RomanNumeralsPrinter();

            string result = sut.Print(50);

            result.ShouldBe("L");
        }

        [TestMethod]
        public void Print_90_XC()
        {
            var sut = new RomanNumeralsPrinter();

            string result = sut.Print(90);

            result.ShouldBe("XC");
        }

        [TestMethod]
        public void Print_99_XCIX()
        {
            var sut = new RomanNumeralsPrinter();

            string result = sut.Print(99);

            result.ShouldBe("XCIX");
        }

        [TestMethod]
        public void Print_100_C()
        {
            var sut = new RomanNumeralsPrinter();

            string result = sut.Print(100);

            result.ShouldBe("C");
        }

        [TestMethod]
        public void Print_105_CV()
        {
            var sut = new RomanNumeralsPrinter();

            string result = sut.Print(105);

            result.ShouldBe("CV");
        }

        [TestMethod]
        public void Print_305_CCCV()
        {
            var sut = new RomanNumeralsPrinter();

            string result = sut.Print(305);

            result.ShouldBe("CCCV");
        }

        [TestMethod]
        public void Print_405_CDV()
        {
            var sut = new RomanNumeralsPrinter();

            string result = sut.Print(405);

            result.ShouldBe("CDV");
        }

        [TestMethod]
        public void Print_500_D()
        {
            var sut = new RomanNumeralsPrinter();

            string result = sut.Print(500);

            result.ShouldBe("D");
        }

        [TestMethod]
        public void Print_800_DCCC()
        {
            var sut = new RomanNumeralsPrinter();

            string result = sut.Print(800);

            result.ShouldBe("DCCC");
        }

        [TestMethod]
        public void Print_905_CMV()
        {
            var sut = new RomanNumeralsPrinter();

            string result = sut.Print(905);

            result.ShouldBe("CMV");
        }

        [TestMethod]
        public void Print_1000_M()
        {
            var sut = new RomanNumeralsPrinter();

            string result = sut.Print(1000);

            result.ShouldBe("M");
        }

        [TestMethod]
        public void Print_3000_M()
        {
            var sut = new RomanNumeralsPrinter();

            string result = sut.Print(3000);

            result.ShouldBe("MMM");
        }

        [TestMethod]
        public void Print_1954_MCMLIV()
        {
            var sut = new RomanNumeralsPrinter();

            string result = sut.Print(1954);

            result.ShouldBe("MCMLIV");
        }

        [TestMethod]
        public void Print_1990_MCMXC()
        {
            var sut = new RomanNumeralsPrinter();

            string result = sut.Print(1990);

            result.ShouldBe("MCMXC");
        }

        [TestMethod]
        public void Print_2014_MMXIV()
        {
            var sut = new RomanNumeralsPrinter();

            string result = sut.Print(2014);

            result.ShouldBe("MMXIV");
        }
    }
}
