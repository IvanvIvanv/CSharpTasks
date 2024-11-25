using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderTask
{
    internal class AdditionalDrinkDecorator(IOrder orderBase) : IOrder
    {
        public string GetDescription()
        {
            return orderBase.GetDescription() + " with extra drink";
        }

        public decimal GetPrice()
        {
            return orderBase.GetPrice() + 6;
        }
    }
}
