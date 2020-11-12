using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step228
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pick a number");
            int int1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("pick another number");
            int int2 = Convert.ToInt32(Console.ReadLine());

            int ret;

            Number n = new Number();

            n.Addition(num1: int1, num2: int2);
            Console.WriteLine(int2);
            Console.ReadLine();
        }
    }
}
