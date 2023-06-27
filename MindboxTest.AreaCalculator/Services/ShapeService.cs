using MindboxTest.AreaCalculator.Shapes;

namespace MindboxTest.AreaCalculator.Services;

public interface IShapeService
{
    double GetCircleArea(double radius);
    double GetTriangleArea(double sideA, double sideB, double sideC);
    bool IsRightTriangle(double sideA, double sideB, double sideC);
}

public class ShapeService : IShapeService
{
    public double GetCircleArea(double radius)
    {
        var shape = new Circle(radius);
        return shape.GetArea();
    }

    public double GetTriangleArea(double sideA, double sideB, double sideC)
    {
        var shape = new Triangle(sideA, sideB, sideC);
        return shape.GetArea();
    }

    public bool IsRightTriangle(double sideA, double sideB, double sideC)
    {
        var shape = new Triangle(sideA, sideB, sideC);
        return shape.IsRightTriangle();
    }
}
