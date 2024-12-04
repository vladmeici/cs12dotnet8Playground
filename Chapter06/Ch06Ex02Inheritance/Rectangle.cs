﻿namespace Ch06Ex02Inheritance
{
    internal class Rectangle : Shape
    {
        public override double Area => Height * Width;

        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }
    }
}
