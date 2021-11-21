using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class Square : IShape
    {
        private double side;

        public Square(double side)
        {
            this.side = side;
        }
        public double GetArea()
        {
            return side * side;
        }
    }
}
