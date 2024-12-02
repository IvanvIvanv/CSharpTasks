using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderTask
{
    internal interface IOrder
    {
        decimal GetPrice();
        string GetDescription();
    }
}
