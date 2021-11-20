using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class OrderItem
    {
        private string name;
        private int quantity;
        private decimal unitPrice;

        public OrderItem(string name, int quantity, decimal unitPrice)
        {
            this.name = name;
            this.quantity = quantity;
            this.unitPrice = unitPrice;
        }

        protected string Name
        {
            get
            {
                return name;
            }
        }

        protected int Quantity
        {
            get
            {
                return quantity;
            }
        }

        protected decimal UnitPrice
        {
            get
            {
                return unitPrice;
            }
        }

        public virtual decimal GetValue()
        {
            return quantity * unitPrice;
        }

        public override string ToString()
        {
            return $"{name}, cena: {unitPrice} PLN, {quantity} szt, wartość: {GetValue()} PLN";
        }
    }
}
