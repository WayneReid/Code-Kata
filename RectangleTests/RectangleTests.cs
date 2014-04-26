
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RectangleIntersection;
using EasyAssertions;

namespace RectangleTests
{
    [TestClass]
    public class RectangleTests
    {
        [TestMethod]
        public void Constructor_xMinGreaterThanOrEqualToxMax_ArgumentException()
        {           
            bool thrown = false;

            try
            {
                new Rectangle(5, 3, 0, 1);
            }
            catch (ArgumentException)
            {
                thrown = true;
            }
            thrown.ShouldBe(true);
        }

        [TestMethod]
        public void Constructor_yMinGreaterThanOrEqualToyMax_ArgumentException()
        {
            bool thrown = false;

            try
            {
                new Rectangle(0, 1, 5, 4);
            }
            catch (ArgumentException)
            {
                thrown = true;
            }
            thrown.ShouldBe(true);
        }

        [TestMethod]
        public void Area_Sides4_Returns16()
        {
            var sut = new Rectangle(0, 4, 0, 4);

            double result = sut.Area();

            result.ShouldBe(16.0, 0.0);
        }

        [TestMethod]
        public void Area_Sides2x4_Returns8()
        {
            var sut = new Rectangle(0, 2, 0, 4);

            double result = sut.Area();

            result.ShouldBe(8.0, 0.0);
        }

        [TestMethod]
        public void Circumference_Sides4_Returns16()
        {
            var sut = new Rectangle(0, 4, 0, 4);

            double result = sut.Circumference();

            result.ShouldBe(16.0, 0.0);
        }

        [TestMethod]
        public void Circumference_Sides2x4_Returns12()
        {
            var sut = new Rectangle(0, 2, 0, 4);

            double result = sut.Circumference();

            result.ShouldBe(12.0, 0.0);
        }

        [TestMethod]
        public void Overlaps_OverlappingRectangles_ReturnsTrue()
        {
            var sut = new Rectangle(0, 2, 0, 4);
            var overlappingRectangle = new Rectangle(0, 4, 0, 4);

            bool result = sut.OverlapsWith(overlappingRectangle);

            result.ShouldBe(true);
        }

        [TestMethod]
        public void Overlaps_EdgesOverlappingOnly_ReturnsTrue()
        {
            var sut = new Rectangle(0, 2, 0, 4);
            var overlappingRectangle = new Rectangle(2, 4, 0, 4);

            bool result = sut.OverlapsWith(overlappingRectangle);

            result.ShouldBe(true);
        }
    }
}
