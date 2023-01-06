using Bridge.Colors;
using Bridge.Sizes;

namespace Bridge.Shapes;

public class Rectangle : Shape
{
    public Rectangle(IColor color, ISize size) : base(color, size)
    {
    }

    public override void GetFigure()
    {
        Console.WriteLine("Rectangle");
    }
}