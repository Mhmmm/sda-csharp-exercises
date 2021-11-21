using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            MyPoint point1 = new MyPoint(1, 2);
            MyPoint point2 = new MyPoint(5, 4);
            LineSegment line1 = new LineSegment(point1, point2);
            LineSegment line2 = new LineSegment(5, 4, 1, 2);

            Console.WriteLine(line1.GetLength());
            Console.WriteLine(line2.GetLength());
        }
    }
}
