using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public static class Calculator
    {
        public delegate int FactorialDelegate<T>(T num);
        public delegate int NumSumDelegate<T>(T num);
        public delegate int NumMultDelegate<T>(T num);
        public delegate void NumSumPrintDelegate<T>(T num);
        public delegate void NumMultPrintDelegate<T>(T num);

        public static int Factorial(int num)
        {
            int res = 1;

            for (int i = 1; i < num; i++)
            {
                res *= i;
            }

            return res;
        }

        public static int Factorial(float num)
        {
            int res = 1;

            for (int i = 1; i < num; i++)
            {
                res *= i;
            }

            return res;
        }

        public static int NumSum(int num)
        {
            int res = 0;
            List<byte> digits = DigitsOf(num);

            foreach (var digit in digits)
            {
                res += digit;
            }

            return res;
        }

        public static float NumSum(float num)
        {
            int res = 0;
            List<byte> digits = DigitsOf(num);

            foreach (var digit in digits)
            {
                res += digit;
            }

            return res;
        }

        public static int NumMult(int num)
        {
            int res = 1;
            List<byte> digits = DigitsOf(num);

            foreach (var digit in digits)
            {
                res *= digit;
            }

            return res;
        }

        public static int NumMult(float num)
        {
            int res = 1;
            List<byte> digits = DigitsOf(num);

            foreach (var digit in digits)
            {
                res *= digit;
            }

            return res;
        }

        public static void PrintNumSum(int num)
        {
            Console.WriteLine(NumSum(num));
        }

        public static void PrintNumMult(int num)
        {
            Console.WriteLine(NumMult(num));
        }

        public static bool RemoveEven(ref int num, out int removedCount)
        {
            List<byte> digits = DigitsOf(num);
            int oldCount = digits.Count;
            digits.RemoveAll(x => x % 2 == 0);
            removedCount = oldCount - digits.Count;
            num = DigitsToNum(digits);
            if (removedCount == 0) return false;
            return true;
        }

        public static List<byte> DigitsOf(int num)
        {
            return num.ToString().ToList().ConvertAll(x => (byte)(x - 48));
        }

        public static List<byte> DigitsOf(float num)
        {
            List<char> chars = [.. num.ToString()];
            chars.Remove('.');
            return chars.ConvertAll(x => (byte)(x - 48));
        }

        public static int DigitsToNum(List<byte> digits)
        {
            int res = 0;

            for (int i = 0; i < digits.Count; i++)
            {
                res += (int)(digits[i] * Math.Pow(10, i));
            }

            return res;
        }
    }
}