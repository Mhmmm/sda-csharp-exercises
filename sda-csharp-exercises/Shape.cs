using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    abstract class Shape
    {
        //private List<Shape> list = new List<Shape>();

        //public void Add(Shape shape)
        //{
        //    list.Add(shape);
        //}

        public abstract double GetArea();
        //{
        //    double total = 0;
        //    foreach (Shape shape in list)
        //    {
        //        total += shape.GetArea();
        //    }
        //    return total;
        //}

        public static double GetTotalArea(List<Shape> list)
        {
            double total = 0;
            foreach (Shape shape in list)
            {
                total += shape.GetArea();
            }
            return total;
        }
    }
}
