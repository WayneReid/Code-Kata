using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineIntersection
{
    public class Line2D
    {
        private readonly Point _point1;
        private readonly Point _point2;

        public Line2D(Point point1, Point point2)
        {
            if (point1 == point2)
                throw new ArgumentException();


            _point1 = point1;
            _point2 = point2;
        }

        public bool IntersectsWith(Line2D otherLine)
        {
            return Slope() != otherLine.Slope();
        }

        public decimal Slope()
        {
            return (_point2.Y - _point1.Y)/(_point2.X - _point1.X);
        }
    }

    public struct Point
    {
        public Point(decimal x, decimal y) : this()
        {
            X = x;
            Y = y;
        }

        public decimal X { get; set; }
        public decimal Y { get; set; }

        #region Equality

        public bool Equals(Point other)
        {
            return X == other.X && Y == other.Y;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is Point && Equals((Point) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (X.GetHashCode()*397) ^ Y.GetHashCode();
            }
        }

        public static bool operator ==(Point left, Point right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Point left, Point right)
        {
            return !left.Equals(right);
        }

        #endregion
    }
}
