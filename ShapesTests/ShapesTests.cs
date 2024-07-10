using System;
using NUnit.Framework;
using Shapes.Entities;

namespace ShapesTests
{
    [TestFixture]
    public class ShapesTests
    {
        [Test]
        public void ShapeArea()
        {
            Assert.DoesNotThrow(()=>
            {
                var circle = new Circle(3);
                var triangle = new Triangle(1, 3, 3);
                var shapes = new List<Shape> { circle, triangle };
                var areas = shapes.Select(x => x.Area).ToList();
            });
        }
    }
}