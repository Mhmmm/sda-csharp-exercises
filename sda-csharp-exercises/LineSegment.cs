using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class LineSegment
    {
        public double point1x = 0;
        public double point1y = 0;
        public double point2x = 0;
        public double point2y = 0;

        public LineSegment(MyPoint point1, MyPoint point2)
        {
            point1x = point1.X;
            point1y = point1.Y;
            point2x = point2.X;
            point2y = point2.Y;
        }

        public LineSegment(double x1, double y1, double x2, double y2)
        {

            point1x = x1;
            point1y = y1;
            point2x = x2;
            point2y = y2;
        }

        public double GetLength()
        {
            return Math.Sqrt(Math.Pow(point2x - point1x, 2) + Math.Pow(point2y - point1y, 2));
        }
    }
}
