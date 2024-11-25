using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderTask
{
    internal class GiftPackagingDecorator(IOrder orderBase) : IOrder
    {
        public string GetDescription()
        {
            return orderBase.GetDescription() + " which will be wrapped 25% better";
        }

        public decimal GetPrice()
        {
            return orderBase.GetPrice() + 14;
        }
    }
}
