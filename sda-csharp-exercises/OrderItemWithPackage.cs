using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class OrderItemWithPackage : OrderItem
    {
        private string packageName;
        private decimal packagePrice;

        public OrderItemWithPackage(string name, int quantity, decimal unitPrice, string packageName, decimal packagePrice) :
            base(name, quantity, unitPrice)
        {
            this.packageName = packageName;
            this.packagePrice = packagePrice;
        }

        protected decimal PackagePrice
        {
            get
            {
                return packagePrice;
            }
        }

        protected string PackageName
        {
            get
            {
                return packageName;
            }
        }
        public override decimal GetValue()
        {
            return base.GetValue() + (Quantity * PackagePrice);
        }

        public override string ToString()
        {
            return $"{Name}, unit price: {UnitPrice} PLN, package: {PackageName}, package price: {PackagePrice} PLN, " +
                $"{Quantity} szt, total: {GetValue()} PLN";
        }
    }
}
