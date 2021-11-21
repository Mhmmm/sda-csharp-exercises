using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    interface IShape
    {
        public double GetArea();
        public static double GetTotalArea(List<IShape> shapes)
        {
            double total = 0;

            foreach (IShape shape in shapes)
            {
                total += shape.GetArea();
            }
            return total;
        }

    }
}
