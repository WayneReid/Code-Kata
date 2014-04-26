using System;
using System.Collections.Generic;

namespace RectangleIntersection
{
    public class Rectangle
    {
        private readonly double _xMin;
        private readonly double _xMax;
        private readonly double _yMin;
        private readonly double _yMax;

        public Rectangle(double xMin, double xMax, double yMin, double yMax)
        {
            if (xMin >= xMax)
                throw new ArgumentException("xMin >= xMax");

            if (yMin >= yMax)
                throw new ArgumentException("yMin >= yMax");

            _xMin = xMin;
            _xMax = xMax;
            _yMin = yMin;
            _yMax = yMax;
        }

        public double Area()
        {
            return Length*Width;
        }

        private double Length
        {
            get { return _xMax - _xMin; }
        }

        private double Width
        {
            get { return _yMax - _yMin; }
        }

        public double Circumference()
        {
            return 2*Width + 2*Length;
        }

        public bool OverlapsWith(Rectangle overlappingRectangle)
        {
            if (overlappingRectangle._xMax < _xMin)
                return false;

            if (overlappingRectangle._xMin > _xMax)
                return false;

            if (overlappingRectangle._yMax < _yMin)
                return false;

            if (overlappingRectangle._yMin > _yMax)
                return false;

            return true;
        }
    }
}
