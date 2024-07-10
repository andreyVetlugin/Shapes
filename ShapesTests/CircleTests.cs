using Shapes.Entities;
using static NUnit.Framework.Assert;

namespace ShapesTests
{
    [TestFixture]
    public class CircleTests
    {
        [TestCase(-2)]
        public void CircleConstructor_NegativeRadius_ArgumentException(double radius)
        {
            Throws<ArgumentException>(() => new Circle(radius));
        }

        [TestCase(1, Math.PI)]
        [TestCase(2, Math.PI * 4)]
        [TestCase(0, 0)]
        public void CircleArea_ResultEqualsExpected(double radius, double expectedArea)
        {
            var circle = new Circle(radius);
            That(expectedArea, Is.EqualTo(circle.Area));
        }
        
        [TestCase(2)]
        [TestCase(0)]
        public void CircleArea_ResultSameForSameRadius(double radius)
        {
            var circle1 = new Circle(radius);
            var circle2 = new Circle(radius);

            That(circle1.Area, Is.EqualTo(circle2.Area));
        }
    }
}