using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class MyPoint3D : MyPoint
    {
        public MyPoint3D(double x, double y, double z) : base(x, y)
        {
            Z = z;
        }
        public override double GetDistanceFromPoint(MyPoint point)
        {
            return Math.Sqrt(Math.Pow(point.X - this.X, 2) + Math.Pow(point.Y - this.Y, 2) + Math.Pow(point.Z - this.Z, 2));
        }
        
    }
}
