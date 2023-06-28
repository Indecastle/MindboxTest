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
        double hypotenuse = Math.Max(_sideA, Math.Max(_sideB, _sideC));
        double shortest = Math.Min(_sideA, Math.Min(_sideB, _sideC));
        double middle = _sideA + _sideB + _sideC - hypotenuse - shortest;
        
        return hypotenuse * hypotenuse - shortest * shortest - middle * middle < 1e-6;
    }
}