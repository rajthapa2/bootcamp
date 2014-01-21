using System;
using ShapeInterface;

namespace Shape
{
    public class Rectangle : IShape
    {
        private readonly double _width;
        private readonly double _height;

        public double Perimeter
        {
            get { return 2 * (_height + _width); }
        }

        public Rectangle(double height, double width)
        {
            if (height < 0 || width < 0)
            {
                throw new ArgumentException();
            }
            _height = height;
            _width = width;
        }

        public double GetArea()
        {
            return _height * _width;
        }
    }
}
