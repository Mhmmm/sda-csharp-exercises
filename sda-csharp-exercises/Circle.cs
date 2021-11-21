using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class Circle : Shape
    {
        private double radius;
        const double PI = 3.14159265359;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return PI * (radius * radius);
        }
    }
}
