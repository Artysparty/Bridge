using Bridge.Colors;
using Bridge.Shapes;
using Bridge.Sizes;

Shape figure1 = new Rectangle(new Blue(), new Small());
figure1.GetFigure();
figure1.GetSize();
figure1.GetColor();
Console.WriteLine("--------------------");
figure1.Color = new White();
figure1.Size = new Big();
figure1.GetFigure();
figure1.GetSize();
figure1.GetColor();
Console.WriteLine("--------------------");
Shape figure2 = new Circle(new Red(), new Big());
figure2.GetFigure();
figure2.GetSize();
figure2.GetColor();
Console.WriteLine("--------------------");
figure2.Color = new White();
figure2.GetFigure();
figure2.GetSize();
figure2.GetColor();