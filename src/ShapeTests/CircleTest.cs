using System;
using NUnit.Framework;
using Shape;

namespace ShapeTests
{
    [TestFixture]
    public class CircleTest
    {
        [TestCase(2.2, 13.823007675795091)]
        [TestCase(4, 25.132741228718345)]
        [TestCase(0, 0)]
        public void ShouldReturnPerimeterWhenPassedValidRadius(double radius, double result)
        {
            var circle = new Circle(radius);
            Assert.That(circle.GetPerimeter(), Is.EqualTo(result));
        }
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void ShouldThrowExceptionWhenPassedInvalidRadius()
        {
            var circle = new Circle(-2.2);
        }

        [TestCase(5, Result = Math.PI * 5 * 5)]
        [TestCase(3, Result = Math.PI * 3 * 3)]
        [TestCase(2, Result = Math.PI * 2 * 2)]
        [TestCase(4.3, Result = Math.PI * 4.3 * 4.3)]
        public double ShouldReturnAreaValue(double radius)
        {
            var circle = new Circle(radius);
           return circle.GetArea();
        }
    }
}