using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamModifier
{
    internal class Calculator
    {
        public static double Calc(params double[] numbers)
        {
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        public static void Triple(ref int a)
        {
            a = 3 * a;
        }

        public static void Quadruple(int x, out int result)
        {
            result = 4 * x;
        }
    }
}
