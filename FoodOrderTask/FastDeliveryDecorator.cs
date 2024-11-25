using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderTask
{
    internal class FastDeliveryDecorator(IOrder orderBase) : IOrder
    {
        public string GetDescription()
        {
            return orderBase.GetDescription() + " which will be delivered 20% faster";
        }

        public decimal GetPrice()
        {
            return orderBase.GetPrice() + 5;
        }
    }
}
