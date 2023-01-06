using Bridge.Colors;
using Bridge.Sizes;

namespace Bridge.Shapes;

public class Circle : Shape
{
    public Circle(IColor color, ISize size) : base(color, size)
    {
    }

    public override void GetFigure()
    {
        Console.WriteLine("Circle");
    }
}