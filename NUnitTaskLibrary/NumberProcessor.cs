using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTaskLibrary
{
    public class NumberProcessor(INumberService numberService)
    {
        private readonly INumberService? numberService = numberService;

        public int CalculateSum()
        {
            int res = 0;

            int[] ints = numberService!.GetIntArray();

            for (int i = 0; i < ints.Length; i++)
            {
                res += ints[i];
            }

            return res;
        }

        public float CalculateAverage()
        {
            int[] ints = numberService!.GetIntArray();

            return (float)CalculateSum() / ints.Length;
        }
    }
}
