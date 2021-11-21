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

            List<Shape> list = new List<Shape>();

            //Shape shapes = new Shape();
            list.Add(circle);
            list.Add(square);

            Console.WriteLine("CIRCLE: " + circle.GetArea());
            Console.WriteLine("SQUARE " + square.GetArea());

            //double total = 0;
            //foreach (Shape shape in list)
            //{
            //    total += shape.GetArea();
            //}

            Console.WriteLine($"TOTAL: " + Shape.GetTotalArea(list));
        }
    }
}
