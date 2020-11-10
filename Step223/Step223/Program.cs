using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step223
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number.");

            int num1 = Convert.ToInt32(Console.ReadLine());
            int ret;
            Number n = new Number();

            ret = n.Addition(num1);
            Console.WriteLine("your number plus two equals " + ret);

            ret = n.Multiplication(num1);
            Console.WriteLine("your number multiplied by two equals " + ret);

            ret = n.Subtraction(num1);
            Console.WriteLine("your number minus one equals " + ret);
            Console.ReadLine();

            }
        
    }
}
