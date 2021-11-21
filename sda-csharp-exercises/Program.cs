using System;
using System.Collections.Generic;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(3.4);
            Square square = new Square(3.4);

            List<IShape> shapes = new List<IShape>();
            shapes.Add(circle);
            shapes.Add(square);

            Console.WriteLine("CIRCLE: " + circle.GetArea());
            Console.WriteLine("SQUARE " + square.GetArea());
            Console.WriteLine($"TOTAL: " + IShape.GetTotalArea(shapes));
        }
    }
}
