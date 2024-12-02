using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyTask
{
    internal class RealService : IService
    {
        public string GetData()
        {
            Task.Delay(3000).Wait();
            return "Fish.json";
        }
    }
}
