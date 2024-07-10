namespace Shapes.Entities;

public class Circle : Shape
{
    private readonly Lazy<double> _area;
    public override double Area => _area.Value;
    public double Radius { get; }

    public Circle(double radius)
    {
        if (radius < 0)
            throw new ArgumentException("Радиус не может быть отрицательным");
        Radius = radius;
        _area = new Lazy<double>(GetArea);
    }

    private double GetArea() => Math.PI * Math.Pow(Radius, 2);
}