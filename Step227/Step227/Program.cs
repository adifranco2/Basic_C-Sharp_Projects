using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step227
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("pick a number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            int num2;

            Console.WriteLine("you can pick another number but you don't have to"); 
            string selection = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(selection))
            {
                num2 = 0;
            }
            else
            {
                num2 = Convert.ToInt32(selection);
            }

                       
            int ret;
            Number n = new Number();

            ret = n.Addition(num1, num2);
            Console.WriteLine("your number(s) plus 2 equals " + ret);
            Console.ReadLine();
        }
    }
}
