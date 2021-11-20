using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chleb, cena: 3.50 PLN, 5 szt, wartość: 17.50 PLN”
            OrderItem item1 = new OrderItem("Bread", 5, 3.50M);
            //Mleko, cena: 2.20 PLN, opakowanie: butelka,
            //cena opakowania: 1 PLN, 5 szt, wartość: 16 PLN”
            OrderItemWithPackage item2 = new OrderItemWithPackage("Milk", 5, 2.20M, "Bottle", 1M);

            Order order = new Order();
            order.AddOrderItem(item1);
            order.AddOrderItem(item2);

            order.DisplayOrderItems();
        }
    }
}
