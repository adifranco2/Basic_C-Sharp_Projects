using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Step231
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pick a number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Number n = new Number();

            n.Division(num1);

            Console.WriteLine("output parameters");
            int x;

            n.valueOutput(out x);
                 
            Console.WriteLine("The addition of the value is: {0}", x);

            Console.WriteLine("pick another number");
            int a = Convert.ToInt32(Console.ReadLine());
            int ret;
            ret = Step231.Number.Addition(a);
            Console.WriteLine("your number plus 10 equals " + ret);

            Console.WriteLine("pick one more number");
            double b = Convert.ToDouble(Console.ReadLine());
            double ret2;
            ret2 = Step231.Number.Addition(b);
            Console.WriteLine("your number plus 2.5 equals " + ret2);

            Console.ReadLine();
        }

            

    }
}
