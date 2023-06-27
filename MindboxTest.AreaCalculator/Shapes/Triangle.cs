namespace MindboxTest.AreaCalculator.Shapes;

public class Triangle : Shape
{
    private readonly double _sideA;
    private readonly double _sideB;
    private readonly double _sideC;

    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
        {
            throw new ArgumentException("Sides must be positive");
        }

        if (sideA + sideB <= sideC || sideB + sideC <= sideA || sideA + sideC <= sideB)
        {
            throw new ArgumentException("The sides must satisfy the inequality of the triangle");
        }

        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;
    }


    public override double GetArea()
    {
        double p = (_sideA + _sideB + _sideC) / 2;
        return Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
    }

    public bool IsRightTriangle()
    {
        if (_sideA > _sideB && _sideA > _sideC)
            return Math.Abs(_sideA * _sideA - (_sideB * _sideB + _sideC * _sideC)) < 1e-6;

        if (_sideB > _sideA && _sideB > _sideC)
            return Math.Abs(_sideB * _sideB - (_sideA * _sideA + _sideC * _sideC)) < 1e-6;

        return Math.Abs(_sideC * _sideC - (_sideA * _sideA + _sideB * _sideB)) < 1e-6;
    }
}