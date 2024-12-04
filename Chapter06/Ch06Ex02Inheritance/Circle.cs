namespace Ch06Ex02Inheritance;

internal class Circle : Shape
{
    public override double Area => Math.PI * (Width / 2) * (Height / 2);

    public Circle(double radius)
    {
        Height = radius * 2;
        Width = radius * 2;
    }
}