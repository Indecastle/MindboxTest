namespace MindboxTest.AreaCalculator.Shapes;

public abstract class Shape
{
    public abstract double GetArea();

    public async ValueTask<double> GetAreaAsync()
    {
        return await Task.Run(GetArea);
    }
}