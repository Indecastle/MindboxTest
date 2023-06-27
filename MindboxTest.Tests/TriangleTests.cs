using MindboxTest.AreaCalculator.Shapes;

namespace MindboxTest.Tests;

[TestFixture]
    public class TriangleTests
    {
        [Test]
        public void Constructor_WhenSidesAreNegative()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, -1, 1));
        }
        
        [Test]
        public void GetArea_WhenEquilateralTriangleWithSideOne()
        {
            double area = new Triangle(1, 1, 1).GetArea();
            
            Assert.That(area, Is.EqualTo(Math.Sqrt(3) / 4).Within(1e-6));
        }
        
        [Test]
        public void GetArea_WhenRightTriangleWithSidesThreeFourFive()
        {
            double area = new Triangle(3, 4, 5).GetArea();
            
            Assert.That(area, Is.EqualTo(6).Within(1e-6));
        }
        
        [Test]
        public void GetArea_WhenArbitraryTriangleWithSidesTwoThreeFour()
        {
            double area = new Triangle(2, 3, 4).GetArea();

            Assert.That(area, Is.EqualTo(2.9047375096555625).Within(1e-6));
        }

        [Test]
        public void IsRightTriangle_WhenEquilateralTriangleWithSideOne()
        {
            bool isRightTriangle = new Triangle(1, 1, 1).IsRightTriangle();

            Assert.IsFalse(isRightTriangle);
        }
        
        [Test]
        public void IsRightTriangle_WhenArbitraryTriangleWithSidesTwoThreeFour()
        {
            bool isRightTriangle = new Triangle(2, 3, 4).IsRightTriangle();

            Assert.IsFalse(isRightTriangle);
        }
        
        [Test]
        public void IsRightTriangle_WhenRightTriangleWithSidesThreeFourFive()
        {
            bool isRightTriangle = new Triangle(3, 4, 5).IsRightTriangle();
            
            Assert.IsTrue(isRightTriangle);
        }
    }