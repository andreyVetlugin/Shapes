using Shapes.Entities;
using static NUnit.Framework.Assert;

namespace ShapesTests
{
    [TestFixture]
    public class TriangleTests
    {
        [TestCase(1, 2, 4)]
        [TestCase(1, 9, 4)]
        [TestCase(7, 2, 4)]
        public void TriangleConstructor_SideBiggerThanOther_ArgumentException(double aSide, double bSide, double cSide)
        {
            Throws<ArgumentException>(() => new Triangle(aSide, bSide, cSide));
        }

        [TestCase(-1, 3, 3)]
        [TestCase(1, -3, 3)]
        [TestCase(1, 3, -3)]
        public void TriangleConstructor_NegativeNumber_ArgumentException(double aSide, double bSide, double cSide)
        {
            Throws<ArgumentException>(() => new Triangle(aSide, bSide, cSide));
        }

        [TestCase(1, 3, 3, 1.48)]
        [TestCase(2, 3, 3, 2.83)]
        [TestCase(2, 9, 8, 7.31)]
        [TestCase(2, 7, 9, 0)]
        public void TriangleArea_ResultEqualsExpected(double aSide, double bSide, double cSide, double expectedArea)
        {
            var triangle = new Triangle(aSide, bSide, cSide);
            That(Math.Round(triangle.Area, 2), Is.EqualTo(expectedArea));
        }

        [TestCase(1, 3, 3)]
        [TestCase(2, 3, 3)]
        [TestCase(2, 9, 8)]
        public void TriangleArea_ResultSameInFewCalls(double aSide, double bSide, double cSide)
        {
            var triangle = new Triangle(aSide, bSide, cSide);
            var area = triangle.Area;
            for (var i = 0; i < 10; i++)
            {
                That(triangle.Area, Is.EqualTo(area));
            }
        }

        [TestCase(1, 3, 3)]
        [TestCase(2, 3, 3)]
        [TestCase(2, 9, 8)]
        public void TriangleArea_ResultSameForTrianglesWithSameSides(double aSide, double bSide, double cSide)
        {
            var triangle1 = new Triangle(aSide, bSide, cSide);
            var triangle2 = new Triangle(aSide, bSide, cSide);

            That(triangle2.Area, Is.EqualTo(triangle1.Area));
        }
    }
}