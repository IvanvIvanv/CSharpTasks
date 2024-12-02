using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderTask
{
    internal class BaseOrder : IOrder
    {
        public string GetDescription()
        {
            return "It's an order";
        }

        public decimal GetPrice()
        {
            return 1;
        }
    }
}
