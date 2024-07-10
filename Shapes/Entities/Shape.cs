using Shapes.Interfaces;

namespace Shapes.Entities;

public abstract class Shape : IHaveArea
{
    public abstract double Area { get; }
}