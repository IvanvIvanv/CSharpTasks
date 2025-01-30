using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public static class Calc
    {
        public delegate int FuncDelegate<T>(T num);
        public delegate void ActionDelegate<T>(T num);

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

        public static int NumSum(float num)
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

        public static void PrintNumSum(float num)
        {
            Console.WriteLine(NumSum(num));
        }

        public static void PrintNumMult(int num)
        {
            Console.WriteLine(NumMult(num));
        }

        public static void PrintNumMult(float num)
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

        public static int EvenSumOddMult(int num)
        {
            if (num % 2 == 0) return NumSum(num);
            else return NumMult(num);
        }

        public static int EvenSumOddMult(float num)
        {
            if (num % 2 == 0) return NumSum(num);
            else return NumMult(num);
        }

        public static FuncDelegate<int> GetEventSumOddMultDelegateInt()
        {
            return new(EvenSumOddMult);
        }

        public static FuncDelegate<float> GetEventSumOddMultDelegateFloat()
        {
            return new(EvenSumOddMult);
        }

        public static List<byte> DigitsOf(int num)
        {
            return num.ToString().ToList().ConvertAll(x => (byte)(x - 48));
        }

        public static List<byte> DigitsOf(float num)
        {
            List<char> chars = [.. num.ToString()];
            chars.Remove(',');
            return chars.ConvertAll(x => (byte)(x - 48));
        }

        public static int DigitsToNum(List<byte> digits)
        {
            int res = 0;

            for (int i = 0; i < digits.Count; i++)
            {
                res += (int)(digits[i] * Math.Pow(10, digits.Count - i - 1));
            }

            return res;
        }
    }
}