using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step231
{
    public class Number
    {
        public void Division(int num1)
        {
            int result;

            result = num1 / 2;

            Console.WriteLine("your number divided by 2 equals " + result);

            return;
        }

        public void valueOutput(out int x)
        {
            x = 10;
            x += x;
        }

        public static int Addition(int a)
        {
            int result;
            result = a + 10;
            return result;
        }

        public static double Addition(double b)
        {
            double result2;
            result2 = b + 2.5;
            return result2;
        }
    }
}
