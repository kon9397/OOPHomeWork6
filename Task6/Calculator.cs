using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal static class Calculator
    {
        public static double Plus(double a, double b)
        {
            return a + b;
        }
        public static double Minus(double a, double b)
        {
            return a - b;
        }
        public static double Multiply(double a, double b)
        {
            return a * b;
        }
        public static double Divide(double a, double b)
        {
            if(b == 0)
            {
                Console.WriteLine("На ноль делить нельзя");
                return double.NaN;
            }
            return a / b;
        }
    }
}
