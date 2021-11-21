using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class MyPoint
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public MyPoint(double x, double y)
        {
            X = x;
            Y = y;
            Z = 0;
        }

        public virtual double GetDistanceFromPoint(MyPoint point)
        {
            return Math.Sqrt(Math.Pow(point.X - this.X, 2) + Math.Pow(point.Y - this.Y, 2));
        }
    }
}
