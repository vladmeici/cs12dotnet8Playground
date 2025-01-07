﻿namespace Packt.Shared;

public class Rectangle : Shape
{
    public double Height { get; set; }
    public double Width { get; set; }
    public override double Area => Height * Width;
}