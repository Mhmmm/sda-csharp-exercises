using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            MyPoint pointA = new MyPoint(1, 2);
            MyPoint pointB = new MyPoint(2, 3);

            MyPoint3D point1 = new MyPoint3D(2, 3, 4);
            MyPoint3D point2 = new MyPoint3D(5, 6, 7);

            LineSegment line2D = new LineSegment(pointA, pointB);
            LineSegment line3D = new LineSegment(point1, point2);

            Console.WriteLine("Linia 2D");
            Console.WriteLine(pointA.GetDistanceFromPoint(pointB));
            Console.WriteLine("Linia 3D");
            Console.WriteLine(point1.GetDistanceFromPoint(point2));
        }
    }
}
