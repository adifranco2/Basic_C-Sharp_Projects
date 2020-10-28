using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step158
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a whole number.");
            int userInput = Convert.ToInt32(Console.ReadLine());
            int multiplication = userInput * 50;
            Console.WriteLine(userInput + " * 50 = " + multiplication);
            Console.WriteLine("Please input a whole number.");
            int userInput2 = Convert.ToInt32(Console.ReadLine());
            int addition = userInput2 + 25;
            Console.WriteLine(userInput2 + " + 25 = " + addition);
            Console.WriteLine("Please input a whole number.");
            double userInput3 = Convert.ToDouble(Console.ReadLine());
            double division = userInput3 / 12.5;
            Console.WriteLine(userInput3 + " / 12.5 = " + division);
            Console.WriteLine("Please input a whole number.");
            int userInput4 = Convert.ToInt32(Console.ReadLine());
            bool greaterThan = userInput4 > 50;
            Console.WriteLine(greaterThan);
            Console.WriteLine("Please input a whole number.");
            int userInput5 = Convert.ToInt32(Console.ReadLine());
            int remainer = userInput5 % 7;
            Console.WriteLine(remainer);
            Console.ReadLine();
        }
    }
}
