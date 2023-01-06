using Bridge.Colors;
using Bridge.Sizes;

namespace Bridge.Shapes;

public abstract class Shape
{
    protected IColor color;
    public IColor Color
    {
        set { color = value; }
    }

    protected ISize size;
    public ISize Size
    {
        set { size = value; }
    }

    public Shape(IColor color, ISize size)
    {
        this.color = color;
        this.size = size;
    }

    public virtual void GetColor()
    {
        color.GetColor();
    }
    public virtual void GetSize()
    {
        size.GetSize();
    }
    public abstract void GetFigure();

}