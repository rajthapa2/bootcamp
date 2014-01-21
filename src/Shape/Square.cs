using System;
using ShapeInterface;

namespace Shape
{
    public class Square : IShape
    {
        private readonly double _length;

        public double GetPerimeter()
        {
            return 4*_length;
        }

        public Square(double length)
        {
            if (length < 0)
            {
                throw new ArgumentException();
            }
            _length = length;
        }

        public double GetArea()
        {
            return _length * _length;
        }
    }
}