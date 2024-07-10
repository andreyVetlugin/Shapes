using System.Runtime.CompilerServices;

namespace Shapes.Entities;

public class Triangle : Shape
{
    private readonly Lazy<double> _area;
    public override double Area => _area.Value;
    public double ASide { get; }
    public double BSide { get; }
    public double CSide { get; }

    public Triangle(double aSide, double bSide, double cSide)
    {
        if (aSide < 0 || bSide < 0 || cSide < 0)
            throw new ArgumentException(
                "Неверно указана сторона треугольника. Сторона треугольника не может быть отрицательной");
        if (aSide > bSide + cSide || bSide > aSide + cSide || cSide > aSide + bSide)
            throw new ArgumentException(
                "Неверно указана сторона треугольника. Сторона треугольника не может быть больше других сторон");
        (ASide, BSide, CSide) = (aSide, bSide, cSide);
        _area = new Lazy<double>(GetArea);
    }

    private double GetArea()
    {
        // вырождение треугольника в линию\точку
        if (ASide * BSide * CSide == 0 ||
            (ASide + BSide - CSide) * (ASide + CSide - BSide) * (BSide + CSide - ASide) == 0)
            return 0;
        var halfPerimeter = (ASide + BSide + CSide) / 2;
        return Math.Sqrt(halfPerimeter * (halfPerimeter - ASide) * (halfPerimeter - BSide) * (halfPerimeter - CSide));
    }
}