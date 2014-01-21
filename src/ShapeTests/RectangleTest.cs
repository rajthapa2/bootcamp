using System;
using NUnit.Framework;
using Shape;

namespace ShapeTests
{
    [TestFixture]
    public class RectangleTest
    {
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void ShouldNotHaveNegativeWidthAndHeight()
        {
            var rectangle = new Rectangle(-1, -3);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void ShouldNotHaveNegativeWidth()
        {
            var rectangle = new Rectangle(10, -2);
        }
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void ShouldNotHaveNegativeHeight()
        {
            var rectangle = new Rectangle(-10, 2);
        }

        [TestCase(10.5, 20, Result = 61)]
        [TestCase(15.1, 30, Result = 90.2)]
        [TestCase(5, 60, Result = 130)]
        [TestCase(0, 0, Result = 0)]
        public double ShouldCalculatePerimeter(double height, double width)
        {
            var rectangle = new Rectangle(height, width);
            return rectangle.Perimeter;
        }

        [TestCase(5, 3, 15)]
        [TestCase(5, 4, 20)]
        [TestCase(4, 2, 8)]
        public void ShouldReturnAreaOfTheRectangle(double height, double width, double expectedResult)
        {
            var rectangle = new Rectangle(height, width);
            var actualresult = rectangle.GetArea();
            Assert.That(actualresult, Is.EqualTo(expectedResult));
        }
    }
}