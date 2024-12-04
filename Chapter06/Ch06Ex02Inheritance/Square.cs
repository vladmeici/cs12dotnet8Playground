namespace Ch06Ex02Inheritance;

internal class Square : Shape
{
    public override double Area => Height * Width;

    public Square(double side)
    {
        Height = side;
        Width = side;
    }
}
