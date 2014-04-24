using System;
using LineIntersection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EasyAssertions;

namespace LineIntersectionTests
{
    [TestClass]
    public class Line2DTests
    {
        [TestMethod]
        public void IntersectsWith_IdenticalPointsInConstructor_InvalidArgumentException()
        {
            bool didThrow = false;

            try
            {
                Line2D sut = new Line2D(new Point(0, 0), new Point(0, 0));
            }
            catch (ArgumentException)
            {
                didThrow = true;                
            }

            didThrow.ShouldBe(true);
        }
        
        
        [TestMethod]
        public void IntersectsWith_ParrallelLines_ReturnsFalse()
        {
            Line2D line1 = new Line2D(new Point(0, 0), new Point(1, 1));
            Line2D line2 = new Line2D(new Point(0, 1), new Point(1, 2));

            bool result = line1.IntersectsWith(line2);

            result.ShouldBe(false);
        }

        [TestMethod]
        public void IntersectsWith_IntersectingLines_ReturnsTrue()
        {
            Line2D line1 = new Line2D(new Point(0, 0), new Point(1, 1));
            Line2D line2 = new Line2D(new Point(0, 4), new Point(1, 0));

            bool result = line1.IntersectsWith(line2);

            result.ShouldBe(true);
        }

        [TestMethod]
        public void Slope_FlatSlope_Returns0()
        {
            Line2D sut = new Line2D(new Point(0, 0), new Point(4, 0));

            decimal result = sut.Slope();

            result.ShouldBe((decimal)0);
        }

        [TestMethod]
        public void Slope_AtypicalSlope_ReturnsSlope()
        {
            Line2D sut = new Line2D(new Point(0, 0), new Point(4, 4));

            decimal result = sut.Slope();

            result.ShouldBe((decimal)1);
        }

        [TestMethod]
        public void Slope_InfiniteSlope_ReturnsSlope()
        {
            Line2D sut = new Line2D(new Point(0, 0), new Point(0, 4));

            bool thrown = false;
            try
            {
                sut.Slope();
            }
            catch (DivideByZeroException)
            {
                thrown = true;
            }

            thrown.ShouldBe(true);
        }
    }
}
