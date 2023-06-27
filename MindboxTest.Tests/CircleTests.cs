using MindboxTest.AreaCalculator.Shapes;

namespace MindboxTest.Tests;

[TestFixture]
public class CircleTests
{
    [Test]
    public void Constructor_WhenRadiusAreNegative()
    {
        Assert.Throws<ArgumentException>(() => new Circle(-1));
    }
    
    [Test]
    public void GetArea_WhenRadiusIsOne()
    {
        double area = new Circle(1).GetArea();

        Assert.That(area, Is.EqualTo(Math.PI).Within(1e-6));
    }

    [Test]
    public void GetArea_WhenRadiusIsFive()
    {
        double area = new Circle(5).GetArea();

        Assert.That(area, Is.EqualTo(25 * Math.PI).Within(1e-6));
    }

    [Test]
    public void GetArea_WhenRadiusIsHalf()
    {
        double area = new Circle(0.5).GetArea();

        Assert.That(area, Is.EqualTo(0.25 * Math.PI).Within(1e-6));
    }
}