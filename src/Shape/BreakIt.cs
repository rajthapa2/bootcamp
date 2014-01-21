using NUnit.Framework;

namespace Shape
{
    [TestFixture]
    internal class BreakIt
    {
        [Test]
        public void ShouldReturnInfinityIfMaxValuesUsed()
        {
            var rectangle = new Rectangle(double.MaxValue, double.MaxValue);

            Assert.IsTrue(double.IsInfinity(rectangle.Perimeter));
        }

    }
}