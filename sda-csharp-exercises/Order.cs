using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class Order
    {
        private List<OrderItem> items = new List<OrderItem>();

        public void AddOrderItem(OrderItem item)
        {
            items.Add(item);
        }

        public decimal GetValue()
        {
            decimal total = 0;

            foreach (OrderItem item in items)
            {
                total += item.GetValue();
            }
            return total;
        }

        public void DisplayOrderItems()
        {
            foreach (OrderItem item in items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Wartość zamówienia = {GetValue()} PLN");
        }
    }
}
