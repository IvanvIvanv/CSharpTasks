using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Difficulties
{
    internal static class NumDifficultyFactory
    {
        public static readonly Difficulty[] difficulties =
        {
            new Easy(),
            new Medium(),
            new Hard(),
        };

        public static Difficulty Create(int difficulty)
        {
            return difficulties[difficulty - 1];
        }
    }
}
