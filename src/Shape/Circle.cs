using System;
using ShapeInterface;

namespace Shape
{
    public class Circle : IShape
    {
        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException();
            }
            _radius = radius;
        }

        private readonly double _radius;

        public double GetPerimeter()
        {
            return 2 * Math.PI * _radius;
        }

        public double GetArea()
        {
            return Math.PI *_radius *_radius;
        }
    }
}