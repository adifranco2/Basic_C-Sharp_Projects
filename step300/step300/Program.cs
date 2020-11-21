using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step300
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime rightNow = DateTime.Now;
            Console.WriteLine("Currently it is: " + rightNow);
            Console.WriteLine("Please enter a number.");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("In " + number + " hours, it will be: " + rightNow.AddHours(number));
            Console.ReadLine();
        }
    }
}
