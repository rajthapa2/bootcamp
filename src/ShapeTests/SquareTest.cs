using System;
using NUnit.Framework;
using Shape;

namespace ShapeTests
{
    [TestFixture]
    public class SquareTest
    {
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void ShouldNotHaveNegativeDimenson()
        {
            var square = new Square(-3.00);
        }

        [TestCase(2, Result = 8)]
        [TestCase(3, Result = 12)]
        [TestCase(4, Result = 16)]
        [TestCase(0, Result = 0)]
        public double ShouldReturnPermeter(double length)
        {
            var square = new Square(length);
            return square.Perimeter;
        }

        [TestCase(5, 25)]
        [TestCase(4, 16)]
        [TestCase(3, 9)]
        [TestCase(0, 0)]
        public void ShouldReturnAreaOfTheSquare(double length, double result)
        {
            var square = new Square(length);
            var actualresult = square.GetArea();
            Assert.That(actualresult, Is.EqualTo(result));
        }
    }
}