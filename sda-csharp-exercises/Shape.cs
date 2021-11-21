using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class Shape
    {
        private List<Shape> list = new List<Shape>();

        public void Add(Shape shape)
        {
            list.Add(shape);
        }

        public virtual double GetArea()
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
