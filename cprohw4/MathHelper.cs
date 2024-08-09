using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClasses
{
    static class MathHelper
    {
        public static int Factorial(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i ++)
            {
                result *= i;
            }
            return result;
        }

        public static float gcd(int a, int b)
        {
            int result = 1;
            int temp;

            if (a > b)
            {
                temp = a;
                a = b;
                b = temp;
            }

            for (int i = 1; i < (a + 1); i++)
            {
                if (a % i == 0 && b % i == 0)
                    result = i;
            }
            return result;
        }

        public static float lcm(int a, int b)
        {
            int num1, num2;
            if (a > b)
            {
                num1 = a; num2 = b;
            }
            else
            {
                num1 = b; num2 = a;
            }

            for (int i = 1; i < num2; i++)
            {
                int mult = num1 * i;
                if (mult % num2 == 0)
                {
                    return mult;
                }
            }
            return num1 * num2;
        }
    }
}
